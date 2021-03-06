using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docentes : Personas
    {
        #region ATRIBUTOS
        private string materia;
        private int legajo;
        #endregion
        #region PROPIEDADES

        public string pMateria
        {
            set { materia = value; }
            get { return materia; }
        }
        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }
        #endregion
        #region CONSTRUCTORES
        public Docentes()
        {
        }

        public Docentes(string Nom, long Dni, DateTime fNac, char Sex, string materia, int legajo) : base(Nom, Dni, fNac, Sex)
        {
            pMateria = materia;
            pLegajo = legajo;
        }
        #endregion


    }
}
