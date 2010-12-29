/** 
 *   Personaje: El personaje que es controlado por el usuario
 *  
 *   @see Hardware ElemGrafico Juego
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  17-Dic-2010  Nacho Cabanes
                      Personaje inicial, con una imagen, capaz de
                        moverse a la derecha,izquierda, arriba, abajo
                         y (vacio) Disparar o Mover de forma automatica
   0.04  24-Dic-2010  Nacho Cabanes
                      Antes de mover en una direccion, comprueba si el mapa
                         lo permite.
                      Indicados ancho y alto, para que las colisiones sean
                         correctas.
 ---------------------------------------------------- */

public class Personaje : ElemGrafico
{

  // Datos del personaje
  Partida miPartida; // Para poder comunicar con la partida
                     // y preguntarle sobre enemigos, mapa, etc   
  short vidas;  // Vidas restantes
    
  // Constructor
  public Personaje(Partida p)
  {
    miPartida = p;   // Para enlazar con el resto de componentes
    x = 400;         // Resto de valores iniciales
    y = 350;
    SetAnchoAlto(30, 48);
    SetVelocidad(4, 4);
    vidas = 3;
    CargarImagen("imagenes/personaje.png");
  }
  
  
  // Métodos de movimiento
  public void MoverDerecha() 
  {
      if (miPartida.GetMapa().EsPosibleMover(x + incrX, y, 
                x + ancho + incrX, y + alto))
            x += incrX;

  }

  public void MoverIzquierda()
  {
      if (miPartida.GetMapa().EsPosibleMover(x - incrX, y,
                x + ancho - incrX, y + alto))
            x -= incrX;
  }

  public void MoverArriba()
  {
      if (miPartida.GetMapa().EsPosibleMover(x,y-incrY,
                x+ancho,y+alto-incrY))
            y -= incrY;
  }

  public void MoverAbajo()
  {
      if (miPartida.GetMapa().EsPosibleMover(x, y + incrY,
                x + ancho, y + alto + incrY))
            y += incrY;
  }
  
  // Para cuando deba moverse solo, p.ej. saltando, o en
  // movimiento continuo, como el PacMan
  public new void Mover()
  {
      // TODO: Vacio por ahora
  }
  
  
  public void Disparar()
  {
      // TODO: Vacio por ahora
  }
  
  
  // Métodos de acceso a las vidas
  public int GetVidas()
  {
    return vidas;
  }
    
  public void SetVidas(short n)
  {
    vidas = n;
  }

  public void Morir()
  {
      vidas--;
  }


} /* fin de la clase Personaje */
