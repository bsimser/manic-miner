
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel04: Mapa de tiles del nivel 4 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Raquel Lloréns Gambín
                        Creada la clase Nivel04 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 4.

 ============================================================= */



using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel04 : Nivel
    {

        public Nivel04(ContentManager c)
            : base(c)
        {
            nombre = "Abandoned Uranium Workings";
            datosNivelIniciales[0] = "LV     T      LLLLLLLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L           V            V   PPL";
            datosNivelIniciales[2] = "L                            PPL";
            datosNivelIniciales[3] = "L                  SSSSSS      L";
            datosNivelIniciales[4] = "L                          SSSSL";
            datosNivelIniciales[5] = "LS     S         S             L";
            datosNivelIniciales[6] = "L           SS  V    SSS      VL";
            datosNivelIniciales[7] = "LFFF                           L";
            datosNivelIniciales[8] = "L      SS                 SSS  L";
            datosNivelIniciales[9] = "L                 SSS          L";
            datosNivelIniciales[10] = "LDDD                          SL";
            datosNivelIniciales[11] = "L           SSS       SSS      L";
            datosNivelIniciales[12] = "L     SS               T    SSSL";
            datosNivelIniciales[13] = "L                 SS           L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase Nivel04 */
}
