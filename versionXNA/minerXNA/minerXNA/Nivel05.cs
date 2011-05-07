
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel05: Mapa de tiles del nivel 5 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  David Martínez Pérez
                        Creada la clase Nivel05 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 5.

 ============================================================= */
 

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel05 : Nivel
    {

        public Nivel05(ContentManager c)
            : base(c)
        {
            nombre = "Eugene Was Here";
            datosNivelIniciales[0] = "L                   T          L";
            datosNivelIniciales[1] = "L                             VL";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                       A      L";
            datosNivelIniciales[5] = "LNNNNNNNNNNNNN    DDDDNNNNNN   L";
            datosNivelIniciales[6] = "L         V                  DDL";
            datosNivelIniciales[7] = "L                    A       V L";
            datosNivelIniciales[8] = "L                 FFFFFFFFFF   L";
            datosNivelIniciales[9] = "L   NNNNNNNNNN                 L";
            datosNivelIniciales[10] = "L                              L";
            datosNivelIniciales[11] = "LDDNNNNNNNNNNN    NNNNNNN     NL";
            datosNivelIniciales[12] = "L      VLV                     L";
            datosNivelIniciales[13] = "LNN     L     LPPL             L";
            datosNivelIniciales[14] = "L    A  L     LPPLLLLLLLAA     L";
            datosNivelIniciales[15] = "LNNNNNNNLLLLLLLLLLLLLLLLNNNNNNNL";

            Reiniciar();
        }

    } /* fin de la clase Nivel05 */
}
