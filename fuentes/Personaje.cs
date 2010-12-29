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
    y = 300;
    vidas = 3;
    CargarImagen("imagenes/personaje.png");
  }
  
  
  // Métodos de movimiento
  public void MoverDerecha() 
  {
      x += 4;
  }

  public void MoverIzquierda()
  {
      x -= 4;
  }

  public void MoverArriba()
  {
      y -= 4;
  }

  public void MoverAbajo()
  {
      y += 4;
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
