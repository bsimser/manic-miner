using Tao.Sdl; 
using System;

/** 
         *   Imagen: una unica imagen estatica
         *  
         *       @see Hardware ElemGrafico
         *       @author 1-DAI 2008/09
         */

/* --------------------------------------------------         
   Parte de Saboteur - Remake
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  14-May-2009  Nacho Cabanes
                      Version inicial, basada en la 0.06 de ElectroFreddy
 
 ---------------------------------------------------- */

public class Imagen
{
    // Atributos
    private IntPtr punteroInterno;
    
    // Operaciones    
    public  Imagen()  // Constructor
    {
      punteroInterno = IntPtr.Zero;  // En principio, no hay imagen
    }
    
    public  Imagen(string nombreFichero)  // Constructor
    {
      Cargar(nombreFichero);
    }
    
    /// Carga una imagen a partir de un nombre de fichero
    public  void Cargar(string nombreFichero)
    {
      punteroInterno = Hardware.CargarImagen(nombreFichero);
      if (punteroInterno == IntPtr.Zero)
        Hardware.ErrorFatal("Imagen inexistente: "+ nombreFichero);
    }
    
    /// Dibuja una imagen en unas coordenadas (se apoya en Hardware)
    public  void DibujarOculta(short x, short y)
    {
      Hardware.DibujarImagenOculta(punteroInterno, x,y);
    }
    
    /// Devuelve el puntero de SDL (no deberia ser necesario usarla nunca)
    public  IntPtr GetPuntero()
    {
      return punteroInterno;
    }
} /* end class Imagen */
