using Microsoft.Xna.Framework.Content;

namespace minerXNA
{

    class Personaje : ElemGrafico
    {
        short vidas;       // Vidas restantes
        bool saltando, cayendo;
        int incrXSalto;
        int fotogramaMvto;
        int cantidadMovimientoSalto;
        int[] pasosSaltoArriba = {-10, -10, -8, -8, -6, -6, -4, -2, -1, -1, 0,
                             0, 1, 1, 2, 4, 6, 6, 8, 8, 10, 10 };

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

        // Para cuando deba moverse solo, p.ej. saltando
        public new void Mover()
        {
            if (saltando)
            {
                // Calculo las siguientes posiciones y veo si son validas
                short xProxMov = (short)(x + incrXSalto);
                short yProxMov = (short)(y + pasosSaltoArriba[fotogramaMvto]);
                bool subiendoSalto = (pasosSaltoArriba[fotogramaMvto] < 0);

                // Si todavía se puede mover, avanzo
                // TODO: Falta comprobar colisiones
                if (true) /* (miPartida.GetMapa().EsPosibleMover(
                    xProxMov, yProxMov + alto - 4,
                    xProxMov + ancho, yProxMov + alto)
                    || subiendoSalto)*/
                {
                    x = xProxMov;
                    y = yProxMov;
                    SiguienteFotograma();
                }
                // Y si no, quizá esté cayendo
                else
                {
                    saltando = false;
                    cayendo = true;
                }

                fotogramaMvto++;
                if (fotogramaMvto >= cantidadMovimientoSalto)
                {
                    saltando = false;
                    cayendo = true;
                }
            }
            else if (cayendo)
            {
                // TODO: Falta comprobar colisiones
                if (true) /*(miPartida.GetMapa().EsPosibleMover(
                    x, y + incrY + alto - 4,
                   x + ancho, y + incrY + alto))*/
                {
                    y += incrY;
                }
                else
                    cayendo = false;
            }

        }


        // Comienza la secuencia de salto
        public void Saltar()
        {
            if (saltando || cayendo)
                return;
            saltando = true;
            fotogramaMvto = 0;
            incrXSalto = 0;
        }


        // Comienza la secuencia de salto hacia la derecha
        public void SaltarDerecha()
        {
            Saltar();
            incrXSalto = incrX;
        }


        // Comienza la secuencia de salto hacia la izquierda
        public void SaltarIzquierda()
        {
            Saltar();
            incrXSalto = -incrX;
        }
  


    }


}
