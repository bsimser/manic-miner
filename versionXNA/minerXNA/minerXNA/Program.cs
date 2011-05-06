using System;

namespace minerXNA
{
#if WINDOWS || XBOX
    static class Program
    {

        
        static void Main(string[] args)
        {
            Presentacion miPresentacion;
            bool sesionTerminada = false;
            bool reiniciarPresentacion = true;

            miPresentacion = new Presentacion();
            

            //do
            {

                //miPresentacion = new Presentacion();
                //miPresentacion.Run();

                Partida miPartida = new Partida();
                miPartida.Run();


                /*switch( miPresentacion.GetOpcionEscogida() )
                {
                        case Presentacion.OPC_CREDITOS: 
                            //creditos.Ejecutar();
                            break;
                        case Presentacion.OPC_SALIR:
                            sesionTerminada = true;
                            break;
                        case Presentacion.OPC_PARTIDA: 
                            Partida miPartida = new Partida();
                            miPartida.Run();
                            break;
                }*/
            }

            //while ( ! sesionTerminada );
            /*using (Partida game = new Partida())
            {
                game.Run();
            }*/
        }
    }
#endif
}

