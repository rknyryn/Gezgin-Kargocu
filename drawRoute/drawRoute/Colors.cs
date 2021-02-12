using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace drawRoute
{
    class Colors
    {
        public static List<string> colors = new List<string>();
        public static void getColors()
        {
            if(System.IO.File.Exists("colors.txt"))
            {
                System.IO.FileStream file = new System.IO.FileStream("colors.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.StreamReader reader = new System.IO.StreamReader(file);
                string line;
                string[] color;
                line = reader.ReadLine();
                while (line != null)
                {
                    color = line.Split(':');
                    colors.Add(color[1]);
                    line = reader.ReadLine();
                }
                reader.Close();
                file.Close();
            }
            else
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("colors.txt", true);
                writer.WriteLine("Path1:Kırmızı");
                writer.WriteLine("Path2:Yeşil");
                writer.WriteLine("Path3:Mavi");
                writer.WriteLine("Path4:Mor");
                writer.WriteLine("Path5:Kahverengi");
                writer.WriteLine("Path6:Siyah");
                writer.Flush();
                writer.Close();
                getColors();
            }
        }
        public static Color getColor(string color)
        {
            switch (color)
            {                
                case "Kırmızı":
                    return Color.Red;
                case "Yeşil":
                    return Color.Green;
                case "Mavi":
                    return Color.Blue;
                case "Pembe":
                    return Color.Pink;
                case "Mor":
                    return Color.Purple;
                case "Kahverengi":
                    return Color.Brown;
                case "Sarı":
                    return Color.Yellow;
                case "Turuncu":
                    return Color.Orange;
                case "Siyah":
                    return Color.Black;
                default:
                    return Color.Black;
            }
        } 
    }
}
