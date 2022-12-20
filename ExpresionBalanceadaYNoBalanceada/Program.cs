using System;
using System.Text;

namespace ExpresionBalanceadaYNoBalanceada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cambia el color a la letra
            Console.ForegroundColor = ConsoleColor.White;

            //Cambiar el color al fondo
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            int salir;

            do
            {
                Console.Clear();

                string expresion;

                Console.WriteLine("\t\tEvaluador de expresiones");
                Console.Write(" Ingrese la expresión a evaluar: ");
                expresion = Console.ReadLine();

                Console.WriteLine(expresion.Evaluar());

                Console.Write(" ¿Desea seguir evaluando expresiones? (1= si ó 0= no): ");
                salir = int.Parse(Console.ReadLine());

            } while (salir == 1);
        }
    }
}
