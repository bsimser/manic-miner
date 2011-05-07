
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel08: Mapa de tiles del nivel 8 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Jose Manuel Rizo
                        Creada la clase Nivel08 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 8.

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel08 : Nivel
    {

        public Nivel08(ContentManager c)
            : base(c)
        {
            nombre = "Miner Willy Meets The Kong Beast";
            datosNivelIniciales[0] = "M T   L   L    AAML M          M";
            datosNivelIniciales[1] = "M              AAM  M          M";
            datosNivelIniciales[2] = "M            V DDM           DDM";
            datosNivelIniciales[3] = "M                M             M";
            datosNivelIniciales[4] = "M                M             M";
            datosNivelIniciales[5] = "MDDD     DDDDDD  MDD           M";
            datosNivelIniciales[6] = "M             V  M   DDDD     DM";
            datosNivelIniciales[7] = "M DDD            M         D   M";
            datosNivelIniciales[8] = "M V     DDD      M             M";
            datosNivelIniciales[9] = "M                MDDDDDD       M";
            datosNivelIniciales[10] = "MD          DDD  M         DDDDM";
            datosNivelIniciales[11] = "M        DD      M             M";
            datosNivelIniciales[12] = "M   DD           M    DDDDD    M";
            datosNivelIniciales[13] = "M          NNNMPPMDD         V M";
            datosNivelIniciales[14] = "M             MPPM     A       M";
            datosNivelIniciales[15] = "MDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDM";

            Reiniciar();
        }

    } /* fin de la clase Nivel08 */
}
