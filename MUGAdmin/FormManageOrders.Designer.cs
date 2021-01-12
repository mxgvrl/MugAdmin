namespace MUGAdmin
{
    partial class FormManageOrders
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
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label orderDateLabel1;
            System.Windows.Forms.Label userNameLabel1;
            System.Windows.Forms.Label orderDateLabel2;
            System.Windows.Forms.Label userNameLabel2;
            System.Windows.Forms.Label userNameLabel3;
            System.Windows.Forms.Label userNameLabel4;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.user_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.dtpDateEdit = new System.Windows.Forms.DateTimePicker();
            this.cbNameEdit = new System.Windows.Forms.ComboBox();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDateDelete = new System.Windows.Forms.DateTimePicker();
            this.cbNameDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateAdd = new System.Windows.Forms.DateTimePicker();
            this.cbNameAdd = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnBackOrderManage = new System.Windows.Forms.Button();
            this.user_OrderTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.User_OrderTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            this.cbIdDelete = new System.Windows.Forms.ComboBox();
            this.cbIdEdit = new System.Windows.Forms.ComboBox();
            orderDateLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            orderDateLabel1 = new System.Windows.Forms.Label();
            userNameLabel1 = new System.Windows.Forms.Label();
            orderDateLabel2 = new System.Windows.Forms.Label();
            userNameLabel2 = new System.Windows.Forms.Label();
            userNameLabel3 = new System.Windows.Forms.Label();
            userNameLabel4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(18, 43);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(80, 17);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "order Date:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(18, 70);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(81, 17);
            userNameLabel.TabIndex = 15;
            userNameLabel.Text = "user Name:";
            // 
            // orderDateLabel1
            // 
            orderDateLabel1.AutoSize = true;
            orderDateLabel1.Location = new System.Drawing.Point(22, 71);
            orderDateLabel1.Name = "orderDateLabel1";
            orderDateLabel1.Size = new System.Drawing.Size(80, 17);
            orderDateLabel1.TabIndex = 16;
            orderDateLabel1.Text = "order Date:";
            // 
            // userNameLabel1
            // 
            userNameLabel1.AutoSize = true;
            userNameLabel1.Location = new System.Drawing.Point(22, 98);
            userNameLabel1.Name = "userNameLabel1";
            userNameLabel1.Size = new System.Drawing.Size(81, 17);
            userNameLabel1.TabIndex = 18;
            userNameLabel1.Text = "user Name:";
            // 
            // orderDateLabel2
            // 
            orderDateLabel2.AutoSize = true;
            orderDateLabel2.Location = new System.Drawing.Point(21, 68);
            orderDateLabel2.Name = "orderDateLabel2";
            orderDateLabel2.Size = new System.Drawing.Size(80, 17);
            orderDateLabel2.TabIndex = 26;
            orderDateLabel2.Text = "order Date:";
            // 
            // userNameLabel2
            // 
            userNameLabel2.AutoSize = true;
            userNameLabel2.Location = new System.Drawing.Point(21, 95);
            userNameLabel2.Name = "userNameLabel2";
            userNameLabel2.Size = new System.Drawing.Size(81, 17);
            userNameLabel2.TabIndex = 28;
            userNameLabel2.Text = "user Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(userNameLabel4);
            this.groupBox3.Controls.Add(this.cbIdEdit);
            this.groupBox3.Controls.Add(orderDateLabel2);
            this.groupBox3.Controls.Add(this.dtpDateEdit);
            this.groupBox3.Controls.Add(userNameLabel2);
            this.groupBox3.Controls.Add(this.cbNameEdit);
            this.groupBox3.Controls.Add(this.btnEditOrder);
            this.groupBox3.Location = new System.Drawing.Point(708, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 194);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // user_OrderBindingSource
            // 
            this.user_OrderBindingSource.DataMember = "User_Order";
            this.user_OrderBindingSource.DataSource = this.mugDBDataSet;
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDateEdit
            // 
            this.dtpDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.user_OrderBindingSource, "orderDate", true));
            this.dtpDateEdit.Location = new System.Drawing.Point(108, 64);
            this.dtpDateEdit.Name = "dtpDateEdit";
            this.dtpDateEdit.Size = new System.Drawing.Size(200, 22);
            this.dtpDateEdit.TabIndex = 27;
            // 
            // cbNameEdit
            // 
            this.cbNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "userName", true));
            this.cbNameEdit.FormattingEnabled = true;
            this.cbNameEdit.Location = new System.Drawing.Point(108, 92);
            this.cbNameEdit.Name = "cbNameEdit";
            this.cbNameEdit.Size = new System.Drawing.Size(200, 24);
            this.cbNameEdit.TabIndex = 29;
            this.cbNameEdit.Click += new System.EventHandler(this.cbNameEdit_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(24, 135);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(284, 39);
            this.btnEditOrder.TabIndex = 24;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(userNameLabel3);
            this.groupBox2.Controls.Add(this.cbIdDelete);
            this.groupBox2.Controls.Add(orderDateLabel1);
            this.groupBox2.Controls.Add(this.dtpDateDelete);
            this.groupBox2.Controls.Add(userNameLabel1);
            this.groupBox2.Controls.Add(this.cbNameDelete);
            this.groupBox2.Controls.Add(this.btnDeleteOrder);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 194);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // dtpDateDelete
            // 
            this.dtpDateDelete.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.user_OrderBindingSource, "orderDate", true));
            this.dtpDateDelete.Enabled = false;
            this.dtpDateDelete.Location = new System.Drawing.Point(109, 67);
            this.dtpDateDelete.Name = "dtpDateDelete";
            this.dtpDateDelete.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDelete.TabIndex = 17;
            // 
            // cbNameDelete
            // 
            this.cbNameDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "userName", true));
            this.cbNameDelete.Enabled = false;
            this.cbNameDelete.FormattingEnabled = true;
            this.cbNameDelete.Location = new System.Drawing.Point(109, 95);
            this.cbNameDelete.Name = "cbNameDelete";
            this.cbNameDelete.Size = new System.Drawing.Size(200, 24);
            this.cbNameDelete.TabIndex = 19;
            this.cbNameDelete.Click += new System.EventHandler(this.cbNameDelete_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(25, 135);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(285, 39);
            this.btnDeleteOrder.TabIndex = 14;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(orderDateLabel);
            this.groupBox1.Controls.Add(this.dtpDateAdd);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.cbNameAdd);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 191);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // dtpDateAdd
            // 
            this.dtpDateAdd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.user_OrderBindingSource, "orderDate", true));
            this.dtpDateAdd.Location = new System.Drawing.Point(105, 39);
            this.dtpDateAdd.Name = "dtpDateAdd";
            this.dtpDateAdd.Size = new System.Drawing.Size(200, 22);
            this.dtpDateAdd.TabIndex = 14;
            // 
            // cbNameAdd
            // 
            this.cbNameAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "userName", true));
            this.cbNameAdd.FormattingEnabled = true;
            this.cbNameAdd.Location = new System.Drawing.Point(105, 67);
            this.cbNameAdd.Name = "cbNameAdd";
            this.cbNameAdd.Size = new System.Drawing.Size(200, 24);
            this.cbNameAdd.TabIndex = 16;
            this.cbNameAdd.Click += new System.EventHandler(this.cbNameAdd_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(21, 135);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(284, 39);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnBackOrderManage
            // 
            this.btnBackOrderManage.Location = new System.Drawing.Point(9, 220);
            this.btnBackOrderManage.Name = "btnBackOrderManage";
            this.btnBackOrderManage.Size = new System.Drawing.Size(76, 30);
            this.btnBackOrderManage.TabIndex = 33;
            this.btnBackOrderManage.Text = "< Back";
            this.btnBackOrderManage.UseVisualStyleBackColor = true;
            this.btnBackOrderManage.Click += new System.EventHandler(this.btnBackOrderManage_Click);
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
            // userNameLabel3
            // 
            userNameLabel3.AutoSize = true;
            userNameLabel3.Location = new System.Drawing.Point(21, 39);
            userNameLabel3.Name = "userNameLabel3";
            userNameLabel3.Size = new System.Drawing.Size(57, 17);
            userNameLabel3.TabIndex = 19;
            userNameLabel3.Text = "Search:";
            // 
            // cbIdDelete
            // 
            this.cbIdDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "userName", true));
            this.cbIdDelete.FormattingEnabled = true;
            this.cbIdDelete.Location = new System.Drawing.Point(108, 36);
            this.cbIdDelete.Name = "cbIdDelete";
            this.cbIdDelete.Size = new System.Drawing.Size(201, 24);
            this.cbIdDelete.TabIndex = 20;
            this.cbIdDelete.TextChanged += new System.EventHandler(this.cbIdDelete_TextChanged);
            this.cbIdDelete.Click += new System.EventHandler(this.cbIdDelete_Click);
            // 
            // userNameLabel4
            // 
            userNameLabel4.AutoSize = true;
            userNameLabel4.Location = new System.Drawing.Point(21, 36);
            userNameLabel4.Name = "userNameLabel4";
            userNameLabel4.Size = new System.Drawing.Size(57, 17);
            userNameLabel4.TabIndex = 29;
            userNameLabel4.Text = "Search:";
            // 
            // cbIdEdit
            // 
            this.cbIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_OrderBindingSource, "userName", true));
            this.cbIdEdit.FormattingEnabled = true;
            this.cbIdEdit.Location = new System.Drawing.Point(108, 33);
            this.cbIdEdit.Name = "cbIdEdit";
            this.cbIdEdit.Size = new System.Drawing.Size(200, 24);
            this.cbIdEdit.TabIndex = 30;
            this.cbIdEdit.TextChanged += new System.EventHandler(this.cbIdEdit_TextChanged);
            this.cbIdEdit.Click += new System.EventHandler(this.cbIdEdit_Click);
            // 
            // FormManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackOrderManage);
            this.Name = "FormManageOrders";
            this.Text = "FormManageOrders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormManageOrders_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnBackOrderManage;
        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource user_OrderBindingSource;
        private MugDBDataSetTableAdapters.User_OrderTableAdapter user_OrderTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtpDateAdd;
        private System.Windows.Forms.ComboBox cbNameAdd;
        private System.Windows.Forms.DateTimePicker dtpDateEdit;
        private System.Windows.Forms.ComboBox cbNameEdit;
        private System.Windows.Forms.DateTimePicker dtpDateDelete;
        private System.Windows.Forms.ComboBox cbNameDelete;
        private System.Windows.Forms.ComboBox cbIdEdit;
        private System.Windows.Forms.ComboBox cbIdDelete;
    }
}