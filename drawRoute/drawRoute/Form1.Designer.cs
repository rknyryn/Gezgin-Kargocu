namespace drawRoute
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxMap = new System.Windows.Forms.PictureBox();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.menuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listedenSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddedCities = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbBoxCities = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDrawRoute = new System.Windows.Forms.Button();
            this.chkBoxAlternativePath1 = new System.Windows.Forms.CheckBox();
            this.chkBoxShortestPath = new System.Windows.Forms.CheckBox();
            this.btnOutPutFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirleriİçeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesafeleriİçeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarıİşleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarıİçeriAktarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotaÇizmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yollarıHaritadaGöstermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteListAll = new System.Windows.Forms.Button();
            this.listBoxShortestPath = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDestinationPoints = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxAlternativePaths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxAlternativePath2 = new System.Windows.Forms.CheckBox();
            this.chkBoxAlternativePath3 = new System.Windows.Forms.CheckBox();
            this.chkBoxAlternativePath4 = new System.Windows.Forms.CheckBox();
            this.chkBoxAlternativePath5 = new System.Windows.Forms.CheckBox();
            this.çıktıDosyasıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıktıDosyasıOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).BeginInit();
            this.menuListBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBoxMap);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 548);
            this.panel1.TabIndex = 0;
            // 
            // picBoxMap
            // 
            this.picBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMap.Image")));
            this.picBoxMap.Location = new System.Drawing.Point(3, 3);
            this.picBoxMap.Name = "picBoxMap";
            this.picBoxMap.Size = new System.Drawing.Size(1117, 542);
            this.picBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMap.TabIndex = 0;
            this.picBoxMap.TabStop = false;
            // 
            // listBoxCities
            // 
            this.listBoxCities.ContextMenuStrip = this.menuListBox;
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.ItemHeight = 16;
            this.listBoxCities.Location = new System.Drawing.Point(29, 610);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(191, 148);
            this.listBoxCities.TabIndex = 1;
            // 
            // menuListBox
            // 
            this.menuListBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listedenSilToolStripMenuItem});
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(154, 28);
            // 
            // listedenSilToolStripMenuItem
            // 
            this.listedenSilToolStripMenuItem.Name = "listedenSilToolStripMenuItem";
            this.listedenSilToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.listedenSilToolStripMenuItem.Text = "Listeden Sil";
            this.listedenSilToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAddedCities
            // 
            this.lblAddedCities.AutoSize = true;
            this.lblAddedCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddedCities.Location = new System.Drawing.Point(26, 589);
            this.lblAddedCities.Name = "lblAddedCities";
            this.lblAddedCities.Size = new System.Drawing.Size(115, 18);
            this.lblAddedCities.TabIndex = 2;
            this.lblAddedCities.Text = "Eklenen Şehirler";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(29, 764);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Listeden Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbBoxCities
            // 
            this.cmbBoxCities.AccessibleName = "cmbBoxCities";
            this.cmbBoxCities.FormattingEnabled = true;
            this.cmbBoxCities.Location = new System.Drawing.Point(241, 610);
            this.cmbBoxCities.Name = "cmbBoxCities";
            this.cmbBoxCities.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxCities.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(241, 640);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Listeye Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDrawRoute
            // 
            this.btnDrawRoute.Location = new System.Drawing.Point(241, 765);
            this.btnDrawRoute.Name = "btnDrawRoute";
            this.btnDrawRoute.Size = new System.Drawing.Size(205, 30);
            this.btnDrawRoute.TabIndex = 7;
            this.btnDrawRoute.Text = "Rota Çiz";
            this.btnDrawRoute.UseVisualStyleBackColor = true;
            this.btnDrawRoute.Click += new System.EventHandler(this.btnDrawRoute_Click);
            // 
            // chkBoxAlternativePath1
            // 
            this.chkBoxAlternativePath1.AutoSize = true;
            this.chkBoxAlternativePath1.Location = new System.Drawing.Point(542, 679);
            this.chkBoxAlternativePath1.Name = "chkBoxAlternativePath1";
            this.chkBoxAlternativePath1.Size = new System.Drawing.Size(120, 21);
            this.chkBoxAlternativePath1.TabIndex = 9;
            this.chkBoxAlternativePath1.Text = "Alternatif yol 1";
            this.chkBoxAlternativePath1.UseVisualStyleBackColor = true;
            this.chkBoxAlternativePath1.CheckedChanged += new System.EventHandler(this.chkBoxAlternativePath1_CheckedChanged);
            // 
            // chkBoxShortestPath
            // 
            this.chkBoxShortestPath.AutoSize = true;
            this.chkBoxShortestPath.Location = new System.Drawing.Point(542, 652);
            this.chkBoxShortestPath.Name = "chkBoxShortestPath";
            this.chkBoxShortestPath.Size = new System.Drawing.Size(98, 21);
            this.chkBoxShortestPath.TabIndex = 8;
            this.chkBoxShortestPath.Text = "En kısa yol";
            this.chkBoxShortestPath.UseVisualStyleBackColor = true;
            this.chkBoxShortestPath.CheckedChanged += new System.EventHandler(this.chkBoxShortestPath_CheckedChanged);
            // 
            // btnOutPutFile
            // 
            this.btnOutPutFile.Location = new System.Drawing.Point(241, 801);
            this.btnOutPutFile.Name = "btnOutPutFile";
            this.btnOutPutFile.Size = new System.Drawing.Size(205, 30);
            this.btnOutPutFile.TabIndex = 10;
            this.btnOutPutFile.Text = "Çıktı Dosyası Oluştur";
            this.btnOutPutFile.UseVisualStyleBackColor = true;
            this.btnOutPutFile.Click += new System.EventHandler(this.btnOutPutFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirleriİçeriAktarToolStripMenuItem,
            this.mesafeleriİçeriAktarToolStripMenuItem,
            this.dosyalarıİşleToolStripMenuItem,
            this.çıktıDosyasıOluşturToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // şehirleriİçeriAktarToolStripMenuItem
            // 
            this.şehirleriİçeriAktarToolStripMenuItem.Name = "şehirleriİçeriAktarToolStripMenuItem";
            this.şehirleriİçeriAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.şehirleriİçeriAktarToolStripMenuItem.Text = "Şehirleri İçeri Aktar";
            this.şehirleriİçeriAktarToolStripMenuItem.Click += new System.EventHandler(this.şehirleriİçeriAktarToolStripMenuItem_Click);
            // 
            // mesafeleriİçeriAktarToolStripMenuItem
            // 
            this.mesafeleriİçeriAktarToolStripMenuItem.Name = "mesafeleriİçeriAktarToolStripMenuItem";
            this.mesafeleriİçeriAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mesafeleriİçeriAktarToolStripMenuItem.Text = "Mesafeleri İçeri Aktar";
            this.mesafeleriİçeriAktarToolStripMenuItem.Click += new System.EventHandler(this.mesafeleriİçeriAktarToolStripMenuItem_Click);
            // 
            // dosyalarıİşleToolStripMenuItem
            // 
            this.dosyalarıİşleToolStripMenuItem.Name = "dosyalarıİşleToolStripMenuItem";
            this.dosyalarıİşleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dosyalarıİşleToolStripMenuItem.Text = "Dosyaları İşle";
            this.dosyalarıİşleToolStripMenuItem.Click += new System.EventHandler(this.dosyalarıİşleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkAyarlarıToolStripMenuItem
            // 
            this.renkAyarlarıToolStripMenuItem.Name = "renkAyarlarıToolStripMenuItem";
            this.renkAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.renkAyarlarıToolStripMenuItem.Text = "Renk Ayarları";
            this.renkAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.renkAyarlarıToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyalarıİçeriAktarmaToolStripMenuItem,
            this.renkDeğiştirmeToolStripMenuItem,
            this.rotaÇizmeToolStripMenuItem,
            this.yollarıHaritadaGöstermeToolStripMenuItem,
            this.çıktıDosyasıOluşturmaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // dosyalarıİçeriAktarmaToolStripMenuItem
            // 
            this.dosyalarıİçeriAktarmaToolStripMenuItem.Name = "dosyalarıİçeriAktarmaToolStripMenuItem";
            this.dosyalarıİçeriAktarmaToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.dosyalarıİçeriAktarmaToolStripMenuItem.Text = "Dosyaları içeri aktarma";
            this.dosyalarıİçeriAktarmaToolStripMenuItem.Click += new System.EventHandler(this.dosyalarıİçeriAktarmaToolStripMenuItem_Click);
            // 
            // rotaÇizmeToolStripMenuItem
            // 
            this.rotaÇizmeToolStripMenuItem.Name = "rotaÇizmeToolStripMenuItem";
            this.rotaÇizmeToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.rotaÇizmeToolStripMenuItem.Text = "Rota çizme";
            this.rotaÇizmeToolStripMenuItem.Click += new System.EventHandler(this.rotaÇizmeToolStripMenuItem_Click);
            // 
            // yollarıHaritadaGöstermeToolStripMenuItem
            // 
            this.yollarıHaritadaGöstermeToolStripMenuItem.Name = "yollarıHaritadaGöstermeToolStripMenuItem";
            this.yollarıHaritadaGöstermeToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.yollarıHaritadaGöstermeToolStripMenuItem.Text = "Yolları haritada gösterme";
            this.yollarıHaritadaGöstermeToolStripMenuItem.Click += new System.EventHandler(this.yollarıHaritadaGöstermeToolStripMenuItem_Click);
            // 
            // renkDeğiştirmeToolStripMenuItem
            // 
            this.renkDeğiştirmeToolStripMenuItem.Name = "renkDeğiştirmeToolStripMenuItem";
            this.renkDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.renkDeğiştirmeToolStripMenuItem.Text = "Renk Değiştirme";
            this.renkDeğiştirmeToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirmeToolStripMenuItem_Click);
            // 
            // btnDeleteListAll
            // 
            this.btnDeleteListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteListAll.Location = new System.Drawing.Point(29, 800);
            this.btnDeleteListAll.Name = "btnDeleteListAll";
            this.btnDeleteListAll.Size = new System.Drawing.Size(193, 30);
            this.btnDeleteListAll.TabIndex = 12;
            this.btnDeleteListAll.Text = "Listeyi Temizle";
            this.btnDeleteListAll.UseVisualStyleBackColor = true;
            this.btnDeleteListAll.Click += new System.EventHandler(this.btnDeleteListAll_Click);
            // 
            // listBoxShortestPath
            // 
            this.listBoxShortestPath.ContextMenuStrip = this.menuListBox;
            this.listBoxShortestPath.FormattingEnabled = true;
            this.listBoxShortestPath.ItemHeight = 16;
            this.listBoxShortestPath.Location = new System.Drawing.Point(6, 5);
            this.listBoxShortestPath.Name = "listBoxShortestPath";
            this.listBoxShortestPath.Size = new System.Drawing.Size(218, 196);
            this.listBoxShortestPath.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Varış Noktaları";
            // 
            // listBoxDestinationPoints
            // 
            this.listBoxDestinationPoints.FormattingEnabled = true;
            this.listBoxDestinationPoints.ItemHeight = 16;
            this.listBoxDestinationPoints.Location = new System.Drawing.Point(738, 611);
            this.listBoxDestinationPoints.Name = "listBoxDestinationPoints";
            this.listBoxDestinationPoints.Size = new System.Drawing.Size(150, 212);
            this.listBoxDestinationPoints.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(897, 592);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 238);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxShortestPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(230, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "En Kısa Yol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxAlternativePaths);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(230, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternatif Yollar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxAlternativePaths
            // 
            this.listBoxAlternativePaths.FormattingEnabled = true;
            this.listBoxAlternativePaths.ItemHeight = 16;
            this.listBoxAlternativePaths.Location = new System.Drawing.Point(6, 6);
            this.listBoxAlternativePaths.Name = "listBoxAlternativePaths";
            this.listBoxAlternativePaths.Size = new System.Drawing.Size(218, 196);
            this.listBoxAlternativePaths.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yol Çiz";
            // 
            // chkBoxAlternativePath2
            // 
            this.chkBoxAlternativePath2.AutoSize = true;
            this.chkBoxAlternativePath2.Location = new System.Drawing.Point(542, 706);
            this.chkBoxAlternativePath2.Name = "chkBoxAlternativePath2";
            this.chkBoxAlternativePath2.Size = new System.Drawing.Size(120, 21);
            this.chkBoxAlternativePath2.TabIndex = 19;
            this.chkBoxAlternativePath2.Text = "Alternatif yol 2";
            this.chkBoxAlternativePath2.UseVisualStyleBackColor = true;
            this.chkBoxAlternativePath2.CheckedChanged += new System.EventHandler(this.chkBoxAlternativePath2_CheckedChanged);
            // 
            // chkBoxAlternativePath3
            // 
            this.chkBoxAlternativePath3.AutoSize = true;
            this.chkBoxAlternativePath3.Location = new System.Drawing.Point(542, 733);
            this.chkBoxAlternativePath3.Name = "chkBoxAlternativePath3";
            this.chkBoxAlternativePath3.Size = new System.Drawing.Size(120, 21);
            this.chkBoxAlternativePath3.TabIndex = 20;
            this.chkBoxAlternativePath3.Text = "Alternatif yol 3";
            this.chkBoxAlternativePath3.UseVisualStyleBackColor = true;
            this.chkBoxAlternativePath3.CheckedChanged += new System.EventHandler(this.chkBoxAlternativePath3_CheckedChanged);
            // 
            // chkBoxAlternativePath4
            // 
            this.chkBoxAlternativePath4.AutoSize = true;
            this.chkBoxAlternativePath4.Location = new System.Drawing.Point(542, 760);
            this.chkBoxAlternativePath4.Name = "chkBoxAlternativePath4";
            this.chkBoxAlternativePath4.Size = new System.Drawing.Size(120, 21);
            this.chkBoxAlternativePath4.TabIndex = 21;
            this.chkBoxAlternativePath4.Text = "Alternatif yol 4";
            this.chkBoxAlternativePath4.UseVisualStyleBackColor = true;
            this.chkBoxAlternativePath4.CheckedChanged += new System.EventHandler(this.chkBoxAlternativePath4_CheckedChanged);
            // 
            // chkBoxAlternativePath5
            // 
            this.chkBoxAlternativePath5.AutoSize = true;
            this.chkBoxAlternativePath5.Location = new System.Drawing.Point(542, 787);
            this.chkBoxAlternativePath5.Name = "chkBoxAlternativePath5";
            this.chkBoxAlternativePath5.Size = new System.Drawing.Size(120, 21);
            this.chkBoxAlternativePath5.TabIndex = 22;
            this.chkBoxAlternativePath5.Text = "Alternatif yol 5";
            this.chkBoxAlternativePath5.UseVisualStyleBackColor = true;
            this.chkBoxAlternativePath5.CheckedChanged += new System.EventHandler(this.chkBoxAlternativePath5_CheckedChanged);
            // 
            // çıktıDosyasıOluşturToolStripMenuItem
            // 
            this.çıktıDosyasıOluşturToolStripMenuItem.Name = "çıktıDosyasıOluşturToolStripMenuItem";
            this.çıktıDosyasıOluşturToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıktıDosyasıOluşturToolStripMenuItem.Text = "Çıktı Dosyası Oluştur";
            this.çıktıDosyasıOluşturToolStripMenuItem.Click += new System.EventHandler(this.btnOutPutFile_Click);
            // 
            // çıktıDosyasıOluşturmaToolStripMenuItem
            // 
            this.çıktıDosyasıOluşturmaToolStripMenuItem.Name = "çıktıDosyasıOluşturmaToolStripMenuItem";
            this.çıktıDosyasıOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.çıktıDosyasıOluşturmaToolStripMenuItem.Text = "Çıktı Dosyası Oluşturma";
            this.çıktıDosyasıOluşturmaToolStripMenuItem.Click += new System.EventHandler(this.çıktıDosyasıOluşturmaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 847);
            this.Controls.Add(this.chkBoxAlternativePath5);
            this.Controls.Add(this.chkBoxAlternativePath4);
            this.Controls.Add(this.chkBoxAlternativePath3);
            this.Controls.Add(this.chkBoxAlternativePath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxDestinationPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteListAll);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOutPutFile);
            this.Controls.Add(this.chkBoxAlternativePath1);
            this.Controls.Add(this.chkBoxShortestPath);
            this.Controls.Add(this.btnDrawRoute);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbBoxCities);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAddedCities);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1165, 894);
            this.MinimumSize = new System.Drawing.Size(1165, 894);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw Route";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).EndInit();
            this.menuListBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxMap;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.Label lblAddedCities;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbBoxCities;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip menuListBox;
        private System.Windows.Forms.ToolStripMenuItem listedenSilToolStripMenuItem;
        private System.Windows.Forms.Button btnDrawRoute;
        private System.Windows.Forms.CheckBox chkBoxAlternativePath1;
        private System.Windows.Forms.CheckBox chkBoxShortestPath;
        private System.Windows.Forms.Button btnOutPutFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirleriİçeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesafeleriİçeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyalarıİşleToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteListAll;
        private System.Windows.Forms.ListBox listBoxShortestPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDestinationPoints;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxAlternativePaths;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkAyarlarıToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxAlternativePath2;
        private System.Windows.Forms.CheckBox chkBoxAlternativePath3;
        private System.Windows.Forms.CheckBox chkBoxAlternativePath4;
        private System.Windows.Forms.CheckBox chkBoxAlternativePath5;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyalarıİçeriAktarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotaÇizmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yollarıHaritadaGöstermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıktıDosyasıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıktıDosyasıOluşturmaToolStripMenuItem;
    }
}

