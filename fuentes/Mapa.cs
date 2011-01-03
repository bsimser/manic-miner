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
 ---------------------------------------------------- */

public class Mapa
{

    // Datos del mapa del nivel actual
    Partida miPartida;

    private int altoMapa = 16, anchoMapa = 32;
    private int anchoTile = 24, altoTile = 24;
    private int margenIzqdo = 20, margenSuperior = 100;
    private int llavesRestantes = 4;   // Valor arbitrario (no 0: final de partida)

    ElemGrafico arbol, deslizante, ladrillo, ladrilloX, llave, puerta, 
        sueloFino, sueloFragil, sueloGrueso, techo;


    string[] datosNivel;  // Datos en el momento de juego

    string[] datosNivelIniciales =  // Datos para reiniciar
    {"L        V T    T            V L",
     "L               V              L",
     "L                              L",
     "L                              L",
     "L                      VA  A   L", 
     "LSS  SSSSSSSSSFFFFSFFFFSSSSSSSSL", 
     "L                             VL", 
     "LSSS                           L", 
     "L                LLL A         L", 
     "LSSSS   DDDDDDDDDDDDDDDDDDDD   L", 
     "L                            SSL", 
     "L                              L", 
     "L            A      LLL  FFFSSSL", 
     "L    SSSSSSSSSSSSSSS         PPL",
     "L                            PPL",
     "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"};
  
    // Constructor
    public Mapa(Partida p)
    {
        miPartida = p;   // Para enlazar con el resto de componentes

        arbol = new ElemGrafico("imagenes/arbol.png");
        deslizante = new ElemGrafico("imagenes/deslizante.png");
        ladrillo = new ElemGrafico("imagenes/ladrillo.png");
        ladrilloX = new ElemGrafico("imagenes/ladrillo2.png");
        llave = new ElemGrafico("imagenes/llave.png");
        puerta = new ElemGrafico("imagenes/puerta.png");
        sueloFino = new ElemGrafico("imagenes/suelo.png");
        sueloFragil = new ElemGrafico("imagenes/sueloFragil.png");
        techo = new ElemGrafico("imagenes/techo.png");

        datosNivel = new string[altoMapa];
        Reiniciar();
  }

   public void Reiniciar()
   {
       for (int fila = 0; fila < altoMapa; fila++)
           datosNivel[fila] = datosNivelIniciales[fila];
   }

   public void DibujarOculta()
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
                  case 'A': arbol.DibujarOculta(posX, posY); break;
                  case 'D': deslizante.DibujarOculta(posX, posY); break;
                  case 'F': sueloFragil.DibujarOculta(posX, posY); break;
                  case 'L': ladrillo.DibujarOculta(posX, posY); break;
                  case 'P': puerta.DibujarOculta(posX, posY); break;
                  case 'S': sueloFino.DibujarOculta(posX, posY); break;
                  case 'T': techo.DibujarOculta(posX, posY); break;
                  case 'V': llave.DibujarOculta(posX, posY); 
                            llavesRestantes++;  break;
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
                  if ((posX+anchoTile > x) && (posY+altoTile > y)  
                      && (xmax> posX) && (ymax > posY))
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
               if ( (posX + anchoTile > x) && (posY + altoTile > y)
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
  
} /* fin de la clase Mapa */
