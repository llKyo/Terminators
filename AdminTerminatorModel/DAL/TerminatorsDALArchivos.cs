using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminTerminatorModel.DTO;
using System.IO;

namespace AdminTerminatorModel.DAL
{
    public class TerminatorsDALArchivos : ITerminatorsDAL
    {
        private static string archivo = "terminators.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
        public void AgregarTerminator(Terminator t)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    string texto = t.NroSerie + ";" //CSV: Comma Separated Values
                        + t.Tipo + ";"
                        + t.PrioridadBase + ";"
                        + t.Objetivo + ";"
                        + t.AñoDestino + ";";
                    writer.WriteLine(texto);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en archivo " + ex.Message);
            }
        }

        public List<Terminator> BuscarTerminator(string nroSerie)
        {
            return ObtenerTerminators().FindAll(t => t.NroSerie.ToLower() == nroSerie.ToLower());
        }

        public List<Terminator> FiltrarTerminator(string nroSerie, uint añoDestino)
        {
            return ObtenerTerminators().FindAll(t => t.NroSerie.ToLower() == nroSerie.ToLower() && t.AñoDestino == añoDestino);
        }

        public List<Terminator> ObtenerTerminators()
        {
            
            List<Terminator> terminators = new List<Terminator>();
            try
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    string texto;
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto != null)
                        {
                            string[] textoArr = texto.Trim().Split(';');
                            string nroSerie = textoArr[0];
                            string tipo = textoArr[1];
                            int prioridadBase = Convert.ToInt16(textoArr[2]);
                            string objetivo = textoArr[3];
                            int añoDestino = Convert.ToInt16(textoArr[4]);
                            Terminator t = new Terminator()
                            {
                                NroSerie = nroSerie,
                                Tipo = tipo,
                                PrioridadBase = prioridadBase,
                                Objetivo = objetivo,
                                AñoDestino = añoDestino
                            };
                            terminators.Add(t);
                        }
                    } while (texto != null);
                }
            } catch (System.IO.FileNotFoundException ex)
            {
                return terminators;
            }

            return terminators;
        }
    }
}
