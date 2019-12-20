using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.clases
{
    public class basededato
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public basededato(string nombre)
        {
            Nombre = nombre;
        }

        public string Mostrar()
        {
            return "\n" + Nombre;
        }



    }
}