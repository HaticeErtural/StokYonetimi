using Sy.Core.Abstract;//base entity ekledikten sonra
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Entities
{
    [Table( name:"Products")]
    public class Product :BaseEntity<Guid >//farklı farklı oluşması için
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [Reguired,StringLength(100)]//ürünün productnamei boş bırakılamaz
        public string ProductName { get; set; }

        [Range (0,99999999)]
        public decimal UnitPrice { get; set; }

        public int CriticStock { get; set; } = 10; //her ürün için kritik stok miktarı var çok satılan ve satılmayana ürüne göre belirleniyor

        public virtual ICollection<ProductStockAction> ProductStockActions { get; set; } = new HashSet<ProductStockAction>();

    }
}
