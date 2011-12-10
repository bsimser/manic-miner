/** 
 *   Nivel16: Mapa de tiles del 16 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Ethan Martinez Carratala
                      Creada la clase Nivel16
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Miguel Angel Laguardia: colocar los enemigosde este propio nivel.
 ---------------------------------------------------- */


public class Nivel16 : Nivel
{

    public Nivel16()
    {
        nombre = "The Sixteenth Cavern";
        datosNivelIniciales[ 0] = "LV                             L";
        datosNivelIniciales[ 1] = "L                              L";
        datosNivelIniciales[ 2] = "L                             VL";
        datosNivelIniciales[ 3] = "L                              L";
        datosNivelIniciales[ 4] = "L                              L";
        datosNivelIniciales[ 5] = "LS     S    LPPL      SSS      L"; 
        datosNivelIniciales[ 6] = "L           LPPLL              L"; 
        datosNivelIniciales[ 7] = "L    S      L VLLL       SSSSSSL"; 
        datosNivelIniciales[ 8] = "L           L  LLLL            L"; 
        datosNivelIniciales[ 9] = "LSSDDDDDDDDDDDDDDDDDDDDDDDD    L"; 
        datosNivelIniciales[10] = "L                V             L"; 
        datosNivelIniciales[11] = "L         LLSS            S    L"; 
        datosNivelIniciales[12] = "LSSSSSSSSS                     L"; 
        datosNivelIniciales[13] = "L                   S     S    L";
        datosNivelIniciales[14] = "L                              L";
        datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemigos = 2;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo(miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo(miPartida);
        listaEnemigos[1].MoverA(200, 280);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxY(100, 300);
        listaEnemigos[1].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        /*listaEnemigos[2] = new Enemigo(c);
        listaEnemigos[2].MoverA(400, 352);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(100, 700);
        listaEnemigos[1].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[3] = new Enemigo(c);
        listaEnemigos[3].MoverA(400, 352);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxX(100, 700);
        listaEnemigos[3].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);*/

        Reiniciar();
    }
  
} /* fin de la clase NivelXX */
