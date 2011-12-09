/** 
 *   Nivel02: Mapa de tiles del segundo nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11  02-Ene-2011  Nacho Cabanes
                      Creada la clase Nivel02
   0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                      Raquel Lloréns Gambín: Añadidos enemigos al nivel
                      Nacho Cabanes: los enemigos son de tipo "pingüino"
 ---------------------------------------------------- */


public class Nivel02 : Nivel
{
    public Nivel02()
    {
        nombre = "The Cold Room";
        datosNivelIniciales[ 0] = "L                  LLLLLLLLLLLLL";
        datosNivelIniciales[ 1] = "L      V                V     TL";
        datosNivelIniciales[ 2] = "L                              L";
        datosNivelIniciales[ 3] = "L                    FFFF      L";
        datosNivelIniciales[ 4] = "L                              L";
        datosNivelIniciales[ 5] = "LSSSSSSSSSSSSSSSSSSS        L  L"; 
        datosNivelIniciales[ 6] = "L                    SSSSLFFL  L"; 
        datosNivelIniciales[ 7] = "LSFFFFF                  LV L  L"; 
        datosNivelIniciales[ 8] = "L                        LFFL  L"; 
        datosNivelIniciales[ 9] = "L  V     SSSSSSS         LFFL  L"; 
        datosNivelIniciales[10] = "L                  FFFF  LFFL  L"; 
        datosNivelIniciales[11] = "L  DDDD                  LFFL  L"; 
        datosNivelIniciales[12] = "L             SSSS V     LFFL  L"; 
        datosNivelIniciales[13] = "L       FFFF                 PPL";
        datosNivelIniciales[14] = "L                            PPL";
        datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemigos = 2;
        listaEnemigos = new Enemigo[numEnemigos];

        // Le damos valores al primer enemigo
        listaEnemigos[0] = new Enemigo("imagenes/enemPinguino.png", miPartida);
        listaEnemigos[0].MoverA(400, 352);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(45, 680);
        listaEnemigos[0].SetAnchoAlto(36, 48);

        // Le damos valores al segundo enemigo
        listaEnemigos[1] = new Enemigo("imagenes/enemPinguino.png", miPartida);
        listaEnemigos[1].MoverA(45, 110);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxX(45, 465);
        listaEnemigos[1].SetAnchoAlto(36, 48);

        Reiniciar();
    }
      
} /* fin de la clase Nivel02 */
