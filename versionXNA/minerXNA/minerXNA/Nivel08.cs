﻿
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel08: Mapa de tiles del nivel 8 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Jose Manuel Rizo:
                        Creada la clase Nivel08 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 8.
   
   0.09x  29-04-2011  Pedro Zalacain: 
                        Agregados los enemigos del nivel.
   0.10x  29-04-2011  Pedro Zalacain: 
                        Modificadas imagenes del nivel.
 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel08 : Nivel
    {

        public Nivel08(ContentManager c)
            : base(c)
        {
            nombre = "Miner Willy Meets The Kong Beast";
            datosNivelIniciales[ 0] = "M T   q   T      Mq M          M";
            datosNivelIniciales[ 1] = "M                M  M          M";
            datosNivelIniciales[ 2] = "M            Q SSM           SSM";
            datosNivelIniciales[ 3] = "M                M             M";
            datosNivelIniciales[ 4] = "M                M             M";
            datosNivelIniciales[ 5] = "MSSS     SSSSSS  MSS           M";
            datosNivelIniciales[ 6] = "M             Q  M   SSSS     SM";
            datosNivelIniciales[ 7] = "M SSS            M         S   M";
            datosNivelIniciales[ 8] = "M Q     SSS      M             M";
            datosNivelIniciales[ 9] = "M                MSSSSSS       M";
            datosNivelIniciales[10] = "MS          SSS  M         SSSSM";
            datosNivelIniciales[11] = "M        SS      M             M";
            datosNivelIniciales[12] = "M   SS           M    SSSSS    M";
            datosNivelIniciales[13] = "M          NNNMPPMSS         Q M";
            datosNivelIniciales[14] = "M             MPPM     A       M";
            datosNivelIniciales[15] = "MSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSM";

            numEnemigos = 2;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo(c);
            listaEnemigos[0].MoverA(380, 40);
            listaEnemigos[0].SetVelocidad(0, 0);
            listaEnemigos[0].SetAnchoAlto(36, 48);

            listaEnemigos[1] = new Enemigo(c);
            listaEnemigos[1].MoverA(150, 350);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(55, 315);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            /*
            listaEnemigos[2] = new Enemigo(c);
            listaEnemigos[2].MoverA(150, 200);
            listaEnemigos[2].SetVelocidad(0, 2);
            listaEnemigos[2].setMinMaxY(100, 300);
            listaEnemigos[2].SetAnchoAlto(36, 48);

            listaEnemigos[3] = new Enemigo(c);
            listaEnemigos[3].MoverA(150, 200);
            listaEnemigos[3].SetVelocidad(0, 2);
            listaEnemigos[3].setMinMaxY(100, 300);
            listaEnemigos[3].SetAnchoAlto(36, 48);
            */
            Reiniciar();
        }

    } /* fin de la clase Nivel08 */
}
