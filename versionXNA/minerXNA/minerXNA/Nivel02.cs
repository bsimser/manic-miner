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
 ---------------------------------------------------- */


using Microsoft.Xna.Framework.Content;

namespace minerXNA
{
    public class Nivel02 : Nivel
    {
        public Nivel02(ContentManager c)
            : base(c)
        {
            nombre = "The Cold Room";
            datosNivelIniciales[0] = "L                  LLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L      V                V     TL";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                    FFFF      L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "LSSSSSSSSSSSSSSSSSSS        L  L";
            datosNivelIniciales[6] = "L                    SSSSLFFL  L";
            datosNivelIniciales[7] = "LSFFFFF                  LV L  L";
            datosNivelIniciales[8] = "L                        LFFL  L";
            datosNivelIniciales[9] = "L  V     SSSSSSS         LFFL  L";
            datosNivelIniciales[10] = "L                  FFFF  LFFL  L";
            datosNivelIniciales[11] = "L  DDDD                  LFFL  L";
            datosNivelIniciales[12] = "L             SSSS V     LFFL  L";
            datosNivelIniciales[13] = "L       FFFF                 PPL";
            datosNivelIniciales[14] = "L                            PPL";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase Nivel02 */
}