
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel04: Mapa de tiles del nivel 4 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Raquel Lloréns Gambín
                        Creada la clase Nivel04 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 4.

   0.09x  16-05-2011  Ethan Martínez Carratalá: 
                        Incluidos dos enemigos que se mueven de forma distinta.
   
   0.10x  18-05.2011  Ethan Martínez Carratalá:
                        Añadidas nuevas imagenes y los enemigos originales. 
 ============================================================= */



using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel04 : Nivel
    {

        public Nivel04(ContentManager c)
            : base(c)
        {
            nombre = "Abandoned Uranium Workings";
            datosNivelIniciales[0] = "LV     $      LLLLLLLLLLLLLLLLLL";
            datosNivelIniciales[1] = "L           V            V   PPL";
            datosNivelIniciales[2] = "L                            PPL";
            datosNivelIniciales[3] = "L                  SSSSSS      L";
            datosNivelIniciales[4] = "L                          SSSSL";
            datosNivelIniciales[5] = "LS     S         S             L";
            datosNivelIniciales[6] = "L           SS  V    SSS      VL";
            datosNivelIniciales[7] = "LFFF                           L";
            datosNivelIniciales[8] = "L      SS                 SSS  L";
            datosNivelIniciales[9] = "L                 SSS          L";
            datosNivelIniciales[10] = "LDDD                          SL";
            datosNivelIniciales[11] = "L           SSS       SSS      L";
            datosNivelIniciales[12] = "L     SS               $    SSSL";
            datosNivelIniciales[13] = "L                 SS           L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

            numEnemigos = 2;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemFoca", c);
            listaEnemigos[0].MoverA(300, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemFoca", c);
            listaEnemigos[1].MoverA(400, 352);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(100, 700);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase Nivel04 */
}
