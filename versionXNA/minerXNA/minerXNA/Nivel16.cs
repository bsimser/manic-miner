/** 
 *   Nivel16: Mapa de tiles del 16 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Ethan Martinez Carratala
                      Creada la clase Nivel16
 ---------------------------------------------------- */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel16 : Nivel
    {

        public Nivel16(ContentManager c)
            : base(c)
        {
            nombre = "The Sixteenth Cavern";
            datosNivelIniciales[0] = "LV                             L";
            datosNivelIniciales[1] = "L                              L";
            datosNivelIniciales[2] = "L                             VL";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "LS     S    LPPL      SSS      L";
            datosNivelIniciales[6] = "L           LPPLL              L";
            datosNivelIniciales[7] = "L    S      L VLLL       SSSSSSL";
            datosNivelIniciales[8] = "L           L  LLLL            L";
            datosNivelIniciales[9] = "LSSDDDDDDDDDDDDDDDDDDDDDDDD    L";
            datosNivelIniciales[10] = "L                V             L";
            datosNivelIniciales[11] = "L         LLSS            S    L";
            datosNivelIniciales[12] = "LSSSSSSSSS                     L";
            datosNivelIniciales[13] = "L                   S     S    L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase NivelXX */
}
