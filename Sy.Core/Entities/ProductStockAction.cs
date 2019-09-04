using Sy.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Entities
{
    [Table(name:"ProductStockActions")]
    public class ProductStockAction: BaseEntity<long>
    {
       
        public Guid ProductId { get; set; }

        
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey(nameof(ProductId))]//name of ile ıd nin adını  yanlış yazma ihitimali ortadan kalkar
        public virtual Product Product { get; set; }


    }
}
