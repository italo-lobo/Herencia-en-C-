using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumnos : Personas
    {
        #region ATRIBUTOS
        private string carrera;
        private long legajo;
        #endregion 
        #region PROPIEDADES
        public string pCarrera
        {
            set { carrera = value; }
            get { return carrera; }
        }
        public long pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        #endregion
        #region CONSTRUCTORES
        public Alumnos()
        {
        }
        public Alumnos(string Nom, long Dni, DateTime fNac, char Sex, string carr, long leg) : base(Nom, Dni, fNac, Sex)
        {
            pCarrera = carr;
            pLegajo = leg;
        }

        #endregion

    }
}
