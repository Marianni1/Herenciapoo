using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Saludable : Burger
    {
        public Saludable(string pan, string carne, int precio) : base(pan, carne, precio)
        {
            e tofu = new e("Tofu", 80);
            e aguacate = new e("Aguacate", 30);

            Ingre_Adi.Add(tofu);
            Ingre_Adi.Add(aguacate);
        }
    }
}
