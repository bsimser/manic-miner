/** 
 *   Nivel18: Mapa de tiles del 18 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Alejandro Guillén Esteso
                      Creada la clase Nivel18
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Frank Royo:
                        Colocación de los nuevos personajes y moviento
                        diferentes
 ---------------------------------------------------- */


public class Nivel18 : Nivel
{

    public Nivel18()
    {
        nombre = "Amoebatrons' Revenge";
        datosNivelIniciales[ 0] = "L                           LPPL";
        datosNivelIniciales[ 1] = "L               V            PPL";
        datosNivelIniciales[ 2] = "L                              L";
        datosNivelIniciales[ 3] = "L                              L";
        datosNivelIniciales[ 4] = "L                              L";
        datosNivelIniciales[ 5] = "L  SS  SSS  SSSSSSSS  SSS  SSSSL"; 
        datosNivelIniciales[ 6] = "L                              L"; 
        datosNivelIniciales[ 7] = "LSS                            L"; 
        datosNivelIniciales[ 8] = "L           SSSSSSSS  SSS  SS  L"; 
        datosNivelIniciales[ 9] = "L  SS  SSS                     L"; 
        datosNivelIniciales[10] = "L                            SSL"; 
        datosNivelIniciales[11] = "L                              L"; 
        datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L"; 
        datosNivelIniciales[13] = "LSS                            L";
        datosNivelIniciales[14] = "L                              L";
        datosNivelIniciales[15] = "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";

        numEnemigos = 8;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemNivel09a.png", miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemNivel09a.png", miPartida);
        listaEnemigos[1].MoverA(310, 280);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxX(300, 475);
        listaEnemigos[1].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemNivel09a.png", miPartida);
        listaEnemigos[2].MoverA(350, 183);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(300, 475);
        listaEnemigos[2].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[3] = new Enemigo("imagenes/enemNivel09a.png", miPartida);
        listaEnemigos[3].MoverA(450, 111);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxX(300, 475);
        listaEnemigos[3].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[4] = new Enemigo("imagenes/enemNivel18b.png", miPartida);
        listaEnemigos[4].MoverA(150, 200);
        listaEnemigos[4].SetVelocidad(0, 2);
        listaEnemigos[4].setMinMaxY(100, 300);
        listaEnemigos[4].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[5] = new Enemigo("imagenes/enemNivel18b.png", miPartida);
        listaEnemigos[5].MoverA(270, 110);
        listaEnemigos[5].SetVelocidad(0, 2);
        listaEnemigos[5].setMinMaxY(100, 300);
        listaEnemigos[5].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[6] = new Enemigo("imagenes/enemNivel18b.png", miPartida);
        listaEnemigos[6].MoverA(500, 250);
        listaEnemigos[6].SetVelocidad(0, 2);
        listaEnemigos[6].setMinMaxY(100, 300);
        listaEnemigos[6].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[7] = new Enemigo("imagenes/enemNivel18b.png", miPartida);
        listaEnemigos[7].MoverA(625, 180);
        listaEnemigos[7].SetVelocidad(0, 2);
        listaEnemigos[7].setMinMaxY(100, 300);
        listaEnemigos[7].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        Reiniciar();
    }
  
} /* fin de la clase Nivel18 */
