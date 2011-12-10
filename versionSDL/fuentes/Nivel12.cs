/** 
 *   Nivel12: Mapa de tiles del nivel 12 del juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Manuel Martinez
                      Creada la clase Nivel12
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Alejandro Guillen: 
                        Enemigos y sus movimientos
 ---------------------------------------------------- */


public class Nivel12 : Nivel
{

    public Nivel12()
    {
        nombre = "Return Of The Alien Kong Beast";
        datosNivelIniciales[ 0] = "L T   A   T      LA  L         L";
        datosNivelIniciales[ 1] = "L                              L";
        datosNivelIniciales[ 2] = "L              FF              L";
        datosNivelIniciales[ 3] = "L              V               L";
        datosNivelIniciales[ 4] = "L                              L";
        datosNivelIniciales[ 5] = "LFFF     FFFFFL  LFFFFFFFF     L"; 
        datosNivelIniciales[ 6] = "L V           L  L            FL"; 
        datosNivelIniciales[ 7] = "L     FF      L VL             L"; 
        datosNivelIniciales[ 8] = "L  F          L  L       FFFFFFL"; 
        datosNivelIniciales[ 9] = "L         FFFFL  L             L"; 
        datosNivelIniciales[10] = "L     F          LFFF          L"; 
        datosNivelIniciales[11] = "L                L       FF    L"; 
        datosNivelIniciales[12] = "LFFFFFF          L     A    A  L"; 
        datosNivelIniciales[13] = "L          FFFLPPLDDDDDDDDDDDV L";
        datosNivelIniciales[14] = "L             LPPL             L";
        datosNivelIniciales[15] = "LFFFFFFFFFFFFFLLLLFFFFFFFFFFFFFL";

        numEnemigos = 3;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemBarril.png", miPartida);
        listaEnemigos[0].MoverA(200, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(150, 300);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemBarril.png", miPartida);
        listaEnemigos[1].MoverA(280, 300);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxX(280, 380);
        listaEnemigos[1].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemBarril.png", miPartida);
        listaEnemigos[2].MoverA(625, 185);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(625, 725);
        listaEnemigos[2].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        Reiniciar();
    }
  
} /* fin de la clase Nivel12 */
