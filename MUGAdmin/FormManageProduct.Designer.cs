namespace MUGAdmin
{
    partial class FormManageProduct
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
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productImageLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label volumeLabel;
            System.Windows.Forms.Label compositionLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label productNameLabel1;
            System.Windows.Forms.Label gradeLabel1;
            System.Windows.Forms.Label volumeLabel1;
            System.Windows.Forms.Label compositionLabel1;
            System.Windows.Forms.Label costLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label productNameLabel2;
            System.Windows.Forms.Label gradeLabel2;
            System.Windows.Forms.Label volumeLabel2;
            System.Windows.Forms.Label compositionLabel2;
            System.Windows.Forms.Label costLabel2;
            System.Windows.Forms.Label label2;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFileUpdate = new System.Windows.Forms.Button();
            this.cbIdEdit = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mugDBDataSet = new MUGAdmin.MugDBDataSet();
            this.tbProductNameEdit = new System.Windows.Forms.TextBox();
            this.tbGradeEdit = new System.Windows.Forms.TextBox();
            this.tbVolumeEdit = new System.Windows.Forms.TextBox();
            this.tbCompositionEdit = new System.Windows.Forms.TextBox();
            this.tbCostEdit = new System.Windows.Forms.TextBox();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIdDelete = new System.Windows.Forms.ComboBox();
            this.tbProductNameDelete = new System.Windows.Forms.TextBox();
            this.tbGradeDelete = new System.Windows.Forms.TextBox();
            this.tbVolumeDelete = new System.Windows.Forms.TextBox();
            this.tbCompositionDelete = new System.Windows.Forms.TextBox();
            this.tbCostDelete = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenFileAdd = new System.Windows.Forms.Button();
            this.tbProductNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbGradeAdd = new System.Windows.Forms.TextBox();
            this.tbVolumeAdd = new System.Windows.Forms.TextBox();
            this.tbCompositionAdd = new System.Windows.Forms.TextBox();
            this.tbCostAdd = new System.Windows.Forms.TextBox();
            this.btnBackUserManage = new System.Windows.Forms.Button();
            this.productsTableAdapter = new MUGAdmin.MugDBDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            productNameLabel = new System.Windows.Forms.Label();
            productImageLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            volumeLabel = new System.Windows.Forms.Label();
            compositionLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            productNameLabel1 = new System.Windows.Forms.Label();
            gradeLabel1 = new System.Windows.Forms.Label();
            volumeLabel1 = new System.Windows.Forms.Label();
            compositionLabel1 = new System.Windows.Forms.Label();
            costLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            productNameLabel2 = new System.Windows.Forms.Label();
            gradeLabel2 = new System.Windows.Forms.Label();
            volumeLabel2 = new System.Windows.Forms.Label();
            compositionLabel2 = new System.Windows.Forms.Label();
            costLabel2 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 44);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(101, 17);
            productNameLabel.TabIndex = 13;
            productNameLabel.Text = "product Name:";
            // 
            // productImageLabel
            // 
            productImageLabel.AutoSize = true;
            productImageLabel.Location = new System.Drawing.Point(12, 69);
            productImageLabel.Name = "productImageLabel";
            productImageLabel.Size = new System.Drawing.Size(102, 17);
            productImageLabel.TabIndex = 15;
            productImageLabel.Text = "product Image:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(12, 128);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(49, 17);
            gradeLabel.TabIndex = 17;
            gradeLabel.Text = "grade:";
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new System.Drawing.Point(12, 156);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new System.Drawing.Size(57, 17);
            volumeLabel.TabIndex = 19;
            volumeLabel.Text = "volume:";
            // 
            // compositionLabel
            // 
            compositionLabel.AutoSize = true;
            compositionLabel.Location = new System.Drawing.Point(12, 184);
            compositionLabel.Name = "compositionLabel";
            compositionLabel.Size = new System.Drawing.Size(87, 17);
            compositionLabel.TabIndex = 21;
            compositionLabel.Text = "composition:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(12, 212);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(38, 17);
            costLabel.TabIndex = 23;
            costLabel.Text = "cost:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 14;
            idLabel.Text = "id:";
            // 
            // productNameLabel1
            // 
            productNameLabel1.AutoSize = true;
            productNameLabel1.Location = new System.Drawing.Point(12, 71);
            productNameLabel1.Name = "productNameLabel1";
            productNameLabel1.Size = new System.Drawing.Size(101, 17);
            productNameLabel1.TabIndex = 16;
            productNameLabel1.Text = "product Name:";
            // 
            // gradeLabel1
            // 
            gradeLabel1.AutoSize = true;
            gradeLabel1.Location = new System.Drawing.Point(12, 103);
            gradeLabel1.Name = "gradeLabel1";
            gradeLabel1.Size = new System.Drawing.Size(49, 17);
            gradeLabel1.TabIndex = 20;
            gradeLabel1.Text = "grade:";
            // 
            // volumeLabel1
            // 
            volumeLabel1.AutoSize = true;
            volumeLabel1.Location = new System.Drawing.Point(12, 131);
            volumeLabel1.Name = "volumeLabel1";
            volumeLabel1.Size = new System.Drawing.Size(57, 17);
            volumeLabel1.TabIndex = 22;
            volumeLabel1.Text = "volume:";
            // 
            // compositionLabel1
            // 
            compositionLabel1.AutoSize = true;
            compositionLabel1.Location = new System.Drawing.Point(12, 159);
            compositionLabel1.Name = "compositionLabel1";
            compositionLabel1.Size = new System.Drawing.Size(87, 17);
            compositionLabel1.TabIndex = 24;
            compositionLabel1.Text = "composition:";
            // 
            // costLabel1
            // 
            costLabel1.AutoSize = true;
            costLabel1.Location = new System.Drawing.Point(12, 187);
            costLabel1.Name = "costLabel1";
            costLabel1.Size = new System.Drawing.Size(38, 17);
            costLabel1.TabIndex = 26;
            costLabel1.Text = "cost:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(14, 40);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 24;
            idLabel1.Text = "id:";
            // 
            // productNameLabel2
            // 
            productNameLabel2.AutoSize = true;
            productNameLabel2.Location = new System.Drawing.Point(18, 119);
            productNameLabel2.Name = "productNameLabel2";
            productNameLabel2.Size = new System.Drawing.Size(101, 17);
            productNameLabel2.TabIndex = 26;
            productNameLabel2.Text = "product Name:";
            // 
            // gradeLabel2
            // 
            gradeLabel2.AutoSize = true;
            gradeLabel2.Location = new System.Drawing.Point(18, 151);
            gradeLabel2.Name = "gradeLabel2";
            gradeLabel2.Size = new System.Drawing.Size(49, 17);
            gradeLabel2.TabIndex = 30;
            gradeLabel2.Text = "grade:";
            // 
            // volumeLabel2
            // 
            volumeLabel2.AutoSize = true;
            volumeLabel2.Location = new System.Drawing.Point(18, 179);
            volumeLabel2.Name = "volumeLabel2";
            volumeLabel2.Size = new System.Drawing.Size(57, 17);
            volumeLabel2.TabIndex = 32;
            volumeLabel2.Text = "volume:";
            // 
            // compositionLabel2
            // 
            compositionLabel2.AutoSize = true;
            compositionLabel2.Location = new System.Drawing.Point(18, 207);
            compositionLabel2.Name = "compositionLabel2";
            compositionLabel2.Size = new System.Drawing.Size(87, 17);
            compositionLabel2.TabIndex = 34;
            compositionLabel2.Text = "composition:";
            // 
            // costLabel2
            // 
            costLabel2.AutoSize = true;
            costLabel2.Location = new System.Drawing.Point(18, 235);
            costLabel2.Name = "costLabel2";
            costLabel2.Size = new System.Drawing.Size(38, 17);
            costLabel2.TabIndex = 36;
            costLabel2.Text = "cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 17);
            label2.TabIndex = 38;
            label2.Text = "product Image:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnOpenFileUpdate);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(idLabel1);
            this.groupBox3.Controls.Add(this.cbIdEdit);
            this.groupBox3.Controls.Add(productNameLabel2);
            this.groupBox3.Controls.Add(this.tbProductNameEdit);
            this.groupBox3.Controls.Add(gradeLabel2);
            this.groupBox3.Controls.Add(this.tbGradeEdit);
            this.groupBox3.Controls.Add(volumeLabel2);
            this.groupBox3.Controls.Add(this.tbVolumeEdit);
            this.groupBox3.Controls.Add(compositionLabel2);
            this.groupBox3.Controls.Add(this.tbCompositionEdit);
            this.groupBox3.Controls.Add(costLabel2);
            this.groupBox3.Controls.Add(this.tbCostEdit);
            this.groupBox3.Controls.Add(this.btnProductEdit);
            this.groupBox3.Location = new System.Drawing.Point(698, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 325);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 40;
            // 
            // btnOpenFileUpdate
            // 
            this.btnOpenFileUpdate.Location = new System.Drawing.Point(122, 69);
            this.btnOpenFileUpdate.Name = "btnOpenFileUpdate";
            this.btnOpenFileUpdate.Size = new System.Drawing.Size(193, 27);
            this.btnOpenFileUpdate.TabIndex = 39;
            this.btnOpenFileUpdate.Text = "Open...";
            this.btnOpenFileUpdate.UseVisualStyleBackColor = true;
            this.btnOpenFileUpdate.Click += new System.EventHandler(this.btnOpenFileUpdate_Click);
            // 
            // cbIdEdit
            // 
            this.cbIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "id", true));
            this.cbIdEdit.FormattingEnabled = true;
            this.cbIdEdit.Location = new System.Drawing.Point(122, 37);
            this.cbIdEdit.Name = "cbIdEdit";
            this.cbIdEdit.Size = new System.Drawing.Size(189, 24);
            this.cbIdEdit.TabIndex = 25;
            this.cbIdEdit.TextChanged += new System.EventHandler(this.cbIdEdit_TextChanged);
            this.cbIdEdit.Click += new System.EventHandler(this.cbIdEdit_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mugDBDataSet;
            // 
            // mugDBDataSet
            // 
            this.mugDBDataSet.DataSetName = "MugDBDataSet";
            this.mugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductNameEdit
            // 
            this.tbProductNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "productName", true));
            this.tbProductNameEdit.Location = new System.Drawing.Point(126, 120);
            this.tbProductNameEdit.Name = "tbProductNameEdit";
            this.tbProductNameEdit.Size = new System.Drawing.Size(189, 22);
            this.tbProductNameEdit.TabIndex = 27;
            // 
            // tbGradeEdit
            // 
            this.tbGradeEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "grade", true));
            this.tbGradeEdit.Location = new System.Drawing.Point(126, 148);
            this.tbGradeEdit.Name = "tbGradeEdit";
            this.tbGradeEdit.Size = new System.Drawing.Size(189, 22);
            this.tbGradeEdit.TabIndex = 31;
            // 
            // tbVolumeEdit
            // 
            this.tbVolumeEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "volume", true));
            this.tbVolumeEdit.Location = new System.Drawing.Point(126, 176);
            this.tbVolumeEdit.Name = "tbVolumeEdit";
            this.tbVolumeEdit.Size = new System.Drawing.Size(189, 22);
            this.tbVolumeEdit.TabIndex = 33;
            // 
            // tbCompositionEdit
            // 
            this.tbCompositionEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "composition", true));
            this.tbCompositionEdit.Location = new System.Drawing.Point(126, 204);
            this.tbCompositionEdit.Name = "tbCompositionEdit";
            this.tbCompositionEdit.Size = new System.Drawing.Size(189, 22);
            this.tbCompositionEdit.TabIndex = 35;
            // 
            // tbCostEdit
            // 
            this.tbCostEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "cost", true));
            this.tbCostEdit.Location = new System.Drawing.Point(126, 232);
            this.tbCostEdit.Name = "tbCostEdit";
            this.tbCostEdit.Size = new System.Drawing.Size(189, 22);
            this.tbCostEdit.TabIndex = 37;
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(17, 271);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(294, 39);
            this.btnProductEdit.TabIndex = 24;
            this.btnProductEdit.Text = "Edit";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(this.cbIdDelete);
            this.groupBox2.Controls.Add(productNameLabel1);
            this.groupBox2.Controls.Add(this.tbProductNameDelete);
            this.groupBox2.Controls.Add(gradeLabel1);
            this.groupBox2.Controls.Add(this.tbGradeDelete);
            this.groupBox2.Controls.Add(volumeLabel1);
            this.groupBox2.Controls.Add(this.tbVolumeDelete);
            this.groupBox2.Controls.Add(compositionLabel1);
            this.groupBox2.Controls.Add(this.tbCompositionDelete);
            this.groupBox2.Controls.Add(costLabel1);
            this.groupBox2.Controls.Add(this.tbCostDelete);
            this.groupBox2.Controls.Add(this.btnUserDelete);
            this.groupBox2.Location = new System.Drawing.Point(355, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 325);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // cbIdDelete
            // 
            this.cbIdDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "id", true));
            this.cbIdDelete.FormattingEnabled = true;
            this.cbIdDelete.Location = new System.Drawing.Point(116, 37);
            this.cbIdDelete.Name = "cbIdDelete";
            this.cbIdDelete.Size = new System.Drawing.Size(190, 24);
            this.cbIdDelete.TabIndex = 15;
            this.cbIdDelete.TextChanged += new System.EventHandler(this.cbIdDelete_TextChanged);
            this.cbIdDelete.Click += new System.EventHandler(this.cbIdDelete_Click);
            // 
            // tbProductNameDelete
            // 
            this.tbProductNameDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "productName", true));
            this.tbProductNameDelete.Enabled = false;
            this.tbProductNameDelete.Location = new System.Drawing.Point(116, 68);
            this.tbProductNameDelete.Name = "tbProductNameDelete";
            this.tbProductNameDelete.Size = new System.Drawing.Size(190, 22);
            this.tbProductNameDelete.TabIndex = 17;
            // 
            // tbGradeDelete
            // 
            this.tbGradeDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "grade", true));
            this.tbGradeDelete.Enabled = false;
            this.tbGradeDelete.Location = new System.Drawing.Point(116, 100);
            this.tbGradeDelete.Name = "tbGradeDelete";
            this.tbGradeDelete.Size = new System.Drawing.Size(190, 22);
            this.tbGradeDelete.TabIndex = 21;
            // 
            // tbVolumeDelete
            // 
            this.tbVolumeDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "volume", true));
            this.tbVolumeDelete.Enabled = false;
            this.tbVolumeDelete.Location = new System.Drawing.Point(116, 128);
            this.tbVolumeDelete.Name = "tbVolumeDelete";
            this.tbVolumeDelete.Size = new System.Drawing.Size(190, 22);
            this.tbVolumeDelete.TabIndex = 23;
            // 
            // tbCompositionDelete
            // 
            this.tbCompositionDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "composition", true));
            this.tbCompositionDelete.Enabled = false;
            this.tbCompositionDelete.Location = new System.Drawing.Point(116, 156);
            this.tbCompositionDelete.Name = "tbCompositionDelete";
            this.tbCompositionDelete.Size = new System.Drawing.Size(190, 22);
            this.tbCompositionDelete.TabIndex = 25;
            // 
            // tbCostDelete
            // 
            this.tbCostDelete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "cost", true));
            this.tbCostDelete.Enabled = false;
            this.tbCostDelete.Location = new System.Drawing.Point(116, 184);
            this.tbCostDelete.Name = "tbCostDelete";
            this.tbCostDelete.Size = new System.Drawing.Size(190, 22);
            this.tbCostDelete.TabIndex = 27;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(15, 271);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(291, 39);
            this.btnUserDelete.TabIndex = 14;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpenFileAdd);
            this.groupBox1.Controls.Add(productNameLabel);
            this.groupBox1.Controls.Add(this.tbProductNameAdd);
            this.groupBox1.Controls.Add(productImageLabel);
            this.groupBox1.Controls.Add(gradeLabel);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.tbGradeAdd);
            this.groupBox1.Controls.Add(volumeLabel);
            this.groupBox1.Controls.Add(this.tbVolumeAdd);
            this.groupBox1.Controls.Add(compositionLabel);
            this.groupBox1.Controls.Add(this.tbCompositionAdd);
            this.groupBox1.Controls.Add(costLabel);
            this.groupBox1.Controls.Add(this.tbCostAdd);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 325);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 26;
            // 
            // btnOpenFileAdd
            // 
            this.btnOpenFileAdd.Location = new System.Drawing.Point(120, 69);
            this.btnOpenFileAdd.Name = "btnOpenFileAdd";
            this.btnOpenFileAdd.Size = new System.Drawing.Size(193, 27);
            this.btnOpenFileAdd.TabIndex = 25;
            this.btnOpenFileAdd.Text = "Open...";
            this.btnOpenFileAdd.UseVisualStyleBackColor = true;
            this.btnOpenFileAdd.Click += new System.EventHandler(this.btnOpenFileAdd_Click);
            // 
            // tbProductNameAdd
            // 
            this.tbProductNameAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "productName", true));
            this.tbProductNameAdd.Location = new System.Drawing.Point(120, 41);
            this.tbProductNameAdd.Name = "tbProductNameAdd";
            this.tbProductNameAdd.Size = new System.Drawing.Size(193, 22);
            this.tbProductNameAdd.TabIndex = 14;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(15, 271);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(298, 39);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbGradeAdd
            // 
            this.tbGradeAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "grade", true));
            this.tbGradeAdd.Location = new System.Drawing.Point(120, 125);
            this.tbGradeAdd.Name = "tbGradeAdd";
            this.tbGradeAdd.Size = new System.Drawing.Size(193, 22);
            this.tbGradeAdd.TabIndex = 18;
            // 
            // tbVolumeAdd
            // 
            this.tbVolumeAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "volume", true));
            this.tbVolumeAdd.Location = new System.Drawing.Point(120, 153);
            this.tbVolumeAdd.Name = "tbVolumeAdd";
            this.tbVolumeAdd.Size = new System.Drawing.Size(193, 22);
            this.tbVolumeAdd.TabIndex = 20;
            // 
            // tbCompositionAdd
            // 
            this.tbCompositionAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "composition", true));
            this.tbCompositionAdd.Location = new System.Drawing.Point(120, 181);
            this.tbCompositionAdd.Name = "tbCompositionAdd";
            this.tbCompositionAdd.Size = new System.Drawing.Size(193, 22);
            this.tbCompositionAdd.TabIndex = 22;
            // 
            // tbCostAdd
            // 
            this.tbCostAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "cost", true));
            this.tbCostAdd.Location = new System.Drawing.Point(120, 209);
            this.tbCostAdd.Name = "tbCostAdd";
            this.tbCostAdd.Size = new System.Drawing.Size(193, 22);
            this.tbCostAdd.TabIndex = 24;
            // 
            // btnBackUserManage
            // 
            this.btnBackUserManage.Location = new System.Drawing.Point(14, 361);
            this.btnBackUserManage.Name = "btnBackUserManage";
            this.btnBackUserManage.Size = new System.Drawing.Size(76, 30);
            this.btnBackUserManage.TabIndex = 29;
            this.btnBackUserManage.Text = "< Back";
            this.btnBackUserManage.UseVisualStyleBackColor = true;
            this.btnBackUserManage.Click += new System.EventHandler(this.btnBackUserManage_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderCompositionTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MUGAdmin.MugDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserOrderTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackUserManage);
            this.Name = "FormManageProduct";
            this.Text = "FormManageProduct";
            this.Load += new System.EventHandler(this.FormManageProduct_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnBackUserManage;
        private MugDBDataSet mugDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MugDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private MugDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnOpenFileAdd;
        private System.Windows.Forms.TextBox tbProductNameAdd;
        private System.Windows.Forms.TextBox tbGradeAdd;
        private System.Windows.Forms.TextBox tbVolumeAdd;
        private System.Windows.Forms.TextBox tbCompositionAdd;
        private System.Windows.Forms.TextBox tbCostAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIdDelete;
        private System.Windows.Forms.TextBox tbProductNameDelete;
        private System.Windows.Forms.TextBox tbGradeDelete;
        private System.Windows.Forms.TextBox tbVolumeDelete;
        private System.Windows.Forms.TextBox tbCompositionDelete;
        private System.Windows.Forms.TextBox tbCostDelete;
        private System.Windows.Forms.ComboBox cbIdEdit;
        private System.Windows.Forms.TextBox tbProductNameEdit;
        private System.Windows.Forms.TextBox tbGradeEdit;
        private System.Windows.Forms.TextBox tbVolumeEdit;
        private System.Windows.Forms.TextBox tbCompositionEdit;
        private System.Windows.Forms.TextBox tbCostEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFileUpdate;
    }
}