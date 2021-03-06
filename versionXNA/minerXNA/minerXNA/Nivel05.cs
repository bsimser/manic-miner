﻿
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
   0.09x  16-05-2011  Aitor Salgado: 
                        Introducir Enemigos en el nivel 5 segun
                        corresponda al mapa original.

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

            numEnemigos = 3;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemRetrete", c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemEugene", c);
            listaEnemigos[1].MoverA(380, 100);
            listaEnemigos[1].SetVelocidad(0, 2);
            listaEnemigos[1].setMinMaxY(100, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[2] = new Enemigo("enemRetrete", c);
            listaEnemigos[2].MoverA(150, 200);
            listaEnemigos[2].SetVelocidad(0, 2);
            listaEnemigos[2].setMinMaxY(100, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase Nivel05 */
}
