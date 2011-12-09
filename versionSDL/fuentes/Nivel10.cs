/** 
 *   Nivel10: Mapa de tiles del 10 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Daniel Marin Mateos
                      Creada la clase Nivel10
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Antonio Ramos: Añadidos enemigos a este nivel.
 ---------------------------------------------------- */


public class Nivel10 : Nivel
{

    public Nivel10()
    {
        nombre = "The Endorian Forest";
        datosNivelIniciales[ 0] = "M             LLLM   LLLLLLLLLLM";
        datosNivelIniciales[ 1] = "M              V M             M";
        datosNivelIniciales[ 2] = "MLLLLLL          M   V     LLLLM";
        datosNivelIniciales[ 3] = "M                M             M";
        datosNivelIniciales[ 4] = "M                MLLLL         M";
        datosNivelIniciales[ 5] = "M        LFFFFFFFM     LLLLLLLLM"; 
        datosNivelIniciales[ 6] = "MLLLL            M             M"; 
        datosNivelIniciales[ 7] = "M                MLLLLLLLFFF   M"; 
        datosNivelIniciales[ 8] = "MLLLLL           M V           M"; 
        datosNivelIniciales[ 9] = "M         LLLLLLLM           LLM"; 
        datosNivelIniciales[10] = "MLLLLFF          MLLLLLLL      M"; 
        datosNivelIniciales[11] = "M                M       FFF   M"; 
        datosNivelIniciales[12] = "M         MMMMMMMMM            M"; 
        datosNivelIniciales[13] = "MLLL         PP             LLLM";
        datosNivelIniciales[14] = "M            PP                M";
        datosNivelIniciales[15] = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN";

        numEnemigos = 4;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemConejo.png", miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 700);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemConejo.png", miPartida);
        listaEnemigos[1].MoverA(400, 200);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxY(200, 400);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[2] = new Enemigo("imagenes/enemConejo.png", miPartida);
        listaEnemigos[2].MoverA(400, 250);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxY(200, 400);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        listaEnemigos[3] = new Enemigo("imagenes/enemConejo.png", miPartida);
        listaEnemigos[3].MoverA(600, 100);
        listaEnemigos[3].SetVelocidad(2, 0);
        listaEnemigos[3].setMinMaxY(550, 750);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        Reiniciar();
    }
  
} /* fin de la clase NivelXX */
