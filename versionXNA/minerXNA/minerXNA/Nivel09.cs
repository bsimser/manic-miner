
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel09: Mapa de tiles del nivel 9 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Alejandro Guijarro Terol
                        Creada la clase Nivel09 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 9.

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel09 : Nivel
    {

        public Nivel09(ContentManager c)
            : base(c)
        {
            nombre = "Wacky Amobeatrons";
            datosNivelIniciales[0] = "LPP                            L";
            datosNivelIniciales[1] = "LPP             V              L";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "LSSSS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[6] = "L                              L";
            datosNivelIniciales[7] = "L                            SSL";
            datosNivelIniciales[8] = "L  SS  SSS  FFFFFFFF           L";
            datosNivelIniciales[9] = "L                     SSS  SS  L";
            datosNivelIniciales[10] = "LSS                            L";
            datosNivelIniciales[11] = "L                              L";
            datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[13] = "L                            SSL";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase Nivel09 */
}
