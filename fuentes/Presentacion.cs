/** 
 *   Presentacion: pantalla de presentacion
 *  
 *   @see Hardware ElemGrafico Juego
 *   @author 1-DAI IES San Vicente 2010/11
 */
 
/* --------------------------------------------------         
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  17-Dic-2010  Nacho Cabanes
                      Version inicial: muestra la pantalla de presentacion 
                        y permite entra a créditos o jugar una partida
 ---------------------------------------------------- */ 

public class Presentacion
{
    // Atributos    
    private ElemGrafico imagen;
    private Fuente fuenteSans18;
    private int opcionEscogida;
    
    // Opciones posibles
    public const byte OPC_PARTIDA = 0;
    public const byte OPC_SALIR = 1;
    public const byte OPC_CREDITOS = 2;


    /// Constructor
    public Presentacion()  // Constructor
    {
        imagen = new ElemGrafico("imagenes/present.png");
        fuenteSans18 = new Fuente("FreeSansBold.ttf",18);
   }
    
    /// Lanza la presentacion
    public  void Ejecutar()
    {
        // Dibujo la imagen de la presentacion
        imagen.DibujarOculta(0,0);
        
        // Escribo avisos de las teclas utilizables
        Hardware.EscribirTextoOculta(
                "Pulsa Espacio para jugar",
                300, 550, 0xAA, 0xAA, 0xAA, fuenteSans18);
        Hardware.EscribirTextoOculta(
                "S para salir, C para créditos",
                290, 575, 0xAA, 0xAA, 0xAA, fuenteSans18);
        
        // Finalmente, muestro en pantalla
        Hardware.VisualizarOculta();  
        
        //hasta que se pulse espacio (sin saturar la CPU)
        do {        
          Hardware.Pausa(40);
        } while ((! Hardware.TeclaPulsada(Hardware.TECLA_ESP) )
                 && (! Hardware.TeclaPulsada(Hardware.TECLA_S))
                 && (! Hardware.TeclaPulsada(Hardware.TECLA_C)));
        
        opcionEscogida = OPC_PARTIDA;
        if (Hardware.TeclaPulsada(Hardware.TECLA_S))
            opcionEscogida = OPC_SALIR;
        if (Hardware.TeclaPulsada(Hardware.TECLA_C))
            opcionEscogida = OPC_CREDITOS;        
    } 
    
      public int GetOpcionEscogida()
      {
        return opcionEscogida;
      }
    
} /* fin de la clase Presentacion */
