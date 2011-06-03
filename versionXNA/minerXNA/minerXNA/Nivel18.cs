
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel18: Mapa de tiles del nivel 18 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Alejandro Guillén Esteso
                        Creada la clase Nivel18 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 18.
   0.09x  16-05-2011  Frank Royo
                        Crear Enemigos 
   0.10x  18-05-2011  Frank Royo
                        Colocación de los nuevos personajes y moviento
                        diferentes
 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel18 : Nivel
    {

        public Nivel18(ContentManager c)
            : base(c)
        {
            nombre = "Amoebatrons' Revenge";
            datosNivelIniciales[0] = "L                           LPPL";
            datosNivelIniciales[1] = "L               V            PPL";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "L  SS  SSS  SSSSSSSS  SSS  SSSSL";
            datosNivelIniciales[6] = "L                              L";
            datosNivelIniciales[7] = "LSS                            L";
            datosNivelIniciales[8] = "L           SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[9] = "L  SS  SSS                     L";
            datosNivelIniciales[10] = "L                            SSL";
            datosNivelIniciales[11] = "L                              L";
            datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[13] = "LSS                            L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";

            numEnemigos = 8;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemNivel09a",c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemNivel09a",c);
            listaEnemigos[1].MoverA(310, 280);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(300, 475);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[2] = new Enemigo("enemNivel09a",c);
            listaEnemigos[2].MoverA(350, 183);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(300, 475);
            listaEnemigos[2].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[3] = new Enemigo("enemNivel09a",c);
            listaEnemigos[3].MoverA(450, 111);
            listaEnemigos[3].SetVelocidad(2, 0);
            listaEnemigos[3].setMinMaxX(300, 475);
            listaEnemigos[3].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[4] = new Enemigo("enemNivel18b",c);
            listaEnemigos[4].MoverA(150, 200);
            listaEnemigos[4].SetVelocidad(0, 2);
            listaEnemigos[4].setMinMaxY(100, 300);
            listaEnemigos[4].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[5] = new Enemigo("enemNivel18b", c);
            listaEnemigos[5].MoverA(270, 110);
            listaEnemigos[5].SetVelocidad(0, 2);
            listaEnemigos[5].setMinMaxY(100, 300);
            listaEnemigos[5].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[6] = new Enemigo("enemNivel18b", c);
            listaEnemigos[6].MoverA(500, 250);
            listaEnemigos[6].SetVelocidad(0, 2);
            listaEnemigos[6].setMinMaxY(100, 300);
            listaEnemigos[6].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[7] = new Enemigo("enemNivel18b", c);
            listaEnemigos[7].MoverA(625, 180);
            listaEnemigos[7].SetVelocidad(0, 2);
            listaEnemigos[7].setMinMaxY(100, 300);
            listaEnemigos[7].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase Nivel18 */
}
