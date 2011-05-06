/** 
         *   Fuente: tipos de letra para escrir en pantalla
         *  
         *       @see Hardware Imagen
         *       @author 1-DAI 2008/09
         */

/* --------------------------------------------------         
   Parte de Saboteur - Remake
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  14-May-2009  Nacho Cabanes
                      Version inicial, basada en la 0.03 de ElectroFreddy
 
 ---------------------------------------------------- */

using System;
using Tao.Sdl;
 
public class Fuente
{
    // Atributos
    
    IntPtr punteroInterno;
    
    // Operaciones
    
    /// Constructor a partir de un nombre de fichero y un tamaño
    public Fuente(string nombreFichero, short tamanyo)
    {
      Cargar(nombreFichero, tamanyo);
    }
    
    public  void Cargar(string nombreFichero, short tamanyo)
    {
      punteroInterno = Hardware.CargarFuente(nombreFichero, tamanyo);
      if (punteroInterno == IntPtr.Zero)
        Hardware.ErrorFatal("Fuente inexistente: "+ nombreFichero);
    }
    
    /*public  void Escribir(short x, short y)
    {
      Hardware.EscribirTextoOculta(punteroInterno, x,y);
    }*/
    
    public  IntPtr LeerPuntero()
    {
      return punteroInterno;
    }
} /* end class Fuente */
