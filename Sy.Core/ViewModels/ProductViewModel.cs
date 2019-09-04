using Sy.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Reguired, StringLength(100)]
        public string ProductName { get; set; }

        [Range(0, 99999999)]
        public decimal UnitPrice { get; set; }

        public int CriticStock { get; set; } = 10;

        public string Display => $"{this.ProductName} -{this.UnitPrice:c2}";//tek satırda get yazabilmek için

    }
}
