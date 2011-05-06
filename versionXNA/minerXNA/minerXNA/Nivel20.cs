/** 
 *   Nivel20: Mapa de tiles del 20 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Antonio Pérez Pareja
                      Creada la clase Nivel20
 ---------------------------------------------------- */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel20 : Nivel
    {

        public Nivel20(ContentManager c)
            : base(c)
        {
            nombre = "This, folks, is the Last Cavern!";
            datosNivelIniciales[0] = "MMMMMMMMMMMMMMMMTTTTTTTTTTTTMMMM";
            datosNivelIniciales[1] = "MA  V    V     A      A    A  VM";
            datosNivelIniciales[2] = "M                              M";
            datosNivelIniciales[3] = "M                              M";
            datosNivelIniciales[4] = "M                 MMMMMMMMMMMMMM";
            datosNivelIniciales[5] = "M                 MPPM V       M";
            datosNivelIniciales[6] = "MS    S    S    SSMPPM        VM";
            datosNivelIniciales[7] = "M    FFFFFFFFFFFMMM  M         M";
            datosNivelIniciales[8] = "M  SS                        SSM";
            datosNivelIniciales[9] = "M                              M";
            datosNivelIniciales[10] = "MDDDDDDDDDDDDDDDDDDDDDD   F    M";
            datosNivelIniciales[11] = "M        AV A V A V         S  M";
            datosNivelIniciales[12] = "MSS                            M";
            datosNivelIniciales[13] = "M    SS                        M";
            datosNivelIniciales[14] = "M                              M";
            datosNivelIniciales[15] = "MSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSM";

            Reiniciar();
        }

    } /* fin de la clase Nivel20 */
}
