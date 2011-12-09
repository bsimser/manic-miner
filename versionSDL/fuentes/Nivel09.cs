//Alejandro Guijarro Terol 
/** 
 *   Nivel09: Mapa de tiles del 09 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 *  */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Alejandro Guijarro Terol
                      Creada la clase Nivel09
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Antonio Pérez: Añadidos 4 enemigos y su movimiento.
 ---------------------------------------------------- */


public class Nivel09 : Nivel
{

    public Nivel09()
    {
        nombre = "Wacky Amobeatrons";
        datosNivelIniciales[ 0] = "LPP                            L";
        datosNivelIniciales[ 1] = "LPP             V              L";
        datosNivelIniciales[ 2] = "L                              L";
        datosNivelIniciales[ 3] = "L                              L";
        datosNivelIniciales[ 4] = "L                              L";
        datosNivelIniciales[ 5] = "LSSSS  SSS  SSSSSSSS  SSS  SS  L"; 
        datosNivelIniciales[ 6] = "L                              L"; 
        datosNivelIniciales[ 7] = "L                            SSL"; 
        datosNivelIniciales[ 8] = "L  SS  SSS  FFFFFFFF           L"; 
        datosNivelIniciales[ 9] = "L                     SSS  SS  L"; 
        datosNivelIniciales[10] = "LSS                            L"; 
        datosNivelIniciales[11] = "L                              L"; 
        datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L"; 
        datosNivelIniciales[13] = "L                            SSL";
        datosNivelIniciales[14] = "L                              L";
        datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemigos = 5;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemNivel09b.png", miPartida);
        listaEnemigos[0].MoverA(150, 200);
        listaEnemigos[0].SetVelocidad(0, 2);
        listaEnemigos[0].setMinMaxY(100, 350);
        listaEnemigos[0].SetAnchoAlto(30, 39);

        listaEnemigos[1] = new Enemigo("imagenes/enemNivel09b.png", miPartida);
        listaEnemigos[1].MoverA(275, 200);
        listaEnemigos[1].SetVelocidad(0, 2);
        listaEnemigos[1].setMinMaxY(100, 350);
        listaEnemigos[1].SetAnchoAlto(30, 39);

        listaEnemigos[2] = new Enemigo("imagenes/enemNivel09b.png", miPartida);
        listaEnemigos[2].MoverA(500, 200);
        listaEnemigos[2].SetVelocidad(0, 2);
        listaEnemigos[2].setMinMaxY(100, 350);
        listaEnemigos[2].SetAnchoAlto(30, 39);

        listaEnemigos[3] = new Enemigo("imagenes/enemNivel09b.png", miPartida);
        listaEnemigos[3].MoverA(625, 200);
        listaEnemigos[3].SetVelocidad(0, 2);
        listaEnemigos[3].setMinMaxY(100, 350);
        listaEnemigos[3].SetAnchoAlto(30, 39);

        listaEnemigos[4] = new Enemigo("imagenes/enemNivel09a.png", miPartida);
        listaEnemigos[4].MoverA(310, 110);
        listaEnemigos[4].SetVelocidad(2, 0);
        listaEnemigos[4].setMinMaxX(310, 470);
        listaEnemigos[4].SetAnchoAlto(30, 48);

        /*listaEnemigos[5] = new Enemigo("enemNivel09a", c);
        listaEnemigos[5].MoverA(310, 110);
        listaEnemigos[5].SetVelocidad(2, 0);
        listaEnemigos[5].setMinMaxX(310, 470);
        listaEnemigos[5].SetAnchoAlto(30, 48);*/

        Reiniciar();
    }
  
} /* fin de la clase Nivel09 */
