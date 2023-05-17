namespace napelem_telepito_kozpont.GUI_Forms
{
    partial class Raktaros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raktaros));
            this.buttonLoginRaktaros = new System.Windows.Forms.Button();
            this.raktarosMenu = new System.Windows.Forms.MenuStrip();
            this.projektekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektekListázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkatrészekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.útvonalOptimalizálásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektListaPanel = new System.Windows.Forms.Panel();
            this.kivitelezesButton = new System.Windows.Forms.Button();
            this.projektIDCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projektListaListView = new System.Windows.Forms.ListView();
            this.projekt_id = new System.Windows.Forms.ColumnHeader();
            this.befejezes = new System.Windows.Forms.ColumnHeader();
            this.varhato_ar = new System.Windows.Forms.ColumnHeader();
            this.helyszin = new System.Windows.Forms.ColumnHeader();
            this.leiras = new System.Windows.Forms.ColumnHeader();
            this.statusz = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.projektAlkatreszPanel = new System.Windows.Forms.Panel();
            this.projektAlkatreszListView = new System.Windows.Forms.ListView();
            this.projIDalk = new System.Windows.Forms.ColumnHeader();
            this.helye = new System.Windows.Forms.ColumnHeader();
            this.projektIDAlkatreszComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.utvonalPanel = new System.Windows.Forms.Panel();
            this.utvonalListView = new System.Windows.Forms.ListView();
            this.sorrend = new System.Windows.Forms.ColumnHeader();
            this.alkHely = new System.Windows.Forms.ColumnHeader();
            this.alkMegn = new System.Windows.Forms.ColumnHeader();
            this.projektIDUtvonalComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.raktarosMenu.SuspendLayout();
            this.projektListaPanel.SuspendLayout();
            this.projektAlkatreszPanel.SuspendLayout();
            this.utvonalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginRaktaros
            // 
            this.buttonLoginRaktaros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoginRaktaros.Location = new System.Drawing.Point(1146, 785);
            this.buttonLoginRaktaros.Name = "buttonLoginRaktaros";
            this.buttonLoginRaktaros.Size = new System.Drawing.Size(217, 75);
            this.buttonLoginRaktaros.TabIndex = 0;
            this.buttonLoginRaktaros.Text = "Vissza a Loginhez";
            this.buttonLoginRaktaros.UseVisualStyleBackColor = true;
            this.buttonLoginRaktaros.Click += new System.EventHandler(this.buttonLoginRaktaros_Click);
            // 
            // raktarosMenu
            // 
            this.raktarosMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.raktarosMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.raktarosMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.raktarosMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektekToolStripMenuItem,
            this.alkatrészekToolStripMenuItem});
            this.raktarosMenu.Location = new System.Drawing.Point(0, 0);
            this.raktarosMenu.Name = "raktarosMenu";
            this.raktarosMenu.Size = new System.Drawing.Size(102, 895);
            this.raktarosMenu.TabIndex = 1;
            this.raktarosMenu.Text = "menuStrip1";
            // 
            // projektekToolStripMenuItem
            // 
            this.projektekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektekListázásaToolStripMenuItem});
            this.projektekToolStripMenuItem.Name = "projektekToolStripMenuItem";
            this.projektekToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.projektekToolStripMenuItem.Text = "projektek";
            // 
            // projektekListázásaToolStripMenuItem
            // 
            this.projektekListázásaToolStripMenuItem.Name = "projektekListázásaToolStripMenuItem";
            this.projektekListázásaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.projektekListázásaToolStripMenuItem.Text = "projektek listázása";
            this.projektekListázásaToolStripMenuItem.Click += new System.EventHandler(this.projektekListázásaToolStripMenuItem_Click);
            // 
            // alkatrészekToolStripMenuItem
            // 
            this.alkatrészekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem,
            this.útvonalOptimalizálásaToolStripMenuItem});
            this.alkatrészekToolStripMenuItem.Name = "alkatrészekToolStripMenuItem";
            this.alkatrészekToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.alkatrészekToolStripMenuItem.Text = "alkatrészek";
            // 
            // projekthezTartozóAlkatrészekListázásaToolStripMenuItem
            // 
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Name = "projekthezTartozóAlkatrészekListázásaToolStripMenuItem";
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Text = "projekthez tartozó alkatrészek listázása";
            this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Click += new System.EventHandler(this.projekthezTartozóAlkatrészekListázásaToolStripMenuItem_Click);
            // 
            // útvonalOptimalizálásaToolStripMenuItem
            // 
            this.útvonalOptimalizálásaToolStripMenuItem.Name = "útvonalOptimalizálásaToolStripMenuItem";
            this.útvonalOptimalizálásaToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.útvonalOptimalizálásaToolStripMenuItem.Text = "útvonal optimalizálása";
            this.útvonalOptimalizálásaToolStripMenuItem.Click += new System.EventHandler(this.útvonalOptimalizálásaToolStripMenuItem_Click);
            // 
            // projektListaPanel
            // 
            this.projektListaPanel.BackColor = System.Drawing.Color.Transparent;
            this.projektListaPanel.Controls.Add(this.kivitelezesButton);
            this.projektListaPanel.Controls.Add(this.projektIDCombobox);
            this.projektListaPanel.Controls.Add(this.label2);
            this.projektListaPanel.Controls.Add(this.projektListaListView);
            this.projektListaPanel.Controls.Add(this.label1);
            this.projektListaPanel.Location = new System.Drawing.Point(167, 219);
            this.projektListaPanel.Name = "projektListaPanel";
            this.projektListaPanel.Size = new System.Drawing.Size(1116, 527);
            this.projektListaPanel.TabIndex = 2;
            // 
            // kivitelezesButton
            // 
            this.kivitelezesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kivitelezesButton.Location = new System.Drawing.Point(462, 391);
            this.kivitelezesButton.Name = "kivitelezesButton";
            this.kivitelezesButton.Size = new System.Drawing.Size(123, 40);
            this.kivitelezesButton.TabIndex = 4;
            this.kivitelezesButton.Text = "Kivitelezés";
            this.kivitelezesButton.UseVisualStyleBackColor = true;
            // 
            // projektIDCombobox
            // 
            this.projektIDCombobox.FormattingEnabled = true;
            this.projektIDCombobox.Location = new System.Drawing.Point(351, 400);
            this.projektIDCombobox.Name = "projektIDCombobox";
            this.projektIDCombobox.Size = new System.Drawing.Size(76, 28);
            this.projektIDCombobox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Projektek kivitelezése:";
            // 
            // projektListaListView
            // 
            this.projektListaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projekt_id,
            this.befejezes,
            this.varhato_ar,
            this.helyszin,
            this.leiras,
            this.statusz});
            this.projektListaListView.Location = new System.Drawing.Point(47, 99);
            this.projektListaListView.Name = "projektListaListView";
            this.projektListaListView.Size = new System.Drawing.Size(914, 266);
            this.projektListaListView.TabIndex = 1;
            this.projektListaListView.UseCompatibleStateImageBehavior = false;
            this.projektListaListView.View = System.Windows.Forms.View.Details;
            // 
            // projekt_id
            // 
            this.projekt_id.Text = "Projekt ID";
            this.projekt_id.Width = 100;
            // 
            // befejezes
            // 
            this.befejezes.Text = "Várható befejezés";
            this.befejezes.Width = 150;
            // 
            // varhato_ar
            // 
            this.varhato_ar.Text = "Ár";
            this.varhato_ar.Width = 100;
            // 
            // helyszin
            // 
            this.helyszin.Text = "Helyszín";
            this.helyszin.Width = 150;
            // 
            // leiras
            // 
            this.leiras.Text = "Leírás";
            this.leiras.Width = 250;
            // 
            // statusz
            // 
            this.statusz.Text = "Státusz";
            this.statusz.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projektek listázása:";
            // 
            // projektAlkatreszPanel
            // 
            this.projektAlkatreszPanel.BackColor = System.Drawing.Color.Transparent;
            this.projektAlkatreszPanel.Controls.Add(this.projektAlkatreszListView);
            this.projektAlkatreszPanel.Controls.Add(this.projektIDAlkatreszComboBox);
            this.projektAlkatreszPanel.Controls.Add(this.label3);
            this.projektAlkatreszPanel.Controls.Add(this.label4);
            this.projektAlkatreszPanel.Location = new System.Drawing.Point(184, 179);
            this.projektAlkatreszPanel.Name = "projektAlkatreszPanel";
            this.projektAlkatreszPanel.Size = new System.Drawing.Size(1116, 527);
            this.projektAlkatreszPanel.TabIndex = 3;
            // 
            // projektAlkatreszListView
            // 
            this.projektAlkatreszListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projIDalk,
            this.helye});
            this.projektAlkatreszListView.Location = new System.Drawing.Point(47, 158);
            this.projektAlkatreszListView.Name = "projektAlkatreszListView";
            this.projektAlkatreszListView.Size = new System.Drawing.Size(365, 242);
            this.projektAlkatreszListView.TabIndex = 4;
            this.projektAlkatreszListView.UseCompatibleStateImageBehavior = false;
            this.projektAlkatreszListView.View = System.Windows.Forms.View.Details;
            // 
            // projIDalk
            // 
            this.projIDalk.Text = "ProjektID";
            this.projIDalk.Width = 100;
            // 
            // helye
            // 
            this.helye.Text = "Alkatrész helye:";
            this.helye.Width = 250;
            // 
            // projektIDAlkatreszComboBox
            // 
            this.projektIDAlkatreszComboBox.FormattingEnabled = true;
            this.projektIDAlkatreszComboBox.Location = new System.Drawing.Point(336, 100);
            this.projektIDAlkatreszComboBox.Name = "projektIDAlkatreszComboBox";
            this.projektIDAlkatreszComboBox.Size = new System.Drawing.Size(76, 28);
            this.projektIDAlkatreszComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Projekt kiválasztása:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(654, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Projekthez tartozó alkatrészek listázása:";
            // 
            // utvonalPanel
            // 
            this.utvonalPanel.BackColor = System.Drawing.Color.Transparent;
            this.utvonalPanel.Controls.Add(this.utvonalListView);
            this.utvonalPanel.Controls.Add(this.projektIDUtvonalComboBox);
            this.utvonalPanel.Controls.Add(this.label5);
            this.utvonalPanel.Controls.Add(this.label6);
            this.utvonalPanel.Location = new System.Drawing.Point(149, 165);
            this.utvonalPanel.Name = "utvonalPanel";
            this.utvonalPanel.Size = new System.Drawing.Size(1116, 527);
            this.utvonalPanel.TabIndex = 4;
            // 
            // utvonalListView
            // 
            this.utvonalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sorrend,
            this.alkHely,
            this.alkMegn});
            this.utvonalListView.Location = new System.Drawing.Point(47, 158);
            this.utvonalListView.Name = "utvonalListView";
            this.utvonalListView.Size = new System.Drawing.Size(607, 242);
            this.utvonalListView.TabIndex = 4;
            this.utvonalListView.UseCompatibleStateImageBehavior = false;
            this.utvonalListView.View = System.Windows.Forms.View.Details;
            // 
            // sorrend
            // 
            this.sorrend.Text = "Sorrend";
            this.sorrend.Width = 100;
            // 
            // alkHely
            // 
            this.alkHely.Text = "Alkatrész helye:";
            this.alkHely.Width = 250;
            // 
            // alkMegn
            // 
            this.alkMegn.Text = "Alkatrész neve:";
            this.alkMegn.Width = 250;
            // 
            // projektIDUtvonalComboBox
            // 
            this.projektIDUtvonalComboBox.Location = new System.Drawing.Point(336, 100);
            this.projektIDUtvonalComboBox.Name = "projektIDUtvonalComboBox";
            this.projektIDUtvonalComboBox.Size = new System.Drawing.Size(76, 28);
            this.projektIDUtvonalComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Projekt kiválasztása:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "Útvonal optimalizálása:";
            // 
            // Raktaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.utvonalPanel);
            this.Controls.Add(this.projektAlkatreszPanel);
            this.Controls.Add(this.projektListaPanel);
            this.Controls.Add(this.buttonLoginRaktaros);
            this.Controls.Add(this.raktarosMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.raktarosMenu;
            this.Name = "Raktaros";
            this.Text = "Raktaros";
            this.raktarosMenu.ResumeLayout(false);
            this.raktarosMenu.PerformLayout();
            this.projektListaPanel.ResumeLayout(false);
            this.projektListaPanel.PerformLayout();
            this.projektAlkatreszPanel.ResumeLayout(false);
            this.projektAlkatreszPanel.PerformLayout();
            this.utvonalPanel.ResumeLayout(false);
            this.utvonalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLoginRaktaros;
        private MenuStrip raktarosMenu;
        private ToolStripMenuItem projektekToolStripMenuItem;
        private ToolStripMenuItem projektekListázásaToolStripMenuItem;
        private ToolStripMenuItem alkatrészekToolStripMenuItem;
        private Panel projektListaPanel;
        private Label label1;
        private ListView projektListaListView;
        private ColumnHeader projekt_id;
        private ColumnHeader befejezes;
        private ColumnHeader varhato_ar;
        private ColumnHeader helyszin;
        private ColumnHeader leiras;
        private ColumnHeader statusz;
        private Button kivitelezesButton;
        private ComboBox projektIDCombobox;
        private Label label2;
        private Panel projektAlkatreszPanel;
        private ComboBox projektIDAlkatreszComboBox;
        private Label label3;
        private Label label4;
        private ListView projektAlkatreszListView;
        private ColumnHeader projIDalk;
        private ColumnHeader helye;
        private ToolStripMenuItem projekthezTartozóAlkatrészekListázásaToolStripMenuItem;
        private ToolStripMenuItem útvonalOptimalizálásaToolStripMenuItem;
        private Panel utvonalPanel;
        private ListView utvonalListView;
        private ColumnHeader sorrend;
        private ColumnHeader alkHely;
        private ColumnHeader alkMegn;
        private ComboBox projektIDUtvonalComboBox;
        private Label label5;
        private Label label6;
    }
}