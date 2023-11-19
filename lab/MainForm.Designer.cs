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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblAdmin = new Label();
            btnMainte = new Button();
            btnPOF = new Button();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.Transparent;
            lblAdmin.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin.ForeColor = SystemColors.Control;
            lblAdmin.Location = new Point(364, 99);
            lblAdmin.Margin = new Padding(4, 0, 4, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(374, 62);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "MAIN FORM";
            // 
            // btnMainte
            // 
            btnMainte.BackColor = Color.CornflowerBlue;
            btnMainte.FlatStyle = FlatStyle.System;
            btnMainte.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainte.ForeColor = SystemColors.Control;
            btnMainte.Location = new Point(406, 278);
            btnMainte.Margin = new Padding(4, 5, 4, 5);
            btnMainte.Name = "btnMainte";
            btnMainte.Size = new Size(285, 68);
            btnMainte.TabIndex = 1;
            btnMainte.Text = "SHOW MAINTENANCE";
            btnMainte.UseVisualStyleBackColor = false;
            btnMainte.Click += button1_Click;
            // 
            // btnPOF
            // 
            btnPOF.BackColor = Color.CornflowerBlue;
            btnPOF.FlatStyle = FlatStyle.System;
            btnPOF.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPOF.ForeColor = SystemColors.Control;
            btnPOF.Location = new Point(406, 376);
            btnPOF.Margin = new Padding(4, 5, 4, 5);
            btnPOF.Name = "btnPOF";
            btnPOF.Size = new Size(285, 68);
            btnPOF.TabIndex = 2;
            btnPOF.Text = "SHOW POINT OF SALES";
            btnPOF.UseVisualStyleBackColor = false;
            btnPOF.Click += btnPOF_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1143, 750);
            Controls.Add(btnPOF);
            Controls.Add(btnMainte);
            Controls.Add(lblAdmin);
            Margin = new Padding(4, 5, 4, 5);
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