using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minerXNA
{
    class Personaje : ElemGrafico
    {
        public Personaje(Partida p)
            : base("imagenes/personaje.png", p)
        {

        }


        // Métodos de movimiento
        public void MoverDerecha() 
        {
            x += 2;
        }

        public void MoverIzquierda()
        {
            x -= 2;
        }

        public void MoverArriba()
        {
            y -= 2;
        }

        public void MoverAbajo()
        {
            y += 2;
        }

    }

    
      

  

}
