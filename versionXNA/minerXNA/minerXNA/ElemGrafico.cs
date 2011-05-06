﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace minerXNA
{
    class ElemGrafico
    {
        protected Texture2D miImagen;
        protected int x, y;
        protected int incrX, incrY;
        protected ContentManager miGestorContenido;
        protected bool contieneImagen = false;
        protected bool contieneSecuencia = false;

        


        public ElemGrafico(string nombreFichero, ContentManager c)
        {
            x = 0; y = 0;
            incrX = 0; incrY = 0;
            CargarImagen(nombreFichero, c);
        }

        /// Mueve el elemento grafico a otra posicion
        public void MoverA(int nuevaX, int nuevaY)
        {
            x = (short)nuevaX;
            y = (short)nuevaY;
        }

        /// Carga la imagen que representara a este elemento grafico
        public void CargarImagen(string nombre, ContentManager contenido)
        {
            //miImagen = Texture2D.FromStream(miPartida.GetGraphics(), 
            //    new FileStream ( nombre ,FileMode.Open ) );
            miImagen = contenido.Load<Texture2D>( nombre );
            //miGestorContenido = c;
            
            contieneImagen = true;
            contieneSecuencia = false;
        }


        /// Dibuja en pantalla oculta, como parte de un "SpriteBatch"
        public void DibujarOculta(SpriteBatch listaSprites)
        {
            listaSprites.Draw(miImagen, new Vector2(x, y), Color.White);
        }


        /// Dibuja en pantalla oculta en ciertas coordenadas
        public void DibujarOculta(int nuevaX, int nuevaY, SpriteBatch listaSprites)
        {
            MoverA(nuevaX, nuevaY);
            listaSprites.Draw(miImagen, new Vector2(x, y), Color.White);
        }
    }
}
