namespace MUGAdmin
{
    partial class FormManageOrderInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label additionNameLabel;
            System.Windows.Forms.Label orderCountLabel;
            System.Windows.Forms.Label userNameLabel1;
            System.Windows.Forms.Label productNameLabel1;
            System.Windows.Forms.Label additionNameLabel1;
            System.Windows.Forms.Label orderCountLabel1;
            System.Windows.Forms.Label userNameLabel2;
            System.Windows.Forms.Label productNameLabel2;
            System.Windows.Forms.Label additionNameLabel2;
            System.Windows.Forms.Label orderCountLabel2;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label orderIdLabel1;
            System.Windows.Forms.Label orderIdLabel2;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbOrderEdit = new System.Windows.Forms.ComboBox();
            this.order_CompositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.cbIdEdit = new System.Windows.Forms.ComboBox();
            this.cbUserEdit = new System.Windows.Forms.ComboBox();
            this.cbProductEdit = new System.Windows.Forms.ComboBox();
            this.cbAdditionEdit = new System.Windows.Forms.ComboBox();
            this.tbCountEdit = new System.Windows.Forms.TextBox();
            this.btnEditOrderInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOrderDelete = new System.Windows.Forms.ComboBox();
            this.cbIdDelete = new System.Windows.Forms.ComboBox();
            this.cbUserDelete = new System.Windows.Forms.ComboBox();
            this.cbProductDelete = new System.Windows.Forms.ComboBox();
            this.cbAdditionDelete = new System.Windows.Forms.ComboBox();
            this.tbCountDelete = new System.Windows.Forms.TextBox();
            this.btnDeleteOrderInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOrderAdd = new System.Windows.Forms.ComboBox();
            this.cbUserAdd = new System.Windows.Forms.ComboBox();
            this.cbProductAdd = new System.Windows.Forms.ComboBox();
            this.cbAdditionAdd = new System.Windows.Forms.ComboBox();
            this.tbCountAdd = new System.Windows.Forms.TextBox();
            this.btnAddOrderInfo = new System.Windows.Forms.Button();
            this.btnBackOrderInfoManage = new System.Windows.Forms.Button();
            this.order_CompositionTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.Order_CompositionTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            userNameLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            additionNameLabel = new System.Windows.Forms.Label();
            orderCountLabel = new System.Windows.Forms.Label();
            userNameLabel1 = new System.Windows.Forms.Label();
            productNameLabel1 = new System.Windows.Forms.Label();
            additionNameLabel1 = new System.Windows.Forms.Label();
            orderCountLabel1 = new System.Windows.Forms.Label();
            userNameLabel2 = new System.Windows.Forms.Label();
            productNameLabel2 = new System.Windows.Forms.Label();
            additionNameLabel2 = new System.Windows.Forms.Label();
            orderCountLabel2 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            orderIdLabel = new System.Windows.Forms.Label();
            orderIdLabel1 = new System.Windows.Forms.Label();
            orderIdLabel2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(18, 75);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(81, 17);
            userNameLabel.TabIndex = 13;
            userNameLabel.Text = "user Name:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(18, 106);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(101, 17);
            productNameLabel.TabIndex = 15;
            productNameLabel.Text = "product Name:";
            // 
            // additionNameLabel
            // 
            additionNameLabel.AutoSize = true;
            additionNameLabel.Location = new System.Drawing.Point(18, 137);
            additionNameLabel.Name = "additionNameLabel";
            additionNameLabel.Size = new System.Drawing.Size(103, 17);
            additionNameLabel.TabIndex = 17;
            additionNameLabel.Text = "addition Name:";
            // 
            // orderCountLabel
            // 
            orderCountLabel.AutoSize = true;
            orderCountLabel.Location = new System.Drawing.Point(18, 168);
            orderCountLabel.Name = "orderCountLabel";
            orderCountLabel.Size = new System.Drawing.Size(87, 17);
            orderCountLabel.TabIndex = 19;
            orderCountLabel.Text = "order Count:";
            // 
            // userNameLabel1
            // 
            userNameLabel1.AutoSize = true;
            userNameLabel1.Location = new System.Drawing.Point(17, 102);
            userNameLabel1.Name = "userNameLabel1";
            userNameLabel1.Size = new System.Drawing.Size(81, 17);
            userNameLabel1.TabIndex = 16;
            userNameLabel1.Text = "user Name:";
            // 
            // productNameLabel1
            // 
            productNameLabel1.AutoSize = true;
            productNameLabel1.Location = new System.Drawing.Point(17, 133);
            productNameLabel1.Name = "productNameLabel1";
            productNameLabel1.Size = new System.Drawing.Size(101, 17);
            productNameLabel1.TabIndex = 18;
            productNameLabel1.Text = "product Name:";
            // 
            // additionNameLabel1
            // 
            additionNameLabel1.AutoSize = true;
            additionNameLabel1.Location = new System.Drawing.Point(17, 164);
            additionNameLabel1.Name = "additionNameLabel1";
            additionNameLabel1.Size = new System.Drawing.Size(103, 17);
            additionNameLabel1.TabIndex = 20;
            additionNameLabel1.Text = "addition Name:";
            // 
            // orderCountLabel1
            // 
            orderCountLabel1.AutoSize = true;
            orderCountLabel1.Location = new System.Drawing.Point(17, 195);
            orderCountLabel1.Name = "orderCountLabel1";
            orderCountLabel1.Size = new System.Drawing.Size(87, 17);
            orderCountLabel1.TabIndex = 22;
            orderCountLabel1.Text = "order Count:";
            // 
            // userNameLabel2
            // 
            userNameLabel2.AutoSize = true;
            userNameLabel2.Location = new System.Drawing.Point(20, 102);
            userNameLabel2.Name = "userNameLabel2";
            userNameLabel2.Size = new System.Drawing.Size(81, 17);
            userNameLabel2.TabIndex = 26;
            userNameLabel2.Text = "user Name:";
            // 
            // productNameLabel2
            // 
            productNameLabel2.AutoSize = true;
            productNameLabel2.Location = new System.Drawing.Point(20, 133);
            productNameLabel2.Name = "productNameLabel2";
            productNameLabel2.Size = new System.Drawing.Size(101, 17);
            productNameLabel2.TabIndex = 28;
            productNameLabel2.Text = "product Name:";
            // 
            // additionNameLabel2
            // 
            additionNameLabel2.AutoSize = true;
            additionNameLabel2.Location = new System.Drawing.Point(20, 164);
            additionNameLabel2.Name = "additionNameLabel2";
            additionNameLabel2.Size = new System.Drawing.Size(103, 17);
            additionNameLabel2.TabIndex = 30;
            additionNameLabel2.Text = "addition Name:";
            // 
            // orderCountLabel2
            // 
            orderCountLabel2.AutoSize = true;
            orderCountLabel2.Location = new System.Drawing.Point(20, 195);
            orderCountLabel2.Name = "orderCountLabel2";
            orderCountLabel2.Size = new System.Drawing.Size(87, 17);
            orderCountLabel2.TabIndex = 32;
            orderCountLabel2.Text = "order Count:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 23;
            idLabel.Text = "id:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(20, 41);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 33;
            idLabel1.Text = "id:";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(18, 44);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(61, 17);
            orderIdLabel.TabIndex = 20;
            orderIdLabel.Text = "order Id:";
            // 
            // orderIdLabel1
            // 
            orderIdLabel1.AutoSize = true;
            orderIdLabel1.Location = new System.Drawing.Point(17, 73);
            orderIdLabel1.Name = "orderIdLabel1";
            orderIdLabel1.Size = new System.Drawing.Size(61, 17);
            orderIdLabel1.TabIndex = 24;
            orderIdLabel1.Text = "order Id:";
            // 
            // orderIdLabel2
            // 
            orderIdLabel2.AutoSize = true;
            orderIdLabel2.Location = new System.Drawing.Point(20, 73);
            orderIdLabel2.Name = "orderIdLabel2";
            orderIdLabel2.Size = new System.Drawing.Size(61, 17);
            orderIdLabel2.TabIndex = 34;
            orderIdLabel2.Text = "order Id:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(orderIdLabel2);
            this.groupBox3.Controls.Add(this.cbOrderEdit);
            this.groupBox3.Controls.Add(idLabel1);
            this.groupBox3.Controls.Add(this.cbIdEdit);
            this.groupBox3.Controls.Add(userNameLabel2);
            this.groupBox3.Controls.Add(this.cbUserEdit);
            this.groupBox3.Controls.Add(productNameLabel2);
            this.groupBox3.Controls.Add(this.cbProductEdit);
            this.groupBox3.Controls.Add(additionNameLabel2);
            this.groupBox3.Controls.Add(this.cbAdditionEdit);
            this.groupBox3.Controls.Add(orderCountLabel2);
            this.groupBox3.Controls.Add(this.tbCountEdit);
            this.groupBox3.Controls.Add(this.btnEditOrderInfo);
            this.groupBox3.Location = new System.Drawing.Point(709, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 298);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // cbOrderEdit
            // 
            this.cbOrderEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderId", true));
            this.cbOrderEdit.FormattingEnabled = true;
            this.cbOrderEdit.Location = new System.Drawing.Point(129, 70);
            this.cbOrderEdit.Name = "cbOrderEdit";
            this.cbOrderEdit.Size = new System.Drawing.Size(178, 24);
            this.cbOrderEdit.TabIndex = 35;
            this.cbOrderEdit.Click += new System.EventHandler(this.cbOrderEdit_Click);
            // 
            // order_CompositionBindingSource
            // 
            this.order_CompositionBindingSource.DataMember = "Order_Composition";
            this.order_CompositionBindingSource.DataSource = this.mugDBDataSet;
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbIdEdit
            // 
            this.cbIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "id", true));
            this.cbIdEdit.FormattingEnabled = true;
            this.cbIdEdit.Location = new System.Drawing.Point(129, 41);
            this.cbIdEdit.Name = "cbIdEdit";
            this.cbIdEdit.Size = new System.Drawing.Size(178, 24);
            this.cbIdEdit.TabIndex = 34;
            this.cbIdEdit.TextChanged += new System.EventHandler(this.cbIdEdit_TextChanged);
            this.cbIdEdit.Click += new System.EventHandler(this.cbIdEdit_Click);
            // 
            // cbUserEdit
            // 
            this.cbUserEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "userName", true));
            this.cbUserEdit.Enabled = false;
            this.cbUserEdit.FormattingEnabled = true;
            this.cbUserEdit.Location = new System.Drawing.Point(129, 99);
            this.cbUserEdit.Name = "cbUserEdit";
            this.cbUserEdit.Size = new System.Drawing.Size(178, 24);
            this.cbUserEdit.TabIndex = 27;
            this.cbUserEdit.Click += new System.EventHandler(this.cbUserEdit_Click);
            // 
            // cbProductEdit
            // 
            this.cbProductEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "productName", true));
            this.cbProductEdit.FormattingEnabled = true;
            this.cbProductEdit.Location = new System.Drawing.Point(129, 130);
            this.cbProductEdit.Name = "cbProductEdit";
            this.cbProductEdit.Size = new System.Drawing.Size(178, 24);
            this.cbProductEdit.TabIndex = 29;
            this.cbProductEdit.Click += new System.EventHandler(this.cbProductEdit_Click);
            // 
            // cbAdditionEdit
            // 
            this.cbAdditionEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "additionName", true));
            this.cbAdditionEdit.FormattingEnabled = true;
            this.cbAdditionEdit.Location = new System.Drawing.Point(129, 161);
            this.cbAdditionEdit.Name = "cbAdditionEdit";
            this.cbAdditionEdit.Size = new System.Drawing.Size(178, 24);
            this.cbAdditionEdit.TabIndex = 31;
            this.cbAdditionEdit.Click += new System.EventHandler(this.cbAdditionEdit_Click);
            // 
            // tbCountEdit
            // 
            this.tbCountEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderCount", true));
            this.tbCountEdit.Location = new System.Drawing.Point(129, 192);
            this.tbCountEdit.Name = "tbCountEdit";
            this.tbCountEdit.Size = new System.Drawing.Size(178, 22);
            this.tbCountEdit.TabIndex = 33;
            this.tbCountEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountEdit_KeyPress);
            // 
            // btnEditOrderInfo
            // 
            this.btnEditOrderInfo.Location = new System.Drawing.Point(23, 239);
            this.btnEditOrderInfo.Name = "btnEditOrderInfo";
            this.btnEditOrderInfo.Size = new System.Drawing.Size(284, 39);
            this.btnEditOrderInfo.TabIndex = 24;
            this.btnEditOrderInfo.Text = "Edit";
            this.btnEditOrderInfo.UseVisualStyleBackColor = true;
            this.btnEditOrderInfo.Click += new System.EventHandler(this.btnEditOrderInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(orderIdLabel1);
            this.groupBox2.Controls.Add(this.cbOrderDelete);
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(this.cbIdDelete);
            this.groupBox2.Controls.Add(userNameLabel1);
            this.groupBox2.Controls.Add(this.cbUserDelete);
            this.groupBox2.Controls.Add(productNameLabel1);
            this.groupBox2.Controls.Add(this.cbProductDelete);
            this.groupBox2.Controls.Add(additionNameLabel1);
            this.groupBox2.Controls.Add(this.cbAdditionDelete);
            this.groupBox2.Controls.Add(orderCountLabel1);
            this.groupBox2.Controls.Add(this.tbCountDelete);
            this.groupBox2.Controls.Add(this.btnDeleteOrderInfo);
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 298);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // cbOrderDelete
            // 
            this.cbOrderDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderId", true));
            this.cbOrderDelete.Enabled = false;
            this.cbOrderDelete.FormattingEnabled = true;
            this.cbOrderDelete.Location = new System.Drawing.Point(126, 70);
            this.cbOrderDelete.Name = "cbOrderDelete";
            this.cbOrderDelete.Size = new System.Drawing.Size(179, 24);
            this.cbOrderDelete.TabIndex = 25;
            this.cbOrderDelete.Click += new System.EventHandler(this.cbOrderDelete_Click);
            // 
            // cbIdDelete
            // 
            this.cbIdDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "id", true));
            this.cbIdDelete.FormattingEnabled = true;
            this.cbIdDelete.Location = new System.Drawing.Point(126, 40);
            this.cbIdDelete.Name = "cbIdDelete";
            this.cbIdDelete.Size = new System.Drawing.Size(179, 24);
            this.cbIdDelete.TabIndex = 24;
            this.cbIdDelete.TextChanged += new System.EventHandler(this.cbIdDelete_TextChanged);
            this.cbIdDelete.Click += new System.EventHandler(this.cbIdDelete_Click);
            // 
            // cbUserDelete
            // 
            this.cbUserDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "userName", true));
            this.cbUserDelete.Enabled = false;
            this.cbUserDelete.FormattingEnabled = true;
            this.cbUserDelete.Location = new System.Drawing.Point(126, 101);
            this.cbUserDelete.Name = "cbUserDelete";
            this.cbUserDelete.Size = new System.Drawing.Size(179, 24);
            this.cbUserDelete.TabIndex = 17;
            this.cbUserDelete.Click += new System.EventHandler(this.cbUserDelete_Click);
            // 
            // cbProductDelete
            // 
            this.cbProductDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "productName", true));
            this.cbProductDelete.Enabled = false;
            this.cbProductDelete.FormattingEnabled = true;
            this.cbProductDelete.Location = new System.Drawing.Point(126, 132);
            this.cbProductDelete.Name = "cbProductDelete";
            this.cbProductDelete.Size = new System.Drawing.Size(179, 24);
            this.cbProductDelete.TabIndex = 19;
            this.cbProductDelete.Click += new System.EventHandler(this.cbProductDelete_Click);
            // 
            // cbAdditionDelete
            // 
            this.cbAdditionDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "additionName", true));
            this.cbAdditionDelete.Enabled = false;
            this.cbAdditionDelete.FormattingEnabled = true;
            this.cbAdditionDelete.Location = new System.Drawing.Point(126, 163);
            this.cbAdditionDelete.Name = "cbAdditionDelete";
            this.cbAdditionDelete.Size = new System.Drawing.Size(179, 24);
            this.cbAdditionDelete.TabIndex = 21;
            this.cbAdditionDelete.Click += new System.EventHandler(this.cbAdditionDelete_Click);
            // 
            // tbCountDelete
            // 
            this.tbCountDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderCount", true));
            this.tbCountDelete.Enabled = false;
            this.tbCountDelete.Location = new System.Drawing.Point(126, 194);
            this.tbCountDelete.Name = "tbCountDelete";
            this.tbCountDelete.Size = new System.Drawing.Size(179, 22);
            this.tbCountDelete.TabIndex = 23;
            this.tbCountDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountDelete_KeyPress);
            // 
            // btnDeleteOrderInfo
            // 
            this.btnDeleteOrderInfo.Location = new System.Drawing.Point(20, 239);
            this.btnDeleteOrderInfo.Name = "btnDeleteOrderInfo";
            this.btnDeleteOrderInfo.Size = new System.Drawing.Size(285, 39);
            this.btnDeleteOrderInfo.TabIndex = 14;
            this.btnDeleteOrderInfo.Text = "Delete";
            this.btnDeleteOrderInfo.UseVisualStyleBackColor = true;
            this.btnDeleteOrderInfo.Click += new System.EventHandler(this.btnDeleteOrderInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(orderIdLabel);
            this.groupBox1.Controls.Add(this.cbOrderAdd);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.cbUserAdd);
            this.groupBox1.Controls.Add(productNameLabel);
            this.groupBox1.Controls.Add(this.cbProductAdd);
            this.groupBox1.Controls.Add(additionNameLabel);
            this.groupBox1.Controls.Add(this.cbAdditionAdd);
            this.groupBox1.Controls.Add(orderCountLabel);
            this.groupBox1.Controls.Add(this.tbCountAdd);
            this.groupBox1.Controls.Add(this.btnAddOrderInfo);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 298);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // cbOrderAdd
            // 
            this.cbOrderAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderId", true));
            this.cbOrderAdd.FormattingEnabled = true;
            this.cbOrderAdd.Location = new System.Drawing.Point(127, 42);
            this.cbOrderAdd.Name = "cbOrderAdd";
            this.cbOrderAdd.Size = new System.Drawing.Size(174, 24);
            this.cbOrderAdd.TabIndex = 21;
            this.cbOrderAdd.TextChanged += new System.EventHandler(this.cbOrderAdd_TextChanged);
            this.cbOrderAdd.Click += new System.EventHandler(this.cbOrderAdd_Click);
            // 
            // cbUserAdd
            // 
            this.cbUserAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "userName", true));
            this.cbUserAdd.Enabled = false;
            this.cbUserAdd.FormattingEnabled = true;
            this.cbUserAdd.Location = new System.Drawing.Point(127, 72);
            this.cbUserAdd.Name = "cbUserAdd";
            this.cbUserAdd.Size = new System.Drawing.Size(174, 24);
            this.cbUserAdd.TabIndex = 14;
            this.cbUserAdd.Click += new System.EventHandler(this.cbUserAdd_Click);
            // 
            // cbProductAdd
            // 
            this.cbProductAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "productName", true));
            this.cbProductAdd.FormattingEnabled = true;
            this.cbProductAdd.Location = new System.Drawing.Point(127, 103);
            this.cbProductAdd.Name = "cbProductAdd";
            this.cbProductAdd.Size = new System.Drawing.Size(174, 24);
            this.cbProductAdd.TabIndex = 16;
            this.cbProductAdd.Click += new System.EventHandler(this.cbProductAdd_Click);
            // 
            // cbAdditionAdd
            // 
            this.cbAdditionAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "additionName", true));
            this.cbAdditionAdd.FormattingEnabled = true;
            this.cbAdditionAdd.Location = new System.Drawing.Point(127, 134);
            this.cbAdditionAdd.Name = "cbAdditionAdd";
            this.cbAdditionAdd.Size = new System.Drawing.Size(174, 24);
            this.cbAdditionAdd.TabIndex = 18;
            this.cbAdditionAdd.Click += new System.EventHandler(this.cbAdditionAdd_Click);
            // 
            // tbCountAdd
            // 
            this.tbCountAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CompositionBindingSource, "orderCount", true));
            this.tbCountAdd.Location = new System.Drawing.Point(127, 165);
            this.tbCountAdd.Name = "tbCountAdd";
            this.tbCountAdd.Size = new System.Drawing.Size(174, 22);
            this.tbCountAdd.TabIndex = 20;
            this.tbCountAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountAdd_KeyPress);
            // 
            // btnAddOrderInfo
            // 
            this.btnAddOrderInfo.Location = new System.Drawing.Point(17, 239);
            this.btnAddOrderInfo.Name = "btnAddOrderInfo";
            this.btnAddOrderInfo.Size = new System.Drawing.Size(284, 39);
            this.btnAddOrderInfo.TabIndex = 11;
            this.btnAddOrderInfo.Text = "Add";
            this.btnAddOrderInfo.UseVisualStyleBackColor = true;
            this.btnAddOrderInfo.Click += new System.EventHandler(this.btnAddOrderInfo_Click);
            // 
            // btnBackOrderInfoManage
            // 
            this.btnBackOrderInfoManage.Location = new System.Drawing.Point(10, 336);
            this.btnBackOrderInfoManage.Name = "btnBackOrderInfoManage";
            this.btnBackOrderInfoManage.Size = new System.Drawing.Size(76, 30);
            this.btnBackOrderInfoManage.TabIndex = 37;
            this.btnBackOrderInfoManage.Text = "< Back";
            this.btnBackOrderInfoManage.UseVisualStyleBackColor = true;
            this.btnBackOrderInfoManage.Click += new System.EventHandler(this.btnBackOrderInfoManage_Click);
            // 
            // order_CompositionTableAdapter
            // 
            this.order_CompositionTableAdapter.ClearBeforeFill = true;
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
            // FormManageOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackOrderInfoManage);
            this.Name = "FormManageOrderInfo";
            this.Text = "FormManageOrderInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageOrderInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormManageOrderInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_CompositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditOrderInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteOrderInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOrderInfo;
        private System.Windows.Forms.Button btnBackOrderInfoManage;
        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource order_CompositionBindingSource;
        private MugDBDataSetTableAdapters.Order_CompositionTableAdapter order_CompositionTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbUserAdd;
        private System.Windows.Forms.ComboBox cbProductAdd;
        private System.Windows.Forms.ComboBox cbAdditionAdd;
        private System.Windows.Forms.TextBox tbCountAdd;
        private System.Windows.Forms.ComboBox cbUserEdit;
        private System.Windows.Forms.ComboBox cbProductEdit;
        private System.Windows.Forms.ComboBox cbAdditionEdit;
        private System.Windows.Forms.TextBox tbCountEdit;
        private System.Windows.Forms.ComboBox cbUserDelete;
        private System.Windows.Forms.ComboBox cbProductDelete;
        private System.Windows.Forms.ComboBox cbAdditionDelete;
        private System.Windows.Forms.TextBox tbCountDelete;
        private System.Windows.Forms.ComboBox cbIdEdit;
        private System.Windows.Forms.ComboBox cbIdDelete;
        private System.Windows.Forms.ComboBox cbOrderEdit;
        private System.Windows.Forms.ComboBox cbOrderDelete;
        private System.Windows.Forms.ComboBox cbOrderAdd;
    }
}