
/* =============================================================
 * Parte de ManicMiner - Remake
 * Nivel10: Mapa de tiles del nivel 10 de juego
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   --------------------------------------------------- 
   0.13  07-Ene-2011  Daniel Marin Mateos
                        Creada la clase Nivel10 para SDL
                      
   0.06x  29-04-2011  Nacho Cabanes: 
                        Creada la adaptación a XNA del Nivel 10.
   0.09x  16-05-2011  Antonio Ramos:
                        Añadidos enemigos a este nivel.
   0.10x  18-05-2011  Antonio Ramos:
                        Añadida nueva apariencia al enemigo, 
                        intentando movimiento nuevo.
  

 ============================================================= */


using Microsoft.Xna.Framework.Content;
namespace minerXNA
{
    public class Nivel10 : Nivel
    {

        public Nivel10(ContentManager c)
            : base(c)
        {
            nombre = "The Endorian Forest";
            datosNivelIniciales[0] = "M             LLLM   LLLLLLLLLLM";
            datosNivelIniciales[1] = "M              V M             M";
            datosNivelIniciales[2] = "MLLLLLL          M   V     LLLLM";
            datosNivelIniciales[3] = "M                M             M";
            datosNivelIniciales[4] = "M                MLLLL         M";
            datosNivelIniciales[5] = "M        LFFFFFFFM     LLLLLLLLM";
            datosNivelIniciales[6] = "MLLLL            M             M";
            datosNivelIniciales[7] = "M                MLLLLLLLFFF   M";
            datosNivelIniciales[8] = "MLLLLL           M V           M";
            datosNivelIniciales[9] = "M         LLLLLLLM           LLM";
            datosNivelIniciales[10] = "MLLLLFF          MLLLLLLL      M";
            datosNivelIniciales[11] = "M                M       FFF   M";
            datosNivelIniciales[12] = "M         MMMMMMMMM            M";
            datosNivelIniciales[13] = "MLLL         PP             LLLM";
            datosNivelIniciales[14] = "M            PP                M";
            datosNivelIniciales[15] = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN";

            Reiniciar();

            numEnemigos = 4;
            listaEnemigos = new Enemigo[numEnemigos];

            listaEnemigos[0] = new Enemigo("enemConejo", c);
            listaEnemigos[0].MoverA(400, 352);
            listaEnemigos[0].SetVelocidad(2, 0);
            listaEnemigos[0].setMinMaxX(100, 700);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

            listaEnemigos[1] = new Enemigo("enemConejo", c);
            listaEnemigos[1].MoverA(400, 200);
            listaEnemigos[1].SetVelocidad(2, 0);
            listaEnemigos[1].setMinMaxY(200, 400);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[2] = new Enemigo("enemConejo", c);
            listaEnemigos[2].MoverA(400, 250);
            listaEnemigos[2].SetVelocidad(2, 0);
            listaEnemigos[2].setMinMaxY(200, 400);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

            listaEnemigos[3] = new Enemigo("enemConejo", c);
            listaEnemigos[3].MoverA(600, 100);
            listaEnemigos[3].SetVelocidad(2, 0);
            listaEnemigos[3].setMinMaxY(550, 750);
            listaEnemigos[0].SetAnchoAlto(36, 48);
            //listaEnemigos[0].CambiarDireccion(ElemGrafico.ABAJO);

        }

    } /* fin de la clase NivelXX */
}
