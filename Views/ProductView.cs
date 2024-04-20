using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViwEvents();
        }

        private void AssociateAndRaiseViwEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Add New Product";

            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Edit new product";

            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabProductDetail);
                    tabControl1.TabPages.Add(tabProductList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
            };
        }

        public string ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CategoryId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProviderId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StockQuantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProductView.ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }
        public string Productid
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string Category
        {
            get { return TxtProductCategory.Text; }
            set { TxtProductCategory.Text = value; }
        }

        public string Provider
        {
            get { return TxtProductProvider.Text; }
            set { TxtProductProvider.Text = value; }
        }

        public string price
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }
        }

        public string Stock
        {
            get { return TxtProductCategory.Text; }
            set { TxtProductCategory.Text = value; }
        }

        public bool isSuccessful { get; private set; }
        public static Form? parentContainer { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;

            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        public static implicit operator ProductView(PayModeView v)
        {
            throw new NotImplementedException();
        }
    }
}