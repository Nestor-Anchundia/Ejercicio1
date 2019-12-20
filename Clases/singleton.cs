using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.clases
{
    public sealed class singleton
    {
        private static singleton instancia = null;
        public singleton()
        {
        }


        public static singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se instancia");
                    instancia = new singleton();
                }

                return instancia;
            }

        }

        private List<basededato> basededatos;

        public List<basededato> Basededatos
        {
            get { return basededatos; }
            set { basededatos = value; }
        }

    }


}