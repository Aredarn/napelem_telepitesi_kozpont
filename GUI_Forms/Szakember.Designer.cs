﻿namespace napelem_telepito_kozpont.GUI_Forms
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
            this.buttonLoginSzakember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginSzakember
            // 
            this.buttonLoginSzakember.Location = new System.Drawing.Point(652, 409);
            this.buttonLoginSzakember.Name = "buttonLoginSzakember";
            this.buttonLoginSzakember.Size = new System.Drawing.Size(136, 29);
            this.buttonLoginSzakember.TabIndex = 0;
            this.buttonLoginSzakember.Text = "Vissza a Loginhez";
            this.buttonLoginSzakember.UseVisualStyleBackColor = true;
            this.buttonLoginSzakember.Click += new System.EventHandler(this.buttonLoginSzakember_Click);
            // 
            // Szakember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoginSzakember);
            this.Name = "Szakember";
            this.Text = "Szakember";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLoginSzakember;
    }
}