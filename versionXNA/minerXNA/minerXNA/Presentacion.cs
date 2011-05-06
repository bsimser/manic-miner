using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace minerXNA
{
    class Presentacion : Microsoft.Xna.Framework.Game
    {
            GraphicsDeviceManager graphics;
            SpriteBatch spriteBatch;
            Texture2D imagenPresentacion;
    
            // Opciones posibles
            public const byte OPC_NINGUNA = 0;
            public const byte OPC_PARTIDA = 1;
            public const byte OPC_SALIR = 2;
            public const byte OPC_CREDITOS = 3;

            private int opcionEscogida = OPC_NINGUNA;

            public Presentacion()
            {
                graphics = new GraphicsDeviceManager(this);
                graphics.PreferredBackBufferWidth = 800;
                graphics.PreferredBackBufferHeight = 600;
                Content.RootDirectory = "Content";

            }

            protected override void Initialize()
            {
                base.Initialize();
            }

            protected override void LoadContent()
            {
                spriteBatch = new SpriteBatch(GraphicsDevice);
                imagenPresentacion = Content.Load<Texture2D>("present");
                //imagenPresentacion = Texture2D.FromStream(graphics.GraphicsDevice,
                //    new FileStream("imagenes\\present.png", FileMode.Open));
            }

            protected override void UnloadContent()
            {
                // No usado por ahora
            }

            protected override void Update(GameTime gameTime)
            {
                // Mover elementos: nada por ahora

                // Colisiones: nada por ahora

                // Comprobacion de teclas para salir
                if (Keyboard.GetState().IsKeyDown(Keys.J))  // J = Jugar
                {
                    opcionEscogida = OPC_PARTIDA;
                    this.Exit();
                }

                if (Keyboard.GetState().IsKeyDown(Keys.C))  // C = Creditos
                {
                    opcionEscogida = OPC_CREDITOS;
                    this.Exit();
                }

                if (Keyboard.GetState().IsKeyDown(Keys.S))  // S = Salir
                {
                    opcionEscogida = OPC_SALIR;
                    this.Exit();
                }

                base.Update(gameTime);
            }


            protected override void Draw(GameTime gameTime)
            {
                GraphicsDevice.Clear(Color.Black);

                spriteBatch.Begin();
                spriteBatch.Draw(imagenPresentacion, new Vector2(0,0), Color.White);
                spriteBatch.End();

                base.Draw(gameTime);
            }


            public int GetOpcionEscogida()
            {
                return opcionEscogida;
            }
      }

}

