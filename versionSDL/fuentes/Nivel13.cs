/** 
 *   Nivel13: Mapa de tiles del 13 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Antonio Pérez Pareja
                      Creada la clase Nivel13
 ---------------------------------------------------- */


public class Nivel13 : Nivel
{

    public Nivel13()
    {
        nombre = "Ore Refinery";
        datosNivelIniciales[ 0] = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
        datosNivelIniciales[ 1] = "L  O                           L";
        datosNivelIniciales[ 2] = "L  O                           L";
        datosNivelIniciales[ 3] = "L  O   MMMMMMMMMMMMMMMMMM VMMMML";
        datosNivelIniciales[ 4] = "L  O                           L";
        datosNivelIniciales[ 5] = "L  O                           L"; 
        datosNivelIniciales[ 6] = "L  O   MM VMMMM  MMMMM  MMMM  ML"; 
        datosNivelIniciales[ 7] = "L  O                           L"; 
        datosNivelIniciales[ 8] = "L  O                           L"; 
        datosNivelIniciales[ 9] = "L  O   MMMMM  MMM  VMMMMM VMMMML"; 
        datosNivelIniciales[10] = "L  O                           L"; 
        datosNivelIniciales[11] = "L  O                           L"; 
        datosNivelIniciales[12] = "L  O   MMM VMMM  MMMM  MMMM  MML"; 
        datosNivelIniciales[13] = "LPPO                           L";
        datosNivelIniciales[14] = "LPPO                           L";
        datosNivelIniciales[15] = "LMMFFFFFFFFFFFFFFFFFFFFFFFFFFMML";

        Reiniciar();
    }
  
} /* fin de la clase Nivel13 */
