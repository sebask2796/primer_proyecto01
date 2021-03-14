using System;

namespace Eje06
{
    class Program
    {


        static void Main(string[] args)
        {

            // Definir nuestro vectores o arreglo 
            string[] edad = { "12", "50","23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = {"juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge","dayana", "lady"};

            string nombreBuscar;
            bool existe = false;
            int posicion = 0;

            Console.Clear();

            ImprimirVector(edad, " Edades");
            ImprimirVector(nombre, "Nombres");

            Console.WriteLine("Digite El nombre a buscar");
            nombreBuscar = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == nombreBuscar)
                {
                    existe = true;
                    posicion = i;
                }
            }
           
            if (existe)
            {
                Console.WriteLine(" El Usuario " + nombreBuscar + " Existe y tiene " + edad[posicion] +" Anos de edad");
            } else
            {
                Console.WriteLine(" El Usuario " + nombreBuscar + " No Existe");
            }

            Console.WriteLine("\n presiones cualquier tecla para continuar");
            Console.ReadKey();

        }

        static void ImprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo " + titulo);

            foreach (string elemento in vector)
            {
                Console.Write("[ " + elemento + " ] ");
            }
            Console.WriteLine("\n");
        }




    }
}
