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
            this.raktarosMenu.SuspendLayout();
            this.projektListaPanel.SuspendLayout();
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
            this.raktarosMenu.Size = new System.Drawing.Size(156, 895);
            this.raktarosMenu.TabIndex = 1;
            this.raktarosMenu.Text = "menuStrip1";
            // 
            // projektekToolStripMenuItem
            // 
            this.projektekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektekListázásaToolStripMenuItem});
            this.projektekToolStripMenuItem.Name = "projektekToolStripMenuItem";
            this.projektekToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.projektekToolStripMenuItem.Text = "projektek";
            // 
            // projektekListázásaToolStripMenuItem
            // 
            this.projektekListázásaToolStripMenuItem.Name = "projektekListázásaToolStripMenuItem";
            this.projektekListázásaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.projektekListázásaToolStripMenuItem.Text = "projektek listázása";
            this.projektekListázásaToolStripMenuItem.Click += new System.EventHandler(this.projektekListázásaToolStripMenuItem_Click);
            // 
            // alkatrészekToolStripMenuItem
            // 
            this.alkatrészekToolStripMenuItem.Name = "alkatrészekToolStripMenuItem";
            this.alkatrészekToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.alkatrészekToolStripMenuItem.Text = "alkatrészek";
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
            // Raktaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
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
    }
}