using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawRoute
{
    public partial class RenkAyarlari : Form
    {
        public RenkAyarlari()
        {
            InitializeComponent();
        }

        private ColorDialog colorDialog = new ColorDialog();

        private void registeredColors()
        {
            cmbBoxShortestPath.SelectedItem = Colors.colors[0];
            cmbBoxPath1.SelectedItem = Colors.colors[1];
            cmbBoxPath2.SelectedItem = Colors.colors[2];
            cmbBoxPath3.SelectedItem = Colors.colors[3];
            cmbBoxPath4.SelectedItem = Colors.colors[4];
            cmbBoxPath5.SelectedItem = Colors.colors[5];

            lblShortestPath.BackColor = Colors.getColor(Colors.colors[0]);
            lblPath1.BackColor = Colors.getColor(Colors.colors[1]);
            lblPath2.BackColor = Colors.getColor(Colors.colors[2]);
            lblPath3.BackColor = Colors.getColor(Colors.colors[3]);
            lblPath4.BackColor = Colors.getColor(Colors.colors[4]);
            lblPath5.BackColor = Colors.getColor(Colors.colors[5]);
        }
        private void setColors()
        {
            if (System.IO.File.Exists("colors.txt"))
                System.IO.File.Delete("colors.txt");
            System.IO.StreamWriter writer = new System.IO.StreamWriter("colors.txt", true);
            writer.WriteLine("Path1:" + cmbBoxShortestPath.SelectedItem.ToString());
            writer.WriteLine("Path2:" + cmbBoxPath1.SelectedItem.ToString());
            writer.WriteLine("Path3:" + cmbBoxPath2.SelectedItem.ToString());
            writer.WriteLine("Path4:" + cmbBoxPath3.SelectedItem.ToString());
            writer.WriteLine("Path5:" + cmbBoxPath4.SelectedItem.ToString());
            writer.WriteLine("Path6:" + cmbBoxPath5.SelectedItem.ToString());
            writer.Flush();
            writer.Close();

            Colors.colors[0] = cmbBoxShortestPath.SelectedItem.ToString();
            Colors.colors[1] = cmbBoxPath1.SelectedItem.ToString();
            Colors.colors[2] = cmbBoxPath2.SelectedItem.ToString();
            Colors.colors[3] = cmbBoxPath3.SelectedItem.ToString();
            Colors.colors[4] = cmbBoxPath4.SelectedItem.ToString();
            Colors.colors[5] = cmbBoxPath5.SelectedItem.ToString();
        }

        private void RenkAyarlari_Load(object sender, EventArgs e)
        {
            registeredColors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {   
            DialogResult dialogResult = MessageBox.Show("Kaydetmek istedğinizden emin misiniz?", "Draw Route", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                setColors();
            }
            this.Close();
        }

        private void cmbBoxShortestPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShortestPath.BackColor = Colors.getColor(cmbBoxShortestPath.SelectedItem.ToString());
        }

        private void cmbBoxPath1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath1.BackColor = Colors.getColor(cmbBoxPath1.SelectedItem.ToString());
        }

        private void cmbBoxPath2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath2.BackColor = Colors.getColor(cmbBoxPath2.SelectedItem.ToString());
        }

        private void cmbBoxPath3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath3.BackColor = Colors.getColor(cmbBoxPath3.SelectedItem.ToString());
        }

        private void cmbBoxPath4_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath4.BackColor = Colors.getColor(cmbBoxPath4.SelectedItem.ToString());
        }

        private void cmbBoxPath5_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath5.BackColor = Colors.getColor(cmbBoxPath5.SelectedItem.ToString());
        }
    }
}
