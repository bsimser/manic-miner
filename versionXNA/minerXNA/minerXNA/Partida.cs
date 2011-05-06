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
    public class Partida 
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont fuente18;
        Presentacion miPresentacion;
        Creditos pantallaCreditos;
        ContentManager contenido;

        Personaje miPersonaje;
        Enemigo miEnemigo;
        Mapa miMapa;

        private bool terminada = false;

        public Partida(GraphicsDeviceManager dispositivo, ContentManager c)
        {
            graphics = dispositivo;
            contenido = c;
        }


        public void LoadContent()
        {
            fuente18 = contenido.Load<SpriteFont>("Lucida Console");
            miPersonaje = new Personaje(contenido);
            miPersonaje.MoverA(400, 300);

            miEnemigo = new Enemigo(contenido);
            miMapa = new Mapa(contenido);

        }


        public void MoverElementos()
        {
            miEnemigo.Mover();
        }


        // --- Comprobación de teclas, ratón y joystick -----
        public void ComprobarTeclas()
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                terminada = true;

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
        public void ComprobarColisiones()
        {
            // Nada por ahora
        }


        // --- Dibujar todos los elementos en pantalla
        public void DibujarElementos(SpriteBatch spriteBatch)
        {
            miMapa.DibujarOculta(spriteBatch);
            miPersonaje.DibujarOculta(spriteBatch);
            miEnemigo.DibujarOculta(spriteBatch);
            spriteBatch.DrawString(fuente18, "Texto de ejemplo",
                       new Vector2(300, 50), Color.LightGreen);
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
