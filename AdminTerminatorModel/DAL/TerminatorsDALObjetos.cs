using AdminTerminatorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminatorModel.DAL
{
    public class TerminatorsDALObjetos
    {
        private static List<Terminator> terminators = new List<Terminator>();
        public void AgregarTerminator(Terminator t)
        {
            terminators.Add(t);
        }
        public List<Terminator> ObtenerTerminators()
        {
            return terminators;
        }
        public List<Terminator> FiltrarTerminator(string nroSerie, UInt32 añoDestino)
        {
            return terminators.FindAll(t => t.NroSerie == nroSerie && t.AñoDestino == añoDestino);
        }
        public List<Terminator> BuscarTerminator(string nroSerie)
        {
            return terminators.FindAll(t => t.NroSerie == nroSerie);
        }
        
    }
}
