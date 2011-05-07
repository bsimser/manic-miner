/* Gestor de pantallas: muestra la presentación, la pantalla de créditos
 * o la partida, según corresponda
 * ------------------------------------------------------
 * Fecha:               Autor/Cambios realizados:
 * 06/05/2011           Héctor Pastor Pérez 
 *                      Añadido un nuevo modo "FINAL" para 
 *                      cuando se tenga que mostrar la animación
 *                      de juego terminado.
 *                      Añadida animacion de fin de partida,
 *                      adaptada la función "Update" para que 
 *                      cambie a modo "FINAL"
 *                      Adaptada la funcion "Draw" para que dibuje
 *                      la animación y el marcador en caso de estar
 *                      en modo "FINAL"
 *                      Añadido modo para pantalla de ayuda
 *                      Añadido modo para pantalla de opciones
 * ------------------------------------------------------*/

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace minerXNA
{
    /// <summary>
    /// Esta es la clase que coordina a todas las demás
    /// </summary>
    public class GestorPantallas: Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Ayuda miAyuda;
        Opciones misOpciones;
        Presentacion miPresentacion;
        Creditos pantallaCreditos;
        Partida miPartida;
        AnimacionFinDeJuego miAnimacion;

        const byte MODO_PRESENT = 0;
        const byte MODO_JUEGO = 1;
        const byte MODO_CREDITOS = 2;

        //Para cuando se tenga que mostrar la animación de fin de partida
        const byte MODO_FINAL = 3;

        //Para cuando se tenga que mostrar la pantalla de opciones
        const byte MODO_OPCIONES = 4;

        const byte MODO_AYUDA = 5;

        byte modo;
        

        public GestorPantallas()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";

            miAyuda = new Ayuda(Content);
            misOpciones = new Opciones(Content);
            miAnimacion = new AnimacionFinDeJuego(Content);
            miPresentacion = new Presentacion(graphics, Content);
            pantallaCreditos = new Creditos(graphics, Content);
            miPartida = new Partida(graphics, Content);
            modo = MODO_PRESENT;
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

            miAyuda.CargarContenido();
            misOpciones.CargarContenido();
            miAnimacion.CargarContenido();
            miPresentacion.CargarContenido();
            pantallaCreditos.CargarContenido();
            miPartida.CargarContenido();
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
            // Permite interrumpir el juego
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Si estamos en modo de presentación
            if (modo == MODO_PRESENT)
            {
                miPresentacion.MoverElementos();
                miPresentacion.ComprobarTeclas();
                miPresentacion.ComprobarColisiones();
                if (miPresentacion.GetTerminada())
                {
                    switch (miPresentacion.GetOpcionEscogida())
                    {
                        case Presentacion.OPC_PARTIDA: modo = MODO_JUEGO; break;
                        case Presentacion.OPC_CREDITOS: modo = MODO_CREDITOS; break;
                        case Presentacion.OPC_SALIR: this.Exit(); break;
                        case Presentacion.OPC_OPCIONES: modo = MODO_OPCIONES; break;
                        case Presentacion.OPC_AYUDA: modo = MODO_AYUDA; break;
                    }
                    miPresentacion.Reiniciar();
                }
            }
            else
            // Si estamos en modo de presentación
            if (modo == MODO_CREDITOS)
            {
                pantallaCreditos.MoverElementos();
                pantallaCreditos.ComprobarTeclas();
                pantallaCreditos.ComprobarColisiones();
                if (pantallaCreditos.GetTerminada())
                {
                    modo = MODO_PRESENT;
                    pantallaCreditos.Reiniciar();
                }
            }
            else
            // Si estamos viendo la animación de fin de juego
            if (modo == MODO_FINAL)
            {
                miAnimacion.ComprobarTeclas();
                if (miAnimacion.GetTerminada())
                {
                    miAnimacion.Reiniciar();
                    modo = MODO_PRESENT;
                }
            }
            else
            // Si estamos viendo la ayuda
            if (modo == MODO_AYUDA)
            {
                miAyuda.ComprobarTeclas();
                if (miAyuda.GetTerminada())
                {
                    miAyuda.Reiniciar();
                    modo = MODO_PRESENT;
                }
            }
            else
            // Si estamos en modo opciones
            if (modo == MODO_OPCIONES)
            {
                misOpciones.ComprobarTeclas();
                if (misOpciones.GetTerminada())
                {
                    modo = MODO_PRESENT;
                    misOpciones.Reiniciar();
                }
            }
            // Si estamos en modo de juego
            else
            {
                miPartida.MoverElementos();
                miPartida.ComprobarTeclas();
                miPartida.ComprobarColisiones();
                if (miPartida.GetTerminada())
                {
                    modo = MODO_FINAL;
                    miPartida.Reiniciar();
                }
            }

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

            // Si estamos en modo de presentación
            if (modo == MODO_PRESENT)
            {
                miPresentacion.DibujarElementos(spriteBatch);
            }
            // Si estamos en modo de presentación
            else if (modo == MODO_CREDITOS)
            {
                pantallaCreditos.DibujarElementos(spriteBatch);
            }
            // Si estamos en modo de opciones
            else if (modo == MODO_OPCIONES)
            {
                misOpciones.DibujarElementos(spriteBatch);
            }
            // Si estamos en modo de opciones
            else if (modo == MODO_AYUDA)
            {
                miAyuda.DibujarElementos(spriteBatch);
            }
            // Si estamos en la animación de final
            else if (modo == MODO_FINAL)
            {
                /* Se dibuja tanto la animación como el marcador, ya que 
                 * el fondo de la animación debe aparecer sobre el marcador*/
                miAnimacion.DibujarElementos(spriteBatch);
                miPartida.GetMarcador().DibujarOculta(spriteBatch);
            }
            // Si estamos en modo de juego
            else
            {
                miPartida.DibujarElementos(spriteBatch);
            }
            
            
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public GraphicsDevice GetGraphics()
        {
            return graphics.GraphicsDevice;
        }

    }
}
