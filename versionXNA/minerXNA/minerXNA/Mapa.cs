/** 
 *   Mapa: Mapa (array) que representa a un nivel de juego
 *  
 *   @see Hardware ElemGrafico Juego
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.03  23-Dic-2010  Nacho Cabanes
                      Mapa inicial, de la primera pantalla
   0.04  24-Dic-2010  Nacho Cabanes
                      Añadido "EsPosibleMover", que comprueba si un
                        rectangulo se solapa con alguna casilla
                        no pisable
   0.08  28-Dic-2010  Nacho Cabanes
                      Añadido un "hueco" en la fila superior, para poder bajar
   0.09  29-Dic-2010  Nacho Cabanes
                      Añadido "ObtenerPuntosPosicion"
                      EsPosibleMover permite tocar llaves, puertas, arboles
                      Creado un array que se modifica, disinto del de definicion
                      Creado un "reiniciar", que devuelve el array a su estado inicial
   0.10  31-Dic-2010  Nacho Cabanes
                      Cambiado el margen superior de 100 a 40
   0.11  02-Ene-2011  Nacho Cabanes
                      Pasadas casi todas sus funcionalidades a "Nivel"
                      Ahora contiene un array de niveles y permite avanzar al siguiente.
   0.13  07-Ene-2011  Nacho Cabanes
                      Al reiniciar (comenzar nueva partida), se vuelve al primer nivel.
   0.14  23-Ene-2011  Nacho Cabanes
                      Añadidos GetNumEnmigos y GetEnemigo(i), que delegan en Nivel

 ---------------------------------------------------- */

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace minerXNA
{
    public class Mapa
    {
        Nivel nivelActual;
        Nivel[] listaNiveles;
        const int MAX_NIVELES = 20;
        int numeroNivelActual = 0;
        //Fuente fuente18;   // Tipo de letra para mensajes

        // Constructor
        public Mapa(ContentManager c)
        {
            listaNiveles = new Nivel[MAX_NIVELES];
            listaNiveles[0] = new Nivel01(c);
            listaNiveles[1] = new Nivel02(c);
            listaNiveles[2] = new Nivel03(c);
            listaNiveles[3] = new Nivel04(c);
            listaNiveles[4] = new Nivel05(c);
            listaNiveles[5] = new Nivel06(c);
            listaNiveles[6] = new Nivel07(c);
            listaNiveles[7] = new Nivel08(c);
            listaNiveles[8] = new Nivel09(c);
            listaNiveles[9] = new Nivel10(c);
            listaNiveles[10] = new Nivel11(c);
            listaNiveles[11] = new Nivel12(c);
            listaNiveles[12] = new Nivel13(c);
            listaNiveles[13] = new Nivel14(c);
            listaNiveles[14] = new Nivel15(c);
            listaNiveles[15] = new Nivel16(c);
            listaNiveles[16] = new Nivel17(c);
            listaNiveles[17] = new Nivel18(c);
            listaNiveles[18] = new Nivel19(c);
            listaNiveles[19] = new Nivel20(c);


            nivelActual = listaNiveles[numeroNivelActual];
            //fuente18 = new Fuente("FreeSansBold.ttf", 18);
        }

        public void Reiniciar()
        {
            numeroNivelActual = 0;
            nivelActual = listaNiveles[numeroNivelActual];
            nivelActual.Reiniciar();
        }

        public void DibujarOculta(SpriteBatch listaSprites)
        {
            nivelActual.DibujarOculta(listaSprites);
        }

        public bool EsPosibleMover(int x, int y, int xmax, int ymax)
        {
            return nivelActual.EsPosibleMover(x, y, xmax, ymax);
        }

        public int ObtenerPuntosPosicion(int x, int y, int xmax, int ymax)
        {
            return nivelActual.ObtenerPuntosPosicion(x, y, xmax, ymax);
        }

        public void Avanzar()
        {
            numeroNivelActual++;
            if (numeroNivelActual >= MAX_NIVELES)
                numeroNivelActual = 0;

            /*
            // Rectángulo de fondo
            Hardware.RectanguloRellenoRGBA(
               200, 100, 600, 300,  // Posicion, ancho y alto de la pantalla
               200, 200, 200,   // Gris claro
               200);         // Con algo de transparencia

            // Y texto de aviso
            Hardware.EscribirTextoOculta(
                    "Pasando al nivel "+(numeroNivelActual+1),
                    300, 200, 0, 0, 0, fuente18);

            Hardware.VisualizarOculta();
            Hardware.Pausa(2000);
            */
            nivelActual = listaNiveles[numeroNivelActual];
            nivelActual.Reiniciar();
        }

        public string GetNombre()
        {
            return nivelActual.LeerNombre();
        }

        public int GetNumEnemigos()
        {
            return nivelActual.GetNumEnemigos();
        }

        public Enemigo GetEnemigo(int i)
        {
            return nivelActual.GetEnemigo(i);
        }

    } /* fin de la clase Mapa */
}