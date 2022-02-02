using BarberShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class ClassEntities
    {
        public static BarberShopEntities context { get; set; } = new BarberShopEntities();

    }
}
