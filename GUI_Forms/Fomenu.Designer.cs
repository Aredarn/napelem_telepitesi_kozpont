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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            usernameBox = new TextBox();
            testLabel = new Label();
            userBindingSource = new BindingSource(components);
            userControllerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 388);
            button1.Name = "button1";
            button1.Size = new Size(116, 50);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(12, 12);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(257, 23);
            usernameBox.TabIndex = 1;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(106, 103);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(38, 15);
            testLabel.TabIndex = 2;
            testLabel.Text = "label1";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // userControllerBindingSource
            // 
            userControllerBindingSource.DataSource = typeof(UserController);
            // 
            // Fomenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testLabel);
            Controls.Add(usernameBox);
            Controls.Add(button1);
            Name = "Fomenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox usernameBox;
        private Label testLabel;
        private BindingSource userBindingSource;
        private BindingSource userControllerBindingSource;
    }
}