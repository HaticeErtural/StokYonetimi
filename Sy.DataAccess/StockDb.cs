using Sy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.DataAccess
{
    public class StockDb: DbContext
    {
        public StockDb()
            :base("name=MyCon") //database bağlan
        {


        }
        public virtual DbSet<Product>Products  { get; set; }//tabloyu oluştur 

    }
}
