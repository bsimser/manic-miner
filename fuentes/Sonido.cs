/** 
         *   Sonido: reproducción de sonidos
         *  
         *       @see Hardware 
         *       @author Nacho
         */

/* --------------------------------------------------         
   Parte de Electro Freddy - Remake
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.11  09-Ene-2009  Nacho Cabanes
                      Creada la estructura basica: puede
                      cargar un sonido, reproducirlo 1 vez,
                      reproducir de fondo o interrumpir todo.
                      (Identico a Fruity 0.25)
 ---------------------------------------------------- */

using System;
using Tao.Sdl; 
 
public class Sonido
{
    // Atributos
    
    IntPtr punteroInterno;
    
    // Operaciones
    
    /// Constructor a partir de un nombre de fichero
    public Sonido(string nombreFichero)
    {
      punteroInterno = SdlMixer.Mix_LoadMUS(nombreFichero);
    }

    /// Reproducir una vez
    public  void Reproducir1()
    {
      SdlMixer.Mix_PlayMusic(punteroInterno, 1);
    }
    
    /// Reproducir continuo (musica de fondo)
    public  void ReproducirFondo()
    {
      SdlMixer.Mix_PlayMusic(punteroInterno, -1);
    }
    
    /// Interrumpir toda la reproducción de sonido
    public  void Interrumpir()
    {
      SdlMixer.Mix_HaltMusic();
    }
    
} /* end class Sonido */
