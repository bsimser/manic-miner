/* =============================================================
 * Parte de ManicMiner - Remake
 * Partida: lógica real de una sesión de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------

   0.02x  08-02-2011  Nacho Cabanes: Clase "Partida" básica

   0.03x  12-02-2011  Nacho Cabanes: Muestra mapa de fondo (primer nivel).
  
   0.04x  12-02-2011  Nacho Cabanes: Incluye presentación y créditos. Muestra enemigo.
 
   0.05x  24-02-2011  Nacho Cabanes: Creado "CargarContenido". Ampliado "Reiniciar", para reiniciar
                        correctamente una partida. Eliminados "using" innecesarios.
 
   0.06x  29-04-2011  Nacho Cabanes: 
                        Incluido marcador básico.
                        Se puede saltar con Espacio.
                        Se puede pulsar T+N para pasar de nivel (truco).
                        Añadido soporte para Gamepad de Xbox.
 
   0.07x  06-05-2011  Alejandro Guillén: Cada vez que cada vez que se pulsa una 
                        tecla de movimiento, mira si es posible mover.
                      Héctor Pastor Pérez: Añadido un GetMarcador para usarlo 
                        la animación de fin de partida. Comprueba colisiones, 
                        para poder ver fin de partida.
                      Nacho Cabanes: Eliminada la posibilidad de mover
                        arriba y abajo. Ligeras correcciones.

 ============================================================= */

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
        SpriteBatch s;

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
                miPersonaje.MoverIzquierda( miMapa );
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                miPersonaje.MoverDerecha( miMapa );


            if (Keyboard.GetState().IsKeyDown(Keys.T) &&
                  (Keyboard.GetState().IsKeyDown(Keys.N)))
                miMapa.Avanzar();

            // Gamepad de Xbox 360

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                terminada = true;

            if (GamePad.GetState(PlayerIndex.One).DPad.Right ==  ButtonState.Pressed)
                miPersonaje.MoverDerecha( miMapa );
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
                miPersonaje.MoverIzquierda( miMapa );
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
                miPersonaje.Saltar();
        }

        
        // --- Comprobar colisiones de enemigo con personaje, etc ---
        public void ComprobarColisiones()
        {
            // Una sola vida, provisional, para ver animación final
            if (miPersonaje.ColisionCon(miEnemigo))
            {
                terminada = true;
            }
        }


        // --- Dibujar todos los elementos en pantalla
        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            miMapa.DibujarOculta(spriteBatch);
            miMarcador.SetNombre(miMapa.GetNombre());
            miMarcador.DibujarOculta(spriteBatch);
            miPersonaje.DibujarOculta(spriteBatch);
            miEnemigo.DibujarOculta(spriteBatch);
        }

        public int GetPersonaje()
        {
            return miPersonaje.GetVidas();
        }

        public bool GetTerminada()
        {
            return terminada;
        }
        
        public void Reiniciar()
        {
            terminada = false;
            miPersonaje = new Personaje(contenido);
            miPersonaje.MoverA(100, 300);
            miEnemigo = new Enemigo(contenido);
            miEnemigo.MoverA(500, 300);
            miMapa = new Mapa(contenido);
            miMarcador = new Marcador(contenido);
        }


        public Marcador GetMarcador()
        {
            return miMarcador;
        }

    }
}
