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
                      Permite saltar en vertical, o bien a ambos lados.
   0.07  27-Dic-2010  Nacho Cabanes
                      La posicion se fija con "MoverA", para que "Reiniciar"
                        lo recoloque en su sitio.
   0.08  28-Dic-2010  Nacho Cabanes
                      Al final de un salto (en "Mover"), comprueba si debe caer.
                      Al final de mover a Dcha o Izqda, comprueba si debe caer.
                      Eliminados MoverArriba y MoverAbajo
   0.09  29-Dic-2010  Nacho Cabanes
                      Cambiado el orden de salto y movimiento, para que la
                        respuesta sea más fiable
                      Cambiada la secuencia de salto: mas ancha y mas baja
   0.10  31-Dic-2010  Nacho Cabanes
                      Cambiada la posición inicial, para adaptarse al margen superior
   0.12  07-Ene-2011  Nacho Cabanes
                      El personaje no muestra una imagen fija, sino una secuencia de 
                        8 imagenes para cada lado
 ---------------------------------------------------- */

public class Personaje : ElemGrafico
{

  // Datos del personaje
  Partida miPartida; // Para poder comunicar con la partida
                     // y preguntarle sobre enemigos, mapa, etc   
  short vidas;       // Vidas restantes
  bool saltando, cayendo;
  int incrXSalto;
  int fotogramaMvto;
  int cantidadMovimientoSalto;
  int[] pasosSaltoArriba = {-10, -10, -8, -8, -6, -6, -4, -2, -1, -1, 0,
                             0, 1, 1, 2, 4, 6, 6, 8, 8, 10, 10 };

    
  // Constructor
  public Personaje(Partida p)
  {
    miPartida = p;   // Para enlazar con el resto de componentes
    MoverA(70,352);         // Resto de valores iniciales
    
    SetVelocidad(4, 4);
    vidas = 3;
    saltando = false;
    incrXSalto = 0;
    cantidadMovimientoSalto = pasosSaltoArriba.Length;

    CargarSecuencia(DERECHA,
            new string[] {"imagenes/personajeD01.png", "imagenes/personajeD01.png", 
                          "imagenes/personajeD02.png", "imagenes/personajeD02.png", 
                          "imagenes/personajeD03.png", "imagenes/personajeD03.png", 
                          "imagenes/personajeD04.png", "imagenes/personajeD04.png", 
                          "imagenes/personajeD05.png", "imagenes/personajeD05.png", 
                          "imagenes/personajeD06.png", "imagenes/personajeD06.png", 
                          "imagenes/personajeD07.png", "imagenes/personajeD07.png", 
                          "imagenes/personajeD08.png", "imagenes/personajeD08.png"});
    CargarSecuencia(IZQUIERDA,
            new string[] {"imagenes/personajeI01.png", "imagenes/personajeI01.png", 
                          "imagenes/personajeI02.png", "imagenes/personajeI02.png", 
                          "imagenes/personajeI03.png", "imagenes/personajeI03.png", 
                          "imagenes/personajeI04.png", "imagenes/personajeI04.png", 
                          "imagenes/personajeI05.png", "imagenes/personajeI05.png", 
                          "imagenes/personajeI06.png", "imagenes/personajeI06.png", 
                          "imagenes/personajeI07.png", "imagenes/personajeI07.png", 
                          "imagenes/personajeI08.png", "imagenes/personajeI08.png"});
    direccion = DERECHA;
    SetAnchoAlto(30, 48); // Si se carga secuencia, ancho y alto deben ir detras
  }
  
  
  // Métodos de movimiento
  public void MoverDerecha() 
  {
      if (saltando || cayendo) return; // No debe moverse mientras salta

      CambiarDireccion(DERECHA);
      if (miPartida.GetMapa().EsPosibleMover(x + incrX, y + alto - 4,
                x + ancho + incrX, y + alto))
      {
          x += incrX;
          SiguienteFotograma();
      }
      cayendo = true;
  }

  public void MoverIzquierda()
  {
      if (saltando || cayendo) return; // No debe moverse mientras salta

      CambiarDireccion(IZQUIERDA);
      if (miPartida.GetMapa().EsPosibleMover(x - incrX, y + alto - 4,
                x + ancho - incrX, y + alto))
      {
          x -= incrX;
          SiguienteFotograma();
      }
      cayendo = true;
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
              SiguienteFotograma();
          }
          // Y si no, quizá esté cayendo
          else
          {
              saltando = false;
              cayendo = true;
          }

          fotogramaMvto++;
          if (fotogramaMvto >= cantidadMovimientoSalto)
          {
              saltando = false;
              cayendo = true;
          }
      }
      else if (cayendo)
      {
          if (miPartida.GetMapa().EsPosibleMover(
              x, y + incrY + alto - 4,
             x + ancho, y + incrY + alto))
          {
              y += incrY;
          }
          else
              cayendo = false;
      }

  }


  // Comienza la secuencia de salto
  public void Saltar()
  {
      if (saltando || cayendo)
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
