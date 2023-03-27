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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelLeiras = new System.Windows.Forms.Label();
            this.labelFelhasznalonev = new System.Windows.Forms.Label();
            this.labelJelszo = new System.Windows.Forms.Label();
            this.textBoxFelhasznalonev = new System.Windows.Forms.TextBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.buttonBelepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLeiras
            // 
            this.labelLeiras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLeiras.AutoSize = true;
            this.labelLeiras.BackColor = System.Drawing.Color.Transparent;
            this.labelLeiras.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelLeiras.ForeColor = System.Drawing.Color.Black;
            this.labelLeiras.Location = new System.Drawing.Point(219, 63);
            this.labelLeiras.Name = "labelLeiras";
            this.labelLeiras.Size = new System.Drawing.Size(1049, 106);
            this.labelLeiras.TabIndex = 0;
            this.labelLeiras.Text = "Napelem telepítő cég neve";
            // 
            // labelFelhasznalonev
            // 
            this.labelFelhasznalonev.AutoSize = true;
            this.labelFelhasznalonev.BackColor = System.Drawing.Color.Transparent;
            this.labelFelhasznalonev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFelhasznalonev.ForeColor = System.Drawing.Color.Black;
            this.labelFelhasznalonev.Location = new System.Drawing.Point(424, 332);
            this.labelFelhasznalonev.Name = "labelFelhasznalonev";
            this.labelFelhasznalonev.Size = new System.Drawing.Size(194, 32);
            this.labelFelhasznalonev.TabIndex = 1;
            this.labelFelhasznalonev.Text = "Felhasználónév:";
            // 
            // labelJelszo
            // 
            this.labelJelszo.AutoSize = true;
            this.labelJelszo.BackColor = System.Drawing.Color.Transparent;
            this.labelJelszo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJelszo.ForeColor = System.Drawing.Color.Black;
            this.labelJelszo.Location = new System.Drawing.Point(424, 391);
            this.labelJelszo.Name = "labelJelszo";
            this.labelJelszo.Size = new System.Drawing.Size(90, 32);
            this.labelJelszo.TabIndex = 2;
            this.labelJelszo.Text = "Jelszó:";
            this.labelJelszo.Click += new System.EventHandler(this.buttonBelepes_Click);
            // 
            // textBoxFelhasznalonev
            // 
            this.textBoxFelhasznalonev.Location = new System.Drawing.Point(631, 339);
            this.textBoxFelhasznalonev.Name = "textBoxFelhasznalonev";
            this.textBoxFelhasznalonev.Size = new System.Drawing.Size(276, 27);
            this.textBoxFelhasznalonev.TabIndex = 3;
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(631, 391);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(276, 27);
            this.textBoxJelszo.TabIndex = 4;
            // 
            // buttonBelepes
            // 
            this.buttonBelepes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBelepes.Location = new System.Drawing.Point(983, 357);
            this.buttonBelepes.Name = "buttonBelepes";
            this.buttonBelepes.Size = new System.Drawing.Size(143, 64);
            this.buttonBelepes.TabIndex = 5;
            this.buttonBelepes.Text = "Belépés";
            this.buttonBelepes.UseVisualStyleBackColor = true;
            this.buttonBelepes.Click += new System.EventHandler(this.buttonBelepes_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1399, 895);
            this.Controls.Add(this.buttonBelepes);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.textBoxFelhasznalonev);
            this.Controls.Add(this.labelJelszo);
            this.Controls.Add(this.labelFelhasznalonev);
            this.Controls.Add(this.labelLeiras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}