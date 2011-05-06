using System;
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
        protected Partida miPartida;
        protected bool contieneImagen = false;
        protected bool contieneSecuencia = false;

        


        public ElemGrafico(string nombreFichero, Partida p)
        {
            x = 0; y = 0;
            incrX = 0; incrY = 0;
            miPartida = p;
            CargarImagen(nombreFichero);
        }

        /// Mueve el elemento grafico a otra posicion
        public void MoverA(int nuevaX, int nuevaY)
        {
            x = (short)nuevaX;
            y = (short)nuevaY;
        }

        /// Carga la imagen que representara a este elemento grafico
        public void CargarImagen(string nombre)
        {
            miImagen = Texture2D.FromStream(miPartida.GetGraphics(), 
                new FileStream ( nombre ,FileMode.Open ) );
            
            contieneImagen = true;
            contieneSecuencia = false;
        }


        /// Dibuja en pantalla oculta, como parte de un "SpriteBatch"
        public void DibujarOculta(SpriteBatch listaSprites)
        {
            listaSprites.Draw(miImagen, new Vector2(x, y), Color.White);
        }
    }
}
