using AdminTerminatorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminatorModel.DAL
{
    public interface ITerminatorsDAL
    {

        void AgregarTerminator(Terminator t);

        List<Terminator> ObtenerTerminators();

        List<Terminator> FiltrarTerminator(string nroSerie, UInt32 añoDestino);

        List<Terminator> BuscarTerminator(string nroSerie);
        
    }
}
