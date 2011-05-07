
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel12: Mapa de tiles del nivel 12 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Manuel Martinez
                        Creada la clase Nivel12 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 12.

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel12 : Nivel
    {

        public Nivel12(ContentManager c)
            : base(c)
        {
            nombre = "Return Of The Alien Kong Beast";
            datosNivelIniciales[0] = "L T   A   T      LA  L         L";
            datosNivelIniciales[1] = "L                              L";
            datosNivelIniciales[2] = "L              FF              L";
            datosNivelIniciales[3] = "L              V               L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "LFFF     FFFFFL  LFFFFFFFF     L";
            datosNivelIniciales[6] = "L V           L  L            FL";
            datosNivelIniciales[7] = "L     FF      L VL             L";
            datosNivelIniciales[8] = "L  F          L  L       FFFFFFL";
            datosNivelIniciales[9] = "L         FFFFL  L             L";
            datosNivelIniciales[10] = "L     F          LFFF          L";
            datosNivelIniciales[11] = "L                L       FF    L";
            datosNivelIniciales[12] = "LFFFFFF          L     A    A  L";
            datosNivelIniciales[13] = "L          FFFLPPLDDDDDDDDDDDV L";
            datosNivelIniciales[14] = "L             LPPL             L";
            datosNivelIniciales[15] = "LFFFFFFFFFFFFFLLLLFFFFFFFFFFFFFL";

            Reiniciar();
        }

    } /* fin de la clase Nivel12 */
}
