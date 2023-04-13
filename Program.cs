using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hamburguesas = new List<string>();
            hamburguesas.Add("Hamburguesa Clásica");
            hamburguesas.Add("Hamburguesa Saludable");
            hamburguesas.Add("Hamburguesa Premiun");
           
            Menu(hamburguesas);
            Console.ReadLine();
        }



        public static void Finalizar()
        {
            Console.WriteLine("\nPresione Enter para regresar.");
            Console.ReadLine();
            Console.Clear();
            Main(null);
        }

        static void Menu(List<string> hamburguesas)
        {
            Console.WriteLine("Bienvenid@ a: Chimi MiBarriga");
            Console.WriteLine("\nA continuación, nuestro menú:");
            Console.WriteLine();
            for (int i = 0; i < hamburguesas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {hamburguesas[i]}");
            }

            Console.Write("\nPor favor, seleccione un tipo de hamburguesa: ");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    Clásica();
                    break;
                case "2":
                    Saludable();
                    break;
                case "3":
                    Premium();
                    break;
                default:
                    Console.WriteLine("\nEl número ingresado no es válido, intente de nuevo.");
                    Finalizar();
                    break;
            }
        }

        public static void Clásica()
        {
            Console.Clear(); 
            Burger Classic = new Burger("", "", 300);
            Classic.ClassicBurger();
            Console.Write("\n¿Desea usted, agregar ingredientes adicionales a su orden? (Sí/No): ");
            string opcion = Console.ReadLine();

            if (opcion == "Sí")
            {
                Classic.FacturaI(opcion, 4);
                Finalizar();
            }
            else if (opcion == "No")
            {
                Classic.FacturaI(opcion, 4);
                Finalizar();
            }
            else
            {
                Console.Write("\nOpción no válida. Presione Enter para intentar de nuevo.");
                Console.ReadLine();
                Clásica();
            }
        }

        public static void Saludable()
        {
            Console.Clear();
            Saludable healthy = new Saludable("", "", 350);
            healthy.HealthyBurger();
            Console.Write("\n¿Desea usted, agregar ingredientes adicionales a su orden? (Sí/No): ");
            string opcion = Console.ReadLine();

            if (opcion == "Sí")
            {
                healthy.FacturaI(opcion, 6);
                Finalizar();
            }
            else if (opcion == "No")
            {
                healthy.FacturaI(opcion, 6);
                Finalizar();
            }
            else
            {
                Console.Write("\nOpción no válida. Presione Enter para intentar de nuevo.");
                Console.ReadLine();
                Saludable();
            }
        }

        public static void Premium()
        {
            Console.Clear();
            Premium Premium_Burger = new Premium("", "", 450);
            Console.WriteLine("En este tipo de hamburguesa no se permiten ingredientes adicionales.");
            Premium_Burger.PremiumBurger();

            List<e> noAdicionales = new List<e>();
            e nada = new e("Adicional", 0);
            noAdicionales.Add(nada);

            Premium_Burger.FacturaR(Premium_Burger.Papas_Bebida());



        }
    }
}
