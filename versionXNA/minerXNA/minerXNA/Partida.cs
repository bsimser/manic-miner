// Partida: lógica real de una sesión de juego

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minerXNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Partida 
    {
        // Los dos elementos necesarios para coordinar con el resto del juego
        GraphicsDeviceManager graphics;
        ContentManager contenido;

        Personaje miPersonaje;
        Enemigo miEnemigo;
        Mapa miMapa;
        Marcador miMarcador;

        private bool terminada = false;

        public Partida(GraphicsDeviceManager dispositivo, ContentManager c)
        {
            graphics = dispositivo;
            contenido = c;
        }


        public void CargarContenido()
        {
            Reiniciar();
        }


        public void MoverElementos()
        {
            miEnemigo.Mover();
            miPersonaje.Mover();
        }


        // --- Comprobación de teclas, ratón y joystick -----
        public void ComprobarTeclas()
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                terminada = true;

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    miPersonaje.SaltarIzquierda();
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    miPersonaje.SaltarDerecha();
                else
                miPersonaje.Saltar();
                return; // No miro más teclas si comienza el salto
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                miPersonaje.MoverIzquierda();
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                miPersonaje.MoverDerecha();
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                miPersonaje.MoverArriba();
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                miPersonaje.MoverAbajo();
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                miPersonaje.MoverAbajo();

            if (Keyboard.GetState().IsKeyDown(Keys.T) &&
                  (Keyboard.GetState().IsKeyDown(Keys.N)))
                miMapa.Avanzar();

            // Gamepad de Xbox 360

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                terminada = true;

            if (GamePad.GetState(PlayerIndex.One).DPad.Right ==  ButtonState.Pressed)
                miPersonaje.MoverDerecha();
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
                miPersonaje.MoverIzquierda();
            if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed)
                miPersonaje.MoverArriba();
            if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed)
                miPersonaje.MoverAbajo();
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
                miPersonaje.Saltar();
        }

        
        // --- Comprobar colisiones de enemigo con personaje, etc ---
        public void ComprobarColisiones()
        {
            // Nada por ahora
        }


        // --- Dibujar todos los elementos en pantalla
        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            miMapa.DibujarOculta(spriteBatch);
            miMarcador.DibujarOculta(spriteBatch);
            miPersonaje.DibujarOculta(spriteBatch);
            miEnemigo.DibujarOculta(spriteBatch);
        }


        public bool GetTerminada()
        {
            return terminada;
        }


        public void Reiniciar()
        {
            terminada = false;
            miPersonaje = new Personaje(contenido);
            miPersonaje.MoverA(400, 300);
            miEnemigo = new Enemigo(contenido);
            miMapa = new Mapa(contenido);
            miMarcador = new Marcador(contenido);
        }
    }
}
