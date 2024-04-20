namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabProductDetail = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtProductStockQuantity = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductCategory = new TextBox();
            TxtProductProvider = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            TxtProductId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
           // label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(BtnClose);
            tabProductList.Controls.Add(BtnDelete);
            tabProductList.Controls.Add(BtnEdit);
            tabProductList.Controls.Add(BtnNew);
            tabProductList.Controls.Add(DgProduct);
            tabProductList.Controls.Add(BtnSearch);
            tabProductList.Controls.Add(TxtSearch);
            tabProductList.Controls.Add(label2);
            tabProductList.Location = new Point(4, 24);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(792, 322);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(596, 267);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(158, 43);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(596, 204);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(158, 43);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(596, 141);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(158, 43);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(596, 76);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(158, 43);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(25, 76);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(555, 238);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(505, 19);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 42);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(25, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(465, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            //label2.Click += label2_Click;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(label8);
            tabProductDetail.Controls.Add(label7);
            tabProductDetail.Controls.Add(label6);
            tabProductDetail.Controls.Add(label5);
            tabProductDetail.Controls.Add(label4);
            tabProductDetail.Controls.Add(label3);
            tabProductDetail.Controls.Add(TxtProductStockQuantity);
            tabProductDetail.Controls.Add(TxtProductPrice);
            tabProductDetail.Controls.Add(TxtProductName);
            tabProductDetail.Controls.Add(TxtProductCategory);
            tabProductDetail.Controls.Add(TxtProductProvider);
            tabProductDetail.Controls.Add(BtnSave);
            tabProductDetail.Controls.Add(BtnCancel);
            tabProductDetail.Controls.Add(TxtProductId);
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(792, 322);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 170);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 23;
            label8.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 81);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 22;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 13);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 21;
            label6.Text = "Provider";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 170);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 20;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 81);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 19;
            label4.Text = "Product name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 13);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 18;
            label3.Text = "Product id";
            label3.UseMnemonic = false;
            // 
            // TxtProductStockQuantity
            // 
            TxtProductStockQuantity.Location = new Point(280, 195);
            TxtProductStockQuantity.Name = "TxtProductStockQuantity";
            TxtProductStockQuantity.Size = new Size(172, 23);
            TxtProductStockQuantity.TabIndex = 17;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(280, 109);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(172, 23);
            TxtProductPrice.TabIndex = 16;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(29, 109);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(172, 23);
            TxtProductName.TabIndex = 15;
            // 
            // TxtProductCategory
            // 
            TxtProductCategory.Location = new Point(29, 195);
            TxtProductCategory.Name = "TxtProductCategory";
            TxtProductCategory.Size = new Size(172, 23);
            TxtProductCategory.TabIndex = 14;
            // 
            // TxtProductProvider
            // 
            TxtProductProvider.Location = new Point(280, 34);
            TxtProductProvider.Name = "TxtProductProvider";
            TxtProductProvider.Size = new Size(172, 23);
            TxtProductProvider.TabIndex = 13;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save1;
            BtnSave.Location = new Point(32, 252);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 62);
            BtnSave.TabIndex = 12;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(143, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 62);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(29, 34);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(172, 23);
            TxtProductId.TabIndex = 10;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private TabPage tabProductDetail;
        private Label label2;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductStockQuantity;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductCategory;
        private TextBox TxtProductProvider;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtProductId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}