/** 
 *   Nivel: Detalles comunes a todos los niveles
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11  02-Ene-2011  Nacho Cabanes
                      Creada la clase Nivel, desglosando sus funcionalidades
                        a partir de "Mapa".
                      Permite más tipos de casillas.
   0.14  23-Ene-2011  Nacho Cabanes
                      Incluye un array de enemigos y los Get para leer cantidad
                        y un enemigo concreto

 ---------------------------------------------------- */

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace minerXNA
{
    public class Nivel
    {

        // Datos del mapa del nivel actual
        protected Partida miPartida;

        private int altoMapa = 16, anchoMapa = 32;
        private int anchoTile = 24, altoTile = 24;
        private int margenIzqdo = 20, margenSuperior = 40;
        private int llavesRestantes = 4;   // Valor arbitrario (no 0: final de partida)

        protected int numEnemigos;
        protected Enemigo[] listaEnemigos;

        private ElemGrafico arbol, deslizante, ladrillo, ladrilloX, llave, puerta,
            sueloFino, sueloFragil, sueloFragil2, sueloGrueso, techo;


        protected string nombre = "(Nonamed)";

        string[] datosNivel;  // Datos en el momento de juego

        protected string[] datosNivelIniciales =  // Datos para reiniciar
        {"LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL",
         "L                              L",
         "L                              L",
         "L                              L",
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                              L", 
         "L                            PPL",
         "L                            PPL",
         "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"};

        // Constructor
        public Nivel(ContentManager c)
        {
            //miPartida = p;   // Para enlazar con el resto de componentes

            arbol = new ElemGrafico("arbol", c);
            deslizante = new ElemGrafico("deslizante", c);
            ladrillo = new ElemGrafico("ladrillo", c);
            ladrilloX = new ElemGrafico("ladrillo2", c);
            llave = new ElemGrafico("llave", c);
            puerta = new ElemGrafico("puerta", c);
            sueloFino = new ElemGrafico("suelo", c);
            sueloGrueso = new ElemGrafico("suelo2", c);
            sueloFragil = new ElemGrafico("sueloFragil", c);
            sueloFragil2 = new ElemGrafico("sueloFragil2", c);
            techo = new ElemGrafico("techo", c);

            datosNivel = new string[altoMapa];

            numEnemigos = 0;
            Reiniciar();
        }

        public void Reiniciar()
        {
            for (int fila = 0; fila < altoMapa; fila++)
                datosNivel[fila] = datosNivelIniciales[fila];
        }

        public void DibujarOculta(SpriteBatch listaSprites)
        {
            // Dibujo el fondo
            llavesRestantes = 0;
            for (int fila = 0; fila < altoMapa; fila++)
                for (int colum = 0; colum < anchoMapa; colum++)
                {
                    int posX = colum * anchoTile + margenIzqdo;
                    int posY = fila * altoTile + margenSuperior;
                    switch (datosNivel[fila][colum])
                    {
                        case 'A': arbol.DibujarOculta(posX, posY, listaSprites); break;
                        case 'D': deslizante.DibujarOculta(posX, posY, listaSprites); break;
                        case 'F': sueloFragil.DibujarOculta(posX, posY, listaSprites); break;
                        case 'L': ladrillo.DibujarOculta(posX, posY, listaSprites); break;
                        case 'M': ladrilloX.DibujarOculta(posX, posY, listaSprites); break;
                        case 'N': sueloGrueso.DibujarOculta(posX, posY, listaSprites); break;
                        case 'O': sueloFragil2.DibujarOculta(posX, posY, listaSprites); break;
                        case 'P': puerta.DibujarOculta(posX, posY, listaSprites); break;
                        case 'S': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case 'T': techo.DibujarOculta(posX, posY, listaSprites); break;
                        case '[': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case ']': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case 'V': llave.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                    }
                }
        }

        public bool EsPosibleMover(int x, int y, int xmax, int ymax)
        {

            // Compruebo si choca con alguna casilla del fondo
            for (int fila = 0; fila < altoMapa; fila++)
                for (int colum = 0; colum < anchoMapa; colum++)
                {
                    int posX = colum * anchoTile + margenIzqdo;
                    int posY = fila * altoTile + margenSuperior;
                    // Si se solapa con la posic a la que queremos mover
                    if ((posX + anchoTile > x) && (posY + altoTile > y)
                        && (xmax > posX) && (ymax > posY))
                        // Y no es espacio blanco, llave, puerta o arbol
                        if ((datosNivel[fila][colum] != ' ')
                            && (datosNivel[fila][colum] != 'V')
                            && (datosNivel[fila][colum] != 'P')
                            && (datosNivel[fila][colum] != 'A'))
                        {
                            return false;
                        }
                }

            return true;
        }

        public int ObtenerPuntosPosicion(int x, int y, int xmax, int ymax)
        {

            // Compruebo si choca con alguna casilla del fondo
            for (int fila = 0; fila < altoMapa; fila++)
                for (int colum = 0; colum < anchoMapa; colum++)
                {
                    int posX = colum * anchoTile + margenIzqdo;
                    int posY = fila * altoTile + margenSuperior;

                    // Si choca con la casilla que estoy mirando
                    if ((posX + anchoTile > x) && (posY + altoTile > y)
                        && (xmax > posX) && (ymax > posY))
                    {
                        // Si choca con el techo o con un arbol
                        if ((datosNivel[fila][colum] == 'T')
                                 || (datosNivel[fila][colum] == 'A'))
                            return -1; // (puntuacion -1: perder vida)

                        // Si toca una llave
                        if (datosNivel[fila][colum] == 'V')
                        {
                            // datosNivel[fila][colum] = ' '; (No valido en C#: 2 pasos)
                            datosNivel[fila] = datosNivel[fila].Remove(colum, 1);
                            datosNivel[fila] = datosNivel[fila].Insert(colum, " ");
                            return 10;
                        }

                        // Si toca la puerta y no quedan llaves, 50 puntos
                        // y (pronto) pasar al nivel siguiente
                        if ((datosNivel[fila][colum] == 'P')
                            && (llavesRestantes == 0))
                        {
                            return 50;
                        }

                    } // Fin de comprobacion de casilla actual
                } // Fin de "for" que revisa todas las casillas

            // Si llego hasta aqui, es que no hay puntos que devolver
            return 0;

        }

        public string LeerNombre()
        {
            return nombre;
        }

        public int GetNumEnemigos()
        {
            return numEnemigos;
        }

        public Enemigo GetEnemigo(int i)
        {
            if (numEnemigos > i)
                return listaEnemigos[i];

            return null;
        }

    } /* fin de la clase Mapa */
}