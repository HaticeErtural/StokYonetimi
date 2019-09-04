using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.ComplexTypes
{
    public static class StockSettings//satic class içerisinde tanımlanan  herşey static olmalı ramde sürekli yer kapladığı için maaliyetlidir kullanıcı bilgilerin sürekli bellekte tutulması gerkiyor tekrar tekrar bilgileri istememesi için o yüzden static tanımladık
    {

        public static  UserInfoViewModel UserInfo { get; set; }




    }
}
