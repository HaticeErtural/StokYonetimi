using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//entity farmeworkdan eklenen kütüphane
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstract
{
    public abstract class AuditBase //amaç burda yapılan değişklikleri tutmak takip etmek takip etmek isteğim classlar 
    {
        public AuditBase()
        {
            this.CreatedDate = DateTime.Now;
        }
        [StringLength(50)]
        public string  CreatedUSer { get; set; }
        public DateTime CreatedDate { get; set; }//date time value typedır =datetime.now da yazabilirsin yukarıdaki constructur yerine 

        public string  UpdatedUser { get; set; } //stringe null atabilirim

        public DateTime? UpdatedDate { get; set; }//date time null olamadığı için soru işareti koyduk


    }
}
