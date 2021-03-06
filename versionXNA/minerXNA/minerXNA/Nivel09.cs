﻿
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel09: Mapa de tiles del nivel 9 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Alejandro Guijarro Terol
                        Creada la clase Nivel09 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 9.
   0.09x  16-05-2011  Antonio Pérez:
                        Añadidos 4 enemigos y su movimiento.
   0.09xb 18-05-2011  Antonio Pérez:
                        Añadidos 1 enemigos y su movimiento.

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel09 : Nivel
    {

        public Nivel09(ContentManager c)
            : base(c)
        {
            nombre = "Wacky Amobeatrons";
            datosNivelIniciales[0] = "LPP                            L";
            datosNivelIniciales[1] = "LPP             V              L";
            datosNivelIniciales[2] = "L                              L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "LSSSS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[6] = "L                              L";
            datosNivelIniciales[7] = "L                            SSL";
            datosNivelIniciales[8] = "L  SS  SSS  FFFFFFFF           L";
            datosNivelIniciales[9] = "L                     SSS  SS  L";
            datosNivelIniciales[10] = "LSS                            L";
            datosNivelIniciales[11] = "L                              L";
            datosNivelIniciales[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L";
            datosNivelIniciales[13] = "L                            SSL";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            numEnemigos = 5;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemNivel09b", c);
            listaEnemigos[0].MoverA(150, 200);
            listaEnemigos[0].SetVelocidad(0, 2);
            listaEnemigos[0].setMinMaxY(100, 350);
            listaEnemigos[0].SetAnchoAlto(30, 39);

            listaEnemigos[1] = new Enemigo("enemNivel09b", c);
            listaEnemigos[1].MoverA(275, 200);
            listaEnemigos[1].SetVelocidad(0, 2);
            listaEnemigos[1].setMinMaxY(100, 350);
            listaEnemigos[1].SetAnchoAlto(30, 39);

            listaEnemigos[2] = new Enemigo("enemNivel09b", c);
            listaEnemigos[2].MoverA(500, 200);
            listaEnemigos[2].SetVelocidad(0, 2);
            listaEnemigos[2].setMinMaxY(100, 350);
            listaEnemigos[2].SetAnchoAlto(30, 39);

            listaEnemigos[3] = new Enemigo("enemNivel09b", c);
            listaEnemigos[3].MoverA(625, 200);            
            listaEnemigos[3].SetVelocidad(0, 2);
            listaEnemigos[3].setMinMaxY(100, 350);
            listaEnemigos[3].SetAnchoAlto(30, 39);

            listaEnemigos[4] = new Enemigo("enemNivel09a", c);
            listaEnemigos[4].MoverA(310, 110);
            listaEnemigos[4].SetVelocidad(2, 0);
            listaEnemigos[4].setMinMaxX(310, 470);
            listaEnemigos[4].SetAnchoAlto(30, 48);

            /*listaEnemigos[5] = new Enemigo("enemNivel09a", c);
            listaEnemigos[5].MoverA(310, 110);
            listaEnemigos[5].SetVelocidad(2, 0);
            listaEnemigos[5].setMinMaxX(310, 470);
            listaEnemigos[5].SetAnchoAlto(30, 48);*/

            Reiniciar();
        }

    } /* fin de la clase Nivel09 */
}
