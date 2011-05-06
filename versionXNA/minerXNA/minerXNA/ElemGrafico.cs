using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace minerXNA
{

    public class ElemGrafico
    {
        protected Texture2D miImagen;
        protected int x, y;
        protected int incrX, incrY;
        protected int minX, maxX, minY, maxY;
        protected int ancho, alto;
        protected ContentManager miGestorContenido;
        protected bool contieneImagen = false;
        protected bool contieneSecuencia = false;
        protected bool visible;
        protected Texture2D[][] secuencia; // Para cuando sea secuencia de imágenes

        protected byte numDirecciones = 10;
        protected byte direccion;
        public const byte ABAJO = 0;
        public const byte ARRIBA = 1;
        public const byte DERECHA = 2;
        public const byte IZQUIERDA = 3;
        public const byte ABAJOD = 4;
        public const byte ABAJOI = 5;
        public const byte ARRIBAD = 6;
        public const byte ARRIBAI = 7;
        public const byte APARECIENDO = 8;
        public const byte MURIENDO = 9;

        int tamanyoSecuencia = 0;
        int fotogramaActual = 0;
        int velocidadFotograma = 1;
        int contadorHastaSigFotograma = 0;

        public ElemGrafico(ContentManager c)
        {
            contieneImagen = false;
            contieneSecuencia = false;
            x = 0; y = 0;
            incrX = 0; incrY = 0;
            visible = true;
            ancho = 32; alto = 32;  // Valores por defecto
            secuencia = new Texture2D[numDirecciones][];
        }

        public ElemGrafico(string nombreFichero, ContentManager c)
            : this(c)
        {
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
            miImagen = contenido.Load<Texture2D>(nombre);
            //miGestorContenido = c;

            contieneImagen = true;
            contieneSecuencia = false;
        }

        /// Carga la secuencia de imagenes imagen2D
        public void CargarSecuencia(byte direcc, string[] nombres, ContentManager contenido)
        {
            tamanyoSecuencia = (byte)nombres.Length;
            secuencia[direcc] = new Texture2D[tamanyoSecuencia];
            for (byte i = 0; i < tamanyoSecuencia; i++)
            {
                secuencia[direcc][i] = contenido.Load<Texture2D>(nombres[i]);
            }
            contieneImagen = true;
            contieneSecuencia = true;
            direccion = direcc;
        }



        /// Dibuja en pantalla oculta, como parte de un "SpriteBatch"
        public void DibujarOculta(SpriteBatch listaSprites)
        {
            if (!visible)
                return;
            if (contieneSecuencia)
                listaSprites.Draw(secuencia[direccion][fotogramaActual], new Vector2(x, y), Color.White);
            else
                listaSprites.Draw(miImagen, new Vector2(x, y), Color.White);
        }


        /// Dibuja en pantalla oculta en ciertas coordenadas
        public void DibujarOculta(int nuevaX, int nuevaY, SpriteBatch listaSprites)
        {
            MoverA(nuevaX, nuevaY);
            listaSprites.Draw(miImagen, new Vector2(x, y), Color.White);
        }

        /// Devuelve el valor de x
        public short GetX()
        {
            return (short)x;
        }

        /// Devuelve el valor de y
        public short GetY()
        {
            return (short)y;
        }

        /// Cambia el ancho y el alto
        public void SetAnchoAlto(short an, short al)
        {
            alto = al;
            ancho = an;
        }


        /// Cambia la velocidad
        public void SetVelocidad(int vx, int vy)
        {
            incrX = vx;
            incrY = vy;
        }


        /// Pasa a la siguiente posición
        public void Mover()
        {
            x += incrX;
            y += incrY;
        }

        /// Devuelve si está visible
        public bool GetActivo()
        {
            return visible;
        }

        /// Cambia si está visible o no )
        public void SetVisible(bool a)
        {
            visible = a;
        }


        /// Comprueba si ha chocado con otro elemento gráfico
        public bool ColisionCon(ElemGrafico otroElem)
        {
            // No se debe chocar con un elemento oculto      
            if ((visible == false) || (otroElem.visible == false))
                return false;
            // Ahora ya compruebo coordenadas
            if ((otroElem.x + otroElem.ancho > x)
                && (otroElem.y + otroElem.alto > y)
                && (x + ancho > otroElem.x)
                && (y + alto > otroElem.y))
                return true;
            else
                return false;
        }


        /// Mueve el elemento grafico a otra posicion
        public void CambiarDireccion(byte nuevaDir)
        {
            if (direccion != nuevaDir)
            {
                direccion = nuevaDir;
                fotogramaActual = 0;
                tamanyoSecuencia = (byte)secuencia[direccion].Length;
            }

        }


        /// Prepara el siguiente fotograma, para animar el movimiento de
        /// un personaje
        public void SiguienteFotograma()
        {
            if (!contieneSecuencia)
                return;

            contadorHastaSigFotograma++;
            if (contadorHastaSigFotograma < velocidadFotograma)
            {
                contadorHastaSigFotograma++;
                return;
            }
            else
                contadorHastaSigFotograma = 0;

            if (fotogramaActual < secuencia[direccion].Length - 1)
                fotogramaActual++;
            else
                fotogramaActual = 0;
        }

        public void SetVelocidadFotograma(int v)
        {
            velocidadFotograma = v;
        }

        public void setMinMaxX(short minimo, short maximo)
        {
            minX = minimo;
            maxX = maximo;
        }

        public void setMinMaxY(short minimo, short maximo)
        {
            minY = minimo;
            maxY = maximo;
        }


    }

}
