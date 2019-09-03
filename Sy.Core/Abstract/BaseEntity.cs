using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstract
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        [Key]//yapmana gerek yok EF zaten Id kelimesini görünce bunun PK olduğunu anlıyor
        public TKey Id { get; set; }
    }
}
