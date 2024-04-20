namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            tabPageProvidersList = new TabPage();
            tabPageProvidersDetail = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProviders = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtContactEmail = new TextBox();
            TxtContactPhone = new TextBox();
            TxtContactName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtProviderName = new TextBox();
            TxtProvidersId = new TextBox();
            BtnCancels = new Button();
            BtnSaves = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            tabPageProvidersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
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
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 35);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 0;
            label1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Location = new Point(4, 24);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 322);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(label6);
            tabPageProvidersDetail.Controls.Add(label7);
            tabPageProvidersDetail.Controls.Add(TxtContactEmail);
            tabPageProvidersDetail.Controls.Add(TxtContactPhone);
            tabPageProvidersDetail.Controls.Add(TxtContactName);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(TxtProviderName);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Controls.Add(BtnCancels);
            tabPageProvidersDetail.Controls.Add(BtnSaves);
            tabPageProvidersDetail.Location = new Point(4, 24);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 322);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(605, 268);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(158, 43);
            BtnClose.TabIndex = 19;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(605, 205);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(158, 43);
            BtnDelete.TabIndex = 18;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(605, 142);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(158, 43);
            BtnEdit.TabIndex = 17;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(605, 77);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(158, 43);
            BtnNew.TabIndex = 16;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(34, 77);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.Size = new Size(555, 238);
            DgProviders.TabIndex = 15;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(514, 20);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 42);
            BtnSearch.TabIndex = 14;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(34, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(465, 23);
            TxtSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 8);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 12;
            label2.Text = "Search Provider";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 109);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 24;
            label6.Text = "Providers Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(510, 15);
            label7.Name = "label7";
            label7.Size = new Size(160, 17);
            label7.TabIndex = 23;
            label7.Text = "Providers Contact Phone";
            // 
            // TxtContactEmail
            // 
            TxtContactEmail.Location = new Point(366, 135);
            TxtContactEmail.Name = "TxtContactEmail";
            TxtContactEmail.PlaceholderText = "Providers Email";
            TxtContactEmail.Size = new Size(272, 23);
            TxtContactEmail.TabIndex = 22;
            // 
            // TxtContactPhone
            // 
            TxtContactPhone.Location = new Point(510, 35);
            TxtContactPhone.Name = "TxtContactPhone";
            TxtContactPhone.PlaceholderText = "Providers Contact Phone";
            TxtContactPhone.Size = new Size(272, 23);
            TxtContactPhone.TabIndex = 21;
            // 
            // TxtContactName
            // 
            TxtContactName.Location = new Point(22, 135);
            TxtContactName.Name = "TxtContactName";
            TxtContactName.PlaceholderText = "Providers Contact Name";
            TxtContactName.Size = new Size(272, 23);
            TxtContactName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 109);
            label5.Name = "label5";
            label5.Size = new Size(157, 17);
            label5.TabIndex = 19;
            label5.Text = "Providers Contact Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 15);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 18;
            label4.Text = "Providers Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 15);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 17;
            label3.Text = "Providers Id";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(198, 35);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Providers Name";
            TxtProviderName.Size = new Size(272, 23);
            TxtProviderName.TabIndex = 16;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(22, 35);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(156, 23);
            TxtProvidersId.TabIndex = 15;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancels
            // 
            BtnCancels.Image = Properties.Resources.search_small;
            BtnCancels.Location = new Point(151, 254);
            BtnCancels.Name = "BtnCancels";
            BtnCancels.Size = new Size(99, 60);
            BtnCancels.TabIndex = 14;
            BtnCancels.UseVisualStyleBackColor = true;
            // 
            // BtnSaves
            // 
            BtnSaves.Image = Properties.Resources.save;
            BtnSaves.Location = new Point(22, 254);
            BtnSaves.Name = "BtnSaves";
            BtnSaves.Size = new Size(99, 60);
            BtnSaves.TabIndex = 13;
            BtnSaves.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProductsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProviders;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox TxtContactEmail;
        private TextBox TxtContactPhone;
        private TextBox TxtContactName;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProviderName;
        private TextBox TxtProvidersId;
        private Button BtnCancels;
        private Button BtnSaves;
    }
}