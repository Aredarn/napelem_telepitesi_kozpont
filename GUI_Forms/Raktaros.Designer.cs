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
            this.buttonLoginRaktaros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginRaktaros
            // 
            this.buttonLoginRaktaros.Location = new System.Drawing.Point(639, 409);
            this.buttonLoginRaktaros.Name = "buttonLoginRaktaros";
            this.buttonLoginRaktaros.Size = new System.Drawing.Size(149, 29);
            this.buttonLoginRaktaros.TabIndex = 0;
            this.buttonLoginRaktaros.Text = "Vissza a Loginhez";
            this.buttonLoginRaktaros.UseVisualStyleBackColor = true;
            this.buttonLoginRaktaros.Click += new System.EventHandler(this.buttonLoginRaktaros_Click);
            // 
            // Raktaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoginRaktaros);
            this.Name = "Raktaros";
            this.Text = "Raktaros";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLoginRaktaros;
    }
}