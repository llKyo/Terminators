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
            terminators.ForEach(t => Console.WriteLine(
                "Número de Serie:{0} Tipo:{1} Objetivo:{2}", t.NroSerie, t.Tipo, t.Objetivo));
        }
        static void BuscarTerminator()
        {
            Console.WriteLine("Ingrese nombre");
            new TerminatorDAL()
                .FiltrarTerminator(Console.ReadLine().Trim())
                .ForEach(t => Console.WriteLine(
                    "Número de Serie:{0} Tipo:{1} Objetivo:{2}", t.NroSerie, t.Tipo, t.Objetivo));
        }
        static void IngresarTerminator()
        {
            string nroSerie;
            string tipo;
            int prioridadBase;
            string objetivo;
            Int32 añoDestino;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---------- Ingrese Terminator ----------");
            Console.ResetColor();

            //NÚMERO DE SERIE
            
            List<String> errores;
            do
            {
                errores = new List<String>();
                Console.Write("Ingrese Número de Serie: ");
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
                Console.Write("Ingrese Tipo: ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        nroSerie = "T-1";
                        break;
                    case "2":
                        nroSerie = "T-800";
                        break;
                    case "3":
                        nroSerie = "T-1000";
                        break;
                    case "4":
                        nroSerie = "T-3000";
                        break;
                    default:
                        Console.WriteLine("[!] Ingrese una opción válida");
                        error = true;
                        break;
                }
            } while (error);
            //FIN TIPO

            //AÑO DESTINO

            do
            {
                try
                {
                    error = false;
                    Console.Write("ingrese año de destino: ");
                    añoDestino = 
                }
                catch (Exception ex)
                {
                    error = true;
                }
            } while (error);
           //FIN AÑO DESTINO
        }
    }
}
