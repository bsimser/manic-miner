/** 
 *   Nivel19: Mapa de tiles del 19 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Ethan Martinez Carratala
                      Creada la clase Nivel19
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      David Martinez:
                        Creación de enemigos del nivel
 ---------------------------------------------------- */


public class Nivel19 : Nivel
{

    public Nivel19()
    {
        nombre = "Solar Power Generator";
        datosNivelIniciales[ 0] = "LLL                     F      L";
        datosNivelIniciales[ 1] = "LPP                     F     VL";
        datosNivelIniciales[ 2] = "LPP                     F      L";
        datosNivelIniciales[ 3] = "L                       F      L";
        datosNivelIniciales[ 4] = "L                       F      L";
        datosNivelIniciales[ 5] = "LV SS     SSSSSS        FSSSSSSL"; 
        datosNivelIniciales[ 6] = "L                       F      L"; 
        datosNivelIniciales[ 7] = "L                       F      L"; 
        datosNivelIniciales[ 8] = "L                   SSS FSSSSSSL"; 
        datosNivelIniciales[ 9] = "LSS         SSS         F      L"; 
        datosNivelIniciales[10] = "L                       F      L"; 
        datosNivelIniciales[11] = "L                   SS  FSSSSSSL"; 
        datosNivelIniciales[12] = "LSSSS                   F     VL"; 
        datosNivelIniciales[13] = "L       DDDD    SSSSS   F      L";
        datosNivelIniciales[14] = "LLL                     F      L";
        datosNivelIniciales[15] = "LLLSSSSSSSSSSSSSSSSSSSSSLSSSSSSL";

        numEnemigos = 7;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemNivel19b.png", miPartida);
        listaEnemigos[0].MoverA(700, 111);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(625, 725);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemNivel19b.png", miPartida);
        listaEnemigos[1].MoverA(700, 183);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxX(625, 725);
        listaEnemigos[1].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemNivel19b.png", miPartida);
        listaEnemigos[2].MoverA(700, 255);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(625, 725);
        listaEnemigos[2].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[3] = new Enemigo("imagenes/enemNivel19b.png", miPartida);
        listaEnemigos[3].MoverA(500, 350);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxX(93, 555);
        listaEnemigos[3].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);



        listaEnemigos[4] = new Enemigo("imagenes/enemNivel19a.png", miPartida);
        listaEnemigos[4].MoverA(150, 100);
        listaEnemigos[4].SetVelocidad(0, 2);
        listaEnemigos[4].setMinMaxY(100, 350);
        listaEnemigos[4].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[5] = new Enemigo("imagenes/enemNivel19a.png", miPartida);
        listaEnemigos[5].MoverA(260, 200);
        listaEnemigos[5].SetVelocidad(0, 2);
        listaEnemigos[5].setMinMaxY(187, 300);
        listaEnemigos[5].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[6] = new Enemigo("imagenes/enemNivel19a.png", miPartida);
        listaEnemigos[6].MoverA(420, 101);
        listaEnemigos[6].SetVelocidad(0, 2);
        listaEnemigos[6].setMinMaxY(100, 300);
        listaEnemigos[6].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        Reiniciar();
    }
  
} /* fin de la clase NivelXX */
