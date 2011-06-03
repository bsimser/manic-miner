
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel17: Mapa de tiles del nivel 17 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Andrés Marotta
                        Creada la clase Nivel17 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 17.
 *        16-05-2011  Maria Navarro: 
                       enemigos Nivel 17.

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{

    public class Nivel17 : Nivel
    {

        public Nivel17(ContentManager c)
            : base(c)
        {
            nombre = "The Warehouse";
            datosNivelIniciales[0] = "L                            LLL";
            datosNivelIniciales[1] = "L                            PPL";
            datosNivelIniciales[2] = "L                            PPL";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L     A  A   A  A     A A      L";
            datosNivelIniciales[5] = "LSSFFFFFFF  FFFFFFF  FFFVFF  SSL";
            datosNivelIniciales[6] = "LFFTFFFFFF  FFFFFFF  FFFFFF  FFL";
            datosNivelIniciales[7] = "LFFFFFFFFF  FFFVFFF  FFFFFT  FFL";
            datosNivelIniciales[8] = "LFF  FFFFF  FFDDDDD  FFFFFF  FFL";
            datosNivelIniciales[9] = "LVF  FFFFF  FFFFFFF  FFFFFF  FFL";
            datosNivelIniciales[10] = "LFF  FFFFF  FFFFFFFVFFTFFFF  FFL";
            datosNivelIniciales[11] = "LFF  FFFFT  FFFFFFFFFFFFFFV  FFL";
            datosNivelIniciales[12] = "LFF  FFFFF  FFFFFFFFFFFFFFF  FFL";
            datosNivelIniciales[13] = "L                              L";
            datosNivelIniciales[14] = "L                          SSSSL";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";
            /*enemNivel17a.png
             enemNivel17b.png*/
            numEnemigos = 4;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemNivel17b", c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(50, 635);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemNivel17a",c);
            listaEnemigos[1].MoverA(90, 250);
            listaEnemigos[1].SetVelocidad(0, 2);
            listaEnemigos[1].setMinMaxY(225, 300);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[2] = new Enemigo("enemNivel17b", c);
            listaEnemigos[2].MoverA(300, 352);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(50, 635);
            listaEnemigos[2].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[3] = new Enemigo("enemNivel17a", c);
            listaEnemigos[3].MoverA(260, 300);
            listaEnemigos[3].SetVelocidad(0, 2);
            listaEnemigos[3].setMinMaxY(100, 300);
            listaEnemigos[3].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);


            /*listaEnemigos[2] = new Enemigo(c);
            listaEnemigos[2].MoverA(200, 352);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[3] = new Enemigo(c);
            listaEnemigos[3].MoverA(180, 200);
            listaEnemigos[3].SetVelocidad(0, 2);
            listaEnemigos[3].setMinMaxY(100, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[4] = new Enemigo(c);
            listaEnemigos[4].MoverA(430, 352);
            listaEnemigos[4].SetVelocidad(2, 0);
            listaEnemigos[4].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[5] = new Enemigo(c);
            listaEnemigos[5].MoverA(100, 200);
            listaEnemigos[5].SetVelocidad(0, 2);
            listaEnemigos[5].setMinMaxY(100, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);*/




            Reiniciar();
        }

    } /* fin de la clase Nivel17 */
}
