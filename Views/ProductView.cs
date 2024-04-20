﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Presenters;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabProductDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
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
                tabProductDetail.Text = "Edit Product";
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

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

                tabControl1.TabPages.Remove(tabProductDetail);
                tabControl1.TabPages.Add(tabProductList);
            };
        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }

        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }

        public string CategoryId
        {
            get { return TxtProductCategory.Text; }
          //  set => TxtProductCategory.SelectValue = value;
        }

        public string ProviderId
        {
            get { return TxtProductProvider.Text; }
           //set { TxtProductProvider.SelectedValue = value; }
        }

        public string Price
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value.ToString(); }
        }

        public string StockQuantity
        {
            get { return TxtProductStockQuantity.Text; }
            set { TxtProductStockQuantity.Text = value.ToString(); }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        string IProductView.CategoryId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProductView.ProviderId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        private static ProductView instance;

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
    }
}
