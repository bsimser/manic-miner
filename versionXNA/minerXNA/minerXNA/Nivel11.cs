
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel11: Mapa de tiles del nivel 11 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Héctor Pastor
                        Creada la clase Nivel11 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 11.
 
   0.10x  18-05-2011  Manuel Martinez, Javier Abad
                        Dos enemigos de tipo "teléfono" 
 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel11 : Nivel
    {
        public Nivel11(ContentManager c)
            : base(c)
        {
            nombre = "Attack of the Mutant Telephones";
            datosNivelIniciales[0] = "LLLLLLL                 V      L";
            datosNivelIniciales[1] = "LPP                           VL";
            datosNivelIniciales[2] = "LPP                            L";
            datosNivelIniciales[3] = "LFFFF                          L";
            datosNivelIniciales[4] = "LV                             L";
            datosNivelIniciales[5] = "L    FFFFFF    FFFFFFFFFFF     L";
            datosNivelIniciales[6] = "L                  V         FFL";
            datosNivelIniciales[7] = "L                              L";
            datosNivelIniciales[8] = "LFF                          FFL";
            datosNivelIniciales[9] = "L          FFFFFFFFF           L";
            datosNivelIniciales[10] = "L                           F  L";
            datosNivelIniciales[11] = "L     DDDF                     L";
            datosNivelIniciales[12] = "L                           FFFL";
            datosNivelIniciales[13] = "LFF                    FFF    VL";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFL";

            numEnemigos = 2;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemTelefono", c);
            listaEnemigos[0].MoverA(100, 100);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(150, 300);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            

            listaEnemigos[1] = new Enemigo("enemTelefono", c);
            listaEnemigos[1].MoverA(600, 200);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(280, 380);
            listaEnemigos[1].SetAnchoAlto(36, 48);

            Reiniciar();
        }

    } /* fin de la clase Nivel11 */
}
