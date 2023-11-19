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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
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
            txtCategory.ForeColor = SystemColors.HighlightText;
            txtCategory.Location = new Point(30, 36);
            txtCategory.Margin = new Padding(4, 0, 4, 0);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(236, 21);
            txtCategory.TabIndex = 2;
            txtCategory.Text = "SELECT ITEM CATEGORY";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Items.AddRange(new object[] { "Laptops", "Desktops", "Keyboards", "Computer Mouse", "Monitors" });
            cbxCategory.Location = new Point(30, 62);
            cbxCategory.Margin = new Padding(4, 5, 4, 5);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(353, 29);
            cbxCategory.TabIndex = 3;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.ForeColor = SystemColors.HighlightText;
            lblSupplier.Location = new Point(30, 125);
            lblSupplier.Margin = new Padding(4, 0, 4, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(167, 21);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "SUPPLIER NAME:";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(30, 151);
            txtSupplier.Margin = new Padding(4, 5, 4, 5);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(353, 28);
            txtSupplier.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = SystemColors.HighlightText;
            lblAddress.Location = new Point(30, 224);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(104, 21);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "ADDRESS:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.ForeColor = SystemColors.HighlightText;
            lblContact.Location = new Point(30, 319);
            lblContact.Margin = new Padding(4, 0, 4, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(191, 21);
            lblContact.TabIndex = 7;
            lblContact.Text = "CONTACT NUMBER:";
            lblContact.Click += lblContact_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.ForeColor = SystemColors.HighlightText;
            lblItemName.Location = new Point(30, 423);
            lblItemName.Margin = new Padding(4, 0, 4, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(119, 21);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "ITEM NAME:";
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.ForeColor = SystemColors.HighlightText;
            lblBasePrice.Location = new Point(30, 528);
            lblBasePrice.Margin = new Padding(4, 0, 4, 0);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(127, 21);
            lblBasePrice.TabIndex = 9;
            lblBasePrice.Text = "BASE PRICE:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 250);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(353, 28);
            txtAddress.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(30, 345);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(353, 28);
            txtContact.TabIndex = 11;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(30, 449);
            txtItemName.Margin = new Padding(4, 5, 4, 5);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(353, 28);
            txtItemName.TabIndex = 12;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(30, 554);
            txtBasePrice.Margin = new Padding(4, 5, 4, 5);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(353, 28);
            txtBasePrice.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(120, 648);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 38);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(821, 47);
            btnUsers.Margin = new Padding(4, 5, 4, 5);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(180, 75);
            btnUsers.TabIndex = 15;
            btnUsers.Text = "DISPLAY USERS";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnItemCategory
            // 
            btnItemCategory.Location = new Point(821, 150);
            btnItemCategory.Margin = new Padding(4, 5, 4, 5);
            btnItemCategory.Name = "btnItemCategory";
            btnItemCategory.Size = new Size(180, 75);
            btnItemCategory.TabIndex = 16;
            btnItemCategory.Text = "DISPLAY ITEM CATEGORY";
            btnItemCategory.UseVisualStyleBackColor = true;
            btnItemCategory.Click += btnItemCategory_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(821, 249);
            btnSuppliers.Margin = new Padding(4, 5, 4, 5);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(180, 75);
            btnSuppliers.TabIndex = 17;
            btnSuppliers.Text = "DISPLAY SUPPLIERS";
            btnSuppliers.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(821, 351);
            btnItems.Margin = new Padding(4, 5, 4, 5);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(180, 75);
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
            dataGridViewMain.BackgroundColor = SystemColors.ControlLight;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewMain.GridColor = SystemColors.ControlLight;
            dataGridViewMain.Location = new Point(36, 37);
            dataGridViewMain.Margin = new Padding(4, 5, 4, 5);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.Size = new Size(759, 648);
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
            tabMainte.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabMainte.Location = new Point(0, -2);
            tabMainte.Margin = new Padding(4, 5, 4, 5);
            tabMainte.Name = "tabMainte";
            tabMainte.SelectedIndex = 0;
            tabMainte.Size = new Size(1030, 748);
            tabMainte.TabIndex = 23;
            // 
            // tabUsers
            // 
            tabUsers.BackColor = SystemColors.GradientInactiveCaption;
            tabUsers.BackgroundImage = (Image)resources.GetObject("tabUsers.BackgroundImage");
            tabUsers.BorderStyle = BorderStyle.FixedSingle;
            tabUsers.Controls.Add(dataGridViewUsers);
            tabUsers.Controls.Add(chbShowPass);
            tabUsers.Controls.Add(txtPassword);
            tabUsers.Controls.Add(txtUserName);
            tabUsers.Controls.Add(btnSubmitUser);
            tabUsers.Controls.Add(lblCPassword);
            tabUsers.Controls.Add(lblCUserName);
            tabUsers.Location = new Point(4, 30);
            tabUsers.Margin = new Padding(4, 5, 4, 5);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(4, 5, 4, 5);
            tabUsers.Size = new Size(1022, 714);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "CREATE USERS";
            tabUsers.Click += tabUsers_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ControlLight;
            dataGridViewUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.Location = new Point(35, 31);
            dataGridViewUsers.Margin = new Padding(4, 5, 4, 5);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 62;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(944, 402);
            dataGridViewUsers.TabIndex = 6;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.BackColor = Color.Transparent;
            chbShowPass.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbShowPass.ForeColor = SystemColors.HighlightText;
            chbShowPass.Location = new Point(278, 601);
            chbShowPass.Margin = new Padding(4, 5, 4, 5);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(166, 26);
            chbShowPass.TabIndex = 5;
            chbShowPass.Text = "Show password";
            chbShowPass.UseVisualStyleBackColor = false;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 543);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(536, 28);
            txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Snow;
            txtUserName.Location = new Point(268, 468);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(536, 28);
            txtUserName.TabIndex = 3;
            // 
            // btnSubmitUser
            // 
            btnSubmitUser.Location = new Point(872, 631);
            btnSubmitUser.Margin = new Padding(4, 5, 4, 5);
            btnSubmitUser.Name = "btnSubmitUser";
            btnSubmitUser.Size = new Size(107, 38);
            btnSubmitUser.TabIndex = 2;
            btnSubmitUser.Text = "SUBMIT";
            btnSubmitUser.UseVisualStyleBackColor = true;
            btnSubmitUser.Click += btnSubmitUser_Click;
            // 
            // lblCPassword
            // 
            lblCPassword.AutoSize = true;
            lblCPassword.BackColor = Color.Transparent;
            lblCPassword.ForeColor = SystemColors.HighlightText;
            lblCPassword.Location = new Point(36, 543);
            lblCPassword.Margin = new Padding(4, 0, 4, 0);
            lblCPassword.Name = "lblCPassword";
            lblCPassword.Size = new Size(189, 21);
            lblCPassword.TabIndex = 1;
            lblCPassword.Text = "ENTER PASSWORD:";
            lblCPassword.Click += lblCPassword_Click;
            // 
            // lblCUserName
            // 
            lblCUserName.AutoSize = true;
            lblCUserName.BackColor = Color.Transparent;
            lblCUserName.ForeColor = SystemColors.HighlightText;
            lblCUserName.Location = new Point(36, 468);
            lblCUserName.Margin = new Padding(4, 0, 4, 0);
            lblCUserName.Name = "lblCUserName";
            lblCUserName.Size = new Size(188, 21);
            lblCUserName.TabIndex = 0;
            lblCUserName.Text = "ENTER USERNAME:";
            // 
            // tabNewITem
            // 
            tabNewITem.BackgroundImage = (Image)resources.GetObject("tabNewITem.BackgroundImage");
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
            tabNewITem.Location = new Point(4, 30);
            tabNewITem.Margin = new Padding(4, 5, 4, 5);
            tabNewITem.Name = "tabNewITem";
            tabNewITem.Padding = new Padding(4, 5, 4, 5);
            tabNewITem.Size = new Size(1022, 714);
            tabNewITem.TabIndex = 0;
            tabNewITem.Text = "CREATE NEW ITEM";
            tabNewITem.UseVisualStyleBackColor = true;
            tabNewITem.Click += tabNewITem_Click;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.BackgroundColor = SystemColors.ControlLight;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewItems.GridColor = SystemColors.ControlLight;
            dataGridViewItems.Location = new Point(416, 31);
            dataGridViewItems.Margin = new Padding(4, 5, 4, 5);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 62;
            dataGridViewItems.RowTemplate.Height = 25;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(578, 655);
            dataGridViewItems.TabIndex = 15;
            // 
            // tabSuppliers
            // 
            tabSuppliers.BackgroundImage = (Image)resources.GetObject("tabSuppliers.BackgroundImage");
            tabSuppliers.Controls.Add(dataGridViewSuppliers);
            tabSuppliers.Controls.Add(btnSubmitSupplier);
            tabSuppliers.Controls.Add(txtSupplierContact);
            tabSuppliers.Controls.Add(txtSupplierAdd);
            tabSuppliers.Controls.Add(txtSupplierName);
            tabSuppliers.Controls.Add(lblSupplierContact);
            tabSuppliers.Controls.Add(lblSupplierAddress);
            tabSuppliers.Controls.Add(lblSupplierName);
            tabSuppliers.Location = new Point(4, 30);
            tabSuppliers.Margin = new Padding(4, 5, 4, 5);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(4, 5, 4, 5);
            tabSuppliers.Size = new Size(1022, 714);
            tabSuppliers.TabIndex = 2;
            tabSuppliers.Text = "CREATE SUPPLIERS";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = SystemColors.ControlLight;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(46, 43);
            dataGridViewSuppliers.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 62;
            dataGridViewSuppliers.RowTemplate.Height = 25;
            dataGridViewSuppliers.Size = new Size(928, 343);
            dataGridViewSuppliers.TabIndex = 7;
            // 
            // btnSubmitSupplier
            // 
            btnSubmitSupplier.Location = new Point(857, 441);
            btnSubmitSupplier.Margin = new Padding(4, 5, 4, 5);
            btnSubmitSupplier.Name = "btnSubmitSupplier";
            btnSubmitSupplier.Size = new Size(107, 38);
            btnSubmitSupplier.TabIndex = 6;
            btnSubmitSupplier.Text = "SUBMIT";
            btnSubmitSupplier.UseVisualStyleBackColor = true;
            btnSubmitSupplier.Click += btnSubmitSupplier_Click;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(455, 602);
            txtSupplierContact.Margin = new Padding(4, 5, 4, 5);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(338, 28);
            txtSupplierContact.TabIndex = 5;
            // 
            // txtSupplierAdd
            // 
            txtSupplierAdd.Location = new Point(455, 523);
            txtSupplierAdd.Margin = new Padding(4, 5, 4, 5);
            txtSupplierAdd.Name = "txtSupplierAdd";
            txtSupplierAdd.Size = new Size(338, 28);
            txtSupplierAdd.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(455, 447);
            txtSupplierName.Margin = new Padding(4, 5, 4, 5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(338, 28);
            txtSupplierName.TabIndex = 3;
            // 
            // lblSupplierContact
            // 
            lblSupplierContact.AutoSize = true;
            lblSupplierContact.ForeColor = SystemColors.HighlightText;
            lblSupplierContact.Location = new Point(129, 609);
            lblSupplierContact.Margin = new Padding(4, 0, 4, 0);
            lblSupplierContact.Name = "lblSupplierContact";
            lblSupplierContact.Size = new Size(288, 21);
            lblSupplierContact.TabIndex = 2;
            lblSupplierContact.Text = "SUPPLIER CONTACT NUMBER:";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.ForeColor = SystemColors.HighlightText;
            lblSupplierAddress.Location = new Point(129, 530);
            lblSupplierAddress.Margin = new Padding(4, 0, 4, 0);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(201, 21);
            lblSupplierAddress.TabIndex = 1;
            lblSupplierAddress.Text = "SUPPLIER ADDRESS:";
            lblSupplierAddress.Click += lblSupplierAddress_Click;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.ForeColor = SystemColors.HighlightText;
            lblSupplierName.Location = new Point(129, 450);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(167, 21);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "SUPPLIER NAME:";
            // 
            // tabCategory
            // 
            tabCategory.BackgroundImage = (Image)resources.GetObject("tabCategory.BackgroundImage");
            tabCategory.BackgroundImageLayout = ImageLayout.None;
            tabCategory.BorderStyle = BorderStyle.FixedSingle;
            tabCategory.Controls.Add(dataGridViewCategory);
            tabCategory.Controls.Add(btnSubmitCategory);
            tabCategory.Controls.Add(lblCategory);
            tabCategory.Controls.Add(txtCategoryName);
            tabCategory.Location = new Point(4, 30);
            tabCategory.Margin = new Padding(4, 5, 4, 5);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(4, 5, 4, 5);
            tabCategory.Size = new Size(1022, 714);
            tabCategory.TabIndex = 4;
            tabCategory.Text = "CREATE CATEGORY";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategory.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewCategory.Location = new Point(82, 94);
            dataGridViewCategory.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersWidth = 62;
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategory.Size = new Size(846, 553);
            dataGridViewCategory.TabIndex = 3;
            // 
            // btnSubmitCategory
            // 
            btnSubmitCategory.Location = new Point(799, 43);
            btnSubmitCategory.Margin = new Padding(4, 5, 4, 5);
            btnSubmitCategory.Name = "btnSubmitCategory";
            btnSubmitCategory.Size = new Size(107, 38);
            btnSubmitCategory.TabIndex = 2;
            btnSubmitCategory.Text = "SUBMIT";
            btnSubmitCategory.UseVisualStyleBackColor = true;
            btnSubmitCategory.Click += btnSubmitCategory_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = SystemColors.HighlightText;
            lblCategory.Location = new Point(82, 52);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(176, 21);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "CATEGORY NAME:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(266, 49);
            txtCategoryName.Margin = new Padding(4, 5, 4, 5);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(506, 28);
            txtCategoryName.TabIndex = 0;
            // 
            // tabTables
            // 
            tabTables.BackgroundImage = (Image)resources.GetObject("tabTables.BackgroundImage");
            tabTables.Controls.Add(dataGridViewMain);
            tabTables.Controls.Add(btnSuppliers);
            tabTables.Controls.Add(btnUsers);
            tabTables.Controls.Add(btnItemCategory);
            tabTables.Controls.Add(btnItems);
            tabTables.Location = new Point(4, 30);
            tabTables.Margin = new Padding(4, 5, 4, 5);
            tabTables.Name = "tabTables";
            tabTables.Padding = new Padding(4, 5, 4, 5);
            tabTables.Size = new Size(1022, 714);
            tabTables.TabIndex = 3;
            tabTables.Text = "VIEW TABLES";
            tabTables.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(1038, 28);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 57);
            btnBack.TabIndex = 24;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBack);
            Controls.Add(tabMainte);
            Margin = new Padding(4, 5, 4, 5);
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