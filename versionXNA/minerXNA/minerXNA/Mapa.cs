using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace minerXNA
{
    class Mapa
    {

        Partida c;

        private int altoMapa = 16, anchoMapa = 32;
        private int anchoTile = 24, altoTile = 24;
        private int margenIzqdo = 20, margenSuperior = 100;

        ElemGrafico arbol, deslizante, ladrillo, ladrilloX, llave, puerta,
            sueloFino, sueloFragil, sueloGrueso, techo;


        string[] datosNivel =
    {"L        V T    T            V L",
     "L               V              L",
     "L                              L",
     "L                              L",
     "L                      VA  A   L", 
     "LSSSSSSSSSSSSSFFFFSFFFFSSSSSSSSL", 
     "L                             VL", 
     "LSSS                           L", 
     "L                LLL A         L", 
     "LSSSS   DDDDDDDDDDDDDDDDDDDD   L", 
     "L                            SSL", 
     "L                              L", 
     "L            A      LLLFFFFFSSSL", 
     "L    SSSSSSSSSSSSSSS         PPL",
     "L                            PPL",
     "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"};

        // Constructor
        public Mapa(ContentManager c)
        {
            arbol = new ElemGrafico("arbol", c);
            deslizante = new ElemGrafico("deslizante", c);
            ladrillo = new ElemGrafico("ladrillo", c);
            ladrilloX = new ElemGrafico("ladrillo2", c);
            llave = new ElemGrafico("llave", c);
            puerta = new ElemGrafico("puerta", c);
            sueloFino = new ElemGrafico("suelo", c);
            sueloFragil = new ElemGrafico("sueloFragil", c);
            techo = new ElemGrafico("techo", c);
        }

        public void DibujarOculta(SpriteBatch listaSprites)
        {
            // Dibujo el fondo
            for (int i = 0; i < altoMapa; i++)
                for (int j = 0; j < anchoMapa; j++)
                {
                    int posX = j * anchoTile + margenIzqdo;
                    int posY = i * altoTile + margenSuperior;
                    switch (datosNivel[i][j])
                    {
                        case 'A': arbol.DibujarOculta(posX, posY, listaSprites); break;
                        case 'D': deslizante.DibujarOculta(posX, posY, listaSprites); break;
                        case 'F': sueloFragil.DibujarOculta(posX, posY, listaSprites); break;
                        case 'L': ladrillo.DibujarOculta(posX, posY, listaSprites); break;
                        case 'P': puerta.DibujarOculta(posX, posY, listaSprites); break;
                        case 'S': sueloFino.DibujarOculta(posX, posY, listaSprites); break;
                        case 'T': techo.DibujarOculta(posX, posY, listaSprites); break;
                        case 'V': llave.DibujarOculta(posX, posY, listaSprites); break;
                    }
                }
        }
  

    }
}
