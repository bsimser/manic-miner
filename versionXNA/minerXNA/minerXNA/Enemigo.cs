using Microsoft.Xna.Framework.Content;

namespace minerXNA
{
    public class Enemigo : ElemGrafico
    {

        // Constructor
        public Enemigo(ContentManager c)
            : base("enemigo", c)
        {
            //miPartida = p;   // Para enlazar con el resto de componentes
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
