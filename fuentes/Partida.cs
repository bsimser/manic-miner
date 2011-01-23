/** 
 *   Partida: Logica de una partida de juego
 *  
 *   @see Hardware
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------         
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  17-Dic-2010  Nacho Cabanes
                      Version inicial: esqueleto, muestra el personaje,
                        permite moverlo a la derecha, izquierda, arriba,
                        abajo y (vacio) Disparar
   0.02  21-Dic-2010  Nacho Cabanes
                      Crea, muestra y mueve un primer enemigo
   0.03  23-Dic-2010  Nacho Cabanes
                      Crea y muestra el mapa de un primer nivel de juego
   0.05  25-Dic-2010  Nacho Cabanes
                      Si se pulsa Espacio, el personaje salta en vertical;
                        con espacio y un lado, salta hacia ese lado.
                      Lo mismo ocurre si se dispara con el joystick y se
                        mueve (o no) hacia algun lado.
                      En "MoverElementos" se mueve también al personaje (salto)  
   0.07  27-Dic-2010  Nacho Cabanes
                      La posicion se fija con "MoverA", para que "Reiniciar"
                        lo recoloque en su sitio.
   0.08  28-Dic-2010  Nacho Cabanes
                      Eliminados MoverArriba y MoverAbajo
   0.09  29-Dic-2010  Nacho Cabanes
                      Cambiado el orden de comprobac salto y movimiento, para que la
                        respuesta al teclado sea más fiable
                      ComprobarColisiones mira puntos y si se choca con algo mortal
                      DibujarElementos muestra los puntos
   0.10  31-Dic-2010  Nacho Cabanes
                      Usa la clase Marcador
   0.11  02-Ene-2011  Nacho Cabanes
                      Al recoger todas las llaves y tocar la puerta, se avanza de nivel.
                      Truco: se avanza también pulsando T+N (para hacer pruebas)
   0.14  23-Ene-2011  Nacho Cabanes
                      Ya no contiene un Enemigo, sino que se delega en la clase Mapa

---------------------------------------------------- */



public class Partida
{

    // Componentes del juego
    private Personaje miPersonaje;
    private Fuente fuenteSans18;
    private Mapa miPantallaJuego;
    private Marcador miMarcador;
    
    // Otros datos del juego
    int puntos;             // Puntuacion obtenida por el usuario
    bool partidaTerminada;  // Si ha terminado una partida
    

    // Inicialización al comenzar la sesión de juego
    public Partida()
    {
        miPersonaje = new Personaje(this);        
        miPantallaJuego = new Mapa(this);
        miMarcador = new Marcador(this);
        puntos = 0;
        partidaTerminada = false;
        fuenteSans18 = new Fuente("FreeSansBold.ttf", 18);
    }
    
        
    // --- Comprobación de teclas, ratón y joystick -----
    void comprobarTeclas()
    {
          // Muevo si se pulsa alguna flecha del teclado
          if (Hardware.TeclaPulsada(Hardware.TECLA_ESP))
          {
              if (Hardware.TeclaPulsada(Hardware.TECLA_DER))
                miPersonaje.SaltarDerecha();
              else if (Hardware.TeclaPulsada(Hardware.TECLA_IZQ))
                  miPersonaje.SaltarIzquierda();
              else
                  miPersonaje.Saltar();
          }
          if (Hardware.TeclaPulsada(Hardware.TECLA_DER))
              miPersonaje.MoverDerecha();

          if (Hardware.TeclaPulsada(Hardware.TECLA_IZQ))
              miPersonaje.MoverIzquierda();

          if ( (Hardware.TeclaPulsada(Hardware.TECLA_T)) &&
              (Hardware.TeclaPulsada(Hardware.TECLA_N)) )
            miPantallaJuego.Avanzar();


          // Compruebo el Joystick
          int posXJoystick, posYJoystick;
          bool JoystickUtilizado = Hardware.JoystickMovido(out posXJoystick, out posYJoystick);

          if (Hardware.JoystickPulsado(0))
          {
              if (posXJoystick > 0) miPersonaje.SaltarDerecha();
              else if (posXJoystick < 0) miPersonaje.SaltarIzquierda();
              else miPersonaje.Saltar();
          }
          else if (JoystickUtilizado)
          {
              if (posXJoystick > 0) miPersonaje.MoverDerecha();
              else if (posXJoystick < 0) miPersonaje.MoverIzquierda();
          }

          // Compruebo el raton
          int posXRaton = 0, posYRaton = 0;
          if (Hardware.RatonPulsado(out posXRaton, out posYRaton))
          {
              miPersonaje.MoverA(posXRaton, posYRaton);
          }

                          
          // Si se pulsa ESC, por ahora termina la partida... y el juego
          if (Hardware.TeclaPulsada(Hardware.TECLA_ESC))
              partidaTerminada = true;
    }

    
    // --- Animación de los enemigos y demás objetos "que se muevan solos" -----
     void moverElementos()
    {
       for (int i=0; i < miPantallaJuego.GetNumEnemigos(); i++)
           miPantallaJuego.GetEnemigo(i).Mover();
       miPersonaje.Mover();
    }
    
        
    // --- Comprobar colisiones de enemigo con personaje, etc ---
     void comprobarColisiones()
    {
        // Colisiones de personaje con fondo: obtener puntos o perder vida
        int puntosMovimiento = miPantallaJuego.ObtenerPuntosPosicion(
          miPersonaje.GetX(),
          miPersonaje.GetY(),
          miPersonaje.GetX() + miPersonaje.GetAncho(),
          miPersonaje.GetY() + miPersonaje.GetAlto());

        // Si realmente ha recogido un objeto, sumamos los puntos en el juego
        if (puntosMovimiento > 0)
        {
            puntos += puntosMovimiento;

            // Si ademas es una puerta, avanzamos de nivel
            if (puntosMovimiento == 50)
                miPantallaJuego.Avanzar();
        }

        // Y si la puntuacion es -1, ha chocado con el fondo:
        // recolocar y perder vida
        if (puntosMovimiento <0 ) 
        {
            miPersonaje.Morir();
            miPersonaje.Reiniciar();
            for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
                miPantallaJuego.GetEnemigo(i).Reiniciar();
        }

        // Igual caso para las colisiones de personaje con enemigo
        for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
            if (miPersonaje.ColisionCon(miPantallaJuego.GetEnemigo(i)))
            {
                miPersonaje.Morir();
                miPersonaje.Reiniciar();
                for (int j = 0; j < miPantallaJuego.GetNumEnemigos(); j++)
                    miPantallaJuego.GetEnemigo(i).Reiniciar();
                break;
            }

         if (miPersonaje.GetVidas() == 0)
             partidaTerminada = true;
    }
    
        
    // --- Dibujar en pantalla todos los elementos visibles del juego ---
    void dibujarElementos()
    {
        // Borro pantalla      
        Hardware.BorrarPantallaOculta(0,0,0);
          
        // Dibujo todos los elementos
        miPantallaJuego.DibujarOculta();
        miPersonaje.DibujarOculta();
        for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
            miPantallaJuego.GetEnemigo(i).DibujarOculta();

        // Y el marcador
        miMarcador.SetVidas(miPersonaje.GetVidas());
        miMarcador.SetPuntuacion(puntos);
        miMarcador.SetNombre(miPantallaJuego.GetNombre());
        miMarcador.DibujarOculta();

        // Finalmente, muestro en pantalla
        Hardware.VisualizarOculta();        
    }
    
        
    // --- Pausa tras cada fotograma de juego, para velocidad de 25 fps -----
    void pausaFotograma() 
    {
        Hardware.Pausa( 40 );
    }
    
    
    // --- Bucle principal de juego -----
    public void BuclePrincipal() 
    {
      
        partidaTerminada = false;
        puntos = 0;
        miPersonaje.Reiniciar();
        miPersonaje.SetVidas(3);
        for (int i = 0; i < miPantallaJuego.GetNumEnemigos(); i++)
            miPantallaJuego.GetEnemigo(i).Reiniciar();
        miPantallaJuego.Reiniciar();

        do {
            comprobarTeclas();
            moverElementos();
            comprobarColisiones();
            dibujarElementos();
            pausaFotograma();
        } while (! partidaTerminada);
    }


    // --- Para que mapa y enemigos puedan saber cosas del personaje
    public Personaje GetPersonaje()
    {
        return miPersonaje;
    }

    // --- Para que personaje y enemigos puedan saber cosas del mapa
    public Mapa GetMapa()
    {
        return miPantallaJuego;
    }
    
            
} /* fin de la clase Partida */
