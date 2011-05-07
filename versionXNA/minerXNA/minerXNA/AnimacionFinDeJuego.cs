
/* =============================================================
 * Parte de ManicMiner - Remake
 * Animacion fin de juego: Contiene la animación
 *      que aparecerá cuando la partida acabe.
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.07x  06-05-2011  Héctor Pastor Pérez 
                        Creada la clase AnimacionFinDeJuego

 ============================================================= */

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class AnimacionFinDeJuego
    {
        ElemGrafico imagenFondo;
        ElemGrafico pie;
        ElemGrafico pierna;
        Fuente fuente18;

        ContentManager contenido;

        // Para saber cuando ha terminado la animación
        bool animacionTerminada = false;

        /* Para tener guardada la coordenada X que centrará
         * las imagenes*/
        int centroPie, centroPierna, centroFondo;
        
        // Para saber cuando se detendrá el pie
        const int principioColumna = 359;

        // Al dibujarse la columna sobre el marcador, se guarda
        // la Y inicial del marcador.
        const int principioMarcador = 420;

        public AnimacionFinDeJuego(ContentManager c)
        {
            contenido = c;
        }

        public void Reiniciar()
        {
            CargarContenido();
            animacionTerminada = false;
        }

        public bool GetTerminada()
        {
            return animacionTerminada;
        }

        public void ComprobarTeclas() //Para salir de la animación o saltarla
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))  // Escape = Salir
            {
                animacionTerminada = true;
            }
        }

        public void CargarContenido()
        {
            imagenFondo = new ElemGrafico("fondoFinal", contenido);
            pie = new ElemGrafico("pie", contenido);
            pierna = new ElemGrafico("pierna", contenido);
            fuente18 = new Fuente("Lucida Console", contenido);

            imagenFondo.SetAnchoAlto(513, 256);
            pie.SetAnchoAlto(32, 28);
            pierna.SetAnchoAlto(16, 4);

            /*  Se sacan las posiciones donde se dibujará el fondo y 
             *  el pie para que quede centrado*/
            centroFondo = 800 / 2 - imagenFondo.GetAncho() / 2;
            centroPie = 800 / 2 - pie.GetAncho() / 2;

            /*  Como la pierna debe ir cogida al pie, su X es 4 puntos
             *  superior a la del pie, se usa la coordenada centro del 
             *  pie mas 4*/
            centroPierna = centroPie + 4;
        }

        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            /*  Como la columna se apoya en el marcador, la coordenada
             *  Y será la coordenada Y del marcador de partida menos el
             *  alto de la imagen de fondo*/
            imagenFondo.DibujarOculta
                (centroFondo, principioMarcador - imagenFondo.GetAlto(), 
                spriteBatch);
            pie.DibujarOculta(centroPie, pie.GetY(), spriteBatch);

            /*  Mientras 'i' sea inferior a la coordenada Y del pie,
             *  se irá dibujando la pierna en la posición de 'i', que 
             *  al medir 4 pixels de alto el tile, se incrementara de 
             *  4 en 4*/
            for (int i = 0; i < pie.GetY(); i += 4)
                pierna.DibujarOculta(centroPierna, i, spriteBatch);

            /*  Mientras el pie no llegue a la posición final de la 
             *  columna, seguira bajando*/
            if (pie.GetY() < principioColumna)
                pie.MoverA(396, pie.GetY() + 5);
            //Si ha llegado a la columna, se escribe el rotulo de fin de partida
            else 
            {
                fuente18.EscribirTextoOculta("G A M E",
                    /* Coordenadas*/ pie.GetX() - 100, pie.GetY(),
                    /* Color RGB */ 200, 200, 200,
                       spriteBatch); ;
                fuente18.EscribirTextoOculta("O V E R",
                    /* Coordenadas*/ pie.GetX() + 50, pie.GetY(),
                    /* Color RGB */ 200, 200, 200,
                    spriteBatch); ;
            }

        }
    }
}
