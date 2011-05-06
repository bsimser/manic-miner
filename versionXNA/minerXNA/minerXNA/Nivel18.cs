/** 
 *   Nivel18: Mapa de tiles del 18 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Alejandro Guillén Esteso
                      Creada la clase Nivel18
   
 ---------------------------------------------------- */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel18 : Nivel
    {

        public Nivel18(ContentManager c)
            : base(c)
        {
            nombre = "Amoebatrons' Revenge";
            datosNivelIniciales[0] = "L                           LPPL";
            datosNivelIniciales[1] = "L               V            PPL";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "L  SS  SSS  SSSSSSSS  SSS  SSSSL";
            datosNivelIniciales[6] = "L                              L";
            datosNivelIniciales[7] = "LSS                            L";
            datosNivelIniciales[8] = "L           SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[9] = "L  SS  SSS                     L";
            datosNivelIniciales[10] = "L                            SSL";
            datosNivelIniciales[11] = "L                              L";
            datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[13] = "LSS                            L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";

            Reiniciar();
        }

    } /* fin de la clase Nivel18 */
}
