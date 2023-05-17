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
            buttonLoginRaktaros = new Button();
            raktarosMenu = new MenuStrip();
            projektekToolStripMenuItem = new ToolStripMenuItem();
            projektekListázásaToolStripMenuItem = new ToolStripMenuItem();
            alkatrészekToolStripMenuItem = new ToolStripMenuItem();
            projekthezTartozóAlkatrészekListázásaToolStripMenuItem = new ToolStripMenuItem();
            útvonalOptimalizálásaToolStripMenuItem = new ToolStripMenuItem();
            projektListaPanel = new Panel();
            kivitelezesButton = new Button();
            projektIDCombobox = new ComboBox();
            label2 = new Label();
            projektListaListView = new ListView();
            projekt_id = new ColumnHeader();
            befejezes = new ColumnHeader();
            varhato_ar = new ColumnHeader();
            helyszin = new ColumnHeader();
            leiras = new ColumnHeader();
            statusz = new ColumnHeader();
            label1 = new Label();
            projektAlkatreszPanel = new Panel();
            projektAlkatreszListView = new ListView();
            ID = new ColumnHeader();
            Neve = new ColumnHeader();
            Darabszám = new ColumnHeader();
            Sor = new ColumnHeader();
            Oszlop = new ColumnHeader();
            Szint = new ColumnHeader();
            projektIDAlkatreszComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            utvonalPanel = new Panel();
            utvonalListView = new ListView();
            sorrend = new ColumnHeader();
            alkHely = new ColumnHeader();
            alkMegn = new ColumnHeader();
            projektIDUtvonalComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            raktarosMenu.SuspendLayout();
            projektListaPanel.SuspendLayout();
            projektAlkatreszPanel.SuspendLayout();
            utvonalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoginRaktaros
            // 
            buttonLoginRaktaros.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoginRaktaros.Location = new Point(1003, 589);
            buttonLoginRaktaros.Margin = new Padding(3, 2, 3, 2);
            buttonLoginRaktaros.Name = "buttonLoginRaktaros";
            buttonLoginRaktaros.Size = new Size(190, 56);
            buttonLoginRaktaros.TabIndex = 0;
            buttonLoginRaktaros.Text = "Vissza a Loginhez";
            buttonLoginRaktaros.UseVisualStyleBackColor = true;
            buttonLoginRaktaros.Click += buttonLoginRaktaros_Click;
            // 
            // raktarosMenu
            // 
            raktarosMenu.BackColor = Color.FromArgb(236, 201, 136);
            raktarosMenu.Dock = DockStyle.Left;
            raktarosMenu.ImageScalingSize = new Size(20, 20);
            raktarosMenu.Items.AddRange(new ToolStripItem[] { projektekToolStripMenuItem, alkatrészekToolStripMenuItem });
            raktarosMenu.Location = new Point(0, 0);
            raktarosMenu.Name = "raktarosMenu";
            raktarosMenu.Padding = new Padding(5, 2, 0, 2);
            raktarosMenu.Size = new Size(81, 671);
            raktarosMenu.TabIndex = 1;
            raktarosMenu.Text = "menuStrip1";
            // 
            // projektekToolStripMenuItem
            // 
            projektekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projektekListázásaToolStripMenuItem });
            projektekToolStripMenuItem.Name = "projektekToolStripMenuItem";
            projektekToolStripMenuItem.Size = new Size(70, 19);
            projektekToolStripMenuItem.Text = "projektek";
            // 
            // projektekListázásaToolStripMenuItem
            // 
            projektekListázásaToolStripMenuItem.Name = "projektekListázásaToolStripMenuItem";
            projektekListázásaToolStripMenuItem.Size = new Size(169, 22);
            projektekListázásaToolStripMenuItem.Text = "projektek listázása";
            projektekListázásaToolStripMenuItem.Click += projektekListázásaToolStripMenuItem_Click;
            // 
            // alkatrészekToolStripMenuItem
            // 
            alkatrészekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projekthezTartozóAlkatrészekListázásaToolStripMenuItem, útvonalOptimalizálásaToolStripMenuItem });
            alkatrészekToolStripMenuItem.Name = "alkatrészekToolStripMenuItem";
            alkatrészekToolStripMenuItem.Size = new Size(70, 19);
            alkatrészekToolStripMenuItem.Text = "alkatrészek";
            // 
            // projekthezTartozóAlkatrészekListázásaToolStripMenuItem
            // 
            projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Name = "projekthezTartozóAlkatrészekListázásaToolStripMenuItem";
            projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Size = new Size(275, 22);
            projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Text = "projekthez tartozó alkatrészek listázása";
            projekthezTartozóAlkatrészekListázásaToolStripMenuItem.Click += projekthezTartozóAlkatrészekListázásaToolStripMenuItem_Click;
            // 
            // útvonalOptimalizálásaToolStripMenuItem
            // 
            útvonalOptimalizálásaToolStripMenuItem.Name = "útvonalOptimalizálásaToolStripMenuItem";
            útvonalOptimalizálásaToolStripMenuItem.Size = new Size(275, 22);
            útvonalOptimalizálásaToolStripMenuItem.Text = "útvonal optimalizálása";
            útvonalOptimalizálásaToolStripMenuItem.Click += útvonalOptimalizálásaToolStripMenuItem_Click;
            // 
            // projektListaPanel
            // 
            projektListaPanel.BackColor = Color.Transparent;
            projektListaPanel.Controls.Add(kivitelezesButton);
            projektListaPanel.Controls.Add(projektIDCombobox);
            projektListaPanel.Controls.Add(label2);
            projektListaPanel.Controls.Add(projektListaListView);
            projektListaPanel.Controls.Add(label1);
            projektListaPanel.Location = new Point(146, 164);
            projektListaPanel.Margin = new Padding(3, 2, 3, 2);
            projektListaPanel.Name = "projektListaPanel";
            projektListaPanel.Size = new Size(976, 395);
            projektListaPanel.TabIndex = 2;
            // 
            // kivitelezesButton
            // 
            kivitelezesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kivitelezesButton.Location = new Point(404, 293);
            kivitelezesButton.Margin = new Padding(3, 2, 3, 2);
            kivitelezesButton.Name = "kivitelezesButton";
            kivitelezesButton.Size = new Size(108, 30);
            kivitelezesButton.TabIndex = 4;
            kivitelezesButton.Text = "Kivitelezés";
            kivitelezesButton.UseVisualStyleBackColor = true;
            kivitelezesButton.Click += kivitelezesButton_Click;
            // 
            // projektIDCombobox
            // 
            projektIDCombobox.FormattingEnabled = true;
            projektIDCombobox.Location = new Point(307, 300);
            projektIDCombobox.Margin = new Padding(3, 2, 3, 2);
            projektIDCombobox.Name = "projektIDCombobox";
            projektIDCombobox.Size = new Size(67, 23);
            projektIDCombobox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 292);
            label2.Name = "label2";
            label2.Size = new Size(244, 30);
            label2.TabIndex = 2;
            label2.Text = "Projektek kivitelezése:";
            // 
            // projektListaListView
            // 
            projektListaListView.Columns.AddRange(new ColumnHeader[] { projekt_id, befejezes, varhato_ar, helyszin, leiras, statusz });
            projektListaListView.Location = new Point(41, 74);
            projektListaListView.Margin = new Padding(3, 2, 3, 2);
            projektListaListView.Name = "projektListaListView";
            projektListaListView.Size = new Size(800, 200);
            projektListaListView.TabIndex = 1;
            projektListaListView.UseCompatibleStateImageBehavior = false;
            projektListaListView.View = View.Details;
            // 
            // projekt_id
            // 
            projekt_id.Text = "Projekt ID";
            projekt_id.Width = 100;
            // 
            // befejezes
            // 
            befejezes.Text = "Várható befejezés";
            befejezes.Width = 150;
            // 
            // varhato_ar
            // 
            varhato_ar.Text = "Ár";
            varhato_ar.Width = 100;
            // 
            // helyszin
            // 
            helyszin.Text = "Helyszín";
            helyszin.Width = 150;
            // 
            // leiras
            // 
            leiras.Text = "Leírás";
            leiras.Width = 250;
            // 
            // statusz
            // 
            statusz.Text = "Státusz";
            statusz.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 0;
            label1.Text = "Projektek listázása:";
            // 
            // projektAlkatreszPanel
            // 
            projektAlkatreszPanel.BackColor = Color.Transparent;
            projektAlkatreszPanel.Controls.Add(projektAlkatreszListView);
            projektAlkatreszPanel.Controls.Add(projektIDAlkatreszComboBox);
            projektAlkatreszPanel.Controls.Add(label3);
            projektAlkatreszPanel.Controls.Add(label4);
            projektAlkatreszPanel.Location = new Point(161, 134);
            projektAlkatreszPanel.Margin = new Padding(3, 2, 3, 2);
            projektAlkatreszPanel.Name = "projektAlkatreszPanel";
            projektAlkatreszPanel.Size = new Size(976, 395);
            projektAlkatreszPanel.TabIndex = 3;
            projektAlkatreszPanel.VisibleChanged += projektAlkatreszPanel_VisibleChanged;
            // 
            // projektAlkatreszListView
            // 
            projektAlkatreszListView.Columns.AddRange(new ColumnHeader[] { ID, Neve, Darabszám, Sor, Oszlop, Szint });
            projektAlkatreszListView.Location = new Point(41, 118);
            projektAlkatreszListView.Margin = new Padding(3, 2, 3, 2);
            projektAlkatreszListView.Name = "projektAlkatreszListView";
            projektAlkatreszListView.Size = new Size(363, 182);
            projektAlkatreszListView.TabIndex = 4;
            projektAlkatreszListView.UseCompatibleStateImageBehavior = false;
            projektAlkatreszListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Neve
            // 
            Neve.Text = "Neve";
            // 
            // Darabszám
            // 
            Darabszám.Text = "Darabszám";
            // 
            // Sor
            // 
            Sor.Text = "Sor";
            // 
            // Oszlop
            // 
            Oszlop.Text = "Oszlop";
            Oszlop.TextAlign = HorizontalAlignment.Right;
            // 
            // Szint
            // 
            Szint.Text = "Szint";
            // 
            // projektIDAlkatreszComboBox
            // 
            projektIDAlkatreszComboBox.FormattingEnabled = true;
            projektIDAlkatreszComboBox.Location = new Point(294, 75);
            projektIDAlkatreszComboBox.Margin = new Padding(3, 2, 3, 2);
            projektIDAlkatreszComboBox.Name = "projektIDAlkatreszComboBox";
            projektIDAlkatreszComboBox.Size = new Size(67, 23);
            projektIDAlkatreszComboBox.TabIndex = 3;
            projektIDAlkatreszComboBox.SelectedIndexChanged += projektIDAlkatreszComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 70);
            label3.Name = "label3";
            label3.Size = new Size(224, 30);
            label3.TabIndex = 2;
            label3.Text = "Projekt kiválasztása:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 23);
            label4.Name = "label4";
            label4.Size = new Size(533, 37);
            label4.TabIndex = 0;
            label4.Text = "Projekthez tartozó alkatrészek listázása:";
            // 
            // utvonalPanel
            // 
            utvonalPanel.BackColor = Color.Transparent;
            utvonalPanel.Controls.Add(utvonalListView);
            utvonalPanel.Controls.Add(projektIDUtvonalComboBox);
            utvonalPanel.Controls.Add(label5);
            utvonalPanel.Controls.Add(label6);
            utvonalPanel.Location = new Point(130, 124);
            utvonalPanel.Margin = new Padding(3, 2, 3, 2);
            utvonalPanel.Name = "utvonalPanel";
            utvonalPanel.Size = new Size(976, 395);
            utvonalPanel.TabIndex = 4;
            // 
            // utvonalListView
            // 
            utvonalListView.Columns.AddRange(new ColumnHeader[] { sorrend, alkHely, alkMegn });
            utvonalListView.Location = new Point(41, 118);
            utvonalListView.Margin = new Padding(3, 2, 3, 2);
            utvonalListView.Name = "utvonalListView";
            utvonalListView.Size = new Size(532, 182);
            utvonalListView.TabIndex = 4;
            utvonalListView.UseCompatibleStateImageBehavior = false;
            utvonalListView.View = View.Details;
            // 
            // sorrend
            // 
            sorrend.Text = "Sorrend";
            sorrend.Width = 100;
            // 
            // alkHely
            // 
            alkHely.Text = "Alkatrész helye:";
            alkHely.Width = 250;
            // 
            // alkMegn
            // 
            alkMegn.Text = "Alkatrész neve:";
            alkMegn.Width = 250;
            // 
            // projektIDUtvonalComboBox
            // 
            projektIDUtvonalComboBox.Location = new Point(294, 75);
            projektIDUtvonalComboBox.Margin = new Padding(3, 2, 3, 2);
            projektIDUtvonalComboBox.Name = "projektIDUtvonalComboBox";
            projektIDUtvonalComboBox.Size = new Size(67, 23);
            projektIDUtvonalComboBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 70);
            label5.Name = "label5";
            label5.Size = new Size(224, 30);
            label5.TabIndex = 2;
            label5.Text = "Projekt kiválasztása:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 23);
            label6.Name = "label6";
            label6.Size = new Size(320, 37);
            label6.TabIndex = 0;
            label6.Text = "Útvonal optimalizálása:";
            // 
            // Raktaros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1224, 671);
            Controls.Add(projektListaPanel);
            Controls.Add(buttonLoginRaktaros);
            Controls.Add(raktarosMenu);
            Controls.Add(utvonalPanel);
            Controls.Add(projektAlkatreszPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = raktarosMenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Raktaros";
            Text = "Raktaros";
            raktarosMenu.ResumeLayout(false);
            raktarosMenu.PerformLayout();
            projektListaPanel.ResumeLayout(false);
            projektListaPanel.PerformLayout();
            projektAlkatreszPanel.ResumeLayout(false);
            projektAlkatreszPanel.PerformLayout();
            utvonalPanel.ResumeLayout(false);
            utvonalPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ColumnHeader ID;
        private ColumnHeader Neve;
        private ColumnHeader Darabszám;
        private ColumnHeader Sor;
        private ColumnHeader Oszlop;
        private ColumnHeader Szint;
    }
}