using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace drawRoute
{
    class FileData
    {
        public static int[,] data = new int[82,82];
        public static ArrayList array = new ArrayList();
        public static ArrayList firstPath = new ArrayList();

        public static void getData()
        {
            try
            {
                FileStream file = new FileStream(FilePath.citiesFilePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                string line = reader.ReadLine();
                while (line != null)
                {
                    addCity(line);
                    line = reader.ReadLine();
                }

                reader.Close();
                file.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Veriler alınırken bir hata oluştu!\nLütfen dosyaları tekrar içeri aktarınız ve tekrar işleyiniz.", "Draw Route");
            }
            
        }
        private static void addCity(string line)
        {
            string[] words = line.Split(',');
            int cityPlateCode = int.Parse(words[0]);
            int neighborPlateCode;
            int distance;

            for(int i=2; i<words.Length-2; i+=3)
            {
                neighborPlateCode = int.Parse(words[i]);
                distance = int.Parse(words[i + 2]);

                data[cityPlateCode,neighborPlateCode] = distance;
            }

            array.Add(words[0]+"-"+words[1]);
        }
        public static int getDistance(int cityPlateCode, int destinationPlateCode)
        {
            FileStream file = new FileStream(FilePath.distanceFilePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            string line, line1;
            string[] s;
            bool b = false;
            int count = 0;

            line = reader.ReadLine();
            while (line != null)
            {
                s = line.Split(',');
                if (s.Length == 1 && int.Parse(s[0]) == cityPlateCode)
                    b = true;

                if (b == true)
                {
                    line1 = reader.ReadLine();
                    while (line1 != null)
                    {
                        count++;
                        s = line1.Split(',');
                        if(count > 81)
                        {
                            reader.Close();
                            file.Close();
                            return 0;
                        }
                        if (int.Parse(s[0]) == destinationPlateCode)
                        {
                            reader.Close();
                            file.Close();
                            return int.Parse(s[2]);
                        }
                        line1 = reader.ReadLine();
                    }
                }
                line = reader.ReadLine();
            }

            reader.Close();
            file.Close();
            return 0;
        }
        public static string getCityName(int plateCode)
        {
            if (plateCode < 82 && plateCode > 0)
                return array[plateCode - 1].ToString();
            else
                return null;
        }
        public static void getFirtsPath(Location l)
        {
            Location iter = l;
            while (iter != null)
            {
                firstPath.Add(iter.plateCode);
                iter = iter.previousCity;
            }
            firstPath.Reverse();
            firstPath.RemoveAt(0);
            firstPath.RemoveAt(firstPath.Count - 1);
        }
    }
}
