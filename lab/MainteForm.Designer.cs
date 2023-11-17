namespace lab
{
    partial class MaintenanceForm
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
            txtCategory = new Label();
            cbxCategory = new ComboBox();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblAddress = new Label();
            lblContact = new Label();
            lblItemName = new Label();
            lblBasePrice = new Label();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtItemName = new TextBox();
            txtBasePrice = new TextBox();
            btnSubmit = new Button();
            btnUsers = new Button();
            btnItemCategory = new Button();
            btnSuppliers = new Button();
            btnItems = new Button();
            dataGridViewMain = new DataGridView();
            tabMainte = new TabControl();
            tabUsers = new TabPage();
            dataGridViewUsers = new DataGridView();
            chbShowPass = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnSubmitUser = new Button();
            lblCPassword = new Label();
            lblCUserName = new Label();
            tabNewITem = new TabPage();
            dataGridViewItems = new DataGridView();
            tabSuppliers = new TabPage();
            dataGridViewSuppliers = new DataGridView();
            btnSubmitSupplier = new Button();
            txtSupplierContact = new TextBox();
            txtSupplierAdd = new TextBox();
            txtSupplierName = new TextBox();
            lblSupplierContact = new Label();
            lblSupplierAddress = new Label();
            lblSupplierName = new Label();
            tabCategory = new TabPage();
            dataGridViewCategory = new DataGridView();
            btnSubmitCategory = new Button();
            lblCategory = new Label();
            txtCategoryName = new TextBox();
            tabTables = new TabPage();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            tabMainte.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabNewITem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            tabTables.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Location = new Point(15, 59);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(135, 15);
            txtCategory.TabIndex = 2;
            txtCategory.Text = "SELECT ITEM CATEGORY";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Items.AddRange(new object[] { "Laptops", "Desktops", "Keyboards", "Computer Mouse", "Monitors" });
            cbxCategory.Location = new Point(156, 56);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(121, 23);
            cbxCategory.TabIndex = 3;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(36, 91);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(97, 15);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "SUPPLIER NAME:";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(156, 85);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(113, 23);
            txtSupplier.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(36, 127);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "ADDRESS:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(36, 166);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(114, 15);
            lblContact.TabIndex = 7;
            lblContact.Text = "CONTACT NUMBER:";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(36, 208);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(73, 15);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "ITEM NAME:";
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Location = new Point(36, 243);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(71, 15);
            lblBasePrice.TabIndex = 9;
            lblBasePrice.Text = "BASE PRICE:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(156, 127);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(113, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(156, 163);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(113, 23);
            txtContact.TabIndex = 11;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(156, 208);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(113, 23);
            txtItemName.TabIndex = 12;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(156, 240);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(113, 23);
            txtBasePrice.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(111, 291);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(163, 288);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(126, 45);
            btnUsers.TabIndex = 15;
            btnUsers.Text = "DISPLAY USERS";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnItemCategory
            // 
            btnItemCategory.Location = new Point(313, 288);
            btnItemCategory.Name = "btnItemCategory";
            btnItemCategory.Size = new Size(126, 45);
            btnItemCategory.TabIndex = 16;
            btnItemCategory.Text = "DISPLAY ITEM CATEGORY";
            btnItemCategory.UseVisualStyleBackColor = true;
            btnItemCategory.Click += btnItemCategory_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(453, 288);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(126, 45);
            btnSuppliers.TabIndex = 17;
            btnSuppliers.Text = "DISPLAY SUPPLIERS";
            btnSuppliers.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(313, 337);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(126, 45);
            btnItems.TabIndex = 18;
            btnItems.Text = "DISPLAY ITEMS";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.AllowUserToResizeColumns = false;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewMain.Location = new Point(150, 43);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.Size = new Size(491, 219);
            dataGridViewMain.TabIndex = 1;
            // 
            // tabMainte
            // 
            tabMainte.AllowDrop = true;
            tabMainte.Controls.Add(tabUsers);
            tabMainte.Controls.Add(tabNewITem);
            tabMainte.Controls.Add(tabSuppliers);
            tabMainte.Controls.Add(tabCategory);
            tabMainte.Controls.Add(tabTables);
            tabMainte.Location = new Point(0, -1);
            tabMainte.Name = "tabMainte";
            tabMainte.SelectedIndex = 0;
            tabMainte.Size = new Size(721, 439);
            tabMainte.TabIndex = 23;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dataGridViewUsers);
            tabUsers.Controls.Add(chbShowPass);
            tabUsers.Controls.Add(txtPassword);
            tabUsers.Controls.Add(txtUserName);
            tabUsers.Controls.Add(btnSubmitUser);
            tabUsers.Controls.Add(lblCPassword);
            tabUsers.Controls.Add(lblCUserName);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(713, 411);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "CREATE USERS";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.Location = new Point(207, 25);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(409, 241);
            dataGridViewUsers.TabIndex = 6;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.Location = new Point(465, 307);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(125, 19);
            chbShowPass.TabIndex = 5;
            chbShowPass.Text = "SHOW PASSWORD";
            chbShowPass.UseVisualStyleBackColor = true;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(359, 322);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(359, 281);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 3;
            // 
            // btnSubmitUser
            // 
            btnSubmitUser.Location = new Point(328, 363);
            btnSubmitUser.Name = "btnSubmitUser";
            btnSubmitUser.Size = new Size(75, 23);
            btnSubmitUser.TabIndex = 2;
            btnSubmitUser.Text = "SUBMIT";
            btnSubmitUser.UseVisualStyleBackColor = true;
            btnSubmitUser.Click += btnSubmitUser_Click;
            // 
            // lblCPassword
            // 
            lblCPassword.AutoSize = true;
            lblCPassword.Location = new Point(245, 322);
            lblCPassword.Name = "lblCPassword";
            lblCPassword.Size = new Size(101, 15);
            lblCPassword.TabIndex = 1;
            lblCPassword.Text = "ENTER PASSWOD:";
            // 
            // lblCUserName
            // 
            lblCUserName.AutoSize = true;
            lblCUserName.Location = new Point(245, 281);
            lblCUserName.Name = "lblCUserName";
            lblCUserName.Size = new Size(108, 15);
            lblCUserName.TabIndex = 0;
            lblCUserName.Text = "ENTER USERNAME:";
            // 
            // tabNewITem
            // 
            tabNewITem.Controls.Add(dataGridViewItems);
            tabNewITem.Controls.Add(txtCategory);
            tabNewITem.Controls.Add(cbxCategory);
            tabNewITem.Controls.Add(lblSupplier);
            tabNewITem.Controls.Add(txtSupplier);
            tabNewITem.Controls.Add(lblAddress);
            tabNewITem.Controls.Add(lblContact);
            tabNewITem.Controls.Add(lblItemName);
            tabNewITem.Controls.Add(lblBasePrice);
            tabNewITem.Controls.Add(txtAddress);
            tabNewITem.Controls.Add(txtContact);
            tabNewITem.Controls.Add(btnSubmit);
            tabNewITem.Controls.Add(txtItemName);
            tabNewITem.Controls.Add(txtBasePrice);
            tabNewITem.Location = new Point(4, 24);
            tabNewITem.Name = "tabNewITem";
            tabNewITem.Padding = new Padding(3);
            tabNewITem.Size = new Size(713, 411);
            tabNewITem.TabIndex = 0;
            tabNewITem.Text = "CREATE NEW ITEM";
            tabNewITem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewItems.Location = new Point(283, 43);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowTemplate.Height = 25;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(437, 271);
            dataGridViewItems.TabIndex = 15;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(dataGridViewSuppliers);
            tabSuppliers.Controls.Add(btnSubmitSupplier);
            tabSuppliers.Controls.Add(txtSupplierContact);
            tabSuppliers.Controls.Add(txtSupplierAdd);
            tabSuppliers.Controls.Add(txtSupplierName);
            tabSuppliers.Controls.Add(lblSupplierContact);
            tabSuppliers.Controls.Add(lblSupplierAddress);
            tabSuppliers.Controls.Add(lblSupplierName);
            tabSuppliers.Location = new Point(4, 24);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(3);
            tabSuppliers.Size = new Size(713, 411);
            tabSuppliers.TabIndex = 2;
            tabSuppliers.Text = "CREATE SUPPLIERS";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(139, 23);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowTemplate.Height = 25;
            dataGridViewSuppliers.Size = new Size(489, 199);
            dataGridViewSuppliers.TabIndex = 7;
            // 
            // btnSubmitSupplier
            // 
            btnSubmitSupplier.Location = new Point(333, 360);
            btnSubmitSupplier.Name = "btnSubmitSupplier";
            btnSubmitSupplier.Size = new Size(75, 23);
            btnSubmitSupplier.TabIndex = 6;
            btnSubmitSupplier.Text = "SUBMIT";
            btnSubmitSupplier.UseVisualStyleBackColor = true;
            btnSubmitSupplier.Click += btnSubmitSupplier_Click;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(428, 325);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(100, 23);
            txtSupplierContact.TabIndex = 5;
            // 
            // txtSupplierAdd
            // 
            txtSupplierAdd.Location = new Point(392, 283);
            txtSupplierAdd.Name = "txtSupplierAdd";
            txtSupplierAdd.Size = new Size(100, 23);
            txtSupplierAdd.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(392, 242);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(100, 23);
            txtSupplierName.TabIndex = 3;
            // 
            // lblSupplierContact
            // 
            lblSupplierContact.AutoSize = true;
            lblSupplierContact.Location = new Point(241, 328);
            lblSupplierContact.Name = "lblSupplierContact";
            lblSupplierContact.Size = new Size(167, 15);
            lblSupplierContact.TabIndex = 2;
            lblSupplierContact.Text = "SUPPLIER CONTACT NUMBER:";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new Point(241, 283);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(112, 15);
            lblSupplierAddress.TabIndex = 1;
            lblSupplierAddress.Text = "SUPPLIER ADDRESS:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(241, 242);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(97, 15);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "SUPPLIER NAME:";
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(dataGridViewCategory);
            tabCategory.Controls.Add(btnSubmitCategory);
            tabCategory.Controls.Add(lblCategory);
            tabCategory.Controls.Add(txtCategoryName);
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(713, 411);
            tabCategory.TabIndex = 4;
            tabCategory.Text = "CREATE CATEGORY";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewCategory.Location = new Point(195, 34);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategory.Size = new Size(418, 237);
            dataGridViewCategory.TabIndex = 3;
            // 
            // btnSubmitCategory
            // 
            btnSubmitCategory.Location = new Point(331, 316);
            btnSubmitCategory.Name = "btnSubmitCategory";
            btnSubmitCategory.Size = new Size(75, 23);
            btnSubmitCategory.TabIndex = 2;
            btnSubmitCategory.Text = "SUBMIT";
            btnSubmitCategory.UseVisualStyleBackColor = true;
            btnSubmitCategory.Click += btnSubmitCategory_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(235, 290);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(105, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "CATEGORY NAME:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(346, 287);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(182, 23);
            txtCategoryName.TabIndex = 0;
            // 
            // tabTables
            // 
            tabTables.Controls.Add(dataGridViewMain);
            tabTables.Controls.Add(btnSuppliers);
            tabTables.Controls.Add(btnUsers);
            tabTables.Controls.Add(btnItemCategory);
            tabTables.Controls.Add(btnItems);
            tabTables.Location = new Point(4, 24);
            tabTables.Name = "tabTables";
            tabTables.Padding = new Padding(3);
            tabTables.Size = new Size(713, 411);
            tabTables.TabIndex = 3;
            tabTables.Text = "VIEW TABLES";
            tabTables.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(727, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 34);
            btnBack.TabIndex = 24;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(tabMainte);
            Name = "MaintenanceForm";
            Text = "Maintenance Form";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            tabMainte.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabNewITem.ResumeLayout(false);
            tabNewITem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            tabSuppliers.ResumeLayout(false);
            tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            tabCategory.ResumeLayout(false);
            tabCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            tabTables.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label txtCategory;
        private ComboBox cbxCategory;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblAddress;
        private Label lblContact;
        private Label lblItemName;
        private Label lblBasePrice;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtItemName;
        private TextBox txtBasePrice;
        private Button btnSubmit;
        private Button btnUsers;
        private Button btnItemCategory;
        private Button btnSuppliers;
        private Button btnItems;
        private DataGridView dataGridViewMain;
        private TabControl tabMainte;
        private TabPage tabNewITem;
        private TabPage tabUsers;
        private TabPage tabSuppliers;
        private TabPage tabTables;
        private Label lblCPassword;
        private Label lblCUserName;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnSubmitUser;
        private CheckBox chbShowPass;
        private Label lblSupplierContact;
        private Label lblSupplierAddress;
        private Label lblSupplierName;
        private TextBox txtSupplierContact;
        private TextBox txtSupplierAdd;
        private TextBox txtSupplierName;
        private Button btnSubmitSupplier;
        private TabPage tabCategory;
        private Button btnSubmitCategory;
        private Label lblCategory;
        private TextBox txtCategoryName;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewItems;
        private DataGridView dataGridViewSuppliers;
        private DataGridView dataGridViewCategory;
        private Button btnBack;
    }
}