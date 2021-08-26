using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personas
    {

        #region ATRIBUTOS 
        private string nombre;
        private long dni;
        private DateTime fechNac;
        private char sexo;
        #endregion

        #region PROPIEDADES
        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long pDni
        {
            get { return dni; }
            set { dni = value; }
        }

        public DateTime pNac
        {
            get { return fechNac; }
            set { fechNac = value; }
        }

        public char pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion

        #region CONSTRUCTORES
        public Personas() { }

        public Personas(string Nom, long Dni, DateTime fNac, char Sex)
        {
            pNombre = Nom;
            pDni = Dni;
            pNac = fNac;
            pSexo = Sex;
        }
        #endregion

        #region Metodos
        public int Edad(int nac)
        {
            int edad = (Convert.ToInt32(DateTime.Now.Year) - nac) - 1;
            return edad;
        }
        public void Sexo(bool M, bool F)
        {
            if (M == true)

            {
                pSexo = 'M';
            }
            else if (F == true)
            {
                pSexo = 'F';
            }
            else
            {
                pSexo = 'X';
            }
        }
        #endregion
    }
}
