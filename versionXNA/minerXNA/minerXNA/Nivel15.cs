
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel15: Mapa de tiles del nivel 15 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Aitor Salgado Molina
                        Creada la clase Nivel15 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 15.
 * 0.09   16-05-2011  Jose Manuel Rizo
 *                    Rellenar el nivel 15 del juego Manic Miner
 * 0.10   18-05-2011  Jose Manuel Rizo
 *                    Rellenar el nivel 15 del juego Manic Miner
 
 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel15 : Nivel
    {

        public Nivel15(ContentManager c)
            : base(c)
        {
            nombre = "The Bank";
            datosNivelIniciales[0] = "L    LLLLLLLLLLLLLLLLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L                            MML";
            datosNivelIniciales[2] = "L                       V    MML";
            datosNivelIniciales[3] = "LPP     DDDDDDDDDDDDDDDDSSSSSMML";
            datosNivelIniciales[4] = "LPP                          MML";
            datosNivelIniciales[5] = "LSSSSS                       MML";
            datosNivelIniciales[6] = "L           V           SS   MML";
            datosNivelIniciales[7] = "L      F    SS               MML";
            datosNivelIniciales[8] = "L  SS             SS         MML";
            datosNivelIniciales[9] = "L                            MML";
            datosNivelIniciales[10] = "LSS         SS           SS  MML";
            datosNivelIniciales[11] = "L                 SS         MML";
            datosNivelIniciales[12] = "L    SSS               SS    MML";
            datosNivelIniciales[13] = "L           SS               MML";
            datosNivelIniciales[14] = "L                         V  MML";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            numEnemigos = 3;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemNivel15", c);
            listaEnemigos[0].MoverA(200, 65);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 670);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemNivel15", c);
            listaEnemigos[1].MoverA(250, 300);
            listaEnemigos[1].SetVelocidad(0,2);
            listaEnemigos[1].setMinMaxY(140, 350);
            listaEnemigos[1].SetAnchoAlto(36, 48);

            listaEnemigos[2] = new Enemigo("enemNivel15", c);
            listaEnemigos[2].MoverA(520, 160);
            listaEnemigos[2].SetVelocidad(0, 2);
            listaEnemigos[2].setMinMaxY(140, 350);
            listaEnemigos[2].SetAnchoAlto(36, 48);

            Reiniciar();
        }

    } /* fin de la clase Nivel15 */
}
