namespace MUGAdmin
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productImageLabel;
            System.Windows.Forms.Label idLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBackToLoginTab1 = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBackToLoginTab2 = new System.Windows.Forms.Button();
            this.btnProductManage = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productImagePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBackToLoginTab3 = new System.Windows.Forms.Button();
            this.btnAdditionsManage = new System.Windows.Forms.Button();
            this.additionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBackToLoginTab4 = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.user_OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbOrderId = new System.Windows.Forms.ComboBox();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.order_CompositionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_CompositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackToLoginTab5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user_OrderTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.User_OrderTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.UsersTableAdapter();
            this.productsTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.ProductsTableAdapter();
            this.additionsTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.AdditionsTableAdapter();
            this.order_CompositionTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.Order_CompositionTableAdapter();
            this.Report = new System.Windows.Forms.Button();
            productImageLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionsBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productImageLabel
            // 
            productImageLabel.AutoSize = true;
            productImageLabel.Location = new System.Drawing.Point(528, 3);
            productImageLabel.Name = "productImageLabel";
            productImageLabel.Size = new System.Drawing.Size(102, 17);
            productImageLabel.TabIndex = 2;
            productImageLabel.Text = "product Image:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(535, 347);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(63, 17);
            idLabel.TabIndex = 10;
            idLabel.Text = "Order №";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBackToLoginTab1);
            this.tabPage1.Controls.Add(this.btnUserManage);
            this.tabPage1.Controls.Add(this.usersDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBackToLoginTab1
            // 
            this.btnBackToLoginTab1.Location = new System.Drawing.Point(6, 333);
            this.btnBackToLoginTab1.Name = "btnBackToLoginTab1";
            this.btnBackToLoginTab1.Size = new System.Drawing.Size(163, 45);
            this.btnBackToLoginTab1.TabIndex = 2;
            this.btnBackToLoginTab1.Text = "< Back";
            this.btnBackToLoginTab1.UseVisualStyleBackColor = true;
            this.btnBackToLoginTab1.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.Location = new System.Drawing.Point(300, 333);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(170, 45);
            this.btnUserManage.TabIndex = 1;
            this.btnUserManage.Text = "Manage Table";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersVisible = false;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(746, 320);
            this.usersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn5.HeaderText = "userName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "userPassword";
            this.dataGridViewTextBoxColumn6.HeaderText = "userPassword";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn7.HeaderText = "adress";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 180;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "userRole";
            this.dataGridViewTextBoxColumn8.HeaderText = "userRole";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 118;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mugDBDataSet;
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBackToLoginTab2);
            this.tabPage2.Controls.Add(productImageLabel);
            this.tabPage2.Controls.Add(this.btnProductManage);
            this.tabPage2.Controls.Add(this.productsDataGridView);
            this.tabPage2.Controls.Add(this.productImagePictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBackToLoginTab2
            // 
            this.btnBackToLoginTab2.Location = new System.Drawing.Point(6, 333);
            this.btnBackToLoginTab2.Name = "btnBackToLoginTab2";
            this.btnBackToLoginTab2.Size = new System.Drawing.Size(163, 45);
            this.btnBackToLoginTab2.TabIndex = 4;
            this.btnBackToLoginTab2.Text = "< Back";
            this.btnBackToLoginTab2.UseVisualStyleBackColor = true;
            this.btnBackToLoginTab2.Click += new System.EventHandler(this.btnBackToLoginTab2_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Location = new System.Drawing.Point(300, 333);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(170, 45);
            this.btnProductManage.TabIndex = 2;
            this.btnProductManage.Text = "Manage Table";
            this.btnProductManage.UseVisualStyleBackColor = true;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(519, 320);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 35;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn10.HeaderText = "productName";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "productImage";
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "productImage";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn11.HeaderText = "grade";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "volume";
            this.dataGridViewTextBoxColumn12.HeaderText = "volume";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "composition";
            this.dataGridViewTextBoxColumn13.HeaderText = "composition";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn14.HeaderText = "cost";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 55;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mugDBDataSet;
            // 
            // productImagePictureBox
            // 
            this.productImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productsBindingSource, "productImage", true));
            this.productImagePictureBox.Location = new System.Drawing.Point(531, 23);
            this.productImagePictureBox.Name = "productImagePictureBox";
            this.productImagePictureBox.Size = new System.Drawing.Size(221, 300);
            this.productImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImagePictureBox.TabIndex = 3;
            this.productImagePictureBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBackToLoginTab3);
            this.tabPage3.Controls.Add(this.btnAdditionsManage);
            this.tabPage3.Controls.Add(this.additionsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(758, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Additions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBackToLoginTab3
            // 
            this.btnBackToLoginTab3.Location = new System.Drawing.Point(6, 333);
            this.btnBackToLoginTab3.Name = "btnBackToLoginTab3";
            this.btnBackToLoginTab3.Size = new System.Drawing.Size(163, 45);
            this.btnBackToLoginTab3.TabIndex = 4;
            this.btnBackToLoginTab3.Text = "< Back";
            this.btnBackToLoginTab3.UseVisualStyleBackColor = true;
            this.btnBackToLoginTab3.Click += new System.EventHandler(this.btnBackToLoginTab3_Click);
            // 
            // btnAdditionsManage
            // 
            this.btnAdditionsManage.Location = new System.Drawing.Point(300, 333);
            this.btnAdditionsManage.Name = "btnAdditionsManage";
            this.btnAdditionsManage.Size = new System.Drawing.Size(170, 45);
            this.btnAdditionsManage.TabIndex = 3;
            this.btnAdditionsManage.Text = "Manage Table";
            this.btnAdditionsManage.UseVisualStyleBackColor = true;
            this.btnAdditionsManage.Click += new System.EventHandler(this.btnAdditionsManage_Click);
            // 
            // additionsDataGridView
            // 
            this.additionsDataGridView.AutoGenerateColumns = false;
            this.additionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.additionsDataGridView.DataSource = this.additionsBindingSource;
            this.additionsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.additionsDataGridView.Name = "additionsDataGridView";
            this.additionsDataGridView.RowHeadersVisible = false;
            this.additionsDataGridView.RowHeadersWidth = 51;
            this.additionsDataGridView.RowTemplate.Height = 24;
            this.additionsDataGridView.Size = new System.Drawing.Size(746, 320);
            this.additionsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn15.HeaderText = "id";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 143;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "additionName";
            this.dataGridViewTextBoxColumn16.HeaderText = "additionName";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "additionCount";
            this.dataGridViewTextBoxColumn17.HeaderText = "additionCount";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 200;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn18.HeaderText = "cost";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 200;
            // 
            // additionsBindingSource
            // 
            this.additionsBindingSource.DataMember = "Additions";
            this.additionsBindingSource.DataSource = this.mugDBDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.Report);
            this.tabPage4.Controls.Add(this.btnBackToLoginTab4);
            this.tabPage4.Controls.Add(this.btnManageOrders);
            this.tabPage4.Controls.Add(this.user_OrderDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(758, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBackToLoginTab4
            // 
            this.btnBackToLoginTab4.Location = new System.Drawing.Point(6, 333);
            this.btnBackToLoginTab4.Name = "btnBackToLoginTab4";
            this.btnBackToLoginTab4.Size = new System.Drawing.Size(163, 45);
            this.btnBackToLoginTab4.TabIndex = 5;
            this.btnBackToLoginTab4.Text = "< Back";
            this.btnBackToLoginTab4.UseVisualStyleBackColor = true;
            this.btnBackToLoginTab4.Click += new System.EventHandler(this.btnBackToLoginTab4_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(300, 333);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(170, 45);
            this.btnManageOrders.TabIndex = 4;
            this.btnManageOrders.Text = "Manage Table";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // user_OrderDataGridView
            // 
            this.user_OrderDataGridView.AutoGenerateColumns = false;
            this.user_OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.user_OrderDataGridView.DataSource = this.user_OrderBindingSource;
            this.user_OrderDataGridView.Location = new System.Drawing.Point(6, 6);
            this.user_OrderDataGridView.Name = "user_OrderDataGridView";
            this.user_OrderDataGridView.RowHeadersVisible = false;
            this.user_OrderDataGridView.RowHeadersWidth = 51;
            this.user_OrderDataGridView.RowTemplate.Height = 24;
            this.user_OrderDataGridView.Size = new System.Drawing.Size(746, 320);
            this.user_OrderDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 143;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "orderDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn3.HeaderText = "userName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // user_OrderBindingSource
            // 
            this.user_OrderBindingSource.DataMember = "User_Order";
            this.user_OrderBindingSource.DataSource = this.mugDBDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(idLabel);
            this.tabPage5.Controls.Add(this.cbOrderId);
            this.tabPage5.Controls.Add(this.btnTakeOrder);
            this.tabPage5.Controls.Add(this.order_CompositionDataGridView);
            this.tabPage5.Controls.Add(this.btnBackToLoginTab5);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(758, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Order Info";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbOrderId
            // 
            this.cbOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "id", true));
            this.cbOrderId.FormattingEnabled = true;
            this.cbOrderId.Location = new System.Drawing.Point(604, 344);
            this.cbOrderId.Name = "cbOrderId";
            this.cbOrderId.Size = new System.Drawing.Size(61, 24);
            this.cbOrderId.TabIndex = 12;
            this.cbOrderId.Click += new System.EventHandler(this.idComboBox_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Location = new System.Drawing.Point(671, 333);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(81, 45);
            this.btnTakeOrder.TabIndex = 11;
            this.btnTakeOrder.Text = "Done";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // order_CompositionDataGridView
            // 
            this.order_CompositionDataGridView.AutoGenerateColumns = false;
            this.order_CompositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_CompositionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.order_CompositionDataGridView.DataSource = this.order_CompositionBindingSource;
            this.order_CompositionDataGridView.Location = new System.Drawing.Point(6, 6);
            this.order_CompositionDataGridView.Name = "order_CompositionDataGridView";
            this.order_CompositionDataGridView.RowHeadersWidth = 51;
            this.order_CompositionDataGridView.RowTemplate.Height = 24;
            this.order_CompositionDataGridView.Size = new System.Drawing.Size(746, 321);
            this.order_CompositionDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn19.HeaderText = "id";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn20.HeaderText = "userName";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn21.HeaderText = "productName";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "additionName";
            this.dataGridViewTextBoxColumn22.HeaderText = "additionName";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "orderId";
            this.dataGridViewTextBoxColumn23.HeaderText = "orderId";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "isDone";
            this.dataGridViewTextBoxColumn24.HeaderText = "isDone";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // order_CompositionBindingSource
            // 
            this.order_CompositionBindingSource.DataMember = "Order_Composition";
            this.order_CompositionBindingSource.DataSource = this.mugDBDataSet;
            // 
            // btnBackToLoginTab5
            // 
            this.btnBackToLoginTab5.Location = new System.Drawing.Point(6, 333);
            this.btnBackToLoginTab5.Name = "btnBackToLoginTab5";
            this.btnBackToLoginTab5.Size = new System.Drawing.Size(163, 45);
            this.btnBackToLoginTab5.TabIndex = 6;
            this.btnBackToLoginTab5.Text = "< Back";
            this.btnBackToLoginTab5.UseVisualStyleBackColor = true;
            this.btnBackToLoginTab5.Click += new System.EventHandler(this.btnBackToLoginTab5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Manage Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_OrderTableAdapter
            // 
            this.user_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.OrderCompositionTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserOrderTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // additionsTableAdapter
            // 
            this.additionsTableAdapter.ClearBeforeFill = true;
            // 
            // order_CompositionTableAdapter
            // 
            this.order_CompositionTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(625, 344);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(75, 23);
            this.Report.TabIndex = 6;
            this.Report.Text = "button2";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "MugAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.additionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionsBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource user_OrderBindingSource;
        private MugDBDataSetTableAdapters.User_OrderTableAdapter user_OrderTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView user_OrderDataGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MugDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MugDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource additionsBindingSource;
        private MugDBDataSetTableAdapters.AdditionsTableAdapter additionsTableAdapter;
        private System.Windows.Forms.DataGridView additionsDataGridView;
        private System.Windows.Forms.BindingSource order_CompositionBindingSource;
        private MugDBDataSetTableAdapters.Order_CompositionTableAdapter order_CompositionTableAdapter;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnProductManage;
        private System.Windows.Forms.PictureBox productImagePictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button btnAdditionsManage;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnBackToLoginTab1;
        private System.Windows.Forms.Button btnBackToLoginTab2;
        private System.Windows.Forms.Button btnBackToLoginTab3;
        private System.Windows.Forms.Button btnBackToLoginTab4;
        private System.Windows.Forms.Button btnBackToLoginTab5;
        private System.Windows.Forms.DataGridView order_CompositionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.ComboBox cbOrderId;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button Report;
    }
}

