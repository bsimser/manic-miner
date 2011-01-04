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
   0.07  27-Dic-2010  Nacho Cabanes
                      La posicion se fija con "MoverA", y la velocidad
                        con SetVelocidad, para que "Reiniciar" lo recoloque 
                        en su sitio.
   0.10  31-Dic-2010  Nacho Cabanes
                      Cambiado la posición inicial, para adaptarse al margen superior
 ---------------------------------------------------- */

public class Enemigo : ElemGrafico
{

  // Datos del enemigo
  Partida miPartida; 
  
  // Constructor
  public Enemigo(Partida p)
  {
    miPartida = p;    // Para enlazar con el resto de componentes
    MoverA(400,352);  // Resto de valores iniciales
    SetAnchoAlto(36, 48);
    SetVelocidad(4,0);
    CargarImagen("imagenes/enemigo.png");
  }
  
  
  // Métodos de movimiento
  public new void Mover() 
  {
      x += incrX;
      
      if ((x < 100) || (x > 700))
        incrX = (short) (- incrX);
  }

} /* fin de la clase Enemigo */
