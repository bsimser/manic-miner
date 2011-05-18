
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel14: Mapa de tiles del nivel 14 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Pedro Zalacain Castaño
                        Creada la clase Nivel14 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 14.

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{

    public class Nivel14 : Nivel
    {

        public Nivel14(ContentManager c)
            : base(c)
        {
            nombre = "Skylab Landing Bay";
            datosNivelIniciales[0] = "L              PP              L";
            datosNivelIniciales[1] = "L              PP              L";
            datosNivelIniciales[2] = "L                      V       L";
            datosNivelIniciales[3] = "L                              L";
            datosNivelIniciales[4] = "L                              L";
            datosNivelIniciales[5] = "L              []              L";
            datosNivelIniciales[6] = "L  []      []      []      []  L";
            datosNivelIniciales[7] = "L      []       V      []  V   L";
            datosNivelIniciales[8] = "L  V                           L";
            datosNivelIniciales[9] = "L    []      []      []      []L";
            datosNivelIniciales[10] = "L                              L";
            datosNivelIniciales[11] = "L[]      []     OOOOOO    []   L";
            datosNivelIniciales[12] = "L                              L";
            datosNivelIniciales[13] = "L      []                      L";
            datosNivelIniciales[14] = "L                              L";
            datosNivelIniciales[15] = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";

            numEnemigos = 3;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo(c);
            listaEnemigos[0].MoverA(200, 300);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxY(200, 800);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[1] = new Enemigo(c);
            listaEnemigos[1].MoverA(270, 370);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxY(200, 800);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[2] = new Enemigo(c);
            listaEnemigos[2].MoverA(150, 200);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxY(200, 800);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            Reiniciar();
        }

    } /* fin de la clase Nivel14 */
}
