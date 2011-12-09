/** 
 *   Nivel03: Mapa de tiles del tercer nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11  02-Ene-2011  Nacho Cabanes
                      Creada la clase Nivel03
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Andrés Marotta: Cambiadas las imagenes para que sean
                       las del nivel original // Faltan las arañas
 ---------------------------------------------------- */


public class Nivel03 : Nivel
{

    public Nivel03()
    {
        nombre = "The Menagerie";
        datosNivelIniciales[ 0] = "M    V   T     V  T    V   T   M";
        datosNivelIniciales[ 1] = "M                              M";
        datosNivelIniciales[ 2] = "M                              M";
        datosNivelIniciales[ 3] = "M                              M";
        datosNivelIniciales[ 4] = "M                              M";
        datosNivelIniciales[ 5] = "MNNNNOOOOOOOOOOOOOOOOOOOOOO  OOM"; 
        datosNivelIniciales[ 6] = "M                    V        VM"; 
        datosNivelIniciales[ 7] = "MNNNNNN                    NNNNM"; 
        datosNivelIniciales[ 8] = "MT                             M"; 
        datosNivelIniciales[ 9] = "M     DDDDDD                   M"; 
        datosNivelIniciales[10] = "M                        NNNNNNM"; 
        datosNivelIniciales[11] = "M             NNNNN          PPM"; 
        datosNivelIniciales[12] = "M    NNNNNN                  PPM"; 
        datosNivelIniciales[13] = "M                    NNNNNNNNNNM";
        datosNivelIniciales[14] = "M                              M";
        datosNivelIniciales[15] = "MNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNM";

        numEnemigos = 3;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemPavo.png", miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(100, 480);
        listaEnemigos[0].SetAnchoAlto(36, 48);

        listaEnemigos[1] = new Enemigo("imagenes/enemPavo.png", miPartida);
        listaEnemigos[1].MoverA(300, 110);
        listaEnemigos[1].SetVelocidad(-2, 0);
        listaEnemigos[1].setMinMaxX(50, 725);
        listaEnemigos[1].SetAnchoAlto(36, 48);

        listaEnemigos[2] = new Enemigo("imagenes/enemPavo.png", miPartida);
        listaEnemigos[2].MoverA(350, 110);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(50, 725);
        listaEnemigos[2].SetAnchoAlto(36, 48);

        Reiniciar();
    }
  
} /* fin de la clase Nivel03 */
