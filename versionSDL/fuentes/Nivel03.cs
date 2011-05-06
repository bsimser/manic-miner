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

        Reiniciar();
    }
  
} /* fin de la clase Nivel03 */
