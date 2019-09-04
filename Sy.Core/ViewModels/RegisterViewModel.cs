using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.ViewModels
{
    public class RegisterViewModel
    {
        private string _email;
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string Email
        {
            get { return _email; }
            set { _email = value.ToLower(); }
        }


    }
}
