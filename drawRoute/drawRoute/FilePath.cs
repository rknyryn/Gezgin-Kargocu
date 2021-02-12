using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawRoute
{
    class FilePath
    {
        public static string citiesFilePath = null;
        public static string distanceFilePath = null;

        public static void getCitiesFilePath()
        {
            try
            {
                FileStream file = new FileStream("citiesFilePath.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                citiesFilePath = reader.ReadLine();

                reader.Close();
                file.Close();
            }
            catch (Exception)
            {
            }
        }
        public static void getDistanceFilePath()
        {
            try
            {
                FileStream file = new FileStream("distanceFilePath.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                distanceFilePath = reader.ReadLine();

                reader.Close();
                file.Close();
            }
            catch (Exception)
            {
            }
        }
        public static void setCitiesFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Txt Dosyası |*.txt";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Txt Dosyası Seçiniz.";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream("citiesFilePath.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                writer.Write(fileDialog.FileName);
                writer.Flush();

                writer.Close();
                file.Close();
            }
            getCitiesFilePath();
        }
        public static void setDistanceFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Txt Dosyası |*.txt";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Txt Dosyası Seçiniz.";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream("distanceFilePath.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                writer.Write(fileDialog.FileName);
                writer.Flush();

                writer.Close();
                file.Close();
            }
            getDistanceFilePath();
        }
    }
}
