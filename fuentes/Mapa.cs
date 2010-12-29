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
 ---------------------------------------------------- */

public class Mapa : ElemGrafico
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
      for (int i = 0; i < altoMapa; i++)
          for (int j = 0; j < anchoMapa; j++)
          {
              int posX = j * anchoTile + margenIzqdo;
              int posY = i * altoTile + margenSuperior;
              switch (datosNivel[i][j])
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
  
  
} /* fin de la clase Mapa */
