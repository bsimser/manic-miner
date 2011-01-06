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
                      Cambiada la posición inicial, para adaptarse al margen superior
   0.12  07-Ene-2011  Nacho Cabanes
                      El enemigo no muestra una imagen fija, sino una secuencia de 
                        8 imagenes para cada lado
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
    SetVelocidad(4,0);
    CargarSecuencia(DERECHA,
                new string[] {"imagenes/enemigoN01D01.png", 
                          "imagenes/enemigoN01D02.png", 
                          "imagenes/enemigoN01D03.png", 
                          "imagenes/enemigoN01D04.png", 
                          "imagenes/enemigoN01D05.png", 
                          "imagenes/enemigoN01D06.png", 
                          "imagenes/enemigoN01D07.png", 
                          "imagenes/enemigoN01D08.png"});
    CargarSecuencia(IZQUIERDA,
                new string[] {"imagenes/enemigoN01I01.png", 
                          "imagenes/enemigoN01I02.png", 
                          "imagenes/enemigoN01I03.png", 
                          "imagenes/enemigoN01I04.png", 
                          "imagenes/enemigoN01I05.png", 
                          "imagenes/enemigoN01I06.png", 
                          "imagenes/enemigoN01I07.png", 
                          "imagenes/enemigoN01I08.png"});
    direccion = DERECHA;
    SetAnchoAlto(36, 48);
  }
  
  
  // Métodos de movimiento
  public new void Mover() 
  {
      x += incrX;
      SiguienteFotograma();

      if ((x < 100) || (x > 700))
      {
          incrX = (short)(-incrX);
          if (incrX < 0)
              CambiarDireccion(IZQUIERDA);
          else
              CambiarDireccion(DERECHA);
      }
  }

} /* fin de la clase Enemigo */
