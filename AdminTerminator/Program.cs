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
            Console.ResetColor();
            //BANNER
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" _                      _             _             ");
            Console.WriteLine("| |                    (_)           | |            ");
            Console.WriteLine("| |_ ___ _ __ _ __ ___  _ _ __   __ _| |_ ___  _ __ ");
            Console.WriteLine("| __/ _ \x005C '__| '_ ` _ \x005C| | '_ \x005C / _` | __/ _ \x005C| '__|");
            Console.WriteLine("| ||  __/ |  | | | | | | | | | | (_| | || (_) | |   ");
            Console.WriteLine(" \x005C__\x005C___|_|  |_| |_| |_|_|_| |_|\x005C__,_|\x005C__\x005C___/|_|   \n\n");
            //FIN BANNER
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                        MENU                        ");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");
            Console.Write("\nIngrese una Opción: \n> ");
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
