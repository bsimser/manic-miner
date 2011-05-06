using Microsoft.Xna.Framework.Content;

namespace minerXNA
{
    class Personaje : ElemGrafico
    {
        public Personaje(ContentManager c)
            : base("personaje", c)
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
