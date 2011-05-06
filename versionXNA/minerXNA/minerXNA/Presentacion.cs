using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class Presentacion 
    {
            // Los dos elementos necesarios para coordinar con el resto del juego
            GraphicsDeviceManager graphics;
            ContentManager contenido;

            // Imágenes y tipos de letra    
            ElemGrafico imagenFondo;
            Fuente fuente18;

            // Opciones posibles
            public const byte OPC_NINGUNA = 0;
            public const byte OPC_PARTIDA = 1;
            public const byte OPC_SALIR = 2;
            public const byte OPC_CREDITOS = 3;

            private bool terminada;

            private int opcionEscogida = OPC_NINGUNA;

            public Presentacion(GraphicsDeviceManager dispositivo, ContentManager c)
            {
                graphics = dispositivo;
                contenido = c;
            }

            public void CargarContenido()
            {
                imagenFondo = new ElemGrafico("present", contenido);
                fuente18 = new Fuente("Lucida Console", contenido);
            }


            public void MoverElementos()
            {
                // Nada por ahora
            }


            public void ComprobarTeclas()
            {

                // Comprobacion de teclas para salir
                if (Keyboard.GetState().IsKeyDown(Keys.J))  // J = Jugar
                {
                    opcionEscogida = OPC_PARTIDA;
                    terminada = true;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.C))  // C = Creditos
                {
                    opcionEscogida = OPC_CREDITOS;
                    terminada = true;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.S))  // S = Salir
                {
                    opcionEscogida = OPC_SALIR;
                    terminada = true;
                }
            }


            public void ComprobarColisiones()
            {
                // Nada por ahora
            }


            public void DibujarElementos(SpriteBatch spriteBatch)
            {
                imagenFondo.DibujarOculta(0, 0, spriteBatch);
                fuente18.EscribirTextoOculta("Pulsa J para Jugar",
                       320, 520, Color.White, spriteBatch);
                fuente18.EscribirTextoOculta("C para Creditos o S para Salir",
                       260, 550, Color.WhiteSmoke, spriteBatch);
            }


            public int GetOpcionEscogida()
            {
                return opcionEscogida;
            }


            public void Reiniciar()
            {
                opcionEscogida= OPC_NINGUNA;
                terminada = false;
            }


            public bool GetTerminada()
            {
                return terminada;
            }
      }

}

