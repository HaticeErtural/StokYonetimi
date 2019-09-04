using Sy.Business.Repository;
using Sy.Core.Entities;
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
            _productRepo = new Repository<Product, Guid>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
