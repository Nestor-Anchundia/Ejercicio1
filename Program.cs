using System;
using System.Collections.Generic;
using Ejercicio1.clases;
/* Se requiere definir una lista de bases de datos
disponibles a conectarse, que será aplicada de forma
única en cualquier parte de la aplicación.
 */
namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {

            basededato tipodebasededato1 = new basededato("oracle");

            basededato tipodebasededato2 = new basededato("SQLSERVER");
            basededato tipodebasededato3 = new basededato("PostgreSQL");




            singleton.Instancia.Basededatos = new List<basededato>();
            singleton.Instancia.Basededatos.Add(tipodebasededato1);
            singleton.Instancia.Basededatos.Add(tipodebasededato2);
            singleton.Instancia.Basededatos.Add(tipodebasededato3);

            foreach (basededato item in singleton.Instancia.Basededatos)
            {
                Console.WriteLine(item.Mostrar());
            }
            Console.ReadKey();



        }
    }
}