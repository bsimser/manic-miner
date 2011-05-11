/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel01: Mapa de tiles del nivel 1 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.11   02-Ene-2011  Nacho Cabanes
                        Creada la clase Nivel02 para SDL
   0.14  23-Ene-2011  Nacho Cabanes
                      Incluidos dos enemigos: uno con movimiento horizontal
                        y otro vertical
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 2.

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel01 : Nivel
    {

        public Nivel01(ContentManager c) : base(c)
        {
            nombre = "Central Cavern";
            datosNivelIniciales[0] = "L        V T    T            V L";
            datosNivelIniciales[1] = "L               V              L";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                      VA  A   L";
            datosNivelIniciales[5] = "LSS  SSSSSSSSSFFFFSFFFFSSSSSSSSL";
            datosNivelIniciales[6] = "L                             VL";
            datosNivelIniciales[7] = "LSSS                           L";
            datosNivelIniciales[8] = "L                LLL A         L";
            datosNivelIniciales[9] = "LSSSS   DDDDDDDDDDDDDDDDDDDD   L";
            datosNivelIniciales[10] = "L                            SSL";
            datosNivelIniciales[11] = "L                              L";
            datosNivelIniciales[12] = "L            A      LLL  FFFSSSL";
            datosNivelIniciales[13] = "L    SSSSSSSSSSSSSSS         PPL";
            datosNivelIniciales[14] = "L                            PPL";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            numEnemigos = 2;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo(c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo(c);
            listaEnemigos[1].MoverA(150, 200);
            listaEnemigos[1].SetVelocidad(0, 2);
            listaEnemigos[1].setMinMaxY(100, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase Nivel01 */
}
