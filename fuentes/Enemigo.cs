/** 
 *   Enemigo: Un primer enemigo que se mueve de lado a lado
 *  
 *   @see Hardware ElemGrafico Juego
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.02  21-Dic-2010  Nacho Cabanes
                      Enemigo inicial, con una imagen, capaz de
                        moverse a la derecha,izquierda, arriba, abajo
                         y (vacio) Disparar o Mover de forma automatica
 ---------------------------------------------------- */

public class Enemigo : ElemGrafico
{

  // Datos del enemigo
  Partida miPartida; 
  
  // Constructor
  public Enemigo(Partida p)
  {
    miPartida = p;   // Para enlazar con el resto de componentes
    x = 400;         // Resto de valores iniciales
    y = 400;
    incrX = 4;
    CargarImagen("imagenes/enemigo.png");
  }
  
  
  // Métodos de movimiento
  public void Mover() 
  {
      x += incrX;
      
      if ((x < 100) || (x > 700))
        incrX = (short) (- incrX);
  }

} /* fin de la clase Enemigo */
