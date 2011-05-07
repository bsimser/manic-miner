
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
            fuente18.EscribirTextoOculta("Ayuda:", 380, 0, 255, 0, 0, spriteBatch);
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
