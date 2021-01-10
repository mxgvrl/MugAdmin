namespace MUGAdmin
{
    partial class FormManageUser
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
            System.Windows.Forms.Label userNameLabel1;
            System.Windows.Forms.Label userPasswordLabel1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label adressLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userRoleLabel2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label userRoleLabel;
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnBackUserManage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRoleAdd = new System.Windows.Forms.ComboBox();
            this.tbAdressAdd = new System.Windows.Forms.TextBox();
            this.tbUserPasswordAdd = new System.Windows.Forms.TextBox();
            this.tbUserNameAdd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUserNameDelete = new System.Windows.Forms.TextBox();
            this.tbUserPasswordDelete = new System.Windows.Forms.TextBox();
            this.tbAdressDelete = new System.Windows.Forms.TextBox();
            this.tbRoleDelete = new System.Windows.Forms.TextBox();
            this.cbIdDelete = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRoleEdit = new System.Windows.Forms.ComboBox();
            this.cbIdEdit = new System.Windows.Forms.ComboBox();
            this.tbAdressEdit = new System.Windows.Forms.TextBox();
            this.tbUserPasswordEdit = new System.Windows.Forms.TextBox();
            this.tbUserNameEdit = new System.Windows.Forms.TextBox();
            userNameLabel1 = new System.Windows.Forms.Label();
            userPasswordLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            adressLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userRoleLabel2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            userRoleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel1
            // 
            userNameLabel1.AutoSize = true;
            userNameLabel1.Location = new System.Drawing.Point(35, 67);
            userNameLabel1.Name = "userNameLabel1";
            userNameLabel1.Size = new System.Drawing.Size(81, 17);
            userNameLabel1.TabIndex = 16;
            userNameLabel1.Text = "user Name:";
            // 
            // userPasswordLabel1
            // 
            userPasswordLabel1.AutoSize = true;
            userPasswordLabel1.Location = new System.Drawing.Point(35, 95);
            userPasswordLabel1.Name = "userPasswordLabel1";
            userPasswordLabel1.Size = new System.Drawing.Size(105, 17);
            userPasswordLabel1.TabIndex = 18;
            userPasswordLabel1.Text = "user Password:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(35, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 14;
            idLabel.Text = "id:";
            // 
            // adressLabel1
            // 
            adressLabel1.AutoSize = true;
            adressLabel1.Location = new System.Drawing.Point(35, 123);
            adressLabel1.Name = "adressLabel1";
            adressLabel1.Size = new System.Drawing.Size(55, 17);
            adressLabel1.TabIndex = 20;
            adressLabel1.Text = "adress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 17);
            label1.TabIndex = 12;
            label1.Text = "id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 17);
            label4.TabIndex = 28;
            label4.Text = "adress:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 17);
            label3.TabIndex = 26;
            label3.Text = "user Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 17);
            label2.TabIndex = 24;
            label2.Text = "user Name:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(14, 64);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(105, 17);
            userPasswordLabel.TabIndex = 5;
            userPasswordLabel.Text = "user Password:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(14, 92);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(55, 17);
            adressLabel.TabIndex = 7;
            adressLabel.Text = "adress:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(14, 36);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(81, 17);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "user Name:";
            // 
            // userRoleLabel2
            // 
            userRoleLabel2.AutoSize = true;
            userRoleLabel2.Location = new System.Drawing.Point(14, 122);
            userRoleLabel2.Name = "userRoleLabel2";
            userRoleLabel2.Size = new System.Drawing.Size(73, 17);
            userRoleLabel2.TabIndex = 11;
            userRoleLabel2.Text = "user Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 17);
            label5.TabIndex = 30;
            label5.Text = "user Role:";
            // 
            // userRoleLabel
            // 
            userRoleLabel.AutoSize = true;
            userRoleLabel.Location = new System.Drawing.Point(35, 151);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new System.Drawing.Size(73, 17);
            userRoleLabel.TabIndex = 24;
            userRoleLabel.Text = "user Role:";
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mugDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderCompositionTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserOrderTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(19, 190);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(280, 39);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(25, 192);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(255, 39);
            this.btnUserDelete.TabIndex = 14;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Location = new System.Drawing.Point(38, 192);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(229, 39);
            this.btnUserEdit.TabIndex = 24;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnBackUserManage
            // 
            this.btnBackUserManage.Location = new System.Drawing.Point(19, 293);
            this.btnBackUserManage.Name = "btnBackUserManage";
            this.btnBackUserManage.Size = new System.Drawing.Size(76, 30);
            this.btnBackUserManage.TabIndex = 25;
            this.btnBackUserManage.Text = "< Back";
            this.btnBackUserManage.UseVisualStyleBackColor = true;
            this.btnBackUserManage.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(userRoleLabel2);
            this.groupBox1.Controls.Add(this.cbRoleAdd);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.tbAdressAdd);
            this.groupBox1.Controls.Add(adressLabel);
            this.groupBox1.Controls.Add(this.tbUserPasswordAdd);
            this.groupBox1.Controls.Add(userPasswordLabel);
            this.groupBox1.Controls.Add(this.tbUserNameAdd);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 251);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // cbRoleAdd
            // 
            this.cbRoleAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userRole", true));
            this.cbRoleAdd.FormattingEnabled = true;
            this.cbRoleAdd.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbRoleAdd.Location = new System.Drawing.Point(125, 117);
            this.cbRoleAdd.Name = "cbRoleAdd";
            this.cbRoleAdd.Size = new System.Drawing.Size(174, 24);
            this.cbRoleAdd.TabIndex = 12;
            // 
            // tbAdressAdd
            // 
            this.tbAdressAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "adress", true));
            this.tbAdressAdd.Location = new System.Drawing.Point(125, 89);
            this.tbAdressAdd.Name = "tbAdressAdd";
            this.tbAdressAdd.Size = new System.Drawing.Size(174, 22);
            this.tbAdressAdd.TabIndex = 8;
            // 
            // tbUserPasswordAdd
            // 
            this.tbUserPasswordAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userPassword", true));
            this.tbUserPasswordAdd.Location = new System.Drawing.Point(125, 61);
            this.tbUserPasswordAdd.Name = "tbUserPasswordAdd";
            this.tbUserPasswordAdd.Size = new System.Drawing.Size(174, 22);
            this.tbUserPasswordAdd.TabIndex = 6;
            // 
            // tbUserNameAdd
            // 
            this.tbUserNameAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userName", true));
            this.tbUserNameAdd.Location = new System.Drawing.Point(125, 33);
            this.tbUserNameAdd.Name = "tbUserNameAdd";
            this.tbUserNameAdd.Size = new System.Drawing.Size(174, 22);
            this.tbUserNameAdd.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.tbUserNameDelete);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.tbUserPasswordDelete);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.tbAdressDelete);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.tbRoleDelete);
            this.groupBox2.Controls.Add(this.cbIdDelete);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.btnUserDelete);
            this.groupBox2.Location = new System.Drawing.Point(360, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 251);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // tbUserNameDelete
            // 
            this.tbUserNameDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userName", true));
            this.tbUserNameDelete.Enabled = false;
            this.tbUserNameDelete.Location = new System.Drawing.Point(135, 64);
            this.tbUserNameDelete.Name = "tbUserNameDelete";
            this.tbUserNameDelete.Size = new System.Drawing.Size(145, 22);
            this.tbUserNameDelete.TabIndex = 25;
            // 
            // tbUserPasswordDelete
            // 
            this.tbUserPasswordDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userPassword", true));
            this.tbUserPasswordDelete.Enabled = false;
            this.tbUserPasswordDelete.Location = new System.Drawing.Point(135, 92);
            this.tbUserPasswordDelete.Name = "tbUserPasswordDelete";
            this.tbUserPasswordDelete.Size = new System.Drawing.Size(145, 22);
            this.tbUserPasswordDelete.TabIndex = 27;
            // 
            // tbAdressDelete
            // 
            this.tbAdressDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "adress", true));
            this.tbAdressDelete.Enabled = false;
            this.tbAdressDelete.Location = new System.Drawing.Point(135, 120);
            this.tbAdressDelete.Name = "tbAdressDelete";
            this.tbAdressDelete.Size = new System.Drawing.Size(145, 22);
            this.tbAdressDelete.TabIndex = 29;
            // 
            // tbRoleDelete
            // 
            this.tbRoleDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userRole", true));
            this.tbRoleDelete.Enabled = false;
            this.tbRoleDelete.Location = new System.Drawing.Point(135, 148);
            this.tbRoleDelete.Name = "tbRoleDelete";
            this.tbRoleDelete.Size = new System.Drawing.Size(145, 22);
            this.tbRoleDelete.TabIndex = 31;
            // 
            // cbIdDelete
            // 
            this.cbIdDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id", true));
            this.cbIdDelete.FormattingEnabled = true;
            this.cbIdDelete.Location = new System.Drawing.Point(135, 33);
            this.cbIdDelete.Name = "cbIdDelete";
            this.cbIdDelete.Size = new System.Drawing.Size(145, 24);
            this.cbIdDelete.TabIndex = 13;
            this.cbIdDelete.TextChanged += new System.EventHandler(this.cbIdDelete_TextChanged);
            this.cbIdDelete.Click += new System.EventHandler(this.cbIdDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(userRoleLabel);
            this.groupBox3.Controls.Add(this.cbRoleEdit);
            this.groupBox3.Controls.Add(this.cbIdEdit);
            this.groupBox3.Controls.Add(this.tbAdressEdit);
            this.groupBox3.Controls.Add(this.btnUserEdit);
            this.groupBox3.Controls.Add(adressLabel1);
            this.groupBox3.Controls.Add(idLabel);
            this.groupBox3.Controls.Add(this.tbUserPasswordEdit);
            this.groupBox3.Controls.Add(userPasswordLabel1);
            this.groupBox3.Controls.Add(userNameLabel1);
            this.groupBox3.Controls.Add(this.tbUserNameEdit);
            this.groupBox3.Location = new System.Drawing.Point(675, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 251);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // cbRoleEdit
            // 
            this.cbRoleEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userRole", true));
            this.cbRoleEdit.FormattingEnabled = true;
            this.cbRoleEdit.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbRoleEdit.Location = new System.Drawing.Point(146, 146);
            this.cbRoleEdit.Name = "cbRoleEdit";
            this.cbRoleEdit.Size = new System.Drawing.Size(121, 24);
            this.cbRoleEdit.TabIndex = 25;
            // 
            // cbIdEdit
            // 
            this.cbIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id", true));
            this.cbIdEdit.FormattingEnabled = true;
            this.cbIdEdit.Location = new System.Drawing.Point(146, 33);
            this.cbIdEdit.Name = "cbIdEdit";
            this.cbIdEdit.Size = new System.Drawing.Size(121, 24);
            this.cbIdEdit.TabIndex = 15;
            this.cbIdEdit.TextChanged += new System.EventHandler(this.cbIdEdit_TextChanged);
            this.cbIdEdit.Click += new System.EventHandler(this.cbIdEdit_Click);
            // 
            // tbAdressEdit
            // 
            this.tbAdressEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "adress", true));
            this.tbAdressEdit.Location = new System.Drawing.Point(146, 120);
            this.tbAdressEdit.Name = "tbAdressEdit";
            this.tbAdressEdit.Size = new System.Drawing.Size(121, 22);
            this.tbAdressEdit.TabIndex = 21;
            // 
            // tbUserPasswordEdit
            // 
            this.tbUserPasswordEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userPassword", true));
            this.tbUserPasswordEdit.Location = new System.Drawing.Point(146, 92);
            this.tbUserPasswordEdit.Name = "tbUserPasswordEdit";
            this.tbUserPasswordEdit.Size = new System.Drawing.Size(121, 22);
            this.tbUserPasswordEdit.TabIndex = 19;
            // 
            // tbUserNameEdit
            // 
            this.tbUserNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "userName", true));
            this.tbUserNameEdit.Location = new System.Drawing.Point(146, 64);
            this.tbUserNameEdit.Name = "tbUserNameEdit";
            this.tbUserNameEdit.Size = new System.Drawing.Size(121, 22);
            this.tbUserNameEdit.TabIndex = 17;
            // 
            // FormManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackUserManage);
            this.Name = "FormManageUser";
            this.Text = "FormManageUser";
            this.Load += new System.EventHandler(this.FormManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MugDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnBackUserManage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAdressAdd;
        private System.Windows.Forms.TextBox tbUserPasswordAdd;
        private System.Windows.Forms.TextBox tbUserNameAdd;
        private System.Windows.Forms.TextBox tbUserNameDelete;
        private System.Windows.Forms.TextBox tbUserPasswordDelete;
        private System.Windows.Forms.TextBox tbAdressDelete;
        private System.Windows.Forms.ComboBox cbIdDelete;
        private System.Windows.Forms.ComboBox cbIdEdit;
        private System.Windows.Forms.TextBox tbAdressEdit;
        private System.Windows.Forms.TextBox tbUserPasswordEdit;
        private System.Windows.Forms.TextBox tbUserNameEdit;
        private System.Windows.Forms.ComboBox cbRoleAdd;
        private System.Windows.Forms.TextBox tbRoleDelete;
        private System.Windows.Forms.ComboBox cbRoleEdit;
    }
}