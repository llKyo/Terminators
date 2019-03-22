using AdminTerminatorModel.DAL;
using AdminTerminatorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminator
{
    public partial class Program
    {
        static void MostrarTerminators()
        {
            List<Terminator> terminators = new TerminatorDAL().ObtenerTerminators();
            if (terminators.Count() != 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0,12}{1,10}{2,20}{3,17}{4,20}\n", "Nro de Serie", "Tipo", "Prioridad Base", "Objetivo", "Año de Destino");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                terminators.ForEach(t => Console.WriteLine(
                    "{0,12}{1,10}{2,20}{3,17}{4,20}", t.NroSerie, t.Tipo, t.PrioridadBase, t.Objetivo, t.AñoDestino));
            } else
            {
                Console.WriteLine("[Info] No hay ningún Terminatos ingresado.");
            }
            Console.Write("\nPresione cualquier tecla para continuar. . .");
            Console.ReadKey();
        }
        static void BuscarTerminator()
        {
            Console.WriteLine("Buscador de Terminator\n");
            Console.Write("Ingrese el nro de serie:\n> ");
            string nroSerie = Console.ReadLine().Trim();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n{0,12}{1,10}{2,20}{3,17}{4,20}\n", "Nro de Serie", "Tipo", "Prioridad Base", "Objetivo", "Año de Destino");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            new TerminatorDAL()
                .FiltrarTerminator(nroSerie)
                .ForEach(t => Console.WriteLine(
                    "{0,12}{1,10}{2,20}{3,17}{4,20}", t.NroSerie, t.Tipo, t.PrioridadBase, t.Objetivo, t.AñoDestino));
            
            Console.Write("\nPresione cualquier tecla para continuar. . .");
            Console.ReadKey();
        }
        static void IngresarTerminator()
        {
            string nroSerie;
            string tipo = "";
            int prioridadBase = 0;
            string objetivo = "";
            Int32 añoDestino = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---------- Ingrese Terminator ----------\n");
            Console.ResetColor();

            //NÚMERO DE SERIE
            
            List<String> errores;
            do
            {
                errores = new List<String>();
                Console.Write("Ingrese Número de Serie:\n> ");
                nroSerie = Console.ReadLine().Trim();
                if (nroSerie.Length != 7)
                {
                    errores.Add("[!] Error: El número de serie debe ser de 7 caracteres");
                    
                }
                
                if (new TerminatorDAL().FiltrarTerminator(nroSerie).Count() != 0)
                {
                    errores.Add("[!] Error: El terminator Existe");
                   
                }

                if(errores.Count() > 0)
                {
                    for (int i = 0; i < errores.Count(); i++)
                    {
                        Console.WriteLine(errores[0]);
                    }
                }

            } while (errores.Count > 0);
            //FIN NRO de SERIE

            // TIPO
            bool error;
            do
            {
                error = false;
                Console.WriteLine("\n----- TIPOS -----");
                Console.WriteLine("1. T-1");
                Console.WriteLine("2. T-800");
                Console.WriteLine("3. T-1000");
                Console.WriteLine("4. T-3000");
                Console.WriteLine("------------------");
                Console.Write("Seleccione una Opción (1-4):\n> ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        tipo = "T-1";
                        break;
                    case "2":
                        tipo = "T-800";
                        break;
                    case "3":
                        tipo = "T-1000";
                        break;
                    case "4":
                        tipo = "T-3000";
                        break;
                    default:
                        Console.WriteLine("[!] Ingrese una opción válida");
                        error = true;
                        break;
                }
            } while (error);
            //FIN TIPO

            //PRIORIDADBASE
            do
            {
                try
                {
                    error = false;
                    Console.Write("Ingrese Prioridad base:\n> ");
                    prioridadBase = Int32.Parse(Console.ReadLine().Trim());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("[!] Ingrese un número");
                    error = true;
                }
            } while (error);
            //FIN PRIORIDADBASE

            //OBJETIVO
            do
            {
                error = false;
                
            } while (error);
            Console.Write("Ingrese objetivo:\n> ");
            objetivo = Console.ReadLine().Trim();
            if (objetivo.ToLower() == "sarah connor")
            {
                prioridadBase = 999;
                Console.WriteLine("[Alert] La prioridad a cambiado a 999");
            }
            //FIN OBJETIVO

            //AÑO DESTINO
            do
            {
                try
                {
                    error = false;
                    Console.Write("Ingrese año de destino:\n> ");
                    añoDestino = Int32.Parse(Console.ReadLine().Trim());
                    if (1997 >= añoDestino || añoDestino >= 3000)
                    {
                        error = true;
                        Console.WriteLine("[!] El año de destino debe ser entre 1997 y 3000");
                    }
                }
                catch (FormatException ex)
                {
                    error = true;
                    Console.WriteLine("[!] Debe ingresar un número");
                }
            } while (error);
            //FIN AÑO DESTINO

            Terminator t = new Terminator() {
                NroSerie = nroSerie, Tipo = tipo, PrioridadBase = prioridadBase
                , Objetivo = objetivo, AñoDestino = añoDestino};

            new TerminatorDAL().AgregarTerminator(t);
            Console.WriteLine("\n\n---------- Resumen ----------\n");
            Console.WriteLine("Nro de Serie  : "+ nroSerie);
            Console.WriteLine("Tipo          : "+ tipo);
            Console.WriteLine("Prioridad Base: "+ prioridadBase);
            Console.WriteLine("Objetivo      : "+ objetivo);
            Console.WriteLine("Año de Destino: "+ añoDestino);
            Console.WriteLine("\n[Info] Terminator Ingresado.");
            Console.Write("\nPresione una tecla para continuar. . .");
            Console.ReadKey();
            

        }
    }
}
