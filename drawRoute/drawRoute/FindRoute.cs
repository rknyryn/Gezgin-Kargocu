using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace drawRoute
{
    class FindRoute
    {
        private int destination, totalDistance, R, H, C, index, pathsCount, cityToNotVisit;
        private int[,] matrix = new int[82,82];
        private string[] fPaths;
        private List<Location> openList = new List<Location>();
        private List<Location> closedList = new List<Location>();
        private List<Location> alternative = new List<Location>();
        private Location startPoint;
        private int[,] citiesToVisit = new int[10, 2];
        private List<Location> allPaths = new List<Location>();

        public ArrayList foundedPaths = new ArrayList();

        public FindRoute(int[,] data)
        {
            this.matrix = data;
            this.totalDistance = 0;
            this.index = 0;
            this.pathsCount = 0;
            this.cityToNotVisit = -1;
            Array.Clear(citiesToVisit, 0, citiesToVisit.Length);
            this.startPoint = new Location(41);
            closedList.Add(startPoint);
            allPaths.Clear();
        }
        public void drawRoute()
        {
            for (int i = 0; i < index; i++)
            {
                this.destination = citiesToVisit[i, 0];
                do
                {
                    findAlternative();
                    int min = openList.Min(Location => Location.calculatedDistance);
                    addClosedList(min);
                    if (closedList.FirstOrDefault(Location => Location.plateCode == destination) != null)
                        break;
                } while (openList.Count > 0);
                openList.Clear();
                closedList.Clear();
                alternative.Clear();
            }
            wayBack();

            FileData.getFirtsPath(allPaths[0]);
            for (int k = 0; k < FileData.firstPath.Count; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resetStart();
                    for (int a = 0; a < index; a++)
                    {
                        this.destination = citiesToVisit[a, 0];
                        if (destination != int.Parse(FileData.firstPath[k].ToString()))
                            cityToNotVisit = int.Parse(FileData.firstPath[k].ToString());
                        else
                        {
                            cityToNotVisit = -1;
                        }
                            
                        do
                        {
                            findAlternative();
                            int min = openList.Min(Location => Location.calculatedDistance);
                            addClosedList(min);
                            if (closedList.FirstOrDefault(Location => Location.plateCode == destination) != null)
                                break;
                        } while (openList.Count > 0);
                        openList.Clear();
                        closedList.Clear();
                        alternative.Clear();
                    }
                    if(j==1)
                        cityToNotVisit = -1;
                    wayBack();
                } 
            }

            if(index>1)
            {
                resetStart();
                sort();
                for (int i = 0; i < index; i++)
                {
                    this.destination = citiesToVisit[i, 0];
                    do
                    {
                        findAlternative();
                        int min = openList.Min(Location => Location.calculatedDistance);
                        addClosedList(min);
                        if (closedList.FirstOrDefault(Location => Location.plateCode == destination) != null)
                            break;
                    } while (openList.Count > 0);
                    openList.Clear();
                    closedList.Clear();
                    alternative.Clear();
                }
                wayBack();
            }
            
            saveRoute();
            findPaths();
        }
        public void addCitiesToVisit(int plateCode)
        {
            citiesToVisit[index, 0] = plateCode;
            citiesToVisit[index, 1] = FileData.getDistance(41, plateCode);
            index++;
            //sort();
        }

        private void sort()
        {
            int pC, distance;
            for (int i = 0; i < index - 1; i++)
            {
                for (int j = 0; j < index - 1; j++)
                {
                    if (citiesToVisit[j, 1] > citiesToVisit[j + 1, 1])
                    {
                        pC = citiesToVisit[j, 0];
                        distance = citiesToVisit[j, 1];

                        citiesToVisit[j, 0] = citiesToVisit[j + 1, 0];
                        citiesToVisit[j, 1] = citiesToVisit[j + 1, 1];

                        citiesToVisit[j + 1, 0] = pC;
                        citiesToVisit[j + 1, 1] = distance;
                    }
                }
            }
        }
        private void resetStart()
        {
            openList.Clear();
            closedList.Clear();
            alternative.Clear();
            this.startPoint = new Location(41);
            this.totalDistance = 0;
            closedList.Add(startPoint);
        }
        private void wayBack()
        {
            this.destination = 41;
            do
            {
                findAlternative();
                int min = openList.Min(Location => Location.calculatedDistance);
                addClosedList(min);
                if (closedList.FirstOrDefault(Location => Location.plateCode == destination) != null)
                    break;
            } while (openList.Count > 0);
            allPaths.Add(startPoint);
            pathsCount++;
            openList.Clear();
            closedList.Clear();
            alternative.Clear();
        }
        private void saveRoute()
        {
            deleteLogFile();
            int distance = 0;
            StreamWriter writer = new StreamWriter("log.txt",true);
            for (int i = 0; i <pathsCount; i++)
            {
                while(allPaths[i] != null)
                {
                    distance += allPaths[i].realDistance;
                    writer.Write(allPaths[i].plateCode + "-");
                    allPaths[i] = allPaths[i].previousCity;          
                }
                writer.Write(distance);
                writer.Write("\n");
                distance = 0;
            }
            writer.Close();
        }
        private void findPaths()
        {
            fPaths = new string[pathsCount];
            FileStream file = new FileStream("log.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            string line;
            int i = 0;
            do
            {
                line = reader.ReadLine();
                if ((controlledPathAddition(line, i))==1)
                    i++;

            } while (line != null);

            reader.Close();
            file.Close();

            for (int j = 0; fPaths[j]!=null; j++)
            {
                foundedPaths.Add(fPaths[j]);
            }
        }
        private int controlledPathAddition(string line, int index)
        {
            string[] w;
            string[] word;
            string[] word1;
            string temp;

            for (int i = 0; i < index; i++)
            {
                if (line == fPaths[i])
                    return 0;
            }
            if(line != null)
            {
                w = line.Split('-');
                if (w[0] != "41")
                    return 0;
            }

            fPaths[index] = line;

            for (int j = 0; j < index - 1; j++)
            {
                for (int k = 0; k < index - 1; k++)
                {
                    word = fPaths[k].Split('-');
                    word1 = fPaths[k + 1].Split('-');

                    if(int.Parse(word[word.Length-1]) > int.Parse(word1[word1.Length-1]))
                    {
                        temp = fPaths[k];
                        fPaths[k] = fPaths[k + 1];
                        fPaths[k + 1] = temp;
                    }
                }
            }
            return 1;
        }
        private void deleteLogFile()
        {
            if (File.Exists("log.txt"))
            {
                File.Delete("log.txt");
            }
        }
        private int getHeuristicDistance(int plateCode, int destinationPlateCode)
        {
            return FileData.getDistance(plateCode, destinationPlateCode);
        }
        private int getRealDistance(int plateCode, int neighborPlateCode)
        {
            return matrix[plateCode,neighborPlateCode];
        }
        private int getCalculatedDistance(int R, int H)
        {
            return R + H;
        }
        private void addClosedList(int min)
        {
            startPoint = openList.First(Location => Location.calculatedDistance == min);
            totalDistance += startPoint.realDistance;
            closedList.Add(startPoint);
            openList.Remove(startPoint);
        }
        private void addOpenList()
        {
            foreach (var item in alternative)
            {
                if (cityToNotVisit == item.plateCode)
                {
                    continue;
                }
                if (closedList.FirstOrDefault(Location => Location.plateCode == item.plateCode)!=null)
                {
                    continue;
                }
                if(openList.FirstOrDefault(Location => Location.plateCode == item.plateCode) == null)
                {
                    openList.Add(item);
                }
                else
                {
                    if(totalDistance + item.heuristicDistance < item.calculatedDistance)
                    {
                        item.realDistance = totalDistance;
                        item.calculatedDistance = item.realDistance + item.heuristicDistance;
                        item.previousCity = startPoint;
                    }
                }
            }
        }
        private void findAlternative()
        {
            for (int i = 1; i < 82; i++)
            {
                if(matrix[startPoint.plateCode,i]!=0)
                {
                    R = getRealDistance(startPoint.plateCode, i);
                    H = getHeuristicDistance(i, destination);
                    C = getCalculatedDistance(R, H);
                    Location location = new Location(i, R, H, C, startPoint);
                    alternative.Add(location);
                }
            }
            addOpenList();
        }
    }
}
