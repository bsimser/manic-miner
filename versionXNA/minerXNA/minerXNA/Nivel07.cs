
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel07: Mapa de tiles del nivel 7 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Miguel Angel Laguardia
                        Creada la clase Nivel07 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 7.
 
   0.09x  16-May-2011   Denys Demyanchuk
                          Creado movimiento de los enemigos Nivel 7.
 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel07 : Nivel
    {

        public Nivel07(ContentManager c)
            : base(c)
        {
            nombre = "The vat";
            datosNivelIniciales[0] = "M             MMMMMMMMMMMMMMMMMM";
            datosNivelIniciales[1] = "M                              M";
            datosNivelIniciales[2] = "M                              M";
            datosNivelIniciales[3] = "M              NNMFFFFFFFFFFFFVM";
            datosNivelIniciales[4] = "M                MFFFFFFFFFFFFFM";
            datosNivelIniciales[5] = "M             NNNMFFFFFFFFFFAFFM";
            datosNivelIniciales[6] = "MNNN             MFFVFFFFFFFFFFM";
            datosNivelIniciales[7] = "M                MFFFFFFFFFVFFFM";
            datosNivelIniciales[8] = "MN               MFFFFFAFFFFFFFM";
            datosNivelIniciales[9] = "M             NNNMFFFFFFFFFFFFFM";
            datosNivelIniciales[10] = "MNNNNNNNNNNN     MFVFFFFFFFFAFFM";
            datosNivelIniciales[11] = "M                MFFFFFFFFFFFFVM";
            datosNivelIniciales[12] = "M             MMMMFFFFFAFFFFFFFM";
            datosNivelIniciales[13] = "M       NNN   MPP              M";
            datosNivelIniciales[14] = "M             MPP              M";
            datosNivelIniciales[15] = "MNNNNNNNNNNNNNMMMMMMMMMMMMMMMMMM";

            numEnemigos = 3;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo(c);
            listaEnemigos[0].MoverA(450, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(450, 730);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo(c);
            listaEnemigos[1].MoverA(350, 230);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(100, 340);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[2] = new Enemigo(c);
            listaEnemigos[2].MoverA(200, 75);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);
            
            Reiniciar();
        }

    } /* fin de la clase Nivel07 */
}
