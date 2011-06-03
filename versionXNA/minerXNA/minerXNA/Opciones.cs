
/* =============================================================
 * Parte de ManicMiner - Remake
 * Opciones: Dará al usuario a elegir opciones sobre el juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.07x  06-05-2011  Héctor Pastor Pérez 
                        Creada la clase Opciones
   0.10x  18-05-2011  David Guerra Abad
                        Cambio en opciones para que se
                           pueda seleccionar nivel (no terminado)
                      Nacho Cabanes
                        Se muestra el nivel escogido; ligeros cambios estéticos

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
        int nivelInicio;

        // Opciones posibles
        private bool terminada;

        public Opciones(ContentManager c)
        {
            guardado = false;
            activado = "No";
            contenido = c;
            nivelInicio = 0;
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
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                if(nivelInicio != 0)
                    nivelInicio --;
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                if (nivelInicio != 19)
                    nivelInicio ++;
        }

        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            fuente18.EscribirTextoOculta
                ("Opciones:", 300, 100, 255, 0, 0, spriteBatch);
            fuente18.EscribirTextoOculta
                ("(M) Musica: " + activado + " (todavía no implementado)", 
                100, 200, 128, 128, 128, spriteBatch);
            fuente18.EscribirTextoOculta
                ("(<-) Nivel Inicio : " + (nivelInicio + 1) + " (->)  (todavía no efectivo)",
                100, 250, 128, 128, 128, spriteBatch);
            fuente18.EscribirTextoOculta
                ("(G) Guardar Partida (todavía no implementado):",
                100, 300, 128, 128, 128, spriteBatch);
            if (guardado)
                fuente18.EscribirTextoOculta
                    ("Partida guardada (todavía no implementado)", 120, 350, 128, 128, 128, spriteBatch);
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
