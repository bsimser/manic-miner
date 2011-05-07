
/* =============================================================
 * Parte de ManicMiner - Remake
 * Opciones: Dará al usuario a elegir opciones sobre el juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.07x  06-05-2011  Héctor Pastor Pérez 
                        Creada la clase Opciones

 ============================================================= */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class Opciones
    {
        ContentManager contenido;
        Fuente fuente18;
        string activado;
        bool guardado;

        // Opciones posibles
        private bool terminada;

        public Opciones(ContentManager c)
        {
            guardado = false;
            activado = "No";
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
            if (Keyboard.GetState().IsKeyDown(Keys.M))
                if (activado == "No")
                    activado = "Si";
                else activado = "No";
            if (Keyboard.GetState().IsKeyDown(Keys.G))
                guardado = true;
        }

        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            fuente18.EscribirTextoOculta
                ("Opciones:", 300, 0, 255, 0, 0, spriteBatch);
            fuente18.EscribirTextoOculta
                ("(M) Musica:", 300, 100, 255, 0, 0, spriteBatch);
            fuente18.EscribirTextoOculta
                (activado, 450, 100, 255, 0, 0, spriteBatch);
            fuente18.EscribirTextoOculta
                ("(G) Guardar Partida:", 300, 150, 255, 0, 0, spriteBatch);
            if (guardado)
                fuente18.EscribirTextoOculta
                    ("Partida guardada", 300, 200, 255, 0, 0, spriteBatch);
        }


        public bool GetTerminada()
        {
            return terminada;
        }

        public void Reiniciar()
        {
            guardado = false;
            terminada = false;
        }
    }


}
