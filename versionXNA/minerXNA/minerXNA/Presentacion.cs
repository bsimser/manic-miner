using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    class Presentacion //: Microsoft.Xna.Framework.Game
    {
            GraphicsDeviceManager graphics;
            ContentManager contenido;
            Texture2D imagenFondo;
            SpriteFont fuente18;

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

            public void LoadContent()
            {
                imagenFondo = contenido.Load<Texture2D>("present");
                fuente18 = contenido.Load<SpriteFont>("Lucida Console");
            }

            
            public void Update()
            {
                // Mover elementos: nada por ahora

                // Colisiones: nada por ahora

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


            public void DibujarElementos(SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(imagenFondo, new Vector2(0,0), Color.White);
                spriteBatch.DrawString(fuente18, "Pulsa J para Jugar",
                       new Vector2(320, 520), Color.White);
                spriteBatch.DrawString(fuente18, "C para Creditos o S para Salir",
                       new Vector2(260, 550), Color.WhiteSmoke);
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

