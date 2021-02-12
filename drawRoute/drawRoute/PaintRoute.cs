using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace drawRoute
{
    class PaintRoute
    {
        private int a, b;
        private Graphics graphic;
        private Pen pen;
        private System.Windows.Forms.PictureBox picBox;
        private bool[] option = new bool[6];

        private System.Collections.ArrayList shortestPath = new System.Collections.ArrayList();
        private System.Collections.ArrayList alternativePath1 = new System.Collections.ArrayList();
        private System.Collections.ArrayList alternativePath2 = new System.Collections.ArrayList();
        private System.Collections.ArrayList alternativePath3 = new System.Collections.ArrayList();
        private System.Collections.ArrayList alternativePath4 = new System.Collections.ArrayList();
        private System.Collections.ArrayList alternativePath5 = new System.Collections.ArrayList();
        private PointF[] points =
        {
            new PointF(415,311),new PointF(543,262),new PointF(208,207),new PointF(737,134),new PointF(432,101),new PointF(307,140),
            new PointF(211,315),new PointF(677,56),new PointF(89,252),new PointF(98,151),new PointF(188,126),new PointF(633,192),
            new PointF(704,213),new PointF(256,95),new PointF(195,266),new PointF(149,121),new PointF(38,118),new PointF(340,106),
            new PointF(394,108),new PointF(143,261),new PointF(625,247),new PointF(52,31),new PointF(578,207),new PointF(587,145),
            new PointF(661,131),new PointF(209,148),new PointF(505,301),new PointF(539,82),new PointF(584,105),new PointF(781,251),
            new PointF(453,353),new PointF(206,262),new PointF(383,322),new PointF(148,73),new PointF(61,217),new PointF(736,83),
            new PointF(345,60),new PointF(419,212),new PointF(78,31),new PointF(363,187),new PointF(185,90),new PointF(291,262),
            new PointF(187,167),new PointF(543,228),new PointF(74,207),new PointF(485,271),new PointF(653,281),new PointF(109,291),
            new PointF(676,197),new PointF(386,219),new PointF(386,254),new PointF(517,79),new PointF(623,69),new PointF(206,91),
            new PointF(451,64),new PointF(700,240),new PointF(404,22),new PointF(484,149),new PointF(86,74),new PointF(463,118),
            new PointF(591,74),new PointF(592,181),new PointF(566,294),new PointF(158,209),new PointF(759,201),new PointF(389,150),
            new PointF(266,54),new PointF(358,232),new PointF(616,114),new PointF(324,302),new PointF(336,150),new PointF(665,247),
            new PointF(725,262),new PointF(287,45),new PointF(714,57),new PointF(778,118),new PointF(158,97),new PointF(300,72),
            new PointF(494,323),new PointF(455,306),new PointF(238,90),
        };

        public PaintRoute(System.Windows.Forms.PictureBox pictureBox)
        {
            this.picBox = pictureBox;
            this.graphic = picBox.CreateGraphics();
            this.shortestPath.Clear();
            this.alternativePath1.Clear();
            this.alternativePath2.Clear();
            this.alternativePath3.Clear();
            this.alternativePath4.Clear();
            this.alternativePath5.Clear();
        }
        public void addShortestPath(int plateCode)
        {
            shortestPath.Add(plateCode);
        }
        public void addAlternativePaths(int plateCode, int index)
        {
            switch (index)
            {
                case 1:
                    alternativePath1.Add(plateCode);
                    break;
                case 2:
                    alternativePath2.Add(plateCode);
                    break;
                case 3:
                    alternativePath3.Add(plateCode);
                    break;
                case 4:
                    alternativePath4.Add(plateCode);
                    break;
                case 5:
                    alternativePath5.Add(plateCode);
                    break;
            }
        }
        public void clearPaths()
        {
            graphic.Dispose();
            shortestPath.Clear();
            alternativePath1.Clear();
            alternativePath2.Clear();
            alternativePath3.Clear();
            alternativePath4.Clear();
            alternativePath5.Clear();
            graphic = picBox.CreateGraphics();
            resetMap();
        }
        public void resetMap()
        { 
            picBox.Image = Image.FromFile("imgs\\map.png");
        }
        public void setPaint(byte index, bool value)
        {
            option[index] = value;
            paint();
        }

        private void paint()
        {
            a = 0;
            b = 0;
            if (option[0] == true)
            {
                paintS();
            }
            if (option[1] == true)
            {
                paintA1();
            }
            if (option[2] == true)
            {
                paintA2();
            }
            if (option[3] == true)
            {
                paintA3();
            }
            if (option[4] == true)
            {
                paintA4();
            }
            if (option[5] == true)
            {
                paintA5();
            }
            if (option[0] == false && option[1] == false && option[2] == false && option[3] == false && option[4] == false && option[5] == false)
                resetMap();
        }
        private void paintS()
        {
            if(shortestPath != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[0].ToString()), 2);
                for (int i = 0; i < shortestPath.Count - 1; i++)
                {
                    a = int.Parse(shortestPath[i].ToString());
                    b = int.Parse(shortestPath[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
            
        }
        private void paintA1()
        {
            if(alternativePath1 != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[1].ToString()), 2);
                for (int i = 0; i < alternativePath1.Count - 1; i++)
                {
                    a = int.Parse(alternativePath1[i].ToString());
                    b = int.Parse(alternativePath1[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
        }
        private void paintA2()
        {
            if (alternativePath2 != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[2].ToString()), 2);
                for (int i = 0; i < alternativePath2.Count - 1; i++)
                {
                    a = int.Parse(alternativePath2[i].ToString());
                    b = int.Parse(alternativePath2[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
        }
        private void paintA3()
        {
            if (alternativePath3 != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[3].ToString()), 2);
                for (int i = 0; i < alternativePath3.Count - 1; i++)
                {
                    a = int.Parse(alternativePath3[i].ToString());
                    b = int.Parse(alternativePath3[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
        }
        private void paintA4()
        {
            if (alternativePath4 != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[4].ToString()), 2);
                for (int i = 0; i < alternativePath4.Count - 1; i++)
                {
                    a = int.Parse(alternativePath4[i].ToString());
                    b = int.Parse(alternativePath4[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
        }
        private void paintA5()
        {
            if (alternativePath5 != null)
            {
                graphic = picBox.CreateGraphics();
                pen = new Pen(Colors.getColor(Colors.colors[5].ToString()), 2);
                for (int i = 0; i < alternativePath5.Count - 1; i++)
                {
                    a = int.Parse(alternativePath5[i].ToString());
                    b = int.Parse(alternativePath5[i + 1].ToString());

                    graphic.DrawLine(pen, points[a - 1], points[b - 1]);
                }
                graphic.Dispose();
            }
        }
    }
}
