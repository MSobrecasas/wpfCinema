using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase {
    public class Proyeccion {
        private int proy_Codigo;

        public int Proy_Codigo {
            get { return proy_Codigo; }
            set { proy_Codigo = value; }
        }
        private string proy_Fecha;

        public string Proy_Fecha {
            get { return proy_Fecha; }
            set { proy_Fecha = value; }
        }
        private string proy_Hora;

        public string Proy_Hora {
            get { return proy_Hora; }
            set { proy_Hora = value; }
        }
        private int sala_ID;

        public int Sala_ID {
            get { return sala_ID; }
            set { sala_ID = value; }
        }
        private int peli_ID;

        public int Peli_ID {
            get { return peli_ID; }
            set { peli_ID = value; }
        }
    }
}
