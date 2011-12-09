/** 
 *   Nivel07: Mapa de tiles del 07 nivel de juego
 *  
 *   @see Partida Nivel Mapa
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
    0.13  07-Ene-2011  Miguel Angel Laguardia
                       mapa nivel 07     
    0.15  09-Dic-2011  Nacho Cabanes: incluido el contenido de la 0.10x (XNA)
                       Denys Demyanchuk: Completar Nivel 7.
 ---------------------------------------------------- */


public class Nivel07 : Nivel
{

    public Nivel07()
    {
        nombre = "The vat";
        datosNivelIniciales[ 0] = "M             MMMMMMMMMMMMMMMMMM";
        datosNivelIniciales[ 1] = "M                              M";
        datosNivelIniciales[ 2] = "M                              M";
        datosNivelIniciales[ 3] = "M              NNMFFFFFFFFFFFFVM";
        datosNivelIniciales[ 4] = "M                MFFFFFFFFFFFFFM";
        datosNivelIniciales[ 5] = "M             NNNMFFFFFFFFFFAFFM"; 
        datosNivelIniciales[ 6] = "MNNN             MFFVFFFFFFFFFFM"; 
        datosNivelIniciales[ 7] = "M                MFFFFFFFFFVFFFM"; 
        datosNivelIniciales[ 8] = "MN               MFFFFFAFFFFFFFM"; 
        datosNivelIniciales[ 9] = "M             NNNMFFFFFFFFFFFFFM"; 
        datosNivelIniciales[10] = "MNNNNNNNNNNN     MFVFFFFFFFFAFFM"; 
        datosNivelIniciales[11] = "M                MFFFFFFFFFFFFVM"; 
        datosNivelIniciales[12] = "M             MMMMFFFFFAFFFFFFFM"; 
        datosNivelIniciales[13] = "M       NNN   MPP              M";
        datosNivelIniciales[14] = "M             MPP              M";
        datosNivelIniciales[15] = "MNNNNNNNNNNNNNMMMMMMMMMMMMMMMMMM";

        numEnemigos = 3;
        listaEnemigos = new Enemigo[numEnemigos];

        listaEnemigos[0] = new Enemigo("imagenes/enemCanguro.png", miPartida);
        listaEnemigos[0].MoverA(430, 350);
        listaEnemigos[0].SetVelocidad(2, 0);
        listaEnemigos[0].setMinMaxX(430, 726);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[1] = new Enemigo("imagenes/enemCanguro.png", miPartida);
        listaEnemigos[1].MoverA(70, 231);
        listaEnemigos[1].SetVelocidad(2, 0);
        listaEnemigos[1].setMinMaxX(70, 275);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        listaEnemigos[2] = new Enemigo("imagenes/enemCanguro.png", miPartida);
        listaEnemigos[2].MoverA(375, 64);
        listaEnemigos[2].SetVelocidad(2, 0);
        listaEnemigos[2].setMinMaxX(375, 726);
        listaEnemigos[0].SetAnchoAlto(36, 48);
        //listaEnemigos[0].CambiarDireccion(ElemGrafico.DERECHA);

        Reiniciar();
    }
  
} /* fin de la clase Nivel07 */
