using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Burger
    {
        private string Bread {get; set;}
        private string Meat {get; set;}
        private int Precio {get; set;}
        public List<e> noAdicionales {get; set;}
        public List<e> Ingre_Adi {get; set;}
        public List<e> selectedAdicionales {get; set;}

        public Burger(string pan, string carne, int precio)
        {
            Bread = pan;
            Meat = carne;
            Precio = precio;

            e lechuga = new e("Lechuga", 20);
            e tomate = new e("Tomate", 20);
            e cebolla = new e("Cebolla", 20);
            e cebolla_caramelizada = new e("Cebolla caramelizada", 50);
            e queso = new e("Queso", 50);
            e tocineta = new e("Tocineta", 65);
            e maíz = new e("Maíz", 10);
            e pepinillo = new e("Pepinillo", 35);
            e chicharrón = new e("Chicharrón", 80);

            Ingre_Adi = new List<e>();
            Ingre_Adi.Add(lechuga);
            Ingre_Adi.Add(tomate);
            Ingre_Adi.Add(cebolla);
            Ingre_Adi.Add(cebolla_caramelizada);
            Ingre_Adi.Add(queso);
            Ingre_Adi.Add(tocineta);
            Ingre_Adi.Add(maíz);
            Ingre_Adi.Add(pepinillo);
            Ingre_Adi.Add(chicharrón);
            selectedAdicionales = new List<e>();

            noAdicionales = new List<e>();
            e nada = new e("Adicional", 0);
            noAdicionales.Add(nada);
        }

        public void ClassicBurger()
        {
            Console.WriteLine("Elija un tipo de pan (Clásica, Brioche, Cristal):");
            Bread = Console.ReadLine();
            if (Bread == "Clásica" || Bread == "Brioche" || Bread == "Cristal")
            {
                Console.WriteLine("\nTipo de Bread seleccionado: " + Bread);
            }
            else
            {
                Console.WriteLine("Este tipo de pan no está disponible, intente eligiendo otro.");
                Console.WriteLine("\nPresione Enter para intentarlo de nuevo.");
                Console.ReadLine();
                ClassicBurger();
            }

            Console.WriteLine("\nAhora, elija un tipo de carne (Res, Pollo, Cerdo)");
            Meat = Console.ReadLine();
            if (Meat == "Res" || Meat == "Pollo" || Meat == "Cerdo")
            {
                Console.WriteLine("\nTipo de carne seleccionada: " + Meat);
            }
            else
            {
                Console.WriteLine("Este tipo de carne no está disponible, intente eligiendo otro.");
                Console.WriteLine("\nPresione Enter para intentarlo de nuevo.");
                Console.ReadLine();
                ClassicBurger();
            }
        }
        public void HealthyBurger()
        {
            Console.WriteLine("Como el tipo de hamburguesa seleccionada es saludable, ya esta hamburguesa viene con pan integral.");
            Console.WriteLine("\nElija un tipo de carne (Res, Pollo, Cerdo)");
            Meat = Console.ReadLine();
            if (Meat == "Res" || Meat == "Pollo" || Meat == "Cerdo")
            {
                Console.WriteLine("\nTipo de carne seleccionada: " + Meat);
            }
            else
            {
                Console.WriteLine("Este tipo de carne no está disponible, intente eligiendo otro.");
                Console.WriteLine("\nPresione Enter para intentarlo de nuevo.");
                Console.ReadLine();
                HealthyBurger();
            }
        }
        public void PremiumBurger()
        {
            Console.WriteLine("\nElija un tipo de pan (Clásica, Brioche, Cristal, Integral)");
            Bread = Console.ReadLine();
            if (Bread == "Clásica" || Bread == "Brioche" || Bread == "Cristal" || Bread == "Integral")
            {
                Console.WriteLine("\nTipo de pan seleccionado: " + Bread);
            }
            else
            {
                Console.WriteLine("Este tipo de pan no está disponible, intente eligiendo otro.");
                Console.WriteLine("\nPresione Enter para intentarlo de nuevo.");
                Console.ReadLine();
                PremiumBurger();
            }

            Console.WriteLine("\nAhora, elija un tipo de carne (Res, Pollo, Cerdo)");
            Meat = Console.ReadLine();
            if (Meat == "Res" || Meat == "Pollo" || Meat == "Cerdo")
            {
                Console.WriteLine("\nTipo de carne seleccionada: " + Meat);
            }
            else
            {
                Console.WriteLine("Este tipo de carne no está disponible, intente eligiendo otro.");
                Console.WriteLine("\nPresione Enter para intentarlo de nuevo.");
                Console.ReadLine();
                PremiumBurger();

            }
        }

        public List<e> Adicionales(int cantidad)
        {
         
            Console.WriteLine("\n\tLos ingredientes disponibles son:");
            Console.WriteLine();
            int a = 0;
            foreach (e n in Ingre_Adi)
            {
                Console.WriteLine($"\t{a}. {n.Nombre}");
                a++;
            }

            Console.WriteLine($"\nSolo puede seleccionar hasta {cantidad} ingredientes.");
            Console.Write("\n¿Cuántos ingredientes desea agregar a su orden? ");
            int cantAdicionales = int.Parse(Console.ReadLine());
            if (cantAdicionales <= cantidad)
            {
                for (int i = 0; i < cantAdicionales; i++)
                {
                    Console.Write($"\n\tEscoja el NÚMERO del ingrediente {i + 1}: ");
                    selectedAdicionales.Add(Ingre_Adi[int.Parse(Console.ReadLine())]);
                }
            }
            else
            {
                Console.WriteLine("\nLa cantidad ingresada no es la correcta.");
            }
            return selectedAdicionales;
        }

        public void FacturaI(string Opción, int cantidad)
        {
            if (Opción == "Sí")
            {
                Factura(Precio, Adicionales(cantidad));
            }
            else if (Opción == "No")
            {
                Factura(Precio, noAdicionales);
            }
        }

        public void FacturaR(List<e> adicionalesR)
        {
            Factura(Precio, adicionalesR);
        }


        private void Factura(int precio, List<e> FinalAd)
        {
            Console.WriteLine("\n\tFactura");
            string[] cabecera = {"Descripción", "Precio"};
            dynamic[,] contenido;

    
            int suma = 0;
            for (int i = 0; i < FinalAd.Count; i++)
            {
                suma += FinalAd[i].Price;
            }

            e FinalBurger = new e("Hamburguesa", precio);
            FinalAd.Insert(0, FinalBurger);
            e total = new e("\n\tTotal", (suma + precio));
            FinalAd.Add(total);
            contenido = new dynamic[FinalAd.Count, 2];

            
            for (int r = 0; r < FinalAd.Count; r++)
            {
                contenido[r, 0] = FinalAd[r].Nombre;
                contenido[r, 1] = $"RD${FinalAd[r].Price}.00";
            }

            Console.WriteLine();
            for (int i = 0; i < cabecera.Length; i++)
            {
                Console.Write("\t" + cabecera[i] + "\t\t");
            }
            Console.WriteLine();

            for (int f = 0; f < FinalAd.Count; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("\t" + contenido[f, c] + "\t\t\t");
                }
            }
        }
    }
}
