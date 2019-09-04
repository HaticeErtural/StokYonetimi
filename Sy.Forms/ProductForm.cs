using Sy.Business.Repository;
using Sy.Core.Abstract;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        public ProductForm()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();


        }
        private void ListeyiDoldur(string search = " ")
        {
            var data = _productRepo.Query(x => x.ProductName.Contains(search))
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    UnitPrice = x.UnitPrice,
                    CriticStock = x.CriticStock,
                    ProductName = x.ProductName
                }).ToList();
            lbUrunler.DataSource = data;
            lbUrunler.DisplayMember = "Display";

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productRepo.Insert(new Product()
                {
                    ProductName = txtUrunAd.Text,
                    UnitPrice = nFiyat.Value,
                    CriticStock = Convert.ToInt32(nKririkStok.Value)


                });
                MessageBox.Show("Ürün ekleme işlemi başarılıdır");
                ListeyiDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
        }
    }
}
