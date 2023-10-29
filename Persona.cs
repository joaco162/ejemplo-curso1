using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        public int Edad { get; set; }
        public float Sueldo { get; set; }
        public string Nombre { get; set; }
        // Metodos
        public string saludar()
        {
            return "Hola! Mi nombre es ..." + Nombre ;
        }                                                                                       
        
    }
}
