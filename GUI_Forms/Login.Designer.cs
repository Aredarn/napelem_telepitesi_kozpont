namespace napelem_telepito_kozpont.GUI_Forms
{
    partial class Login
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
            this.labelLeiras = new System.Windows.Forms.Label();
            this.labelFelhasznalonev = new System.Windows.Forms.Label();
            this.labelJelszo = new System.Windows.Forms.Label();
            this.textBoxFelhasznalonev = new System.Windows.Forms.TextBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.buttonBelepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelLeiras
            // 
            this.labelLeiras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLeiras.AutoSize = true;
            this.labelLeiras.Location = new System.Drawing.Point(304, 9);
            this.labelLeiras.Name = "labelLeiras";
            this.labelLeiras.Size = new System.Drawing.Size(266, 20);
            this.labelLeiras.TabIndex = 0;
            this.labelLeiras.Text = "*valami rendkívül kreatív szöveg helye*";
            // 
            // labelFelhasznalonev
            // 
            this.labelFelhasznalonev.AutoSize = true;
            this.labelFelhasznalonev.Location = new System.Drawing.Point(270, 129);
            this.labelFelhasznalonev.Name = "labelFelhasznalonev";
            this.labelFelhasznalonev.Size = new System.Drawing.Size(112, 20);
            this.labelFelhasznalonev.TabIndex = 1;
            this.labelFelhasznalonev.Text = "Felhasználónév:";
            // 
            // labelJelszo
            // 
            this.labelJelszo.AutoSize = true;
            this.labelJelszo.Location = new System.Drawing.Point(270, 163);
            this.labelJelszo.Name = "labelJelszo";
            this.labelJelszo.Size = new System.Drawing.Size(51, 20);
            this.labelJelszo.TabIndex = 2;
            this.labelJelszo.Text = "Jelszó:";
            // 
            // textBoxFelhasznalonev
            // 
            this.textBoxFelhasznalonev.Location = new System.Drawing.Point(388, 126);
            this.textBoxFelhasznalonev.Name = "textBoxFelhasznalonev";
            this.textBoxFelhasznalonev.Size = new System.Drawing.Size(276, 27);
            this.textBoxFelhasznalonev.TabIndex = 3;
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(388, 160);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(276, 27);
            this.textBoxJelszo.TabIndex = 4;
            // 
            // buttonBelepes
            // 
            this.buttonBelepes.Location = new System.Drawing.Point(670, 126);
            this.buttonBelepes.Name = "buttonBelepes";
            this.buttonBelepes.Size = new System.Drawing.Size(106, 61);
            this.buttonBelepes.TabIndex = 5;
            this.buttonBelepes.Text = "Belépés";
            this.buttonBelepes.UseVisualStyleBackColor = true;
            this.buttonBelepes.Click += new System.EventHandler(this.buttonBelepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "ideiglenes megoldás,\r\nami a legördülő menüben ki van választva,\r\nbelépés gomb meg" +
    "nyomása után oda navigál\r\n\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Szakember",
            "Raktáros",
            "Raktárvezető",
            "Admin"});
            this.comboBox1.Location = new System.Drawing.Point(388, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 499);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBelepes);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.textBoxFelhasznalonev);
            this.Controls.Add(this.labelJelszo);
            this.Controls.Add(this.labelFelhasznalonev);
            this.Controls.Add(this.labelLeiras);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLeiras;
        private Label labelFelhasznalonev;
        private Label labelJelszo;
        private TextBox textBoxFelhasznalonev;
        private TextBox textBoxJelszo;
        private Button buttonBelepes;
        private Label label1;
        private ComboBox comboBox1;
    }
}