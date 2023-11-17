namespace lab
{
    partial class MainForm
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
            lblAdmin = new Label();
            btnMainte = new Button();
            btnPOF = new Button();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(337, 19);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(74, 15);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "MAIN FORM";
            // 
            // btnMainte
            // 
            btnMainte.Location = new Point(140, 205);
            btnMainte.Name = "btnMainte";
            btnMainte.Size = new Size(178, 41);
            btnMainte.TabIndex = 1;
            btnMainte.Text = "SHOW MAINTENANCE";
            btnMainte.UseVisualStyleBackColor = true;
            btnMainte.Click += button1_Click;
            // 
            // btnPOF
            // 
            btnPOF.Location = new Point(433, 205);
            btnPOF.Name = "btnPOF";
            btnPOF.Size = new Size(178, 41);
            btnPOF.TabIndex = 2;
            btnPOF.Text = "SHOW POINT OF SALES";
            btnPOF.UseVisualStyleBackColor = true;
            btnPOF.Click += btnPOF_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPOF);
            Controls.Add(btnMainte);
            Controls.Add(lblAdmin);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private Button btnMainte;
        private Button btnPOF;
    }
}