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
            this.buttonLoginRaktarvezeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginRaktarvezeto
            // 
            this.buttonLoginRaktarvezeto.Location = new System.Drawing.Point(632, 384);
            this.buttonLoginRaktarvezeto.Name = "buttonLoginRaktarvezeto";
            this.buttonLoginRaktarvezeto.Size = new System.Drawing.Size(138, 29);
            this.buttonLoginRaktarvezeto.TabIndex = 0;
            this.buttonLoginRaktarvezeto.Text = "Vissza a Loginhez";
            this.buttonLoginRaktarvezeto.UseVisualStyleBackColor = true;
            this.buttonLoginRaktarvezeto.Click += new System.EventHandler(this.buttonLoginRaktarvezeto_Click);
            // 
            // Raktárvezető
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoginRaktarvezeto);
            this.Name = "Raktárvezető";
            this.Text = "Raktárvezető";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLoginRaktarvezeto;
    }
}