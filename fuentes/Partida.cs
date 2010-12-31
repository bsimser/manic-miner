﻿/** 
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
 ---------------------------------------------------- */



public class Partida
{

    // Componentes del juego
    private Personaje miPersonaje;
    private Enemigo miEnemigo;
    private Fuente fuenteSans18;
    private Mapa miPantallaJuego;
    
    // Otros datos del juego
    int puntos;             // Puntuacion obtenida por el usuario
    bool partidaTerminada;  // Si ha terminado una partida
    

    // Inicialización al comenzar la sesión de juego
    public Partida()
    {
        miPersonaje = new Personaje(this);        
        miEnemigo = new Enemigo(this);
        miPantallaJuego = new Mapa(this);
        puntos = 0;
        partidaTerminada = false;
        fuenteSans18 = new Fuente("FreeSansBold.ttf", 18);
    }
    
        
    // --- Comprobación de teclas, ratón y joystick -----
    void comprobarTeclas()
    {
          // Muevo si se pulsa alguna flecha del teclado
          if (Hardware.TeclaPulsada(Hardware.TECLA_DER) )
              miPersonaje.MoverDerecha();
          
          if (Hardware.TeclaPulsada(Hardware.TECLA_IZQ))
              miPersonaje.MoverIzquierda();

          if (Hardware.TeclaPulsada(Hardware.TECLA_ARR))
              miPersonaje.MoverArriba();

          if (Hardware.TeclaPulsada(Hardware.TECLA_ABA))
              miPersonaje.MoverAbajo();

          if (Hardware.TeclaPulsada(Hardware.TECLA_ESP))
          {
              if (Hardware.TeclaPulsada(Hardware.TECLA_DER))
                miPersonaje.SaltarDerecha();
              else if (Hardware.TeclaPulsada(Hardware.TECLA_IZQ))
                  miPersonaje.SaltarIzquierda();
              else
                  miPersonaje.Saltar();
          }

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
              else if (posYJoystick > 0) miPersonaje.MoverAbajo();
              else if (posYJoystick < 0) miPersonaje.MoverArriba();
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
       miEnemigo.Mover();
       miPersonaje.Mover();
    }
    
        
    // --- Comprobar colisiones de enemigo con personaje, etc ---
     void comprobarColisiones()
    {
        if (miPersonaje.ColisionCon(miEnemigo))
        {
            miPersonaje.Morir();
            miPersonaje.Reiniciar();
            miEnemigo.Reiniciar();
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
        miEnemigo.DibujarOculta();

        // Muestro vidas (pronto será parte del marcador)
        Hardware.EscribirTextoOculta("Vidas: "+miPersonaje.GetVidas(),
            280, 550, 0xAA, 0xAA, 0xAA, fuenteSans18);
        
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
        miPersonaje.Reiniciar();
        miPersonaje.SetVidas(3);
        miEnemigo.Reiniciar();
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
