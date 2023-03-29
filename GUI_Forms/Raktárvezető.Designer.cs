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
            buttonLoginRaktarvezeto = new Button();
            raktarvezetoMenu = new MenuStrip();
            alkatreszekMenu = new ToolStripMenuItem();
            hozzaadMenu = new ToolStripMenuItem();
            modositMenu = new ToolStripMenuItem();
            hianyzikMenu = new ToolStripMenuItem();
            raktarMenu = new ToolStripMenuItem();
            beerkezoMenu = new ToolStripMenuItem();
            tarolasMenu = new ToolStripMenuItem();
            almenu_cim = new Label();
            label1 = new Label();
            label2 = new Label();
            rekeszMaxLabel = new Label();
            ujNev = new TextBox();
            ujAr = new TextBox();
            rekeszenkentiMax = new NumericUpDown();
            hozzaadPanel = new Panel();
            arModositasButton = new Button();
            hozzaadasButton = new Button();
            arucikkekCombobox = new ComboBox();
            raktarvezetoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rekeszenkentiMax).BeginInit();
            hozzaadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoginRaktarvezeto
            // 
            buttonLoginRaktarvezeto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoginRaktarvezeto.Location = new Point(1003, 589);
            buttonLoginRaktarvezeto.Margin = new Padding(3, 2, 3, 2);
            buttonLoginRaktarvezeto.Name = "buttonLoginRaktarvezeto";
            buttonLoginRaktarvezeto.Size = new Size(190, 56);
            buttonLoginRaktarvezeto.TabIndex = 0;
            buttonLoginRaktarvezeto.Text = "Vissza a Loginhez";
            buttonLoginRaktarvezeto.UseVisualStyleBackColor = true;
            buttonLoginRaktarvezeto.Click += buttonLoginRaktarvezeto_Click;
            // 
            // raktarvezetoMenu
            // 
            raktarvezetoMenu.BackColor = Color.FromArgb(236, 201, 136);
            raktarvezetoMenu.Dock = DockStyle.Left;
            raktarvezetoMenu.ImageScalingSize = new Size(20, 20);
            raktarvezetoMenu.Items.AddRange(new ToolStripItem[] { alkatreszekMenu, raktarMenu });
            raktarvezetoMenu.Location = new Point(0, 0);
            raktarvezetoMenu.Name = "raktarvezetoMenu";
            raktarvezetoMenu.Size = new Size(82, 671);
            raktarvezetoMenu.TabIndex = 1;
            raktarvezetoMenu.Text = "raktarvezetoMenu";
            // 
            // alkatreszekMenu
            // 
            alkatreszekMenu.DropDownItems.AddRange(new ToolStripItem[] { hozzaadMenu, modositMenu, hianyzikMenu });
            alkatreszekMenu.Name = "alkatreszekMenu";
            alkatreszekMenu.Size = new Size(69, 19);
            alkatreszekMenu.Text = "alkatrészek";
            // 
            // hozzaadMenu
            // 
            hozzaadMenu.Name = "hozzaadMenu";
            hozzaadMenu.Size = new Size(129, 22);
            hozzaadMenu.Text = "hozzáadás";
            hozzaadMenu.Click += hozzaadMenu_Click;
            // 
            // modositMenu
            // 
            modositMenu.Name = "modositMenu";
            modositMenu.Size = new Size(129, 22);
            modositMenu.Text = "módosítás";
            modositMenu.Click += modositMenu_Click;
            // 
            // hianyzikMenu
            // 
            hianyzikMenu.Name = "hianyzikMenu";
            hianyzikMenu.Size = new Size(129, 22);
            hianyzikMenu.Text = "hiányzik";
            // 
            // raktarMenu
            // 
            raktarMenu.DropDownItems.AddRange(new ToolStripItem[] { beerkezoMenu, tarolasMenu });
            raktarMenu.Name = "raktarMenu";
            raktarMenu.Size = new Size(69, 19);
            raktarMenu.Text = "raktár";
            // 
            // beerkezoMenu
            // 
            beerkezoMenu.Name = "beerkezoMenu";
            beerkezoMenu.Size = new Size(181, 22);
            beerkezoMenu.Text = "beérkező alkatrészek";
            // 
            // tarolasMenu
            // 
            tarolasMenu.Name = "tarolasMenu";
            tarolasMenu.Size = new Size(181, 22);
            tarolasMenu.Text = "tárolás";
            // 
            // almenu_cim
            // 
            almenu_cim.AutoSize = true;
            almenu_cim.BackColor = Color.Transparent;
            almenu_cim.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            almenu_cim.ForeColor = Color.White;
            almenu_cim.Location = new Point(24, 37);
            almenu_cim.Name = "almenu_cim";
            almenu_cim.Size = new Size(96, 37);
            almenu_cim.TabIndex = 2;
            almenu_cim.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 158);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 206);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 4;
            label2.Text = "Ár:";
            // 
            // rekeszMaxLabel
            // 
            rekeszMaxLabel.AutoSize = true;
            rekeszMaxLabel.BackColor = Color.Transparent;
            rekeszMaxLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rekeszMaxLabel.ForeColor = Color.White;
            rekeszMaxLabel.Location = new Point(24, 251);
            rekeszMaxLabel.Name = "rekeszMaxLabel";
            rekeszMaxLabel.Size = new Size(329, 25);
            rekeszMaxLabel.TabIndex = 5;
            rekeszMaxLabel.Text = "Rekeszenkénti maximális darabszám:";
            // 
            // ujNev
            // 
            ujNev.Location = new Point(175, 163);
            ujNev.Name = "ujNev";
            ujNev.Size = new Size(281, 23);
            ujNev.TabIndex = 6;
            // 
            // ujAr
            // 
            ujAr.Location = new Point(177, 206);
            ujAr.Name = "ujAr";
            ujAr.Size = new Size(281, 23);
            ujAr.TabIndex = 7;
            // 
            // rekeszenkentiMax
            // 
            rekeszenkentiMax.Location = new Point(420, 251);
            rekeszenkentiMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            rekeszenkentiMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rekeszenkentiMax.Name = "rekeszenkentiMax";
            rekeszenkentiMax.Size = new Size(38, 23);
            rekeszenkentiMax.TabIndex = 8;
            rekeszenkentiMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // hozzaadPanel
            // 
            hozzaadPanel.BackColor = Color.Transparent;
            hozzaadPanel.Controls.Add(arModositasButton);
            hozzaadPanel.Controls.Add(hozzaadasButton);
            hozzaadPanel.Controls.Add(label2);
            hozzaadPanel.Controls.Add(rekeszenkentiMax);
            hozzaadPanel.Controls.Add(ujAr);
            hozzaadPanel.Controls.Add(rekeszMaxLabel);
            hozzaadPanel.Controls.Add(ujNev);
            hozzaadPanel.Controls.Add(almenu_cim);
            hozzaadPanel.Controls.Add(label1);
            hozzaadPanel.Controls.Add(arucikkekCombobox);
            hozzaadPanel.Location = new Point(139, 171);
            hozzaadPanel.Name = "hozzaadPanel";
            hozzaadPanel.Size = new Size(670, 312);
            hozzaadPanel.TabIndex = 9;
            // 
            // arModositasButton
            // 
            arModositasButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            arModositasButton.Location = new Point(529, 231);
            arModositasButton.Name = "arModositasButton";
            arModositasButton.Size = new Size(137, 35);
            arModositasButton.TabIndex = 10;
            arModositasButton.Text = "Módosítás";
            arModositasButton.UseVisualStyleBackColor = true;
            arModositasButton.Click += arModositasButton_Click;
            // 
            // hozzaadasButton
            // 
            hozzaadasButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hozzaadasButton.Location = new Point(529, 272);
            hozzaadasButton.Name = "hozzaadasButton";
            hozzaadasButton.Size = new Size(138, 37);
            hozzaadasButton.TabIndex = 9;
            hozzaadasButton.Text = "Hozzáadás";
            hozzaadasButton.UseVisualStyleBackColor = true;
            hozzaadasButton.Click += hozzaadasButton_Click;
            // 
            // arucikkekCombobox
            // 
            arucikkekCombobox.FormattingEnabled = true;
            arucikkekCombobox.Location = new Point(174, 158);
            arucikkekCombobox.Name = "arucikkekCombobox";
            arucikkekCombobox.Size = new Size(282, 23);
            arucikkekCombobox.TabIndex = 11;
            arucikkekCombobox.SelectedIndexChanged += arucikkekComboboxChanged;
            // 
            // Raktárvezető
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1224, 671);
            Controls.Add(hozzaadPanel);
            Controls.Add(buttonLoginRaktarvezeto);
            Controls.Add(raktarvezetoMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = raktarvezetoMenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Raktárvezető";
            Text = "Raktárvezető";
            raktarvezetoMenu.ResumeLayout(false);
            raktarvezetoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rekeszenkentiMax).EndInit();
            hozzaadPanel.ResumeLayout(false);
            hozzaadPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}