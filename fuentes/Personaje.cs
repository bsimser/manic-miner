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
   0.05  25-Dic-2010  Nacho Cabanes
                      Permite saltar en vertical, o bien a ambos lados.s
 ---------------------------------------------------- */

public class Personaje : ElemGrafico
{

  // Datos del personaje
  Partida miPartida; // Para poder comunicar con la partida
                     // y preguntarle sobre enemigos, mapa, etc   
  short vidas;       // Vidas restantes
  bool saltando;
  int incrXSalto;
  int fotogramaMvto;
  int cantidadMovimientoSalto;
  int[] pasosSaltoArriba = {-14, -14, -11, -8, -6, -4, -2, 0,
                             0, 2, 4, 6, 8, 11, 14, 14 };

    
  // Constructor
  public Personaje(Partida p)
  {
    miPartida = p;   // Para enlazar con el resto de componentes
    x = 70;         // Resto de valores iniciales
    y = 424;
    SetAnchoAlto(30, 48);
    SetVelocidad(4, 4);
    vidas = 3;
    saltando = false;
    incrXSalto = 0;
    cantidadMovimientoSalto = pasosSaltoArriba.Length;
    
    CargarImagen("imagenes/personaje.png");
  }
  
  
  // Métodos de movimiento
  public void MoverDerecha() 
  {
      if (saltando) return; // No debe moverse mientras salta
      if (miPartida.GetMapa().EsPosibleMover(x + incrX, y, 
                x + ancho + incrX, y + alto))
            x += incrX;

  }

  public void MoverIzquierda()
  {
      if (saltando) return; // No debe moverse mientras salta
      if (miPartida.GetMapa().EsPosibleMover(x - incrX, y,
                x + ancho - incrX, y + alto))
            x -= incrX;
  }

  public void MoverArriba()
  {
      if (saltando) return; // No debe moverse mientras salta
      if (miPartida.GetMapa().EsPosibleMover(x,y-incrY,
                x+ancho,y+alto-incrY))
            y -= incrY;
  }

  public void MoverAbajo()
  {
      if (saltando) return; // No debe moverse mientras salta
      if (miPartida.GetMapa().EsPosibleMover(x, y + incrY,
                x + ancho, y + alto + incrY))
            y += incrY;
  }
  

  // Para cuando deba moverse solo, p.ej. saltando
  public new void Mover()
  {
      if (saltando)
      {
          // Calculo las siguientes posiciones y veo si son validas
          short xProxMov = (short) (x + incrXSalto);
          short yProxMov = (short) (y + pasosSaltoArriba[fotogramaMvto]);
          bool subiendoSalto = (pasosSaltoArriba[fotogramaMvto] < 0);

          // Si todavía se puede mover, avanzo
          if (miPartida.GetMapa().EsPosibleMover(
              xProxMov, yProxMov + alto - 4,
              xProxMov + ancho, yProxMov + alto)
              || subiendoSalto)
          {
              x = xProxMov;
              y = yProxMov;
          }
          // Y si no, quizá esté cayendo
          else
              saltando = false;

          fotogramaMvto++;
          if (fotogramaMvto >= cantidadMovimientoSalto)
              saltando = false;
      }

  }


  // Comienza la secuencia de salto
  public void Saltar()
  {
      if (saltando)
          return;
      saltando = true;
      fotogramaMvto = 0;
      incrXSalto = 0;
  }


  // Comienza la secuencia de salto hacia la derecha
  public void SaltarDerecha() 
  {
    Saltar();
    incrXSalto = incrX;
  }


  // Comienza la secuencia de salto hacia la izquierda
  public void SaltarIzquierda() 
  {
    Saltar();
    incrXSalto = -incrX;
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
