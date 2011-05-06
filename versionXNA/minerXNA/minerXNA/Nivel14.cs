/** 
 *   Nivel14: Mapa de tiles del 14 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.13  07-Ene-2011  Pedro Zalacain Castaño
                      Creada la clase Nivel14
 ---------------------------------------------------- */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{

    public class Nivel14 : Nivel
    {

        public Nivel14(ContentManager c)
            : base(c)
        {
            nombre = "Skylab Landing Bay";
            datosNivelIniciales[0] = "L              PP              L";
            datosNivelIniciales[1] = "L              PP              L";
            datosNivelIniciales[2] = "L                      V       L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "L              []              L";
            datosNivelIniciales[6] = "L  []      []      []      []  L";
            datosNivelIniciales[7] = "L      []       V      []  V   L";
            datosNivelIniciales[8] = "L  V                           L";
            datosNivelIniciales[9] = "L    []      []      []      []L";
            datosNivelIniciales[10] = "L                              L";
            datosNivelIniciales[11] = "L[]      []     OOOOOO    []   L";
            datosNivelIniciales[12] = "L                              L";
            datosNivelIniciales[13] = "L      []                      L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";

            Reiniciar();
        }

    } /* fin de la clase Nivel14 */
}
