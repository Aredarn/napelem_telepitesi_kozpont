﻿namespace napelem_telepito_kozpont.GUI_Forms
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
            this.label3 = new System.Windows.Forms.Label();
            this.ujNev = new System.Windows.Forms.TextBox();
            this.ujAr = new System.Windows.Forms.TextBox();
            this.rekeszenkentiMax = new System.Windows.Forms.NumericUpDown();
            this.hozzaadPanel = new System.Windows.Forms.Panel();
            this.hozzaadasButton = new System.Windows.Forms.Button();
            this.raktarvezetoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszenkentiMax)).BeginInit();
            this.hozzaadPanel.SuspendLayout();
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
            this.buttonLoginRaktarvezeto.Click += new System.EventHandler(this.buttonLoginRaktarvezeto_Click);
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
            this.raktarvezetoMenu.Size = new System.Drawing.Size(103, 895);
            this.raktarvezetoMenu.TabIndex = 1;
            this.raktarvezetoMenu.Text = "raktarvezetoMenu";
            // 
            // alkatreszekMenu
            // 
            this.alkatreszekMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hozzaadMenu,
            this.modositMenu,
            this.hianyzikMenu});
            this.alkatreszekMenu.Name = "alkatreszekMenu";
            this.alkatreszekMenu.Size = new System.Drawing.Size(88, 24);
            this.alkatreszekMenu.Text = "alkatrészek";
            // 
            // hozzaadMenu
            // 
            this.hozzaadMenu.Name = "hozzaadMenu";
            this.hozzaadMenu.Size = new System.Drawing.Size(162, 26);
            this.hozzaadMenu.Text = "hozzáadás";
            this.hozzaadMenu.Click += new System.EventHandler(this.hozzaadMenu_Click);
            // 
            // modositMenu
            // 
            this.modositMenu.Name = "modositMenu";
            this.modositMenu.Size = new System.Drawing.Size(162, 26);
            this.modositMenu.Text = "módosítás";
            // 
            // hianyzikMenu
            // 
            this.hianyzikMenu.Name = "hianyzikMenu";
            this.hianyzikMenu.Size = new System.Drawing.Size(162, 26);
            this.hianyzikMenu.Text = "hiányzik";
            // 
            // raktarMenu
            // 
            this.raktarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beerkezoMenu,
            this.tarolasMenu});
            this.raktarMenu.Name = "raktarMenu";
            this.raktarMenu.Size = new System.Drawing.Size(88, 24);
            this.raktarMenu.Text = "raktár";
            // 
            // beerkezoMenu
            // 
            this.beerkezoMenu.Name = "beerkezoMenu";
            this.beerkezoMenu.Size = new System.Drawing.Size(230, 26);
            this.beerkezoMenu.Text = "beérkező alkatrészek";
            // 
            // tarolasMenu
            // 
            this.tarolasMenu.Name = "tarolasMenu";
            this.tarolasMenu.Size = new System.Drawing.Size(230, 26);
            this.tarolasMenu.Text = "tárolás";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rekeszenkénti maximális darabszám:";
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
            this.hozzaadPanel.Controls.Add(this.hozzaadasButton);
            this.hozzaadPanel.Controls.Add(this.label2);
            this.hozzaadPanel.Controls.Add(this.rekeszenkentiMax);
            this.hozzaadPanel.Controls.Add(this.ujAr);
            this.hozzaadPanel.Controls.Add(this.label3);
            this.hozzaadPanel.Controls.Add(this.ujNev);
            this.hozzaadPanel.Controls.Add(this.almenu_cim);
            this.hozzaadPanel.Controls.Add(this.label1);
            this.hozzaadPanel.Location = new System.Drawing.Point(159, 228);
            this.hozzaadPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hozzaadPanel.Name = "hozzaadPanel";
            this.hozzaadPanel.Size = new System.Drawing.Size(766, 416);
            this.hozzaadPanel.TabIndex = 9;
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
            // Raktárvezető
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.hozzaadPanel);
            this.Controls.Add(this.buttonLoginRaktarvezeto);
            this.Controls.Add(this.raktarvezetoMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.raktarvezetoMenu;
            this.Name = "Raktárvezető";
            this.Text = "Raktárvezető";
            this.raktarvezetoMenu.ResumeLayout(false);
            this.raktarvezetoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekeszenkentiMax)).EndInit();
            this.hozzaadPanel.ResumeLayout(false);
            this.hozzaadPanel.PerformLayout();
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
        private Label label3;
        private TextBox ujNev;
        private TextBox ujAr;
        private NumericUpDown rekeszenkentiMax;
        private Panel hozzaadPanel;
        private Button hozzaadasButton;
    }
}