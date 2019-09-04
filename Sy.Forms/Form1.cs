using Sy.Business.Repository;
using Sy.Core.ComplexTypes;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Forms.Auth;
using System;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;//classlar IEntity tipinde olmalı 
        public Form1()
        {
            
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
            groupBox1.Visible = true;
            lblGirisBilgi.Visible = false;
            menuStrip1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo==null)
            {
                groupBox1.Visible = true;
                lblGirisBilgi.Visible = false;

            }
            else
            {
                groupBox1.Visible = false;
                lblGirisBilgi.Visible = true;
                lblGirisBilgi.Text = StockSettings.UserInfo.Display;
                if (StockSettings.UserInfo.ApplicationRole== ApplicationRole.Customer)
                {
                    ürünlerToolStripMenuItem.Visible = false;
                    müşterilerToolStripMenuItem.Visible = false;



                }
                menuStrip1.Visible = true;
               

            }
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
