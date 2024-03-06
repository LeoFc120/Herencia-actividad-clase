using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_actividad
{
    internal class Gato:Mamifero
    {
        //Atributos
        private int nBigotes { get; set; }

        //Constructor
        /* Cuando se hereda un constructor con parametros
         * se tienen que colocar los parametros en el constructor
         * de la clase derivada (o subclase), de lo contrario
         * se mantendra un errro
         */
        public Gato(string n, double p, int b) : base(n, p)
        {
            this.nBigotes = b;
        }

        //Metodos 
        public void mostrarGato()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
            Console.WriteLine("Tiene " + nBigotes + " bigotes completos");
        }
    }
}
