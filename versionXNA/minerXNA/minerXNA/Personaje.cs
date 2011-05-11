/* =============================================================
 * Parte de ManicMiner - Remake
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------

   0.02x  08-02-2011  Nacho Cabanes: Clase "Personaje" básica

   0.03x  12-02-2011  Nacho Cabanes: Usa "ContentManager", en vez de cargar imágenes al vuelo
  
   0.04x  12-02-2011  Nacho Cabanes: El constructor no recibe la partida como parámetro, sino
                        el "ContentManager". Eliminados "using" innecesarios.
 
   0.06x  29-04-2011  Nacho Cabanes: Ampliado para permitir saltar y caer.
 
   0.07x  06-05-2011  Antonio Ramos: Agregar secuencia animada de movimiento.
                      Alejandro Guillén: antes de mover, comprueba
                        si es posible mover, mirando el mapa.
                      Nacho Cabanes: Eliminada la posibilidad de mover arriba y abajo.

   0.08x  11-05-2011  Nacho Cabanes: Añadidos Morir y SetVidas, creada secuencia de
                        salto y caída.

 ============================================================= */

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
        int[] pasosSaltoArriba = {
             -8, -8, -8, -6, -6, -5, -5, -4, -4, -4, -3, -3, -2, -1, -1, 0, 0, 0,
             0, 0, 0, 1, 1, 2, 3, 3, 4, 4, 4, 5, 5, 6, 6, 8, 8, 8 };

        public Personaje(ContentManager c)
            : base("personaje", c)
        {
            vidas = 3;
            incrXSalto = 0;
            cantidadMovimientoSalto = pasosSaltoArriba.Length;

            MoverA(70, 352);

            // Le añado secuencia al personaje de derecha a izquierda.
            CargarSecuencia(DERECHA,
                 new string[] {
                  "personajeD01","personajeD01",
                  "personajeD02","personajeD02",
                  "personajeD03","personajeD03",
                  "personajeD04","personajeD04",
                  "personajeD05","personajeD05",
                  "personajeD06","personajeD06",
                  "personajeD07","personajeD07",
                  "personajeD08","personajeD08"}, c
                 );
            CargarSecuencia(IZQUIERDA,
                 new string[] {
                  "personajeI01","personajeI01",
                  "personajeI02","personajeI02",
                  "personajeI03","personajeI03",
                  "personajeI04","personajeI04",
                  "personajeI05","personajeI05",
                  "personajeI06","personajeI06",
                  "personajeI07","personajeI07",
                  "personajeI08","personajeI08"}, c
                 );
            direccion = DERECHA;

            SetAnchoAlto(30, 48); // Si se carga secuencia, ancho y alto deben ir detras
        }


        // Métodos de movimiento
        public void MoverDerecha( Mapa m ) 
        {
            if (saltando || cayendo) return; // No debe moverse mientras salta

            CambiarDireccion(DERECHA);
            if (m.EsPosibleMover(x + incrX, y + alto - 4,
                      x + ancho + incrX, y + alto))
            {
                x += incrX;
                SiguienteFotograma();
            }
            cayendo = true;
        }


        public void MoverIzquierda( Mapa m )
        {
            if (saltando || cayendo) return; // No debe moverse mientras salta

            CambiarDireccion(IZQUIERDA);
            if (m.EsPosibleMover(x - incrX, y + alto - 4,
                      x + ancho - incrX, y + alto))
            {
                x -= incrX;
                SiguienteFotograma();
            }
            cayendo = true;
        }


        // Para cuando deba moverse solo, p.ej. saltando
        public new void Mover(Mapa m)
        {
            if (saltando)
            {
                // Calculo las siguientes posiciones y veo si son validas
                short xProxMov = (short)(x + incrXSalto);
                short yProxMov = (short)(y + pasosSaltoArriba[fotogramaMvto]);
                bool subiendoSalto = (pasosSaltoArriba[fotogramaMvto] < 0);

                // Si todavía se puede mover, avanzo
                if (m.EsPosibleMover(
                    xProxMov, yProxMov + alto - 2,
                    xProxMov + ancho, yProxMov + alto)
                    || subiendoSalto)
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
                if (m.EsPosibleMover(
                    x, y + incrY + alto - 4,
                   x + ancho, y + incrY + alto))
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


        // Métodos de acceso a las vidas
        public int GetVidas()
        {
            return vidas;
        }

        public void SetVidas(short n)
        {
            vidas = n;
        }

        public void Morir()
        {
            vidas--;
        }

    }


}
