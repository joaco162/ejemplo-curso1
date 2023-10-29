
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        
        private string color;
        private string material;
        private int cantidadActual;
        public int Capacidad { get; set; }

        //public int Capacidad
        //{
        //    get { return capacidad;}
        //    set { capacidad = value; }
        //}

        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            
            cantidadActual = 0;
        }
        //Sobrecarga del costructor
        public Botella()
        {

        }
        //metodo
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif =Capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;

            }
            cantidadActual = 100;
            return 50;
        }
    }
}
