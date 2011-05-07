
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel17: Mapa de tiles del nivel 17 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Andrés Marotta
                        Creada la clase Nivel17 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 17.

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{

    public class Nivel17 : Nivel
    {

        public Nivel17(ContentManager c)
            : base(c)
        {
            nombre = "The Warehouse";
            datosNivelIniciales[0] = "L                            LLL";
            datosNivelIniciales[1] = "L                            PPL";
            datosNivelIniciales[2] = "L                            PPL";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L     A  A   A  A     A A      L";
            datosNivelIniciales[5] = "LSSFFFFFFF  FFFFFFF  FFFVFF  SSL";
            datosNivelIniciales[6] = "LFFTFFFFFF  FFFFFFF  FFFFFF  FFL";
            datosNivelIniciales[7] = "LFFFFFFFFF  FFFVFFF  FFFFFT  FFL";
            datosNivelIniciales[8] = "LFF  FFFFF  FFDDDDD  FFFFFF  FFL";
            datosNivelIniciales[9] = "LVF  FFFFF  FFFFFFF  FFFFFF  FFL";
            datosNivelIniciales[10] = "LFF  FFFFF  FFFFFFFVFFTFFFF  FFL";
            datosNivelIniciales[11] = "LFF  FFFFT  FFFFFFFFFFFFFFV  FFL";
            datosNivelIniciales[12] = "LFF  FFFFF  FFFFFFFFFFFFFFF  FFL";
            datosNivelIniciales[13] = "L                              L";
            datosNivelIniciales[14] = "L                          SSSSL";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase Nivel17 */
}
