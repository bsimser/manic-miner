using System;

namespace minerXNA
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Partida game = new Partida())
            {
                game.Run();
            }
        }
    }
#endif
}

