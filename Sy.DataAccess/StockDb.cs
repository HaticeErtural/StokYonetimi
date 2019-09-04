using Sy.Core.Abstract;
using Sy.Core.ComplexTypes;
using Sy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.DataAccess
{
    public class StockDb: DbContext//entityden gelen nesne 
    {
        public StockDb()
            :base("name=MyCon") //database bağlan
        {
            //virtual metodları bulunduğu yerde çalışır ancak başka yerde istediğimiz gibi override edebiliyoruz
            

        }

        public override int SaveChanges()//virtual olduğu için override edip kendime göe dzenliyorum
        {
            if (StockSettings.UserInfo!=null)
            {
                var selectedEntityList = ChangeTracker.Entries() //değişiklikleri takip eden metod
                .Where(x => x.Entity is AuditBase && x.State == EntityState.Added);
                foreach (var item in selectedEntityList)
                {
                    (item.Entity as AuditBase).CreatedUSer = StockSettings.UserInfo.Email;
                    (item.Entity as AuditBase).CreatedDate = DateTime.Now;

                }

                selectedEntityList = ChangeTracker.Entries() //değişiklikleri takip eden metod hangi tablode ne zaman ne değişklik oldu
                .Where(x => x.Entity is AuditBase && x.State == EntityState.Modified);

                foreach (var item in selectedEntityList)
                {
                    (item.Entity as AuditBase).UpdatedUser = StockSettings.UserInfo.Email;
                    (item.Entity as AuditBase).UpdatedDate = DateTime.Now;

                }

            }

            return base.SaveChanges();
        }
        public virtual DbSet<Product>Products  { get; set; }//tabloyu oluştur 
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ProductStockAction> ProductStockActions { get; set; }



    }
}
