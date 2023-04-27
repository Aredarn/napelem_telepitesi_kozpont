namespace napelem_telepito_kozpont.GUI_Forms
{
    partial class Szakember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szakember));
            this.buttonLoginSzakember = new System.Windows.Forms.Button();
            this.szakemberMenu = new System.Windows.Forms.MenuStrip();
            this.alkatrészekProjekthezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekthezRendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkatrészekListázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újProjektLétrehozásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektekListázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkHozzarendelPanel = new System.Windows.Forms.Panel();
            this.darabszamTextBox = new System.Windows.Forms.TextBox();
            this.arucikkListView = new System.Windows.Forms.ListView();
            this.nev1 = new System.Windows.Forms.ColumnHeader();
            this.darab = new System.Windows.Forms.ColumnHeader();
            this.projektIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hozzarendelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alkatreszComboBox = new System.Windows.Forms.ComboBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.darabszamLabel = new System.Windows.Forms.Label();
            this.alkatreszLabel = new System.Windows.Forms.Label();
            this.hozzarendelLabel = new System.Windows.Forms.Label();
            this.ujProjektPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonszamTextBox = new System.Windows.Forms.TextBox();
            this.lakcimTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.projektListazasPanel = new System.Windows.Forms.Panel();
            this.projektekListView = new System.Windows.Forms.ListView();
            this.ProjektID = new System.Windows.Forms.ColumnHeader();
            this.Helyszín = new System.Windows.Forms.ColumnHeader();
            this.Leírás = new System.Windows.Forms.ColumnHeader();
            this.Megrendelő_neve = new System.Windows.Forms.ColumnHeader();
            this.Megrendelő_címe = new System.Windows.Forms.ColumnHeader();
            this.Projekt_státusza = new System.Windows.Forms.ColumnHeader();
            this.label10 = new System.Windows.Forms.Label();
            this.alkatreszekPanel = new System.Windows.Forms.Panel();
            this.alkatreszekListView = new System.Windows.Forms.ListView();
            this.alk_nev = new System.Windows.Forms.ColumnHeader();
            this.ar = new System.Windows.Forms.ColumnHeader();
            this.mennyiseg = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.munkadijPanel = new System.Windows.Forms.Panel();
            this.szamitasButton = new System.Windows.Forms.Button();
            this.projektAzonositoTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.munkaoraTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.szakemberMenu.SuspendLayout();
            this.alkHozzarendelPanel.SuspendLayout();
            this.ujProjektPanel.SuspendLayout();
            this.projektListazasPanel.SuspendLayout();
            this.alkatreszekPanel.SuspendLayout();
            this.munkadijPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginSzakember
            // 
            this.buttonLoginSzakember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoginSzakember.Location = new System.Drawing.Point(1146, 785);
            this.buttonLoginSzakember.Name = "buttonLoginSzakember";
            this.buttonLoginSzakember.Size = new System.Drawing.Size(217, 75);
            this.buttonLoginSzakember.TabIndex = 0;
            this.buttonLoginSzakember.Text = "Vissza a Loginhez";
            this.buttonLoginSzakember.UseVisualStyleBackColor = true;
            this.buttonLoginSzakember.Click += new System.EventHandler(this.buttonLoginSzakember_Click);
            // 
            // szakemberMenu
            // 
            this.szakemberMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.szakemberMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.szakemberMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.szakemberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alkatrészekProjekthezToolStripMenuItem,
            this.projektekToolStripMenuItem,
            this.munkaToolStripMenuItem});
            this.szakemberMenu.Location = new System.Drawing.Point(0, 0);
            this.szakemberMenu.Name = "szakemberMenu";
            this.szakemberMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.szakemberMenu.Size = new System.Drawing.Size(157, 895);
            this.szakemberMenu.TabIndex = 1;
            this.szakemberMenu.Text = "menuStrip1";
            // 
            // alkatrészekProjekthezToolStripMenuItem
            // 
            this.alkatrészekProjekthezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekthezRendelésToolStripMenuItem,
            this.alkatrészekListázásaToolStripMenuItem});
            this.alkatrészekProjekthezToolStripMenuItem.Name = "alkatrészekProjekthezToolStripMenuItem";
            this.alkatrészekProjekthezToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.alkatrészekProjekthezToolStripMenuItem.Text = "alkatrészek";
            // 
            // projekthezRendelésToolStripMenuItem
            // 
            this.projekthezRendelésToolStripMenuItem.Name = "projekthezRendelésToolStripMenuItem";
            this.projekthezRendelésToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.projekthezRendelésToolStripMenuItem.Text = "projekthez rendelés";
            this.projekthezRendelésToolStripMenuItem.Click += new System.EventHandler(this.projekthezRendelésToolStripMenuItem_Click);
            // 
            // alkatrészekListázásaToolStripMenuItem
            // 
            this.alkatrészekListázásaToolStripMenuItem.Name = "alkatrészekListázásaToolStripMenuItem";
            this.alkatrészekListázásaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.alkatrészekListázásaToolStripMenuItem.Text = "alkatrészek listázása";
            this.alkatrészekListázásaToolStripMenuItem.Click += new System.EventHandler(this.alkatrészekListázásaToolStripMenuItem_Click);
            // 
            // projektekToolStripMenuItem
            // 
            this.projektekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újProjektLétrehozásaToolStripMenuItem,
            this.projektekListázásaToolStripMenuItem});
            this.projektekToolStripMenuItem.Name = "projektekToolStripMenuItem";
            this.projektekToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.projektekToolStripMenuItem.Text = "projektek";
            // 
            // újProjektLétrehozásaToolStripMenuItem
            // 
            this.újProjektLétrehozásaToolStripMenuItem.Name = "újProjektLétrehozásaToolStripMenuItem";
            this.újProjektLétrehozásaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.újProjektLétrehozásaToolStripMenuItem.Text = "új projekt létrehozása";
            this.újProjektLétrehozásaToolStripMenuItem.Click += new System.EventHandler(this.újProjektLétrehozásaToolStripMenuItem_Click);
            // 
            // projektekListázásaToolStripMenuItem
            // 
            this.projektekListázásaToolStripMenuItem.Name = "projektekListázásaToolStripMenuItem";
            this.projektekListázásaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.projektekListázásaToolStripMenuItem.Text = "projektek listázása";
            this.projektekListázásaToolStripMenuItem.Click += new System.EventHandler(this.projektekListázásaToolStripMenuItem_Click);
            // 
            // munkaToolStripMenuItem
            // 
            this.munkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem});
            this.munkaToolStripMenuItem.Name = "munkaToolStripMenuItem";
            this.munkaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.munkaToolStripMenuItem.Text = "munkavégzés";
            // 
            // munkadíjIdőtartamMeghatározásaToolStripMenuItem
            // 
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem.Name = "munkadíjIdőtartamMeghatározásaToolStripMenuItem";
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem.Text = "munkadíj, időtartam meghatározása";
            this.munkadíjIdőtartamMeghatározásaToolStripMenuItem.Click += new System.EventHandler(this.munkadíjIdőtartamMeghatározásaToolStripMenuItem_Click);
            // 
            // alkHozzarendelPanel
            // 
            this.alkHozzarendelPanel.BackColor = System.Drawing.Color.Transparent;
            this.alkHozzarendelPanel.Controls.Add(this.darabszamTextBox);
            this.alkHozzarendelPanel.Controls.Add(this.arucikkListView);
            this.alkHozzarendelPanel.Controls.Add(this.projektIDTextBox);
            this.alkHozzarendelPanel.Controls.Add(this.label2);
            this.alkHozzarendelPanel.Controls.Add(this.hozzarendelButton);
            this.alkHozzarendelPanel.Controls.Add(this.label1);
            this.alkHozzarendelPanel.Controls.Add(this.alkatreszComboBox);
            this.alkHozzarendelPanel.Controls.Add(this.hozzaadButton);
            this.alkHozzarendelPanel.Controls.Add(this.darabszamLabel);
            this.alkHozzarendelPanel.Controls.Add(this.alkatreszLabel);
            this.alkHozzarendelPanel.Controls.Add(this.hozzarendelLabel);
            this.alkHozzarendelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkHozzarendelPanel.Location = new System.Drawing.Point(176, 213);
            this.alkHozzarendelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alkHozzarendelPanel.Name = "alkHozzarendelPanel";
            this.alkHozzarendelPanel.Size = new System.Drawing.Size(859, 523);
            this.alkHozzarendelPanel.TabIndex = 9;
            // 
            // darabszamTextBox
            // 
            this.darabszamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darabszamTextBox.Location = new System.Drawing.Point(288, 195);
            this.darabszamTextBox.Name = "darabszamTextBox";
            this.darabszamTextBox.Size = new System.Drawing.Size(125, 24);
            this.darabszamTextBox.TabIndex = 14;
            // 
            // arucikkListView
            // 
            this.arucikkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nev1,
            this.darab});
            this.arucikkListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arucikkListView.Location = new System.Drawing.Point(539, 147);
            this.arucikkListView.Name = "arucikkListView";
            this.arucikkListView.Size = new System.Drawing.Size(281, 171);
            this.arucikkListView.TabIndex = 13;
            this.arucikkListView.UseCompatibleStateImageBehavior = false;
            this.arucikkListView.View = System.Windows.Forms.View.Details;
            // 
            // nev1
            // 
            this.nev1.Text = "Megnevezés";
            this.nev1.Width = 180;
            // 
            // darab
            // 
            this.darab.Text = "darabszam";
            this.darab.Width = 100;
            // 
            // projektIDTextBox
            // 
            this.projektIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projektIDTextBox.Location = new System.Drawing.Point(355, 429);
            this.projektIDTextBox.Name = "projektIDTextBox";
            this.projektIDTextBox.Size = new System.Drawing.Size(78, 24);
            this.projektIDTextBox.TabIndex = 12;
            this.projektIDTextBox.Text = "Projekt ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hozzárendelés a projekthez:";
            // 
            // hozzarendelButton
            // 
            this.hozzarendelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hozzarendelButton.Location = new System.Drawing.Point(542, 384);
            this.hozzarendelButton.Name = "hozzarendelButton";
            this.hozzarendelButton.Size = new System.Drawing.Size(278, 69);
            this.hozzarendelButton.TabIndex = 10;
            this.hozzarendelButton.Text = "Kiválasztott elemek hozzárendelelése \r\na kiválasztott projekthez";
            this.hozzarendelButton.UseVisualStyleBackColor = true;
            this.hozzarendelButton.Click += new System.EventHandler(this.hozzarendelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kiválasztott alkatrészek:\r\n";
            // 
            // alkatreszComboBox
            // 
            this.alkatreszComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkatreszComboBox.FormattingEnabled = true;
            this.alkatreszComboBox.Location = new System.Drawing.Point(153, 147);
            this.alkatreszComboBox.Name = "alkatreszComboBox";
            this.alkatreszComboBox.Size = new System.Drawing.Size(260, 26);
            this.alkatreszComboBox.TabIndex = 6;
            this.alkatreszComboBox.SelectedIndexChanged += new System.EventHandler(this.alkatreszComboBox_SelectedIndexChanged);
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hozzaadButton.Location = new System.Drawing.Point(27, 247);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(165, 69);
            this.hozzaadButton.TabIndex = 5;
            this.hozzaadButton.Text = "Hozzáadás \r\na listához";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
            // 
            // darabszamLabel
            // 
            this.darabszamLabel.AutoSize = true;
            this.darabszamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.darabszamLabel.ForeColor = System.Drawing.Color.White;
            this.darabszamLabel.Location = new System.Drawing.Point(27, 187);
            this.darabszamLabel.Name = "darabszamLabel";
            this.darabszamLabel.Size = new System.Drawing.Size(255, 32);
            this.darabszamLabel.TabIndex = 3;
            this.darabszamLabel.Text = "Szükséges mennyiség:";
            // 
            // alkatreszLabel
            // 
            this.alkatreszLabel.AutoSize = true;
            this.alkatreszLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alkatreszLabel.ForeColor = System.Drawing.Color.White;
            this.alkatreszLabel.Location = new System.Drawing.Point(27, 140);
            this.alkatreszLabel.Name = "alkatreszLabel";
            this.alkatreszLabel.Size = new System.Drawing.Size(120, 32);
            this.alkatreszLabel.TabIndex = 1;
            this.alkatreszLabel.Text = "Alkatrész:";
            // 
            // hozzarendelLabel
            // 
            this.hozzarendelLabel.AutoSize = true;
            this.hozzarendelLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hozzarendelLabel.ForeColor = System.Drawing.Color.White;
            this.hozzarendelLabel.Location = new System.Drawing.Point(27, 49);
            this.hozzarendelLabel.Name = "hozzarendelLabel";
            this.hozzarendelLabel.Size = new System.Drawing.Size(636, 46);
            this.hozzarendelLabel.TabIndex = 0;
            this.hozzarendelLabel.Text = "Alkatrészek hozzárendelése projekthez";
            // 
            // ujProjektPanel
            // 
            this.ujProjektPanel.BackColor = System.Drawing.Color.Transparent;
            this.ujProjektPanel.Controls.Add(this.emailTextBox);
            this.ujProjektPanel.Controls.Add(this.telefonszamTextBox);
            this.ujProjektPanel.Controls.Add(this.lakcimTextBox);
            this.ujProjektPanel.Controls.Add(this.nevTextBox);
            this.ujProjektPanel.Controls.Add(this.label17);
            this.ujProjektPanel.Controls.Add(this.label16);
            this.ujProjektPanel.Controls.Add(this.label15);
            this.ujProjektPanel.Controls.Add(this.label14);
            this.ujProjektPanel.Controls.Add(this.leirasTextBox);
            this.ujProjektPanel.Controls.Add(this.textBox1);
            this.ujProjektPanel.Controls.Add(this.button1);
            this.ujProjektPanel.Controls.Add(this.label4);
            this.ujProjektPanel.Controls.Add(this.label5);
            this.ujProjektPanel.Controls.Add(this.label6);
            this.ujProjektPanel.Controls.Add(this.label7);
            this.ujProjektPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ujProjektPanel.Location = new System.Drawing.Point(173, 213);
            this.ujProjektPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ujProjektPanel.Name = "ujProjektPanel";
            this.ujProjektPanel.Size = new System.Drawing.Size(859, 523);
            this.ujProjektPanel.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.Location = new System.Drawing.Point(509, 299);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(294, 24);
            this.emailTextBox.TabIndex = 20;
            // 
            // telefonszamTextBox
            // 
            this.telefonszamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonszamTextBox.Location = new System.Drawing.Point(565, 263);
            this.telefonszamTextBox.Name = "telefonszamTextBox";
            this.telefonszamTextBox.Size = new System.Drawing.Size(238, 24);
            this.telefonszamTextBox.TabIndex = 19;
            // 
            // lakcimTextBox
            // 
            this.lakcimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lakcimTextBox.Location = new System.Drawing.Point(517, 231);
            this.lakcimTextBox.Name = "lakcimTextBox";
            this.lakcimTextBox.Size = new System.Drawing.Size(286, 24);
            this.lakcimTextBox.TabIndex = 18;
            // 
            // nevTextBox
            // 
            this.nevTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nevTextBox.Location = new System.Drawing.Point(474, 197);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(329, 24);
            this.nevTextBox.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(415, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 32);
            this.label17.TabIndex = 16;
            this.label17.Text = "E-mail:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(415, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 32);
            this.label16.TabIndex = 15;
            this.label16.Text = "Telefonszám:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(415, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 32);
            this.label15.TabIndex = 14;
            this.label15.Text = "Lakcím:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(415, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 32);
            this.label14.TabIndex = 13;
            this.label14.Text = "Név:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leirasTextBox.Location = new System.Drawing.Point(27, 223);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(309, 171);
            this.leirasTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(143, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 24);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(542, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "Projekt létrehozása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(415, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Megrendelő adatai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Leírás:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Helyszín:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Új projekt létrehozása";
            // 
            // projektListazasPanel
            // 
            this.projektListazasPanel.BackColor = System.Drawing.Color.Transparent;
            this.projektListazasPanel.Controls.Add(this.projektekListView);
            this.projektListazasPanel.Controls.Add(this.label10);
            this.projektListazasPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projektListazasPanel.Location = new System.Drawing.Point(170, 219);
            this.projektListazasPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projektListazasPanel.Name = "projektListazasPanel";
            this.projektListazasPanel.Size = new System.Drawing.Size(1039, 523);
            this.projektListazasPanel.TabIndex = 11;
            // 
            // projektekListView
            // 
            this.projektekListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjektID,
            this.Helyszín,
            this.Leírás,
            this.Megrendelő_neve,
            this.Megrendelő_címe,
            this.Projekt_státusza});
            this.projektekListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projektekListView.Location = new System.Drawing.Point(33, 107);
            this.projektekListView.Name = "projektekListView";
            this.projektekListView.Size = new System.Drawing.Size(956, 343);
            this.projektekListView.TabIndex = 1;
            this.projektekListView.UseCompatibleStateImageBehavior = false;
            this.projektekListView.View = System.Windows.Forms.View.Details;
            // 
            // ProjektID
            // 
            this.ProjektID.Text = "Projekt ID";
            this.ProjektID.Width = 100;
            // 
            // Helyszín
            // 
            this.Helyszín.Text = "Helyszín";
            this.Helyszín.Width = 150;
            // 
            // Leírás
            // 
            this.Leírás.Text = "Leírás";
            this.Leírás.Width = 200;
            // 
            // Megrendelő_neve
            // 
            this.Megrendelő_neve.Text = "Megrendelő neve";
            this.Megrendelő_neve.Width = 150;
            // 
            // Megrendelő_címe
            // 
            this.Megrendelő_címe.Text = "Megrendelő címe";
            this.Megrendelő_címe.Width = 200;
            // 
            // Projekt_státusza
            // 
            this.Projekt_státusza.Text = "Státusz";
            this.Projekt_státusza.Width = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Projektek listázása";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // alkatreszekPanel
            // 
            this.alkatreszekPanel.BackColor = System.Drawing.Color.Transparent;
            this.alkatreszekPanel.Controls.Add(this.alkatreszekListView);
            this.alkatreszekPanel.Controls.Add(this.label3);
            this.alkatreszekPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkatreszekPanel.Location = new System.Drawing.Point(173, 188);
            this.alkatreszekPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alkatreszekPanel.Name = "alkatreszekPanel";
            this.alkatreszekPanel.Size = new System.Drawing.Size(1039, 523);
            this.alkatreszekPanel.TabIndex = 12;
            // 
            // alkatreszekListView
            // 
            this.alkatreszekListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.alk_nev,
            this.ar,
            this.mennyiseg});
            this.alkatreszekListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkatreszekListView.Location = new System.Drawing.Point(33, 107);
            this.alkatreszekListView.Name = "alkatreszekListView";
            this.alkatreszekListView.Size = new System.Drawing.Size(654, 343);
            this.alkatreszekListView.TabIndex = 1;
            this.alkatreszekListView.UseCompatibleStateImageBehavior = false;
            this.alkatreszekListView.View = System.Windows.Forms.View.Details;
            // 
            // alk_nev
            // 
            this.alk_nev.Text = "Alkatrész megnevezése";
            this.alk_nev.Width = 200;
            // 
            // ar
            // 
            this.ar.Text = "Ár";
            this.ar.Width = 150;
            // 
            // mennyiseg
            // 
            this.mennyiseg.Text = "Raktáron";
            this.mennyiseg.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alkatrészek listázása";
            // 
            // munkadijPanel
            // 
            this.munkadijPanel.BackColor = System.Drawing.Color.Transparent;
            this.munkadijPanel.Controls.Add(this.szamitasButton);
            this.munkadijPanel.Controls.Add(this.projektAzonositoTextBox);
            this.munkadijPanel.Controls.Add(this.label12);
            this.munkadijPanel.Controls.Add(this.munkaoraTextBox);
            this.munkadijPanel.Controls.Add(this.label11);
            this.munkadijPanel.Controls.Add(this.label9);
            this.munkadijPanel.Controls.Add(this.label8);
            this.munkadijPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.munkadijPanel.Location = new System.Drawing.Point(167, 355);
            this.munkadijPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.munkadijPanel.Name = "munkadijPanel";
            this.munkadijPanel.Size = new System.Drawing.Size(1039, 523);
            this.munkadijPanel.TabIndex = 13;
            // 
            // szamitasButton
            // 
            this.szamitasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.szamitasButton.Location = new System.Drawing.Point(525, 147);
            this.szamitasButton.Name = "szamitasButton";
            this.szamitasButton.Size = new System.Drawing.Size(147, 68);
            this.szamitasButton.TabIndex = 6;
            this.szamitasButton.Text = "Kalkulálás";
            this.szamitasButton.UseVisualStyleBackColor = true;
            this.szamitasButton.Click += new System.EventHandler(this.szamitasButton_Click);
            // 
            // projektAzonositoTextBox
            // 
            this.projektAzonositoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projektAzonositoTextBox.Location = new System.Drawing.Point(351, 147);
            this.projektAzonositoTextBox.Name = "projektAzonositoTextBox";
            this.projektAzonositoTextBox.Size = new System.Drawing.Size(159, 30);
            this.projektAzonositoTextBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Adja meg a projekt azonosítóját:";
            // 
            // munkaoraTextBox
            // 
            this.munkaoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.munkaoraTextBox.Location = new System.Drawing.Point(352, 187);
            this.munkaoraTextBox.Name = "munkaoraTextBox";
            this.munkaoraTextBox.Size = new System.Drawing.Size(159, 30);
            this.munkaoraTextBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(326, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Adja meg a tervezett munkaórát:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Munkadíj fix 15.000 ft óránként!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(423, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "Munkadíj meghatározása";
            // 
            // Szakember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.buttonLoginSzakember);
            this.Controls.Add(this.szakemberMenu);
            this.Controls.Add(this.alkatreszekPanel);
            this.Controls.Add(this.projektListazasPanel);
            this.Controls.Add(this.ujProjektPanel);
            this.Controls.Add(this.munkadijPanel);
            this.Controls.Add(this.alkHozzarendelPanel);
            this.Name = "Szakember";
            this.Text = "Szakember";
            this.Load += new System.EventHandler(this.Szakember_Load);
            this.szakemberMenu.ResumeLayout(false);
            this.szakemberMenu.PerformLayout();
            this.alkHozzarendelPanel.ResumeLayout(false);
            this.alkHozzarendelPanel.PerformLayout();
            this.ujProjektPanel.ResumeLayout(false);
            this.ujProjektPanel.PerformLayout();
            this.projektListazasPanel.ResumeLayout(false);
            this.projektListazasPanel.PerformLayout();
            this.alkatreszekPanel.ResumeLayout(false);
            this.alkatreszekPanel.PerformLayout();
            this.munkadijPanel.ResumeLayout(false);
            this.munkadijPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLoginSzakember;
        private MenuStrip szakemberMenu;
        private ToolStripMenuItem alkatrészekProjekthezToolStripMenuItem;
        private ToolStripMenuItem projekthezRendelésToolStripMenuItem;
        private Panel alkHozzarendelPanel;
        private Label hozzarendelLabel;
        private Label alkatreszLabel;
        private Label darabszamLabel;
        private Button hozzaadButton;
        private Label label2;
        private Button hozzarendelButton;
        private Label label1;
        private ComboBox alkatreszComboBox;
        private TextBox projektIDTextBox;
        private ToolStripMenuItem alkatrészekListázásaToolStripMenuItem;
        private ToolStripMenuItem projektekToolStripMenuItem;
        private ToolStripMenuItem újProjektLétrehozásaToolStripMenuItem;
        private ToolStripMenuItem projektekListázásaToolStripMenuItem;
        private ToolStripMenuItem munkaToolStripMenuItem;
        private ToolStripMenuItem munkadíjIdőtartamMeghatározásaToolStripMenuItem;
        private Panel ujProjektPanel;
        private TextBox leirasTextBox;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel projektListazasPanel;
        private Label label10;
        private ListView projektekListView;
        private ColumnHeader ProjektID;
        private ColumnHeader Helyszín;
        private ColumnHeader Leírás;
        private ColumnHeader Megrendelő_neve;
        private ColumnHeader Megrendelő_címe;
        private ColumnHeader Projekt_státusza;
        private Panel alkatreszekPanel;
        private ListView alkatreszekListView;
        private ColumnHeader alk_nev;
        private ColumnHeader ar;
        private ColumnHeader mennyiseg;
        private Label label3;
        private Panel munkadijPanel;
        private TextBox projektAzonositoTextBox;
        private Label label12;
        private TextBox munkaoraTextBox;
        private Label label11;
        private Label label9;
        private Label label8;
        private Button szamitasButton;
        private ListView arucikkListView;
        private ColumnHeader nev1;
        private ColumnHeader darab;
        private TextBox darabszamTextBox;
        private TextBox emailTextBox;
        private TextBox telefonszamTextBox;
        private TextBox lakcimTextBox;
        private TextBox nevTextBox;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}