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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Partida : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont fuente18;

        Personaje miPersonaje;
        Enemigo miEnemigo;
        Mapa miMapa;

        public Partida()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            miPersonaje = new Personaje( this );
            miPersonaje.MoverA(400, 300);
            fuente18 = Content.Load<SpriteFont>("Lucida Console");

            miEnemigo = new Enemigo(this);
            miMapa = new Mapa(this);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            MoverElementos();
            ComprobarTeclas();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            miMapa.DibujarOculta(spriteBatch);
            miPersonaje.DibujarOculta(spriteBatch);
            miEnemigo.DibujarOculta(spriteBatch);
            spriteBatch.DrawString(fuente18, "Texto de ejemplo",
                       new Vector2(300, 50), Color.LightGreen);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public GraphicsDevice GetGraphics()
        {
            return graphics.GraphicsDevice;
        }


        public void MoverElementos()
        {
            miEnemigo.Mover();
        }


        // --- Comprobación de teclas, ratón y joystick -----
        public void ComprobarTeclas()
        {
            // Permite interrumpir el juego
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                miPersonaje.MoverIzquierda();
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                miPersonaje.MoverDerecha();
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                miPersonaje.MoverArriba();
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                miPersonaje.MoverAbajo();
        }


        // --- Comprobar colisiones de enemigo con personaje, etc ---
        void comprobarColisiones()
        {
            // Nada por ahora
        }
    }
}
