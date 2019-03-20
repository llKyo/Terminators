using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminator
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }
        static bool Menu()
        {
            bool continuar = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------- TERMINATORS! ----------");
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");
            Console.Write("\nIngrese una Opción: ");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    Console.Clear();
                    IngresarTerminator();
                    break;
                case "2":
                    Console.Clear();
                    MostrarTerminators();
                    break;
                case "3":
                    Console.Clear();
                    BuscarTerminator();
                    break;
                case "0":
                    Console.Clear();
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Apreta bien ctm");
                    break;
            }
            
            return continuar;
        }
    }
}
