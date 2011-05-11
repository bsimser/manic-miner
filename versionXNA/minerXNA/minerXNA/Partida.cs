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
 
   0.08x  11-05-2011  Nacho Cabanes: 
                        DibujarElementos permite varios enemigos por nivel.
                        DibujarElementos actualiza todos los datos del marcador.
                        ComprobarColisiones sigue la lógica de la versión de SDL.

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

        Personaje miPersonaje;
        Enemigo miEnemigo;
        Mapa miPantallaJuego;
        Marcador miMarcador;

        int puntos;             // Puntuacion obtenida por el usuario
        private bool partidaTerminada = false;

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
            for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
                miPantallaJuego.GetEnemigo(i).Mover();
            miPersonaje.Mover( miPantallaJuego );
        }


        // --- Comprobación de teclas, ratón y joystick -----
        public void ComprobarTeclas()
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                partidaTerminada = true;

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
                miPersonaje.MoverIzquierda(miPantallaJuego);
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                miPersonaje.MoverDerecha(miPantallaJuego);


            if (Keyboard.GetState().IsKeyDown(Keys.T) &&
                  (Keyboard.GetState().IsKeyDown(Keys.N)))
                miPantallaJuego.Avanzar();

            // Gamepad de Xbox 360

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                partidaTerminada = true;

            if (GamePad.GetState(PlayerIndex.One).DPad.Right ==  ButtonState.Pressed)
                miPersonaje.MoverDerecha( miPantallaJuego );
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
                miPersonaje.MoverIzquierda(miPantallaJuego);
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
                miPersonaje.Saltar();
        }

        
        // --- Comprobar colisiones de enemigo con personaje, etc ---
        public void ComprobarColisiones()
        {
            // Colisiones de personaje con fondo: obtener puntos o perder vida
            int puntosMovimiento = miPantallaJuego.ObtenerPuntosPosicion(
              miPersonaje.GetX(),
              miPersonaje.GetY(),
              miPersonaje.GetX() + miPersonaje.GetAncho(),
              miPersonaje.GetY() + miPersonaje.GetAlto());

            // Si realmente ha recogido un objeto, sumamos los puntos en el juego
            if (puntosMovimiento > 0)
            {
                puntos += puntosMovimiento;

                // Si ademas es una puerta, avanzamos de nivel
                if (puntosMovimiento == 50)
                    miPantallaJuego.Avanzar();
            }

            // Y si la puntuacion es -1, ha chocado con el fondo:
            // recolocar y perder vida
            if (puntosMovimiento < 0)
            {
                miPersonaje.Morir();
                miPersonaje.Reiniciar();
                for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
                    miPantallaJuego.GetEnemigo(i).Reiniciar();
            }

            // Igual caso para las colisiones de personaje con enemigo
            for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
                if (miPersonaje.ColisionCon(miPantallaJuego.GetEnemigo(i)))
                {
                    miPersonaje.Morir();
                    miPersonaje.Reiniciar();
                    for (int j = 0; j < miPantallaJuego.GetNumEnemigos(); j++)
                        miPantallaJuego.GetEnemigo(i).Reiniciar();
                    break;
                }

            if (miPersonaje.GetVidas() == 0)
                partidaTerminada = true;
        }


        // --- Dibujar todos los elementos en pantalla
        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            // Dibujo todos los elementos
            miPantallaJuego.DibujarOculta(spriteBatch);
            miPersonaje.DibujarOculta(spriteBatch);
            for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
                miPantallaJuego.GetEnemigo(i).DibujarOculta(spriteBatch);

            // Y el marcador
            miMarcador.SetVidas(miPersonaje.GetVidas());
            miMarcador.SetPuntuacion(puntos);
            miMarcador.SetNombre(miPantallaJuego.GetNombre());
            miMarcador.DibujarOculta(spriteBatch);
        }

        public int GetPersonaje()
        {
            return miPersonaje.GetVidas();
        }

        public bool GetTerminada()
        {
            return partidaTerminada;
        }
        
        public void Reiniciar()
        {
            partidaTerminada = false;
            miPersonaje = new Personaje(contenido);
            miPersonaje.SetVelocidad(2,2);
            miEnemigo = new Enemigo(contenido);
            miEnemigo.MoverA(500, 300);
            miPantallaJuego = new Mapa(contenido);
            miMarcador = new Marcador(contenido);
        }


        public Marcador GetMarcador()
        {
            return miMarcador;
        }

    }
}
