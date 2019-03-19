using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminatorModel.DTO
{
    public class Terminator
    {
        string nroSerie;
        string tipo;
        int prioridadBase;
        string objetivo;
        Int32 añoDestino;

        public string NroSerie
        {
            get
            {
                return nroSerie;
            }

            set
            {
                nroSerie = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int PrioridadBase
        {
            get
            {
                return prioridadBase;
            }

            set
            {
                prioridadBase = value;
            }
        }

        public string Objetivo
        {
            get
            {
                return objetivo;
            }

            set
            {
                objetivo = value;
            }
        }

        public int AñoDestino
        {
            get
            {
                return añoDestino;
            }

            set
            {
                añoDestino = value;
            }
        }
    }
}
