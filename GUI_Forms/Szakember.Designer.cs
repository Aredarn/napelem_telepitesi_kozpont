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
            this.alkHozzarendelPanel = new System.Windows.Forms.Panel();
            this.projektIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hozzarendelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kivalasztottAlkatreszekTextBox = new System.Windows.Forms.TextBox();
            this.darabszamComboBox = new System.Windows.Forms.ComboBox();
            this.alkatreszComboBox = new System.Windows.Forms.ComboBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.darabszamLabel = new System.Windows.Forms.Label();
            this.alkatreszLabel = new System.Windows.Forms.Label();
            this.hozzarendelLabel = new System.Windows.Forms.Label();
            this.szakemberMenu.SuspendLayout();
            this.alkHozzarendelPanel.SuspendLayout();
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
            this.alkatrészekProjekthezToolStripMenuItem});
            this.szakemberMenu.Location = new System.Drawing.Point(0, 0);
            this.szakemberMenu.Name = "szakemberMenu";
            this.szakemberMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.szakemberMenu.Size = new System.Drawing.Size(103, 895);
            this.szakemberMenu.TabIndex = 1;
            this.szakemberMenu.Text = "menuStrip1";
            // 
            // alkatrészekProjekthezToolStripMenuItem
            // 
            this.alkatrészekProjekthezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekthezRendelésToolStripMenuItem});
            this.alkatrészekProjekthezToolStripMenuItem.Name = "alkatrészekProjekthezToolStripMenuItem";
            this.alkatrészekProjekthezToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.alkatrészekProjekthezToolStripMenuItem.Text = "alkatrészek";
            // 
            // projekthezRendelésToolStripMenuItem
            // 
            this.projekthezRendelésToolStripMenuItem.Name = "projekthezRendelésToolStripMenuItem";
            this.projekthezRendelésToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.projekthezRendelésToolStripMenuItem.Text = "projekthez rendelés";
            this.projekthezRendelésToolStripMenuItem.Click += new System.EventHandler(this.projekthezRendelésToolStripMenuItem_Click);
            // 
            // alkHozzarendelPanel
            // 
            this.alkHozzarendelPanel.BackColor = System.Drawing.Color.Transparent;
            this.alkHozzarendelPanel.Controls.Add(this.projektIDTextBox);
            this.alkHozzarendelPanel.Controls.Add(this.label2);
            this.alkHozzarendelPanel.Controls.Add(this.hozzarendelButton);
            this.alkHozzarendelPanel.Controls.Add(this.label1);
            this.alkHozzarendelPanel.Controls.Add(this.kivalasztottAlkatreszekTextBox);
            this.alkHozzarendelPanel.Controls.Add(this.darabszamComboBox);
            this.alkHozzarendelPanel.Controls.Add(this.alkatreszComboBox);
            this.alkHozzarendelPanel.Controls.Add(this.hozzaadButton);
            this.alkHozzarendelPanel.Controls.Add(this.darabszamLabel);
            this.alkHozzarendelPanel.Controls.Add(this.alkatreszLabel);
            this.alkHozzarendelPanel.Controls.Add(this.hozzarendelLabel);
            this.alkHozzarendelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkHozzarendelPanel.Location = new System.Drawing.Point(157, 146);
            this.alkHozzarendelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alkHozzarendelPanel.Name = "alkHozzarendelPanel";
            this.alkHozzarendelPanel.Size = new System.Drawing.Size(859, 522);
            this.alkHozzarendelPanel.TabIndex = 9;
            // 
            // projektIDTextBox
            // 
            this.projektIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projektIDTextBox.Location = new System.Drawing.Point(355, 430);
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
            this.label2.Location = new System.Drawing.Point(27, 422);
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
            this.hozzarendelButton.Size = new System.Drawing.Size(278, 70);
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
            // kivalasztottAlkatreszekTextBox
            // 
            this.kivalasztottAlkatreszekTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kivalasztottAlkatreszekTextBox.Location = new System.Drawing.Point(542, 146);
            this.kivalasztottAlkatreszekTextBox.Multiline = true;
            this.kivalasztottAlkatreszekTextBox.Name = "kivalasztottAlkatreszekTextBox";
            this.kivalasztottAlkatreszekTextBox.Size = new System.Drawing.Size(278, 171);
            this.kivalasztottAlkatreszekTextBox.TabIndex = 8;
            this.kivalasztottAlkatreszekTextBox.TextChanged += new System.EventHandler(this.kivalasztottAlkatreszekTextBox_TextChanged);
            // 
            // darabszamComboBox
            // 
            this.darabszamComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darabszamComboBox.FormattingEnabled = true;
            this.darabszamComboBox.Location = new System.Drawing.Point(288, 195);
            this.darabszamComboBox.Name = "darabszamComboBox";
            this.darabszamComboBox.Size = new System.Drawing.Size(48, 26);
            this.darabszamComboBox.TabIndex = 7;
            // 
            // alkatreszComboBox
            // 
            this.alkatreszComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alkatreszComboBox.FormattingEnabled = true;
            this.alkatreszComboBox.Location = new System.Drawing.Point(153, 146);
            this.alkatreszComboBox.Name = "alkatreszComboBox";
            this.alkatreszComboBox.Size = new System.Drawing.Size(183, 26);
            this.alkatreszComboBox.TabIndex = 6;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hozzaadButton.Location = new System.Drawing.Point(27, 247);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(164, 70);
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
            // Szakember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.alkHozzarendelPanel);
            this.Controls.Add(this.buttonLoginSzakember);
            this.Controls.Add(this.szakemberMenu);
            this.Name = "Szakember";
            this.Text = "Szakember";
            this.szakemberMenu.ResumeLayout(false);
            this.szakemberMenu.PerformLayout();
            this.alkHozzarendelPanel.ResumeLayout(false);
            this.alkHozzarendelPanel.PerformLayout();
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
        private TextBox kivalasztottAlkatreszekTextBox;
        private ComboBox darabszamComboBox;
        private ComboBox alkatreszComboBox;
        private TextBox projektIDTextBox;
    }
}