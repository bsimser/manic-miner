
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel19: Mapa de tiles del nivel 19 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Ethan Martinez Carratala
                        Creada la clase Nivel19 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 19.
 
   0.09x  10-May-2011  David Martinez:
                        Creación de enemigos del nivel
 
   0.10x  18-May-2011  David Martinez:
                        Modificados tipo de enemigos

 ============================================================= */

using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel19 : Nivel
    {

        public Nivel19(ContentManager c)
            : base(c)
        {
            nombre = "Solar Power Generator";
            datosNivelIniciales[ 0] = "LLL                     F      L";
            datosNivelIniciales[ 1] = "LPP                     F     VL";
            datosNivelIniciales[ 2] = "LPP                     F      L";
            datosNivelIniciales[ 3] = "L                       F      L";
            datosNivelIniciales[ 4] = "L                       F      L";
            datosNivelIniciales[ 5] = "LV SS     SSSSSS        FSSSSSSL";
            datosNivelIniciales[ 6] = "L                       F      L";
            datosNivelIniciales[ 7] = "L                   SSS F      L";
            datosNivelIniciales[ 8] = "LSS         SSS         FSSSSSSL";
            datosNivelIniciales[ 9] = "L                       F      L";
            datosNivelIniciales[10] = "L                  SS   F      L";
            datosNivelIniciales[11] = "LSSSS                   FSSSSSSL";
            datosNivelIniciales[12] = "L       DDDD    SSSSS   F     VL";
            datosNivelIniciales[13] = "L                       F      L";
            datosNivelIniciales[14] = "LLL                     F      L";
            datosNivelIniciales[15] = "LLLSSSSSSSSSSSSSSSSSSSSSLSSSSSSL";

            numEnemigos = 7;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemNivel19b",c);
            listaEnemigos[0].MoverA(700, 111);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(625, 725);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemNivel19b",c);
            listaEnemigos[1].MoverA(700, 183);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxX(625, 725);
            listaEnemigos[1].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);
            
            listaEnemigos[2] = new Enemigo("enemNivel19b", c);
            listaEnemigos[2].MoverA(700, 255);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxX(625, 725);
            listaEnemigos[2].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[3] = new Enemigo("enemNivel19b", c);
            listaEnemigos[3].MoverA(500, 350);
            listaEnemigos[3].SetVelocidad(2, 0);
            listaEnemigos[3].setMinMaxX(93, 555);
            listaEnemigos[3].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);



            listaEnemigos[4] = new Enemigo("enemNivel19a", c);
            listaEnemigos[4].MoverA(150, 100);
            listaEnemigos[4].SetVelocidad(0, 2);
            listaEnemigos[4].setMinMaxY(100, 350);
            listaEnemigos[4].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[5] = new Enemigo("enemNivel19a", c);
            listaEnemigos[5].MoverA(260, 200);
            listaEnemigos[5].SetVelocidad(0, 2);
            listaEnemigos[5].setMinMaxY(187, 300);
            listaEnemigos[5].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[6] = new Enemigo("enemNivel19a", c);
            listaEnemigos[6].MoverA(420, 101);
            listaEnemigos[6].SetVelocidad(0, 2);
            listaEnemigos[6].setMinMaxY(100, 300);
            listaEnemigos[6].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase NivelXX */
}
