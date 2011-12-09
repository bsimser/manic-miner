﻿/** 
 *   Nivel06: Mapa de tiles del 06 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Francisco Juan Royo Bua
                      Creada la clase Nivel06
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Cristian Bautista
                      Varios enemigos por nivel
 ---------------------------------------------------- */


public class Nivel06 : Nivel
{

    public Nivel06()
    {
        nombre = "Processing Plant";
        datosNivelIniciales[ 0] = "L                            PPL";
        datosNivelIniciales[ 1] = "L                            PPL";
        datosNivelIniciales[ 2] = "L                              L";
        datosNivelIniciales[ 3] = "L                              L";
        datosNivelIniciales[ 4] = "L                    A         L";
        datosNivelIniciales[ 5] = "L       NNN    NN    NNNNN     L"; 
        datosNivelIniciales[ 6] = "L  NN          VLV          NNNL"; 
        datosNivelIniciales[ 7] = "L               L             VL"; 
        datosNivelIniciales[ 8] = "L                      NNNNN   L"; 
        datosNivelIniciales[ 9] = "LNN                            L"; 
        datosNivelIniciales[10] = "LV     NNNNNNNNNLNNNNNNNNN     L"; 
        datosNivelIniciales[11] = "L            V  LA             L"; 
        datosNivelIniciales[12] = "L               L           NNNL"; 
        datosNivelIniciales[13] = "L  DDDD               NN       L";
        datosNivelIniciales[14] = "L                              L";
        datosNivelIniciales[15] = "LNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNL";

        numEnemigos = 5;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemPacMan.png", miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemPacMan.png", miPartida);
        listaEnemigos[1].MoverA(150, 200);
        listaEnemigos[1].SetVelocidad(0, 2);
        listaEnemigos[1].setMinMaxY(100, 300);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemPacMan.png", miPartida);
        listaEnemigos[2].MoverA(400, 352);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[3] = new Enemigo("imagenes/enemPacMan.png", miPartida);
        listaEnemigos[3].MoverA(400, 352);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[4] = new Enemigo("imagenes/enemFantasma.png", miPartida);
        listaEnemigos[4].MoverA(400, 352);
        listaEnemigos[4].SetVelocidad(2, 0);
        listaEnemigos[4].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        Reiniciar();
    }
  
} /* fin de la clase Nivel06 */
