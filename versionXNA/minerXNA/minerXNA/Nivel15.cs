
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel15: Mapa de tiles del nivel 15 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Aitor Salgado Molina
                        Creada la clase Nivel15 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 15.

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel15 : Nivel
    {

        public Nivel15(ContentManager c)
            : base(c)
        {
            nombre = "The Bank";
            datosNivelIniciales[0] = "L    LLLLLLLLLLLLLLLLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L                            MML";
            datosNivelIniciales[2] = "L                       V    MML";
            datosNivelIniciales[3] = "LPP     DDDDDDDDDDDDDDDDSSSSSMML";
            datosNivelIniciales[4] = "LPP                          MML";
            datosNivelIniciales[5] = "LSSSSS                       MML";
            datosNivelIniciales[6] = "L           V           SS   MML";
            datosNivelIniciales[7] = "L      F    SS               MML";
            datosNivelIniciales[8] = "L  SS             SS         MML";
            datosNivelIniciales[9] = "L                            MML";
            datosNivelIniciales[10] = "LSS         SS           SS  MML";
            datosNivelIniciales[11] = "L                 SS         MML";
            datosNivelIniciales[12] = "L    SSS               SS    MML";
            datosNivelIniciales[13] = "L           SS               MML";
            datosNivelIniciales[14] = "L                         V  MML";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            Reiniciar();
        }

    } /* fin de la clase Nivel15 */
}
