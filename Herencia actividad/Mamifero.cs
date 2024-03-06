using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_actividad
{
    internal class Mamifero
    {
        //Atributos
        private string nombre { get; set; }
        protected double peso { get; set; }

        //Constructor
        public Mamifero(string n, double p)
        {
            this.nombre = n;
            this.peso = p;
        }

        //Metodos
        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
