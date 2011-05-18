/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel03: Mapa de tiles del nivel 3 de juego
 * =============================================================
   Versiones hasta la fecha:

   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11   02-Ene-2011  Nacho Cabanes
                        Creada la clase Nivel03 para SDL
   0.06x  29-04-2011  Nacho Cabanes:
                        Creada la adaptación a XNA del Nivel 3.
   0.09x  16-05-2011  Andrés Marotta: Creados los enemigos del Nivel 3.
                      Nacho Cabanes: los enemigos son de tipo "pavo"

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel03 : Nivel
    {

        public Nivel03(ContentManager c)
            : base(c)
        {
            nombre = "The Menagerie";
            datosNivelIniciales[0] = "M    V   T     V  T    V   T   M";
            datosNivelIniciales[1] = "M                              M";
            datosNivelIniciales[2] = "M                              M";
            datosNivelIniciales[3] = "M                              M";
            datosNivelIniciales[4] = "M                              M";
            datosNivelIniciales[5] = "MNNNNOOOOOOOOOOOOOOOOOOOOOO  OOM";
            datosNivelIniciales[6] = "M                    V        VM";
            datosNivelIniciales[7] = "MNNNNNN                    NNNNM";
            datosNivelIniciales[8] = "MT                             M";
            datosNivelIniciales[9] = "M     DDDDDD                   M";
            datosNivelIniciales[10] = "M                        NNNNNNM";
            datosNivelIniciales[11] = "M             NNNNN          PPM";
            datosNivelIniciales[12] = "M    NNNNNN                  PPM";
            datosNivelIniciales[13] = "M                    NNNNNNNNNNM";
            datosNivelIniciales[14] = "M                              M";
            datosNivelIniciales[15] = "MNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNM";

            numEnemigos = 3;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemPavo", c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 480);
            listaEnemigos[0].SetAnchoAlto(36, 48);

            listaEnemigos[1] = new Enemigo("enemPavo", c);
            listaEnemigos[1].MoverA(150, 110);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(50, 725);
            listaEnemigos[1].SetAnchoAlto(36, 48);

            listaEnemigos[2] = new Enemigo("enemPavo", c);
            listaEnemigos[2].MoverA(200, 110);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(50, 725);
            listaEnemigos[2].SetAnchoAlto(36, 48);

            Reiniciar();
        }

    } /* fin de la clase Nivel03 */
}
