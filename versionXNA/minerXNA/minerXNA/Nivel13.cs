
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel13: Mapa de tiles del nivel 13 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Antonio Pérez Pareja
                        Creada la clase Nivel13 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 13.
 
   0.09x  16-05-2011  Alejandro Guijarro Terol
                        Enemigos con movimientos
                        
   0.10x  18-05-2011  Alejandro Guijarro Terol
                        Enemigos correctos
 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel13 : Nivel
    {

        public Nivel13(ContentManager c)
            : base(c)
        {
            nombre = "Ore Refinery";
            datosNivelIniciales[0] = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L  O                           L";
            datosNivelIniciales[2] = "L  O                           L";
            datosNivelIniciales[3] = "L  O   MMMMMMMMMMMMMMMMMM VMMMML";
            datosNivelIniciales[4] = "L  O                           L";
            datosNivelIniciales[5] = "L  O                           L";
            datosNivelIniciales[6] = "L  O   MM VMMMM  MMMMM  MMMM  ML";
            datosNivelIniciales[7] = "L  O                           L";
            datosNivelIniciales[8] = "L  O                           L";
            datosNivelIniciales[9] = "L  O   MMMMM  MMM  VMMMMM VMMMML";
            datosNivelIniciales[10] = "L  O                           L";
            datosNivelIniciales[11] = "L  O                           L";
            datosNivelIniciales[12] = "L  O   MMM VMMM  MMMM  MMMM  MML";
            datosNivelIniciales[13] = "LPPO                           L";
            datosNivelIniciales[14] = "LPPO                           L";
            datosNivelIniciales[15] = "LMMFFFFFFFFFFFFFFFFFFFFFFFFFFMML";

            numEnemigos = 4;
            listaEnemigos = new Enemigo[numEnemigos];

            
           
            // enemigo piso 4
            listaEnemigos[1] = new Enemigo("enemNivel13a",c);
            listaEnemigos[1].MoverA(227, 64);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(200, 700);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            
            // enemigo piso 3
            listaEnemigos[2] = new Enemigo("enemNivel13a", c);
            listaEnemigos[2].MoverA(340, 136);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(200, 700);
            listaEnemigos[2].SetAnchoAlto(36, 48);

            // enemigo piso 2
            listaEnemigos[0] = new Enemigo("enemNivel13a", c);
            listaEnemigos[0].MoverA(400, 208);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(200, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);

            // enemigo piso 1
            listaEnemigos[3] = new Enemigo("enemNivel13a", c);
            listaEnemigos[3].MoverA(420, 280);
            listaEnemigos[3].SetVelocidad(2, 0);
            listaEnemigos[3].setMinMaxX(200, 700);
            listaEnemigos[3].SetAnchoAlto(36, 48);


            Reiniciar();
        }

    } /* fin de la clase Nivel13 */
}
