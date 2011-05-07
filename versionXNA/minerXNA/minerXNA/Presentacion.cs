/* =============================================================
 * Parte de ManicMiner - Remake
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  17-Dic-2010  Nacho Cabanes
                      Version inicial en SDL: muestra la pantalla de presentacion 
                        y permite entra a créditos o jugar una partida
   0.06  26-Dic-2010  Nacho Cabanes
                      El "triángulo" se mueve en la pantalla, rebotando en 
                        los extremos.
   0.07  27-Dic-2010  Nacho Cabanes
                      Se entra al juego con J, no con Espacio.
                      Añadido O para opciones.

   0.03x  12-02-2011  Nacho Cabanes: Adaptación básica a XNA
  
   0.04x  12-02-2011  Nacho Cabanes: Se apoya en el "Gestor de Pantallas"
  
   0.05x  24-02-2011  Nacho Cabanes: Usa las clases ElemGrafico y Fuente
 
   0.07x  06-05-2011  Héctor Pastor: Comprueba teclas (y muestra textos) para 
                        acceder a Ayuda y Opciones.
                      Denys Demyanchuk: Triángulo en movimiento.
                      Nacho Cabanes: Correcciones en animación

 ============================================================= */

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
            ElemGrafico imagenFondo, cartelMovil;
            Fuente fuente18;

            // Coordenadas del cartel móvil
            int x=400, y=100;
            int incrX = 2, incrY = 2;

            // Opciones posibles
            public const byte OPC_NINGUNA = 0;
            public const byte OPC_PARTIDA = 1;
            public const byte OPC_SALIR = 2;
            public const byte OPC_CREDITOS = 3;
            public const byte OPC_OPCIONES = 4;
            public const byte OPC_AYUDA = 5;
            private bool terminada;

            private int opcionEscogida = OPC_NINGUNA;
            
            // Colores del texto
            byte rojo = 50, verde = 255, azul = 50;
            int contadorFotogramas = 0;
            System.Random aleatorio;

            public Presentacion(GraphicsDeviceManager dispositivo, ContentManager c)
            {
                graphics = dispositivo;
                contenido = c;
                aleatorio = new System.Random();
            }

            public void CargarContenido()
            {
                imagenFondo = new ElemGrafico("present", contenido);
                cartelMovil = new ElemGrafico("present_triang", contenido);
                fuente18 = new Fuente("Lucida Console", contenido);
            }


            public void MoverElementos()
            {
                // Desplazo el cartel móvil
                x += incrX;
                y += incrY;

                // Invierto velocidad si llega al borde
                if ((x < 10) || (x > 800 - 10 - 192))
                    incrX = -incrX;
                if ((y < 10) || (y > 600 - 10 - 196))
                    incrY = -incrY;
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


                if (Keyboard.GetState().IsKeyDown(Keys.O))  // O = Opciones
                {
                    opcionEscogida = OPC_OPCIONES;
                    terminada = true;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.A))  // A = Ayuda
                {
                    opcionEscogida = OPC_AYUDA;
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

                fuente18.EscribirTextoOculta("Pulsa J para Jugar, O para opciones",
                       250, 520, Color.White, spriteBatch);
                fuente18.EscribirTextoOculta
                    ("A para ayuda, C para Creditos o S para Salir",
                       220, 550, Color.WhiteSmoke, spriteBatch);

                cartelMovil.DibujarOculta(x, y, spriteBatch);            
                

                //fuente18.EscribirTextoOculta(" MANIC MINER",
                //    /* Coordenadas */ 320, 400, rojo, verde, azul, spriteBatch);
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

