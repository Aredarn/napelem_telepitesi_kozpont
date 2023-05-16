namespace napelem_telepito_kozpont.GUI_Forms
{
    partial class Raktárvezető
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raktárvezető));
            this.buttonLoginRaktarvezeto = new System.Windows.Forms.Button();
            this.raktarvezetoMenu = new System.Windows.Forms.MenuStrip();
            this.alkatreszekMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hozzaadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modositMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hianyzikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.raktarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.beerkezoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tarolasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.almenu_cim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rekeszMaxLabel = new System.Windows.Forms.Label();
            this.ujNev = new System.Windows.Forms.TextBox();
            this.ujAr = new System.Windows.Forms.TextBox();
            this.rekeszenkentiMax = new System.Windows.Forms.NumericUpDown();
            this.hozzaadPanel = new System.Windows.Forms.Panel();
            this.arModositasButton = new System.Windows.Forms.Button();
            this.hozzaadasButton = new System.Windows.Forms.Button();
            this.arucikkekCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.beerkezettAlkComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mennyisegTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.raktarHozzaadPanel = new System.Windows.Forms.Panel();
            this.raktarHozzaadButton = new System.Windows.Forms.Button();
            this.rekeszPanel = new System.Windows.Forms.Panel();
            this.rekeszekDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hianyzoAlkatreszekPanel = new System.Windows.Forms.Panel();
            this.hianyzoListView = new System.Windows.Forms.ListView();
            this.p_id = new System.Windows.Forms.ColumnHeader();
            this.alk_nev = new System.Windows.Forms.ColumnHeader();
            this.hianyzo_db = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hianyzoLefoglaltPanel = new System.Windows.Forms.Panel();
            this.hianyzoLefoglaltListView = new System.Windows.Forms.ListView();
            this.alk_h_megn = new System.Windows.Forms.ColumnHeader();
            this.hiany_H_menny = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raktarvezetoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszenkentiMax)).BeginInit();
            this.hozzaadPanel.SuspendLayout();
            this.raktarHozzaadPanel.SuspendLayout();
            this.rekeszPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszekDataGridView)).BeginInit();
            this.hianyzoAlkatreszekPanel.SuspendLayout();
            this.hianyzoLefoglaltPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginRaktarvezeto
            // 
            this.buttonLoginRaktarvezeto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoginRaktarvezeto.Location = new System.Drawing.Point(1146, 785);
            this.buttonLoginRaktarvezeto.Name = "buttonLoginRaktarvezeto";
            this.buttonLoginRaktarvezeto.Size = new System.Drawing.Size(217, 75);
            this.buttonLoginRaktarvezeto.TabIndex = 0;
            this.buttonLoginRaktarvezeto.Text = "Vissza a Loginhez";
            this.buttonLoginRaktarvezeto.UseVisualStyleBackColor = true;
            this.buttonLoginRaktarvezeto.Click += new System.EventHandler(this.buttonLoginRaktarvezeto_Click_1);
            // 
            // raktarvezetoMenu
            // 
            this.raktarvezetoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.raktarvezetoMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.raktarvezetoMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.raktarvezetoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alkatreszekMenu,
            this.raktarMenu});
            this.raktarvezetoMenu.Location = new System.Drawing.Point(0, 0);
            this.raktarvezetoMenu.Name = "raktarvezetoMenu";
            this.raktarvezetoMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.raktarvezetoMenu.Size = new System.Drawing.Size(157, 895);
            this.raktarvezetoMenu.TabIndex = 1;
            this.raktarvezetoMenu.Text = "raktarvezetoMenu";
            // 
            // alkatreszekMenu
            // 
            this.alkatreszekMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hozzaadMenu,
            this.modositMenu,
            this.hianyzikMenu,
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem});
            this.alkatreszekMenu.Name = "alkatreszekMenu";
            this.alkatreszekMenu.Size = new System.Drawing.Size(142, 24);
            this.alkatreszekMenu.Text = "alkatrészek";
            // 
            // hozzaadMenu
            // 
            this.hozzaadMenu.Name = "hozzaadMenu";
            this.hozzaadMenu.Size = new System.Drawing.Size(280, 26);
            this.hozzaadMenu.Text = "hozzáadás";
            this.hozzaadMenu.Click += new System.EventHandler(this.hozzaadMenu_Click);
            // 
            // modositMenu
            // 
            this.modositMenu.Name = "modositMenu";
            this.modositMenu.Size = new System.Drawing.Size(280, 26);
            this.modositMenu.Text = "módosítás";
            this.modositMenu.Click += new System.EventHandler(this.modositMenu_Click);
            // 
            // hianyzikMenu
            // 
            this.hianyzikMenu.Name = "hianyzikMenu";
            this.hianyzikMenu.Size = new System.Drawing.Size(280, 26);
            this.hianyzikMenu.Text = "hiányzó alkatrészek";
            this.hianyzikMenu.Click += new System.EventHandler(this.hianyzikMenu_Click);
            // 
            // raktarMenu
            // 
            this.raktarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beerkezoMenu,
            this.tarolasMenu});
            this.raktarMenu.Name = "raktarMenu";
            this.raktarMenu.Size = new System.Drawing.Size(142, 24);
            this.raktarMenu.Text = "raktár";
            // 
            // beerkezoMenu
            // 
            this.beerkezoMenu.Name = "beerkezoMenu";
            this.beerkezoMenu.Size = new System.Drawing.Size(267, 26);
            this.beerkezoMenu.Text = "beérkező alkatrészek";
            this.beerkezoMenu.Click += new System.EventHandler(this.beerkezoMenu_Click);
            // 
            // tarolasMenu
            // 
            this.tarolasMenu.Name = "tarolasMenu";
            this.tarolasMenu.Size = new System.Drawing.Size(267, 26);
            this.tarolasMenu.Text = "rekesz méretének kezelése";
            this.tarolasMenu.Click += new System.EventHandler(this.tarolasMenu_Click);
            // 
            // almenu_cim
            // 
            this.almenu_cim.AutoSize = true;
            this.almenu_cim.BackColor = System.Drawing.Color.Transparent;
            this.almenu_cim.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.almenu_cim.ForeColor = System.Drawing.Color.White;
            this.almenu_cim.Location = new System.Drawing.Point(27, 49);
            this.almenu_cim.Name = "almenu_cim";
            this.almenu_cim.Size = new System.Drawing.Size(117, 46);
            this.almenu_cim.TabIndex = 2;
            this.almenu_cim.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ár:";
            // 
            // rekeszMaxLabel
            // 
            this.rekeszMaxLabel.AutoSize = true;
            this.rekeszMaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.rekeszMaxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rekeszMaxLabel.ForeColor = System.Drawing.Color.White;
            this.rekeszMaxLabel.Location = new System.Drawing.Point(27, 335);
            this.rekeszMaxLabel.Name = "rekeszMaxLabel";
            this.rekeszMaxLabel.Size = new System.Drawing.Size(416, 32);
            this.rekeszMaxLabel.TabIndex = 5;
            this.rekeszMaxLabel.Text = "Rekeszenkénti maximális darabszám:";
            // 
            // ujNev
            // 
            this.ujNev.Location = new System.Drawing.Point(200, 217);
            this.ujNev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ujNev.Name = "ujNev";
            this.ujNev.Size = new System.Drawing.Size(321, 27);
            this.ujNev.TabIndex = 6;
            // 
            // ujAr
            // 
            this.ujAr.Location = new System.Drawing.Point(202, 275);
            this.ujAr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ujAr.Name = "ujAr";
            this.ujAr.Size = new System.Drawing.Size(321, 27);
            this.ujAr.TabIndex = 7;
            // 
            // rekeszenkentiMax
            // 
            this.rekeszenkentiMax.Location = new System.Drawing.Point(480, 335);
            this.rekeszenkentiMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rekeszenkentiMax.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rekeszenkentiMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rekeszenkentiMax.Name = "rekeszenkentiMax";
            this.rekeszenkentiMax.Size = new System.Drawing.Size(43, 27);
            this.rekeszenkentiMax.TabIndex = 8;
            this.rekeszenkentiMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hozzaadPanel
            // 
            this.hozzaadPanel.BackColor = System.Drawing.Color.Transparent;
            this.hozzaadPanel.Controls.Add(this.arModositasButton);
            this.hozzaadPanel.Controls.Add(this.hozzaadasButton);
            this.hozzaadPanel.Controls.Add(this.label2);
            this.hozzaadPanel.Controls.Add(this.rekeszenkentiMax);
            this.hozzaadPanel.Controls.Add(this.ujAr);
            this.hozzaadPanel.Controls.Add(this.rekeszMaxLabel);
            this.hozzaadPanel.Controls.Add(this.almenu_cim);
            this.hozzaadPanel.Controls.Add(this.label1);
            this.hozzaadPanel.Controls.Add(this.arucikkekCombobox);
            this.hozzaadPanel.Controls.Add(this.ujNev);
            this.hozzaadPanel.Location = new System.Drawing.Point(158, 171);
            this.hozzaadPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hozzaadPanel.Name = "hozzaadPanel";
            this.hozzaadPanel.Size = new System.Drawing.Size(840, 491);
            this.hozzaadPanel.TabIndex = 9;
            // 
            // arModositasButton
            // 
            this.arModositasButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arModositasButton.Location = new System.Drawing.Point(605, 308);
            this.arModositasButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arModositasButton.Name = "arModositasButton";
            this.arModositasButton.Size = new System.Drawing.Size(157, 47);
            this.arModositasButton.TabIndex = 10;
            this.arModositasButton.Text = "Módosítás";
            this.arModositasButton.UseVisualStyleBackColor = true;
            this.arModositasButton.Click += new System.EventHandler(this.arModositasButton_Click);
            // 
            // hozzaadasButton
            // 
            this.hozzaadasButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hozzaadasButton.Location = new System.Drawing.Point(605, 363);
            this.hozzaadasButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hozzaadasButton.Name = "hozzaadasButton";
            this.hozzaadasButton.Size = new System.Drawing.Size(158, 49);
            this.hozzaadasButton.TabIndex = 9;
            this.hozzaadasButton.Text = "Hozzáadás";
            this.hozzaadasButton.UseVisualStyleBackColor = true;
            this.hozzaadasButton.Click += new System.EventHandler(this.hozzaadasButton_Click);
            // 
            // arucikkekCombobox
            // 
            this.arucikkekCombobox.FormattingEnabled = true;
            this.arucikkekCombobox.Location = new System.Drawing.Point(199, 211);
            this.arucikkekCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arucikkekCombobox.Name = "arucikkekCombobox";
            this.arucikkekCombobox.Size = new System.Drawing.Size(322, 28);
            this.arucikkekCombobox.TabIndex = 11;
            this.arucikkekCombobox.SelectedValueChanged += new System.EventHandler(this.arucikkekComboboxChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(664, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Beérkezett alkatrész felvétele a raktárba:";
            // 
            // beerkezettAlkComboBox
            // 
            this.beerkezettAlkComboBox.FormattingEnabled = true;
            this.beerkezettAlkComboBox.Location = new System.Drawing.Point(225, 135);
            this.beerkezettAlkComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beerkezettAlkComboBox.Name = "beerkezettAlkComboBox";
            this.beerkezettAlkComboBox.Size = new System.Drawing.Size(323, 28);
            this.beerkezettAlkComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alkatrész neve: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mennyiség:";
            // 
            // mennyisegTextBox
            // 
            this.mennyisegTextBox.Location = new System.Drawing.Point(225, 212);
            this.mennyisegTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mennyisegTextBox.Name = "mennyisegTextBox";
            this.mennyisegTextBox.Size = new System.Drawing.Size(110, 27);
            this.mennyisegTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 15;
            // 
            // raktarHozzaadPanel
            // 
            this.raktarHozzaadPanel.BackColor = System.Drawing.Color.Transparent;
            this.raktarHozzaadPanel.Controls.Add(this.raktarHozzaadButton);
            this.raktarHozzaadPanel.Controls.Add(this.label6);
            this.raktarHozzaadPanel.Controls.Add(this.mennyisegTextBox);
            this.raktarHozzaadPanel.Controls.Add(this.label5);
            this.raktarHozzaadPanel.Controls.Add(this.label4);
            this.raktarHozzaadPanel.Controls.Add(this.beerkezettAlkComboBox);
            this.raktarHozzaadPanel.Controls.Add(this.label3);
            this.raktarHozzaadPanel.Location = new System.Drawing.Point(449, 152);
            this.raktarHozzaadPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raktarHozzaadPanel.Name = "raktarHozzaadPanel";
            this.raktarHozzaadPanel.Size = new System.Drawing.Size(675, 352);
            this.raktarHozzaadPanel.TabIndex = 16;
            // 
            // raktarHozzaadButton
            // 
            this.raktarHozzaadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raktarHozzaadButton.Location = new System.Drawing.Point(471, 275);
            this.raktarHozzaadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raktarHozzaadButton.Name = "raktarHozzaadButton";
            this.raktarHozzaadButton.Size = new System.Drawing.Size(160, 48);
            this.raktarHozzaadButton.TabIndex = 16;
            this.raktarHozzaadButton.Text = "Felvesz";
            this.raktarHozzaadButton.UseVisualStyleBackColor = true;
            this.raktarHozzaadButton.Click += new System.EventHandler(this.raktarHozzaadButton_Click);
            // 
            // rekeszPanel
            // 
            this.rekeszPanel.BackColor = System.Drawing.Color.Transparent;
            this.rekeszPanel.Controls.Add(this.rekeszekDataGridView);
            this.rekeszPanel.Controls.Add(this.label7);
            this.rekeszPanel.Controls.Add(this.label10);
            this.rekeszPanel.Location = new System.Drawing.Point(161, 150);
            this.rekeszPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rekeszPanel.Name = "rekeszPanel";
            this.rekeszPanel.Size = new System.Drawing.Size(989, 582);
            this.rekeszPanel.TabIndex = 17;
            // 
            // rekeszekDataGridView
            // 
            this.rekeszekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rekeszekDataGridView.Location = new System.Drawing.Point(29, 159);
            this.rekeszekDataGridView.Name = "rekeszekDataGridView";
            this.rekeszekDataGridView.RowHeadersWidth = 51;
            this.rekeszekDataGridView.RowTemplate.Height = 29;
            this.rekeszekDataGridView.Size = new System.Drawing.Size(931, 353);
            this.rekeszekDataGridView.TabIndex = 16;
            this.rekeszekDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.rekeszekDataGridView_CellValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(29, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(13, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(576, 92);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rekeszben elhelyezhető maximális \r\ndarabszámú alkatrész";
            // 
            // hianyzoAlkatreszekPanel
            // 
            this.hianyzoAlkatreszekPanel.BackColor = System.Drawing.Color.Transparent;
            this.hianyzoAlkatreszekPanel.Controls.Add(this.hianyzoListView);
            this.hianyzoAlkatreszekPanel.Controls.Add(this.label8);
            this.hianyzoAlkatreszekPanel.Controls.Add(this.label9);
            this.hianyzoAlkatreszekPanel.Location = new System.Drawing.Point(205, 156);
            this.hianyzoAlkatreszekPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hianyzoAlkatreszekPanel.Name = "hianyzoAlkatreszekPanel";
            this.hianyzoAlkatreszekPanel.Size = new System.Drawing.Size(989, 582);
            this.hianyzoAlkatreszekPanel.TabIndex = 18;
            // 
            // hianyzoListView
            // 
            this.hianyzoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.p_id,
            this.alk_nev,
            this.hianyzo_db});
            this.hianyzoListView.Location = new System.Drawing.Point(13, 68);
            this.hianyzoListView.Name = "hianyzoListView";
            this.hianyzoListView.Size = new System.Drawing.Size(512, 321);
            this.hianyzoListView.TabIndex = 16;
            this.hianyzoListView.UseCompatibleStateImageBehavior = false;
            this.hianyzoListView.View = System.Windows.Forms.View.Details;
            // 
            // p_id
            // 
            this.p_id.Text = "Projekt_ID";
            this.p_id.Width = 100;
            // 
            // alk_nev
            // 
            this.alk_nev.Text = "Alkatrész megnevezése";
            this.alk_nev.Width = 250;
            // 
            // hianyzo_db
            // 
            this.hianyzo_db.Text = "Hiányző mennyiség";
            this.hianyzo_db.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(29, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 32);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(488, 46);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hiányzó alkatrészek listázása:";
            // 
            // hianyzoLefoglaltPanel
            // 
            this.hianyzoLefoglaltPanel.BackColor = System.Drawing.Color.Transparent;
            this.hianyzoLefoglaltPanel.Controls.Add(this.hianyzoLefoglaltListView);
            this.hianyzoLefoglaltPanel.Controls.Add(this.label11);
            this.hianyzoLefoglaltPanel.Controls.Add(this.label12);
            this.hianyzoLefoglaltPanel.Location = new System.Drawing.Point(213, 164);
            this.hianyzoLefoglaltPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hianyzoLefoglaltPanel.Name = "hianyzoLefoglaltPanel";
            this.hianyzoLefoglaltPanel.Size = new System.Drawing.Size(989, 582);
            this.hianyzoLefoglaltPanel.TabIndex = 19;
            // 
            // hianyzoLefoglaltListView
            // 
            this.hianyzoLefoglaltListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.alk_h_megn,
            this.hiany_H_menny});
            this.hianyzoLefoglaltListView.Location = new System.Drawing.Point(13, 68);
            this.hianyzoLefoglaltListView.Name = "hianyzoLefoglaltListView";
            this.hianyzoLefoglaltListView.Size = new System.Drawing.Size(512, 321);
            this.hianyzoLefoglaltListView.TabIndex = 16;
            this.hianyzoLefoglaltListView.UseCompatibleStateImageBehavior = false;
            this.hianyzoLefoglaltListView.View = System.Windows.Forms.View.Details;
            // 
            // alk_h_megn
            // 
            this.alk_h_megn.Text = "Alkatrész megnevezése";
            this.alk_h_megn.Width = 250;
            // 
            // hiany_H_menny
            // 
            this.hiany_H_menny.Text = "Hiányző mennyiség";
            this.hiany_H_menny.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(29, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(13, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(769, 46);
            this.label12.TabIndex = 10;
            this.label12.Text = "Hiányzó, de már lefoglalt  alkatrészek listázása:";
            // 
            // hiányzóLefoglaltAlkatrészekToolStripMenuItem
            // 
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem.Name = "hiányzóLefoglaltAlkatrészekToolStripMenuItem";
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem.Text = "hiányzó lefoglalt alkatrészek";
            this.hiányzóLefoglaltAlkatrészekToolStripMenuItem.Click += new System.EventHandler(this.hiányzóLefoglaltAlkatrészekToolStripMenuItem_Click);
            // 
            // Raktárvezető
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.buttonLoginRaktarvezeto);
            this.Controls.Add(this.raktarvezetoMenu);
            this.Controls.Add(this.hianyzoAlkatreszekPanel);
            this.Controls.Add(this.rekeszPanel);
            this.Controls.Add(this.raktarHozzaadPanel);
            this.Controls.Add(this.hozzaadPanel);
            this.Controls.Add(this.hianyzoLefoglaltPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.raktarvezetoMenu;
            this.Name = "Raktárvezető";
            this.Text = "Raktárvezető";
            this.Load += new System.EventHandler(this.Raktárvezető_Load);
            this.raktarvezetoMenu.ResumeLayout(false);
            this.raktarvezetoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszenkentiMax)).EndInit();
            this.hozzaadPanel.ResumeLayout(false);
            this.hozzaadPanel.PerformLayout();
            this.raktarHozzaadPanel.ResumeLayout(false);
            this.raktarHozzaadPanel.PerformLayout();
            this.rekeszPanel.ResumeLayout(false);
            this.rekeszPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszekDataGridView)).EndInit();
            this.hianyzoAlkatreszekPanel.ResumeLayout(false);
            this.hianyzoAlkatreszekPanel.PerformLayout();
            this.hianyzoLefoglaltPanel.ResumeLayout(false);
            this.hianyzoLefoglaltPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLoginRaktarvezeto;
        private MenuStrip raktarvezetoMenu;
        private ToolStripMenuItem alkatreszekMenu;
        private ToolStripMenuItem raktarMenu;
        private ToolStripMenuItem hozzaadMenu;
        private ToolStripMenuItem modositMenu;
        private ToolStripMenuItem hianyzikMenu;
        private ToolStripMenuItem beerkezoMenu;
        private ToolStripMenuItem tarolasMenu;
        private Label almenu_cim;
        private Label label1;
        private Label label2;
        private Label rekeszMaxLabel;
        private TextBox ujNev;
        private TextBox ujAr;
        private NumericUpDown rekeszenkentiMax;
        private Panel hozzaadPanel;
        private Button hozzaadasButton;
        private Button arModositasButton;
        private ComboBox arucikkekCombobox;
        private Label label3;
        private ComboBox beerkezettAlkComboBox;
        private Label label4;
        private Label label5;
        private TextBox mennyisegTextBox;
        private Label label6;
        private Panel raktarHozzaadPanel;
        private Button raktarHozzaadButton;
        private Panel rekeszPanel;
        private DataGridView rekeszekDataGridView;
        private Label label7;
        private Label label10;
        private Panel hianyzoAlkatreszekPanel;
        private ListView hianyzoListView;
        private ColumnHeader p_id;
        private ColumnHeader alk_nev;
        private ColumnHeader hianyzo_db;
        private Label label8;
        private Label label9;
        private Panel hianyzoLefoglaltPanel;
        private ListView hianyzoLefoglaltListView;
        private ColumnHeader alk_h_megn;
        private ColumnHeader hiany_H_menny;
        private Label label11;
        private Label label12;
        private ToolStripMenuItem hiányzóLefoglaltAlkatrészekToolStripMenuItem;
    }
}