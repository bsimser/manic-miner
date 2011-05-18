
/* =============================================================
 * Parte de ManicMiner - Remake
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.07x  06-05-2011  Héctor Pastor Pérez 
                        Creada la clase Ayuda

 ============================================================= */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class Ayuda
    {
        ContentManager contenido;
        Fuente fuente18;

        // Opciones posibles
        private bool terminada;

        public Ayuda(ContentManager c)
        {
            contenido = c;
        }

        public void CargarContenido()
        {
            fuente18 = new Fuente("Lucida Console", contenido);
        }

        public void ComprobarTeclas()
        {
            // Comprobacion de teclas
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                terminada = true;
        }

        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            fuente18.EscribirTextoOculta("Ayuda:", 380, 100, 255, 0, 0, spriteBatch);

            fuente18.EscribirTextoOculta("- Usa las flechas para mover a izquierda y derecha",
                100, 200, 128, 128, 128, spriteBatch);
            fuente18.EscribirTextoOculta("- Usa espacio para saltar",
                100, 230, 128, 128, 128, spriteBatch);
            fuente18.EscribirTextoOculta("- Recoge todas las llaves y abre la puerta para avanzar nivel",
                100, 260, 128, 128, 128, spriteBatch);
            fuente18.EscribirTextoOculta("- Pulsa ESC para abandonar la partida",
                100, 290, 128, 128, 128, spriteBatch);
        }


        public bool GetTerminada()
        {
            return terminada;
        }

        public void Reiniciar()
        {
            terminada = false;
        }
    }


}
