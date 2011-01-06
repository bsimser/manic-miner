/** 
 *   Nivel01: Mapa de tiles del primer nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11  02-Ene-2011  Nacho Cabanes
                      Creada la clase Nivel01
 ---------------------------------------------------- */

public class Nivel01 : Nivel
{

    public Nivel01()
    {
        nombre = "Central Cavern";
        datosNivelIniciales[ 0] = "L        V T    T            V L";
        datosNivelIniciales[ 1] = "L               V              L";
        datosNivelIniciales[ 2] = "L                              L";
        datosNivelIniciales[ 3] = "L                              L";
        datosNivelIniciales[ 4] = "L                      VA  A   L"; 
        datosNivelIniciales[ 5] = "LSS  SSSSSSSSSFFFFSFFFFSSSSSSSSL"; 
        datosNivelIniciales[ 6] = "L                             VL"; 
        datosNivelIniciales[ 7] = "LSSS                           L"; 
        datosNivelIniciales[ 8] = "L                LLL A         L"; 
        datosNivelIniciales[ 9] = "LSSSS   DDDDDDDDDDDDDDDDDDDD   L"; 
        datosNivelIniciales[10] = "L                            SSL"; 
        datosNivelIniciales[11] = "L                              L"; 
        datosNivelIniciales[12] = "L            A      LLL  FFFSSSL"; 
        datosNivelIniciales[13] = "L    SSSSSSSSSSSSSSS         PPL";
        datosNivelIniciales[14] = "L                            PPL";
        datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        Reiniciar();
    }
 
} /* fin de la clase Nivel01 */
