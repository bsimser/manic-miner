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
        byte direccionMovimiento;
        // Constructor
        public Enemigo(ContentManager c)
            : base("enemigo", c)
        {
            //miPartida = p;   // Para enlazar con el resto de componentes
            x = 400;         // Resto de valores iniciales
            y = 300;
            incrX = 2;

            // Le añado secuencia al personaje de derecha a izquierda.
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

            direccionMovimiento = DERECHA;
        }


        // Métodos de movimiento
        public void Mover()
        {
            if (direccionMovimiento == DERECHA)
            {
                x += incrX;
                SiguienteFotograma();
                CambiarDireccion(ElemGrafico.DERECHA);

                if ((x < 100) ||(x > 700))
                {
                    CambiarDireccion(ElemGrafico.IZQUIERDA);
                    direccionMovimiento = IZQUIERDA;
                }
            }

            if (direccionMovimiento == IZQUIERDA)
            {
                x -= incrX;
                SiguienteFotograma();
                if ((x < 100) || (x > 700))
                {
                    CambiarDireccion(ElemGrafico.DERECHA);
                    direccionMovimiento = DERECHA;
                }
            }

        }


    }
}
