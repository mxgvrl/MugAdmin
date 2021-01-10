namespace MUGAdmin
{
    partial class FormManageAdditions
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
            System.Windows.Forms.Label additionNameLabel;
            System.Windows.Forms.Label additionCountLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label additionNameLabel1;
            System.Windows.Forms.Label additionCountLabel1;
            System.Windows.Forms.Label costLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label additionNameLabel2;
            System.Windows.Forms.Label additionCountLabel2;
            System.Windows.Forms.Label costLabel2;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIdEdit = new System.Windows.Forms.ComboBox();
            this.additionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.tbAdditionNameEdit = new System.Windows.Forms.TextBox();
            this.tbAdditionCountEdit = new System.Windows.Forms.TextBox();
            this.tbCostEdit = new System.Windows.Forms.TextBox();
            this.btnEditAddition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIdDelete = new System.Windows.Forms.ComboBox();
            this.tbAdditionNameDelete = new System.Windows.Forms.TextBox();
            this.tbAdditionCountDelete = new System.Windows.Forms.TextBox();
            this.tbCostDelete = new System.Windows.Forms.TextBox();
            this.btnDeleteAddition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAdditionNameAdd = new System.Windows.Forms.TextBox();
            this.tbAdditionCountAdd = new System.Windows.Forms.TextBox();
            this.tbCostAdd = new System.Windows.Forms.TextBox();
            this.btnAddAddition = new System.Windows.Forms.Button();
            this.btnBackAdditionManage = new System.Windows.Forms.Button();
            this.additionsTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.AdditionsTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            additionNameLabel = new System.Windows.Forms.Label();
            additionCountLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            additionNameLabel1 = new System.Windows.Forms.Label();
            additionCountLabel1 = new System.Windows.Forms.Label();
            costLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            additionNameLabel2 = new System.Windows.Forms.Label();
            additionCountLabel2 = new System.Windows.Forms.Label();
            costLabel2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionNameLabel
            // 
            additionNameLabel.AutoSize = true;
            additionNameLabel.Location = new System.Drawing.Point(22, 49);
            additionNameLabel.Name = "additionNameLabel";
            additionNameLabel.Size = new System.Drawing.Size(103, 17);
            additionNameLabel.TabIndex = 13;
            additionNameLabel.Text = "addition Name:";
            // 
            // additionCountLabel
            // 
            additionCountLabel.AutoSize = true;
            additionCountLabel.Location = new System.Drawing.Point(22, 77);
            additionCountLabel.Name = "additionCountLabel";
            additionCountLabel.Size = new System.Drawing.Size(103, 17);
            additionCountLabel.TabIndex = 15;
            additionCountLabel.Text = "addition Count:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(22, 105);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(38, 17);
            costLabel.TabIndex = 17;
            costLabel.Text = "cost:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 46);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 14;
            idLabel.Text = "id:";
            // 
            // additionNameLabel1
            // 
            additionNameLabel1.AutoSize = true;
            additionNameLabel1.Location = new System.Drawing.Point(24, 77);
            additionNameLabel1.Name = "additionNameLabel1";
            additionNameLabel1.Size = new System.Drawing.Size(103, 17);
            additionNameLabel1.TabIndex = 16;
            additionNameLabel1.Text = "addition Name:";
            // 
            // additionCountLabel1
            // 
            additionCountLabel1.AutoSize = true;
            additionCountLabel1.Location = new System.Drawing.Point(24, 105);
            additionCountLabel1.Name = "additionCountLabel1";
            additionCountLabel1.Size = new System.Drawing.Size(103, 17);
            additionCountLabel1.TabIndex = 18;
            additionCountLabel1.Text = "addition Count:";
            // 
            // costLabel1
            // 
            costLabel1.AutoSize = true;
            costLabel1.Location = new System.Drawing.Point(24, 133);
            costLabel1.Name = "costLabel1";
            costLabel1.Size = new System.Drawing.Size(38, 17);
            costLabel1.TabIndex = 20;
            costLabel1.Text = "cost:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(35, 46);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 24;
            idLabel1.Text = "id:";
            // 
            // additionNameLabel2
            // 
            additionNameLabel2.AutoSize = true;
            additionNameLabel2.Location = new System.Drawing.Point(35, 77);
            additionNameLabel2.Name = "additionNameLabel2";
            additionNameLabel2.Size = new System.Drawing.Size(103, 17);
            additionNameLabel2.TabIndex = 26;
            additionNameLabel2.Text = "addition Name:";
            // 
            // additionCountLabel2
            // 
            additionCountLabel2.AutoSize = true;
            additionCountLabel2.Location = new System.Drawing.Point(35, 105);
            additionCountLabel2.Name = "additionCountLabel2";
            additionCountLabel2.Size = new System.Drawing.Size(103, 17);
            additionCountLabel2.TabIndex = 28;
            additionCountLabel2.Text = "addition Count:";
            // 
            // costLabel2
            // 
            costLabel2.AutoSize = true;
            costLabel2.Location = new System.Drawing.Point(35, 133);
            costLabel2.Name = "costLabel2";
            costLabel2.Size = new System.Drawing.Size(38, 17);
            costLabel2.TabIndex = 30;
            costLabel2.Text = "cost:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(idLabel1);
            this.groupBox3.Controls.Add(this.cbIdEdit);
            this.groupBox3.Controls.Add(additionNameLabel2);
            this.groupBox3.Controls.Add(this.tbAdditionNameEdit);
            this.groupBox3.Controls.Add(additionCountLabel2);
            this.groupBox3.Controls.Add(this.tbAdditionCountEdit);
            this.groupBox3.Controls.Add(costLabel2);
            this.groupBox3.Controls.Add(this.tbCostEdit);
            this.groupBox3.Controls.Add(this.btnEditAddition);
            this.groupBox3.Location = new System.Drawing.Point(671, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 251);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // cbIdEdit
            // 
            this.cbIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "id", true));
            this.cbIdEdit.FormattingEnabled = true;
            this.cbIdEdit.Location = new System.Drawing.Point(144, 43);
            this.cbIdEdit.Name = "cbIdEdit";
            this.cbIdEdit.Size = new System.Drawing.Size(136, 24);
            this.cbIdEdit.TabIndex = 25;
            this.cbIdEdit.TextChanged += new System.EventHandler(this.cbIdEdit_TextChanged);
            this.cbIdEdit.Click += new System.EventHandler(this.cbIdEdit_Click);
            // 
            // additionsBindingSource
            // 
            this.additionsBindingSource.DataMember = "Additions";
            this.additionsBindingSource.DataSource = this.mugDBDataSet;
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAdditionNameEdit
            // 
            this.tbAdditionNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionName", true));
            this.tbAdditionNameEdit.Location = new System.Drawing.Point(144, 74);
            this.tbAdditionNameEdit.Name = "tbAdditionNameEdit";
            this.tbAdditionNameEdit.Size = new System.Drawing.Size(136, 22);
            this.tbAdditionNameEdit.TabIndex = 27;
            // 
            // tbAdditionCountEdit
            // 
            this.tbAdditionCountEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionCount", true));
            this.tbAdditionCountEdit.Location = new System.Drawing.Point(144, 102);
            this.tbAdditionCountEdit.Name = "tbAdditionCountEdit";
            this.tbAdditionCountEdit.Size = new System.Drawing.Size(136, 22);
            this.tbAdditionCountEdit.TabIndex = 29;
            // 
            // tbCostEdit
            // 
            this.tbCostEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "cost", true));
            this.tbCostEdit.Location = new System.Drawing.Point(144, 130);
            this.tbCostEdit.Name = "tbCostEdit";
            this.tbCostEdit.Size = new System.Drawing.Size(136, 22);
            this.tbCostEdit.TabIndex = 31;
            // 
            // btnEditAddition
            // 
            this.btnEditAddition.Location = new System.Drawing.Point(38, 192);
            this.btnEditAddition.Name = "btnEditAddition";
            this.btnEditAddition.Size = new System.Drawing.Size(242, 39);
            this.btnEditAddition.TabIndex = 24;
            this.btnEditAddition.Text = "Edit";
            this.btnEditAddition.UseVisualStyleBackColor = true;
            this.btnEditAddition.Click += new System.EventHandler(this.btnEditAddition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(this.cbIdDelete);
            this.groupBox2.Controls.Add(additionNameLabel1);
            this.groupBox2.Controls.Add(this.tbAdditionNameDelete);
            this.groupBox2.Controls.Add(additionCountLabel1);
            this.groupBox2.Controls.Add(this.tbAdditionCountDelete);
            this.groupBox2.Controls.Add(costLabel1);
            this.groupBox2.Controls.Add(this.tbCostDelete);
            this.groupBox2.Controls.Add(this.btnDeleteAddition);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 251);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // cbIdDelete
            // 
            this.cbIdDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "id", true));
            this.cbIdDelete.FormattingEnabled = true;
            this.cbIdDelete.Location = new System.Drawing.Point(133, 43);
            this.cbIdDelete.Name = "cbIdDelete";
            this.cbIdDelete.Size = new System.Drawing.Size(147, 24);
            this.cbIdDelete.TabIndex = 15;
            this.cbIdDelete.TextChanged += new System.EventHandler(this.cbIdDelete_TextChanged);
            this.cbIdDelete.Click += new System.EventHandler(this.cbIdDelete_Click);
            // 
            // tbAdditionNameDelete
            // 
            this.tbAdditionNameDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionName", true));
            this.tbAdditionNameDelete.Enabled = false;
            this.tbAdditionNameDelete.Location = new System.Drawing.Point(133, 74);
            this.tbAdditionNameDelete.Name = "tbAdditionNameDelete";
            this.tbAdditionNameDelete.Size = new System.Drawing.Size(147, 22);
            this.tbAdditionNameDelete.TabIndex = 17;
            // 
            // tbAdditionCountDelete
            // 
            this.tbAdditionCountDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionCount", true));
            this.tbAdditionCountDelete.Enabled = false;
            this.tbAdditionCountDelete.Location = new System.Drawing.Point(133, 102);
            this.tbAdditionCountDelete.Name = "tbAdditionCountDelete";
            this.tbAdditionCountDelete.Size = new System.Drawing.Size(147, 22);
            this.tbAdditionCountDelete.TabIndex = 19;
            // 
            // tbCostDelete
            // 
            this.tbCostDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "cost", true));
            this.tbCostDelete.Enabled = false;
            this.tbCostDelete.Location = new System.Drawing.Point(133, 130);
            this.tbCostDelete.Name = "tbCostDelete";
            this.tbCostDelete.Size = new System.Drawing.Size(147, 22);
            this.tbCostDelete.TabIndex = 21;
            // 
            // btnDeleteAddition
            // 
            this.btnDeleteAddition.Location = new System.Drawing.Point(25, 192);
            this.btnDeleteAddition.Name = "btnDeleteAddition";
            this.btnDeleteAddition.Size = new System.Drawing.Size(255, 39);
            this.btnDeleteAddition.TabIndex = 14;
            this.btnDeleteAddition.Text = "Delete";
            this.btnDeleteAddition.UseVisualStyleBackColor = true;
            this.btnDeleteAddition.Click += new System.EventHandler(this.btnDeleteAddition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(additionNameLabel);
            this.groupBox1.Controls.Add(this.tbAdditionNameAdd);
            this.groupBox1.Controls.Add(additionCountLabel);
            this.groupBox1.Controls.Add(this.tbAdditionCountAdd);
            this.groupBox1.Controls.Add(costLabel);
            this.groupBox1.Controls.Add(this.tbCostAdd);
            this.groupBox1.Controls.Add(this.btnAddAddition);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 249);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // tbAdditionNameAdd
            // 
            this.tbAdditionNameAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionName", true));
            this.tbAdditionNameAdd.Location = new System.Drawing.Point(131, 46);
            this.tbAdditionNameAdd.Name = "tbAdditionNameAdd";
            this.tbAdditionNameAdd.Size = new System.Drawing.Size(168, 22);
            this.tbAdditionNameAdd.TabIndex = 14;
            // 
            // tbAdditionCountAdd
            // 
            this.tbAdditionCountAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "additionCount", true));
            this.tbAdditionCountAdd.Location = new System.Drawing.Point(131, 74);
            this.tbAdditionCountAdd.Name = "tbAdditionCountAdd";
            this.tbAdditionCountAdd.Size = new System.Drawing.Size(168, 22);
            this.tbAdditionCountAdd.TabIndex = 16;
            // 
            // tbCostAdd
            // 
            this.tbCostAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.additionsBindingSource, "cost", true));
            this.tbCostAdd.Location = new System.Drawing.Point(131, 102);
            this.tbCostAdd.Name = "tbCostAdd";
            this.tbCostAdd.Size = new System.Drawing.Size(168, 22);
            this.tbCostAdd.TabIndex = 18;
            // 
            // btnAddAddition
            // 
            this.btnAddAddition.Location = new System.Drawing.Point(19, 190);
            this.btnAddAddition.Name = "btnAddAddition";
            this.btnAddAddition.Size = new System.Drawing.Size(280, 39);
            this.btnAddAddition.TabIndex = 11;
            this.btnAddAddition.Text = "Add";
            this.btnAddAddition.UseVisualStyleBackColor = true;
            this.btnAddAddition.Click += new System.EventHandler(this.btnAddAddition_Click);
            // 
            // btnBackAdditionManage
            // 
            this.btnBackAdditionManage.Location = new System.Drawing.Point(13, 274);
            this.btnBackAdditionManage.Name = "btnBackAdditionManage";
            this.btnBackAdditionManage.Size = new System.Drawing.Size(76, 30);
            this.btnBackAdditionManage.TabIndex = 29;
            this.btnBackAdditionManage.Text = "< Back";
            this.btnBackAdditionManage.UseVisualStyleBackColor = true;
            this.btnBackAdditionManage.Click += new System.EventHandler(this.btnBackAdditionManage_Click);
            // 
            // additionsTableAdapter
            // 
            this.additionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionsTableAdapter = this.additionsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderCompositionTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserOrderTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormManageAdditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackAdditionManage);
            this.Name = "FormManageAdditions";
            this.Text = "FormManageAdditions";
            this.Load += new System.EventHandler(this.FormManageAdditions_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditAddition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteAddition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAddition;
        private System.Windows.Forms.Button btnBackAdditionManage;
        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource additionsBindingSource;
        private MugDBDataSetTableAdapters.AdditionsTableAdapter additionsTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbIdEdit;
        private System.Windows.Forms.TextBox tbAdditionNameEdit;
        private System.Windows.Forms.TextBox tbAdditionCountEdit;
        private System.Windows.Forms.TextBox tbCostEdit;
        private System.Windows.Forms.ComboBox cbIdDelete;
        private System.Windows.Forms.TextBox tbAdditionNameDelete;
        private System.Windows.Forms.TextBox tbAdditionCountDelete;
        private System.Windows.Forms.TextBox tbCostDelete;
        private System.Windows.Forms.TextBox tbAdditionNameAdd;
        private System.Windows.Forms.TextBox tbAdditionCountAdd;
        private System.Windows.Forms.TextBox tbCostAdd;
    }
}