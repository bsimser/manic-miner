using System;

namespace minerXNA
{
#if WINDOWS || XBOX
    static class Program
    {

        
        static void Main(string[] args)
        {
              GestorPantallas entornoJuego = new GestorPantallas();
              entornoJuego.Run();
        }
    }
#endif
}

