using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawRoute
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private FindRoute findRoute;
        private PaintRoute paintRoute;
        private void setData(bool text)
        {
            try
            {
                cmbBoxCities.Items.Clear();
                cmbBoxCities.Items.Add("Şehir Seçiniz...");
                foreach (string s in FileData.array)
                cmbBoxCities.Items.Add(s);
                if(text==true)
                    MessageBox.Show("Veriler işlendi.", "Draw Route");
                cmbBoxCities.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler işlenirken bir hata oluştu!", "Draw Route");
            }
        }
        private int getPlateCode(string words)
        {
            string[] s = words.Split('-');
            return int.Parse(s[0]);
        }
        private void fillDestinaionPoints()
        {
            listBoxDestinationPoints.Items.Clear();
            for (int j = 0; j < listBoxCities.Items.Count; j++)
            {
                listBoxCities.SelectedIndex = j;
                listBoxDestinationPoints.Items.Add(listBoxCities.SelectedItem);
            }
        }
        private void fillPathsList()
        {
            string[] split;
            listBoxShortestPath.Items.Clear();
            split = findRoute.foundedPaths[0].ToString().Split('-');
            listBoxShortestPath.Items.Add("Toplam mesafe: " + split[split.Length - 1] + " km");
            for (int i = split.Length - 2; i >= 0; i--)
            {
                listBoxShortestPath.Items.Add(FileData.getCityName(int.Parse(split[i])));
            }

            listBoxAlternativePaths.Items.Clear();
            for (int i = 1; i < findRoute.foundedPaths.Count; i++)
            {
                split = findRoute.foundedPaths[i].ToString().Split('-');
                listBoxAlternativePaths.Items.Add(i + ". Yol");
                listBoxAlternativePaths.Items.Add("Toplam mesafe: " + split[split.Length - 1] + " km");
                for (int j = split.Length - 2; j >= 0; j--)
                {
                    listBoxAlternativePaths.Items.Add(FileData.getCityName(int.Parse(split[j])));
                }
            }

            listBoxCities.Items.Clear();
        }
        private void fillPathsPaint()
        {
            paintRoute.clearPaths();

            string[] split;
            split = findRoute.foundedPaths[0].ToString().Split('-');
            for (int i = split.Length - 2; i >= 0; i--)
            {
                paintRoute.addShortestPath(int.Parse(split[i]));
            }
            for (int i = 1; i < findRoute.foundedPaths.Count; i++)
            {
                if (i > 5)
                    break;
                split = findRoute.foundedPaths[i].ToString().Split('-');
                for (int j = split.Length - 2; j >= 0; j--)
                {
                    paintRoute.addAlternativePaths(int.Parse(split[j]), i);
                }
            }
        }

        private void şehirleriİçeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePath.setCitiesFile();
        }

        private void mesafeleriİçeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePath.setDistanceFile();
        }

        private void btnDrawRoute_Click(object sender, EventArgs e)
        {
            if(listBoxCities.Items.Count != 0)
            {
                findRoute = new FindRoute(FileData.data);

                for (int j = 0; j < listBoxCities.Items.Count; j++)
                {
                    listBoxCities.SelectedIndex = j;
                    findRoute.addCitiesToVisit(getPlateCode(listBoxCities.SelectedItem.ToString()));
                }
                fillDestinaionPoints();
                findRoute.drawRoute();
                fillPathsList();
                fillPathsPaint();
            }
            else
            {
                MessageBox.Show("Gidilecek herhangi bir şehir eklemediniz!", "Draw Route");
            }
        }

        private void dosyalarıİşleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileData.getData();
            setData(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for(int i=0; i<listBoxCities.Items.Count; i++)
            {
                listBoxCities.SelectedIndex = i;
                if (listBoxCities.SelectedItem == cmbBoxCities.SelectedItem)
                {
                    MessageBox.Show("Bu şehir zaten listeye eklenmiş.", "Draw Route");
                    cmbBoxCities.SelectedIndex = 0;
                    return;
                }
                    
            }
            if(cmbBoxCities.SelectedIndex != 0)
                listBoxCities.Items.Add(cmbBoxCities.SelectedItem);
            cmbBoxCities.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxCities.Items.Remove(listBoxCities.SelectedItem);
        }

        private void btnDeleteListAll_Click(object sender, EventArgs e)
        {
            listBoxCities.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePath.getCitiesFilePath();
            FilePath.getDistanceFilePath();
            FileData.getData();
            Colors.getColors();
            paintRoute = new PaintRoute(picBoxMap);
            setData(false);
        }

        private void chkBoxShortestPath_CheckedChanged(object sender, EventArgs e)
        {
            if(listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxShortestPath.Checked)
                    paintRoute.setPaint(0,true);
                else
                    paintRoute.setPaint(0, false);
                    
            }
            else
            {
                chkBoxShortestPath.Checked = false;
            }
        }

        private void btnOutPutFile_Click(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                string[] split;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Metin Dosyası|*.txt";
                if (dialog.ShowDialog()==DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(dialog.FileName);
                    writer.Write("Varış Noktaları:\n");
                    for (int i = 0; i < listBoxDestinationPoints.Items.Count; i++)
                    {
                        listBoxDestinationPoints.SelectedIndex = i;
                        writer.Write(listBoxDestinationPoints.SelectedItem.ToString() + "\n");
                    }

                    writer.Write("En Kısa Yol\n");
                    split = findRoute.foundedPaths[0].ToString().Split('-');
                    writer.Write("Toplam Mesafe: " + split[split.Length - 1] +" km ");
                    for (int i = split.Length - 2; i >= 0; i--)
                    {
                        writer.Write(FileData.getCityName(int.Parse(split[i])));
                        if (i != 0)
                            writer.Write("-");
                    }

                    writer.Write("\nAlternatif Yollar\n");
                    for (int i = 1; i < findRoute.foundedPaths.Count; i++)
                    {
                        split = findRoute.foundedPaths[i].ToString().Split('-');
                        writer.Write(i + ".Yol: ");
                        writer.Write("Toplam mesafe: " + split[split.Length - 1] + " km ");
                        for (int j = split.Length - 2; j >= 0; j--)
                        {
                            writer.Write(FileData.getCityName(int.Parse(split[j])));
                        }
                        writer.Write("\n");
                    }

                    writer.Flush();
                    writer.Close();
                }
                MessageBox.Show("Çıktı dosyası oluşturuldu.", "Draw Route");
            }
            
        }

        private void renkAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkAyarlari renk = new RenkAyarlari();
            renk.ShowDialog();
        }

        private void chkBoxAlternativePath1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxAlternativePath1.Checked)
                    paintRoute.setPaint(1, true);
                else
                    paintRoute.setPaint(1, false);
                    
            }
            else
            {
                chkBoxAlternativePath1.Checked = false;
            }
        }

        private void chkBoxAlternativePath2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxAlternativePath2.Checked)
                    paintRoute.setPaint(2, true);
                else
                    paintRoute.setPaint(2, false);
                    
                    
            }
            else
            {
                chkBoxAlternativePath2.Checked = false;
            }
        }

        private void chkBoxAlternativePath3_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxAlternativePath3.Checked)
                    paintRoute.setPaint(3, true);
                else
                    paintRoute.setPaint(3, false);
                    
            }
            else
            {
                chkBoxAlternativePath3.Checked = false;
            }
        }

        private void chkBoxAlternativePath4_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxAlternativePath4.Checked)
                    paintRoute.setPaint(4, true);
                else
                    paintRoute.setPaint(4, false);
                    
            }
            else
            {
                chkBoxAlternativePath4.Checked = false;
            }
        }

        private void chkBoxAlternativePath5_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxShortestPath.Items.Count != 0)
            {
                if (chkBoxAlternativePath5.Checked)
                    paintRoute.setPaint(5, true);
                else
                    paintRoute.setPaint(5, false);
            }
            else
            {
                chkBoxAlternativePath5.Checked = false;
            }
        }

        private void dosyalarıİçeriAktarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer dosya yolları ile ilgili bir uyarı aldıysanız; sol üstte bulunan dosya sekmesi altındaki “Şehirleri içeri aktar” ve “Mesafeleri içeri aktar” seçenekleri kullanılarak belirlenen formatta hazırlanmış kaynak dosyalarını seçniz. Ardından yine Dosya sekmesi altında bulunan “Dosyaları işle” seçeneğine tıklayarak içeri aktardığınız kaynak dosyaları içerisindeki verileri uygulama için kullanılır hale getirmiş olursunuz.", "Draw Route",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void rotaÇizmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir rota çizilmesi için; öncelikle gidilmesini istediğiniz şehri rotaya eklemek için bir şehir seçiniz ve listeye ekle seçeneğine tıklayınız. Eğer bir şehri silmek isterseniz; silmek istediğiniz şehri listede seçiniz ve “Listeden Sil” seçeneğine tıklayınız veya seçmiş olduğunuz şehre sağ tıklayarak listeden sil diyerek te silebilirsiniz. Listeyi temizlemek isterseniz “Listeyi Temizle” seçeneğine tıklayınız.Oluşturulacak rota için şehirleri girdikten sonra “Rota Çiz” seçeneğine tıklayınız.", "Draw Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void renkDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlar sekmesi altından “Renk Ayarları” seçeneğine tıklayarak açılan pencerede, yolların hangi renkle gösterilmesini istiyorsanız onu seçip, seçenekleri kayıt ederek gösterilecek renkleri değiştirebilirsiniz.", "Draw Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void yollarıHaritadaGöstermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harita üzerinde çizdirmek isterseniz; “Yol Çiz” seçenekleri arasından hangisini çizdirmek isterseniz o seçeneğe tıklayarak rotayı çizdirebilirsiniz. Eğer rotayı silmek isterseniz seçeneği kaldırınız.", "Draw Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıktıDosyasıOluşturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bulunan rotayı çıktı dosyası olarak basmak isterseniz; “Çıktı Dosyası Oluştur” seçeneğine tıklayarak veya Dosya sekmesi altından “Çıktı Dosyası Oluştur” seçeneğine tıklayınız, açılan pencerede dosyasyı nereye kayıt etmek istediğinizi seçip, dosyanın adını veriniz ve kaydet diyerek çıktı dosyası oluşturabilirsiniz.", "Draw Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
