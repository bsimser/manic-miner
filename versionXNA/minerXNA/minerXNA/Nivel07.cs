
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel07: Mapa de tiles del nivel 7 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Miguel Angel Laguardia
                        Creada la clase Nivel07 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 7.

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel07 : Nivel
    {

        public Nivel07(ContentManager c)
            : base(c)
        {
            nombre = "The vat";
            datosNivelIniciales[0] = "M             MMMMMMMMMMMMMMMMMM";
            datosNivelIniciales[1] = "M                              M";
            datosNivelIniciales[2] = "M                              M";
            datosNivelIniciales[3] = "M              NNMFFFFFFFFFFFFVM";
            datosNivelIniciales[4] = "M                MFFFFFFFFFFFFFM";
            datosNivelIniciales[5] = "M             NNNMFFFFFFFFFFAFFM";
            datosNivelIniciales[6] = "MNNN             MFFVFFFFFFFFFFM";
            datosNivelIniciales[7] = "M                MFFFFFFFFFVFFFM";
            datosNivelIniciales[8] = "MN               MFFFFFAFFFFFFFM";
            datosNivelIniciales[9] = "M             NNNMFFFFFFFFFFFFFM";
            datosNivelIniciales[10] = "MNNNNNNNNNNN     MFVFFFFFFFFAFFM";
            datosNivelIniciales[11] = "M                MFFFFFFFFFFFFVM";
            datosNivelIniciales[12] = "M             MMMMFFFFFAFFFFFFFM";
            datosNivelIniciales[13] = "M       NNN   MPP              M";
            datosNivelIniciales[14] = "M             MPP              M";
            datosNivelIniciales[15] = "MNNNNNNNNNNNNNMMMMMMMMMMMMMMMMMM";

            Reiniciar();
        }

    } /* fin de la clase Nivel07 */
}
