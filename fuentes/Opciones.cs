/** 
         *   Opciones: pantalla de opciones
         *  
         *       @see Hardware Juego Presentacion
         *       @author 1-DAI IES San Vicente 2010/11
         */

/* --------------------------------------------------
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.07  27-Dic-2010  Nacho Cabanes
                      Primera versión de la pantalla de opciones,
                        que todavía no muestra información.
 ---------------------------------------------------- */


public class Opciones
{
    // Atributos
    private Fuente fuenteSans18;
    private Fuente fuenteSans12;

    public Opciones()  // Constructor
    {
      fuenteSans18 = new Fuente("FreeSansBold.ttf",18);
      fuenteSans12 = new Fuente("FreeSansBold.ttf",12);
    }
    

    /// Lanza la pantalla de creditos
    public  void Ejecutar()
    {
      bool salir = false;  
      
      byte color = 0x55;
      while (! salir )
      {

          Hardware.BorrarPantallaOculta(0,0,0); // Borro en negro
          
          Hardware.EscribirTextoOculta(
              "Opciones", 110, 100,
                0x77, 0x77, color, fuenteSans18);
          
          Hardware.EscribirTextoOculta("Pronto disponibles...", 200, 240,
                color, color, 0, fuenteSans18);                
          Hardware.EscribirTextoOculta(
                "Pulsa ESC para volver a la presentación...",
                110,550,0xAA, 0xAA, 0xAA, fuenteSans12);
				
			
          Hardware.VisualizarOculta();
          Hardware.Pausa(40); 
          
          salir = Hardware.TeclaPulsada (Hardware.TECLA_ESC);
      }
    } 
    
} /* fin de la clase Opciones */
