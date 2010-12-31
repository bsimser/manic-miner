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
 ---------------------------------------------------- */

public class Mapa
{

    // Datos del mapa del nivel actual
    Partida miPartida;

    private int altoMapa = 16, anchoMapa = 32;
    private int anchoTile = 24, altoTile = 24;
    private int margenIzqdo = 20, margenSuperior = 100;

    ElemGrafico arbol, deslizante, ladrillo, ladrilloX, llave, puerta, 
        sueloFino, sueloFragil, sueloGrueso, techo;


    string[] datosNivel =
    {"L        V T    T            V L",
     "L               V              L",
     "L                              L",
     "L                              L",
     "L                      VA  A   L", 
     "LSSSSSSSSSSSSSFFFFSFFFFSSSSSSSSL", 
     "L                             VL", 
     "LSSS                           L", 
     "L                LLL A         L", 
     "LSSSS   DDDDDDDDDDDDDDDDDDDD   L", 
     "L                            SSL", 
     "L                              L", 
     "L            A      LLLFFFFFSSSL", 
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
  }

   public void DibujarOculta()
   {
      // Dibujo el fondo
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
                  case 'V': llave.DibujarOculta(posX, posY); break;
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
                  // Si no es espacio blanco
                  if ((datosNivel[fila][colum] != ' ')
                      // Y se solapa con la posic a la que queremos mover
                      && (posX+anchoTile > x) && (posY+altoTile > y)  
                      && (xmax> posX) && (ymax > posY))
                  {
                      return false;
                  }
               }

       return true;

  }
  
  
} /* fin de la clase Mapa */
