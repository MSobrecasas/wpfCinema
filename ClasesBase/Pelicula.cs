using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase {
    public class Pelicula
    {
        private int peli_ID;

        public int Peli_ID {
            get { return peli_ID; }
            set { peli_ID = value; }
        }
        private string peli_Titulo;

        public string Peli_Titulo {
            get { return peli_Titulo; }
            set { peli_Titulo = value; }
        }
        private string peli_Duracion;

        public string Peli_Duracion {
            get { return peli_Duracion; }
            set { peli_Duracion = value; }
        }
        private int gen_ID;

        public int Gen_ID
        {
            get { return gen_ID; }
            set { gen_ID = value; }
        }
        private int cla_ID;

        public int Cla_ID
        {
            get { return cla_ID; }
            set { cla_ID = value; }
        }
    }
}
