/* =============================================================
 * Parte de ManicMiner - Remake
 * =============================================================
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------

   0.07x  06-05-2011  Antonio Ramos: Agregar secuencia animada de movimiento.
  
   0.08x  11-05-2011  Nacho Cabanes: Permitir movimiento vertical también:
                       Nuevas secuencias y corregido Mover (similar a SDL)

 ============================================================= */

/*
 * Fecha: 06-Mayo-2011
 * Hecho por: Antonio Ramos.
 * Modificaciones: Agregar secuencia de movimiento al personaje.
 * 
 * */
using Microsoft.Xna.Framework.Content;

namespace minerXNA
{
    public class Enemigo : ElemGrafico
    {
        // Constructor
        public Enemigo(ContentManager c)
            : base("enemigo", c)
        {
            //miPartida = p;   // Para enlazar con el resto de componentes
            x = 400;         // Resto de valores iniciales
            y = 300;
            incrX = 1;

            // Secuencias de movimiento
            CargarSecuencia(DERECHA,
                 new string[] {
                  "enemigoN01D01","enemigoN01D01",
                  "enemigoN01D02","enemigoN01D02",
                  "enemigoN01D03","enemigoN01D03",
                  "enemigoN01D04","enemigoN01D04",
                  "enemigoN01D05","enemigoN01D05",
                  "enemigoN01D06","enemigoN01D06",
                  "enemigoN01D07","enemigoN01D07",
                  "enemigoN01D08","enemigoN01D08"}, c
                 );

            CargarSecuencia(IZQUIERDA,
                 new string[] {
                  "enemigoN01I01","enemigoN01I01",
                  "enemigoN01I02","enemigoN01I02",
                  "enemigoN01I03","enemigoN01I03",
                  "enemigoN01I04","enemigoN01I04",
                  "enemigoN01I05","enemigoN01I05",
                  "enemigoN01I06","enemigoN01I06",
                  "enemigoN01I07","enemigoN01I07",
                  "enemigoN01I08","enemigoN01I08"}, c
                 );
            CargarSecuencia(ARRIBA,
                 new string[] {
                  "enemigoN01D01","enemigoN01D01",
                  "enemigoN01D02","enemigoN01D02",
                  "enemigoN01D03","enemigoN01D03",
                  "enemigoN01D04","enemigoN01D04",
                  "enemigoN01D05","enemigoN01D05",
                  "enemigoN01D06","enemigoN01D06",
                  "enemigoN01D07","enemigoN01D07",
                  "enemigoN01D08","enemigoN01D08"}, c
                 );

            CargarSecuencia(ABAJO,
                 new string[] {
                  "enemigoN01I01","enemigoN01I01",
                  "enemigoN01I02","enemigoN01I02",
                  "enemigoN01I03","enemigoN01I03",
                  "enemigoN01I04","enemigoN01I04",
                  "enemigoN01I05","enemigoN01I05",
                  "enemigoN01I06","enemigoN01I06",
                  "enemigoN01I07","enemigoN01I07",
                  "enemigoN01I08","enemigoN01I08"}, c
                 );

            direccion = DERECHA;
        }


        // Métodos de movimiento
        public new void Mover()
        {
            if (incrX != 0)
            {
                x += incrX;
                SiguienteFotograma();

                if ((x < minX) || (x > maxX))
                {
                    incrX = (short)(-incrX);
                    if (incrX < 0)
                        CambiarDireccion(IZQUIERDA);
                    else
                        CambiarDireccion(DERECHA);
                }
            }
            if (incrY != 0)
            {
                y += incrY;
                SiguienteFotograma();

                if ((y < minY) || (y > maxY))
                {
                    incrY = (short)(-incrY);
                    if (incrY < 0)
                        CambiarDireccion(ARRIBA);
                    else
                        CambiarDireccion(ABAJO);
                }
            }
        }


    }
}
