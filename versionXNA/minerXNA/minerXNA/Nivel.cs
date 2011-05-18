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
   0.09x  17-05-2011  Nacho Cabanes
                      Muchos más elementos gráficos para fondo, premios y obstáculos
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

        // Añadidos en la versión 0.09x
        private ElemGrafico obstaculo04, obstaculo06, obstaculo07, obstaculo10, obstaculo15,
            obstaculo16, obstaculo17, obstaculo20, pared10, pared15, premio05, premio06, premio07,
             premio08a, premio08b, premio10, premio11, premio13, premio14, premio15,
             premio16, premio17, suelo07, suelo10a, suelo10b, suelo13a, suelo13b, suelo14a, suelo14b,
             suelo14c, suelo15a, suelo15b, suelo17a, suelo17b, suelo18;

        // Lista de obstáculos, premios y elementos mortales
        // para comprobar de forma rápida
        private string listaObstaculos = "DFLMNOS[]|!-_=zxcCbnmasd";
        private string listaPremios = "VvWwQqYyUuKkJ";
        private string listaMortales = "AT$&/0%¬·@";

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

            // Añadidos en la versión 0.09x
            obstaculo04 = new ElemGrafico("obstaculoNivel04", c);
            obstaculo06 = new ElemGrafico("obstaculoNivel06", c);
            obstaculo07 = new ElemGrafico("obstaculoNivel07", c);
            obstaculo10 = new ElemGrafico("obstaculoNivel10", c);
            obstaculo15 = new ElemGrafico("obstaculoNivel15", c);
            obstaculo16 = new ElemGrafico("obstaculoNivel16", c);
            obstaculo17 = new ElemGrafico("obstaculoNivel17a", c);
            obstaculo20 = new ElemGrafico("obstaculoNivel20", c);
            pared10 = new ElemGrafico("paredNivel10", c);
            pared15 = new ElemGrafico("paredNivel15", c);
            premio05 = new ElemGrafico("premioNivel05", c);
            premio06 = new ElemGrafico("premioNivel06", c);
            premio07 = new ElemGrafico("premioNivel07", c);
            premio08a = new ElemGrafico("premioNivel08a", c);
            premio08b = new ElemGrafico("premioNivel08b", c);
            premio10 = new ElemGrafico("premioNivel10", c);
            premio11 = new ElemGrafico("premioNivel11", c);
            premio13 = new ElemGrafico("premioNivel13", c);
            premio14 = new ElemGrafico("premioNivel14", c);
            premio15 = new ElemGrafico("premioNivel15", c);
            premio16 = new ElemGrafico("premioNivel16", c);
            premio17 = new ElemGrafico("premioNivel17", c);
            suelo07 = new ElemGrafico("sueloNivel07", c);
            suelo10a = new ElemGrafico("sueloNivel10a", c);
            suelo10b = new ElemGrafico("sueloNivel10b", c);
            suelo13a = new ElemGrafico("sueloNivel13a", c);
            suelo13b = new ElemGrafico("sueloNivel13b", c);
            suelo14a = new ElemGrafico("sueloNivel14a", c);
            suelo14b = new ElemGrafico("sueloNivel14b", c);
            suelo14c = new ElemGrafico("sueloNivel14c", c);
            suelo15a = new ElemGrafico("sueloNivel15a", c);
            suelo15b = new ElemGrafico("sueloNivel15b", c);
            suelo17a = new ElemGrafico("sueloNivel17a", c);
            suelo17b = new ElemGrafico("sueloNivel17b", c);
            suelo18 = new ElemGrafico("sueloNivel18", c);

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
                        // Paredes y suelos
                        case 'D': deslizante.DibujarOculta(posX, posY, listaSprites); break;
                        case 'F': sueloFragil.DibujarOculta(posX, posY, listaSprites); break;
                        case 'L': ladrillo.DibujarOculta(posX, posY, listaSprites); break;
                        case 'M': ladrilloX.DibujarOculta(posX, posY, listaSprites); break;
                        case 'N': sueloGrueso.DibujarOculta(posX, posY, listaSprites); break;
                        case 'O': sueloFragil2.DibujarOculta(posX, posY, listaSprites); break;
                        case 'S': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case '[': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case ']': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case '|': pared10.DibujarOculta(posX, posY, listaSprites); break;
                        case '!': pared15.DibujarOculta(posX, posY, listaSprites); break;

                        case '-': suelo07.DibujarOculta(posX, posY, listaSprites); break;
                        case '_': suelo10a.DibujarOculta(posX, posY, listaSprites); break;
                        case '=': suelo10b.DibujarOculta(posX, posY, listaSprites); break;
                        case 'z': suelo13a.DibujarOculta(posX, posY, listaSprites); break;
                        case 'x': suelo13b.DibujarOculta(posX, posY, listaSprites); break;
                        case 'c': suelo14a.DibujarOculta(posX, posY, listaSprites); break;
                        case 'C': suelo14b.DibujarOculta(posX, posY, listaSprites); break;
                        case 'b': suelo14c.DibujarOculta(posX, posY, listaSprites); break;
                        case 'n': suelo15a.DibujarOculta(posX, posY, listaSprites); break;
                        case 'm': suelo15b.DibujarOculta(posX, posY, listaSprites); break;
                        case 'a': suelo17a.DibujarOculta(posX, posY, listaSprites); break;
                        case 's': suelo17b.DibujarOculta(posX, posY, listaSprites); break;
                        case 'd': suelo18.DibujarOculta(posX, posY, listaSprites); break;

                        // Obstáculos "que matan"
                        case 'A': arbol.DibujarOculta(posX, posY, listaSprites); break;
                        case 'T': techo.DibujarOculta(posX, posY, listaSprites); break;
                        case '$': obstaculo04.DibujarOculta(posX, posY, listaSprites); break;
                        case '&': obstaculo06.DibujarOculta(posX, posY, listaSprites); break;
                        case '/': obstaculo07.DibujarOculta(posX, posY, listaSprites); break;
                        case '0': obstaculo10.DibujarOculta(posX, posY, listaSprites); break;
                        case '%': obstaculo15.DibujarOculta(posX, posY, listaSprites); break;
                        case '¬': obstaculo16.DibujarOculta(posX, posY, listaSprites); break;
                        case '·': obstaculo17.DibujarOculta(posX, posY, listaSprites); break;
                        case '@': obstaculo20.DibujarOculta(posX, posY, listaSprites); break;

                        // Puertas
                        case 'P': puerta.DibujarOculta(posX, posY, listaSprites); break;

                        // Llaves y premios que permiten obtener puntos y pasar de nivel
                        case 'V': llave.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'v': premio05.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'W': premio06.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'w': premio07.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'Q': premio08a.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'q': premio08b.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'Y': premio10.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'y': premio11.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'U': premio13.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'u': premio14.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'K': premio15.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'k': premio16.DibujarOculta(posX, posY, listaSprites);
                            llavesRestantes++; break;
                        case 'J': premio17.DibujarOculta(posX, posY, listaSprites);
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
                        if (listaObstaculos.Contains("" + datosNivel[fila][colum]))
                            return false;
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
                        if (listaMortales.Contains("" + datosNivel[fila][colum]))
                            return -1; // (puntuacion -1: perder vida)

                        // Si toca una llave
                        if ( listaPremios.Contains(""+datosNivel[fila][colum]) )
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