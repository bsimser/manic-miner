/** 
 *   Nivel19: Mapa de tiles del 19 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Ethan Martinez Carratala
                      Creada la clase Nivel19
 ---------------------------------------------------- */


public class Nivel19 : Nivel
{

    public Nivel19()
    {
        nombre = "Solar Power Generator";
        datosNivelIniciales[ 0] = "LLL                     F      L";
        datosNivelIniciales[ 1] = "LPP                     F     VL";
        datosNivelIniciales[ 2] = "LPP                     F      L";
        datosNivelIniciales[ 3] = "L                       F      L";
        datosNivelIniciales[ 4] = "L                       F      L";
        datosNivelIniciales[ 5] = "LV SS     SSSSSS        FSSSSSSL"; 
        datosNivelIniciales[ 6] = "L                       F      L"; 
        datosNivelIniciales[ 7] = "L                       F      L"; 
        datosNivelIniciales[ 8] = "L                   SSS FSSSSSSL"; 
        datosNivelIniciales[ 9] = "LSS         SSS         F      L"; 
        datosNivelIniciales[10] = "L                       F      L"; 
        datosNivelIniciales[11] = "L                   SS  FSSSSSSL"; 
        datosNivelIniciales[12] = "LSSSS                   F     VL"; 
        datosNivelIniciales[13] = "L       DDDD    SSSSS   F      L";
        datosNivelIniciales[14] = "LLL                     F      L";
        datosNivelIniciales[15] = "LLLSSSSSSSSSSSSSSSSSSSSSLSSSSSSL";

        Reiniciar();
    }
  
} /* fin de la clase NivelXX */
