/** 
 *   Nivel14: Mapa de tiles del 14 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Pedro Zalacain Castaño
                      Creada la clase Nivel14
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Daniel Marin: Añadir enemigos
 ---------------------------------------------------- */


public class Nivel14 : Nivel
{

    public Nivel14()
    {
        nombre = "Skylab Landing Bay";
        datosNivelIniciales[0] = "b              PP              b";
        datosNivelIniciales[1] = "b              PP              b";
        datosNivelIniciales[2] = "b                      V       b";
        datosNivelIniciales[3] = "b                              b";
        datosNivelIniciales[4] = "b                              b";
        datosNivelIniciales[5] = "b              []              b";
        datosNivelIniciales[6] = "b  []      []      []      []  b";
        datosNivelIniciales[7] = "b      []       V      []  V   b";
        datosNivelIniciales[8] = "b  V                           b";
        datosNivelIniciales[9] = "b    []      []      []      []b";
        datosNivelIniciales[10] = "b                              b";
        datosNivelIniciales[11] = "b[]      []     OOOOOO    []   b";
        datosNivelIniciales[12] = "b                              b";
        datosNivelIniciales[13] = "bL      []                      b";
        datosNivelIniciales[14] = "b                              b";
        datosNivelIniciales[15] = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";

        numEnemigos = 3;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemNivel14.png", miPartida);
        listaEnemigos[0].MoverA(200, 300);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxY(200, 800);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[1] = new Enemigo("imagenes/enemNivel14.png", miPartida);
        listaEnemigos[1].MoverA(270, 370);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxY(200, 800);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemNivel14.png", miPartida);
        listaEnemigos[2].MoverA(150, 200);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxY(200, 800);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        Reiniciar();
    }
  
} /* fin de la clase Nivel14 */
