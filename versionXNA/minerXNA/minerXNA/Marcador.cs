/** 
 *   Marcador: muestra puntos, vidas, aire, mejor punt.
 *  
 *   @see Hardware ElemGrafico Juego
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.10  31-Dic-2010  Nacho Cabanes
                      Primera versión de la clase Marcador
   0.11  02-Ene-2011  Nacho Cabanes
                      Incluido el campo "Nombre", que muestra nombre de nivel
 ---------------------------------------------------- */

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace minerXNA
{

    public class Marcador
    {
        private ElemGrafico imgVidas, imgEnergia;
        private ElemGrafico imgAireRojo, imgAireRojoVacio, imgAireVerde, imgAireVerdeVacio;
        private ElemGrafico imgFondoMetal;
        private int aire;
        private int puntuacion;
        private int mejorPunt;
        private int vidas;
        private string nombreNivel;

        //private Partida miPartida;
        Fuente tipoDeLetra;

        public void SetVidas(int valor)
        {
            vidas = valor;
        }

        public int GetVidas()
        {
            return vidas;
        }

        public Marcador(ContentManager c)
        {
            //miPartida = p;
            //tipoDeLetra = new Fuente("FreeSansBold.ttf", 18);
            imgVidas = new ElemGrafico("personaje", c);
            imgAireRojo = new ElemGrafico("aireRojo", c);
            imgAireRojoVacio = new ElemGrafico("aireRojoV", c);
            imgAireVerde = new ElemGrafico("aireVerde", c);
            imgAireVerdeVacio = new ElemGrafico("aireVerdeV", c);
            imgFondoMetal = new ElemGrafico("metal", c);
        }


        /// Devuelve el valor del aire
        public int GetAire()
        {
            return aire;
        }


        /// Cambia el valor del aire
        public void SetAire(int valor)
        {
            aire = valor;
        }

        /// Incrementa el valor del aire
        public void IncrAire(int valor)
        {
            aire += valor;
        }


        /// Devuelve el valor de la puntuación
        public int GetPuntuacion()
        {
            return puntuacion;
        }


        /// Cambia el valor de la mejor puntuación
        public void SetMejorPuntuacion(int valor)
        {
            mejorPunt = valor;
        }


        /// Cambia el valor del nombre del nivel
        public void SetNombre(string valor)
        {
            nombreNivel = valor;
        }


        /// Cambia el valor de la puntuación
        public void SetPuntuacion(int valor)
        {
            puntuacion = valor;
        }


        /// Incrementa el valor de la puntuación
        public void IncrPuntuacion(int valor)
        {
            puntuacion += valor;
        }


        public void DibujarOculta(SpriteBatch listaSprites)
        {

            // Carteles  
            //Hardware.EscribirTextoOculta("Vidas: " + miPartida.GetPersonaje().GetVidas(),
            //   280, 550, 0xAA, 0xAA, 0xAA, tipoDeLetra);


            // TODO: Por adaptar al formato de XNA
            //Hardware.EscribirTextoOculta("Mejor puntuación: 000000",
            //   200, 520, 0xFF, 0xFF, 0x00, tipoDeLetra);
            //Hardware.EscribirTextoOculta("Puntos: " + puntuacion.ToString("000000"),
            //   550, 520, 0xFF, 0xFF, 0x00, tipoDeLetra);

            // Borde superior e inferior y nombre de nivel (prefijado por ahora)
            imgFondoMetal.DibujarOculta(0, 0, listaSprites);
            imgFondoMetal.DibujarOculta(0, 420, listaSprites);
            //Hardware.EscribirTextoOculta(nombreNivel,
            //    350, 430, 0,0,0, tipoDeLetra);

            // Medidor de aire
            int i;
            for (i = 0; i < 200; i++)
            {
                if (i < 25) imgAireRojo.DibujarOculta(i * 4, 460, listaSprites);
                else if (i < 60) imgAireRojoVacio.DibujarOculta(i * 4, 460, listaSprites);
                else if (i < 175) imgAireVerdeVacio.DibujarOculta(i * 4, 460, listaSprites);
                else imgAireVerde.DibujarOculta(i * 4, 460, listaSprites);
            }
            //Hardware.EscribirTextoOculta("Aire",
            //  10, 464, 0, 0, 0, tipoDeLetra);

            // Vidas, como barra (maximo 10 segmentos)
            int vidasMostrar = vidas;
            if (vidasMostrar > 5) vidasMostrar = 5;
            for (i = 0; i < vidasMostrar; i++)
            {
                imgVidas.DibujarOculta(20 + 40 * i, 500, listaSprites);
            }

        }
    } /* end class Marcador */
}
