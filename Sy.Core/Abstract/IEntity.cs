using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstract
{
    public interface IEntity
    {
    }
    public interface IEntity<TKey>//Diamond Expression--- Id nesenesinin tipi girdiğin değere göre  tkey değişecek 
    {
        TKey Id { get; set; }
    }
}
