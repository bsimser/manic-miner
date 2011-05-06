/** 
 *   Nivel10: Mapa de tiles del 10 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Daniel Marin Mateos
                      Creada la clase Nivel10
 ---------------------------------------------------- */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel10 : Nivel
    {

        public Nivel10(ContentManager c)
            : base(c)
        {
            nombre = "The Endorian Forest";
            datosNivelIniciales[0] = "M             LLLM   LLLLLLLLLLM";
            datosNivelIniciales[1] = "M              V M             M";
            datosNivelIniciales[2] = "MLLLLLL          M   V     LLLLM";
            datosNivelIniciales[3] = "M                M             M";
            datosNivelIniciales[4] = "M                MLLLL         M";
            datosNivelIniciales[5] = "M        LFFFFFFFM     LLLLLLLLM";
            datosNivelIniciales[6] = "MLLLL            M             M";
            datosNivelIniciales[7] = "M                MLLLLLLLFFF   M";
            datosNivelIniciales[8] = "MLLLLL           M V           M";
            datosNivelIniciales[9] = "M         LLLLLLLM           LLM";
            datosNivelIniciales[10] = "MLLLLFF          MLLLLLLL      M";
            datosNivelIniciales[11] = "M                M       FFF   M";
            datosNivelIniciales[12] = "M         MMMMMMMMM            M";
            datosNivelIniciales[13] = "MLLL         PP             LLLM";
            datosNivelIniciales[14] = "M            PP                M";
            datosNivelIniciales[15] = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN";

            Reiniciar();
        }

    } /* fin de la clase NivelXX */
}
