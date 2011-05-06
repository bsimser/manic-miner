using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minerXNA
{
    class Enemigo : ElemGrafico
    {

        // Constructor
        public Enemigo(Partida p)
            : base("enemigo", p)
        {
            miPartida = p;   // Para enlazar con el resto de componentes
            x = 400;         // Resto de valores iniciales
            y = 400;
            incrX = 2;
        }


        // Métodos de movimiento
        public void Mover()
        {
            x += incrX;

            if ((x < 100) || (x > 700))
                incrX = (short)(-incrX);
        }


    }
}
