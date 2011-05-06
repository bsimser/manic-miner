using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class Creditos
    {
            // Los dos elementos necesarios para coordinar con el resto del juego
            GraphicsDeviceManager graphics;
            ContentManager contenido;

            // Imágenes y tipos de letra    
            ElemGrafico imagenFondo;
            Fuente fuente18;

            // Posicion y velocidad de un texto que se movera solo    
            int xTexto = 320, yTexto = 500;
            int incrX = 1, incrY = 1;

            // Opciones posibles
            private bool terminada;

            public Creditos(GraphicsDeviceManager dispositivo, ContentManager c)
            {
                graphics = dispositivo;
                contenido = c;
            }

            public void CargarContenido()
            {
                imagenFondo = new ElemGrafico("creditos", contenido);
                fuente18 = new Fuente("Lucida Console", contenido);
            }


            public void MoverElementos()
            {
                // Mover elementos (texto)
                xTexto += incrX;
                yTexto += incrY;

                if ((xTexto < 100) || (xTexto > 520)) incrX = -incrX;
                if ((yTexto < 500) || (yTexto > 560)) incrY = -incrY;
            }


            public void ComprobarTeclas()
            {
                // Comprobacion de teclas para salir
                if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    terminada = true;
            }


            public void ComprobarColisiones()
            {
                // Nada por ahora
            }



            public void DibujarElementos(SpriteBatch spriteBatch)
            {
                imagenFondo.DibujarOculta(0, 0, spriteBatch);
                fuente18.EscribirTextoOculta("Remake 2011 por Nacho",
                       /* Coordenadas*/ xTexto, yTexto, /* Color RGB */ 200, 200, 200, 
                       spriteBatch);
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
