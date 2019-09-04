using Sy.Business.Repository;
using Sy.Core.Abstract;
using Sy.Core.Entities;//Domain modelimiz
using Sy.Core.Enums;
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


namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly IRepository<Client, int> _clientRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            var model = new RegisterViewModel()
            {
                Email = txtEmail.Text,
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Password = txtSifre.Text

            };
            var kontrol = _clientRepository.Query(x => x.Email == model.Email).Any();
            if (kontrol)
            {
                MessageBox.Show("Bu email kullanılmaktadır");
                return;
            }
            //benzersiz emailden sonra kişiyi kaydet
            var mustreiMi = !_clientRepository.Query().Any();
       
            _clientRepository.Insert(new Client()
            {
                Email = model.Email,
                Surname = model.Surname,
                Password = model.Password,
                Name = model.Name,
                ApplicationRole = mustreiMi? ApplicationRole.Customer:ApplicationRole.Admin
            });
            MessageBox.Show($"Kayıt işleminiz başarlıdır:)\n{model.Name}{model.Surname}");
            this.Close();//  O anda bulunduğu classın o anki referansına işaret eder
            //Base kalıtım aldığımız classı işaret eder this c deki pointeri çözüyor
        }
    }
}
