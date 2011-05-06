using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace minerXNA
{
    class Mapa
    {

        Partida miPartida;

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
        public Mapa(Partida p)
        {
            miPartida = p;   // Para enlazar con el resto de componentes

            arbol = new ElemGrafico("arbol", miPartida);
            deslizante = new ElemGrafico("deslizante", miPartida);
            ladrillo = new ElemGrafico("ladrillo", miPartida);
            ladrilloX = new ElemGrafico("ladrillo2", miPartida);
            llave = new ElemGrafico("llave", miPartida);
            puerta = new ElemGrafico("puerta", miPartida);
            sueloFino = new ElemGrafico("suelo", miPartida);
            sueloFragil = new ElemGrafico("sueloFragil", miPartida);
            techo = new ElemGrafico("techo", miPartida);
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
