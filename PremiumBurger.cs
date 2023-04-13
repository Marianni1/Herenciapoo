using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Premium : Burger
    {
        public List<e> Sabores;
        public List<e> SaborSeleccionado;
        public Premium(string pan, string carne, int precio) : base(pan, carne, precio)
        {
            e Cola = new e("Cola", 35);
            e Limón = new e("Limón", 35);
            e Naranja = new e("Naranja", 35);
            e Uva = new e("Uva", 35);
            e Frambuesa = new e("Frambuesa", 35);
            Sabores = new List<e>();
            Sabores.Add(Cola);
            Sabores.Add(Limón);
            Sabores.Add(Naranja);
            Sabores.Add(Uva);
            Sabores.Add(Frambuesa);
            SaborSeleccionado = new List<e>();
        }
        private void Flavors(List<e> flavor)
        {
            int i = 0;
            foreach (e n in flavor)
            {
                Console.WriteLine($"\t{i}. {n.Nombre}");
                i++;
            }
        }

        public List<e> Papas_Bebida()
        {
            Console.WriteLine("\n¿Desea sus papas sazonadas? (Sí/No)");
            string opción = Console.ReadLine();
            if (opción == "Sí")
            {
                Console.WriteLine("\nOpción seleccionada: " + opción);
            }
            else
            {
                Console.WriteLine("\nOpción seleccionada: " + opción);
            }
            Console.WriteLine("\nLos sabores de refrescos disponibles son:");
            Flavors(Sabores);
            Console.WriteLine("\nEscoja el NÚMERO del sabor de su refresco.");
            SaborSeleccionado.Add(Sabores[int.Parse(Console.ReadLine())]);
            
            return SaborSeleccionado;
            
        }
    }
}

