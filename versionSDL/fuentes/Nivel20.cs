/** 
 *   Nivel20: Mapa de tiles del 20 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Antonio Pérez Pareja
                      Creada la clase Nivel20
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                     Julio Antoraz Ros: Enemigos nivel
 ---------------------------------------------------- */


public class Nivel20 : Nivel
{

    public Nivel20()
    {
        nombre = "This, folks, is the Last Cavern!";
        datosNivelIniciales[ 0] = "MMMMMMMMMMMMMMMMTTTTTTTTTTTTMMMM";
        datosNivelIniciales[ 1] = "MA  V    V     A      A    A  VM";
        datosNivelIniciales[ 2] = "M                              M";
        datosNivelIniciales[ 3] = "M                              M";
        datosNivelIniciales[ 4] = "M                 MMMMMMMMMMMMMM";
        datosNivelIniciales[ 5] = "M                 MPPM V       M"; 
        datosNivelIniciales[ 6] = "MS    S    S    SSMPPM        VM"; 
        datosNivelIniciales[ 7] = "M    FFFFFFFFFFFMMM  M         M"; 
        datosNivelIniciales[ 8] = "M  SS                        SSM"; 
        datosNivelIniciales[ 9] = "M                              M"; 
        datosNivelIniciales[10] = "MDDDDDDDDDDDDDDDDDDDDDD   F    M"; 
        datosNivelIniciales[11] = "M        AV A V A V         S  M"; 
        datosNivelIniciales[12] = "MSS                            M"; 
        datosNivelIniciales[13] = "M    SS                        M";
        datosNivelIniciales[14] = "M                              M";
        datosNivelIniciales[15] = "MSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSM";

        numEnemigos = 4;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo(miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo(miPartida);
        listaEnemigos[1].MoverA(600, 300);
        listaEnemigos[1].SetVelocidad(0, 2);
        listaEnemigos[1].setMinMaxY(200, 350);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo(miPartida);
        listaEnemigos[2].MoverA(100, 233);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(100, 500);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[3] = new Enemigo(miPartida);
        listaEnemigos[3].MoverA(420, 100);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        Reiniciar();
    }
  
} /* fin de la clase Nivel20 */
