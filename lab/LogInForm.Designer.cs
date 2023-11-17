namespace lab
{
    partial class LogInForm
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
            lblLogIn = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            btnSubmit = new Button();
            chbShowPass = new CheckBox();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Location = new Point(363, 30);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(42, 15);
            lblLogIn.TabIndex = 0;
            lblLogIn.Text = "LOGIN";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(307, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(167, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(307, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(167, 23);
            txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(227, 63);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(71, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "USERNAME:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(227, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(74, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "PASSWORD: ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(345, 146);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.Location = new Point(480, 108);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(108, 19);
            chbShowPass.TabIndex = 6;
            chbShowPass.Text = "Show Password";
            chbShowPass.UseVisualStyleBackColor = true;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chbShowPass);
            Controls.Add(btnSubmit);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblLogIn);
            Name = "LogInForm";
            Text = "Log In Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnSubmit;
        private CheckBox chbShowPass;
    }
}