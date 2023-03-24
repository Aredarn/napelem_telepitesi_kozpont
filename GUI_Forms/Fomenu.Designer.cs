namespace napelem_telepito_kozpont
{
    partial class Fomenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Névkeresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(109, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(309, 23);
            this.usernameBox.TabIndex = 1;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(12, 59);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(81, 15);
            this.testLabel.TabIndex = 2;
            this.testLabel.Text = "*Információk*";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 15);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(91, 15);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Név megadása: ";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(void);
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 231);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.button1);
            this.Name = "Fomenu";
            this.Text = "Főmenü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox usernameBox;
        private Label testLabel;
        private Label label_Name;
        private BindingSource userBindingSource;
    }
}