using System;
using System.Threading;
using Tao.Sdl;

/** 
         *   Hardware: oculta el acceso a la libreria grafica
         *  
         *       @see imagen Fuente ElemGrafico
         *       @author Nacho
         */

/* --------------------------------------------------         
   Parte de Fruity Frank - Remake
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.20  08-Dic-2008  Nacho Cabanes
                      Clase básica: incluye Inicializar, DibujarImagenOculta,
                      VisualizarOculta, CargarImagen, TeclaPulsada,
                      RectanguloRellenoRGBA, RectanguloGBBA, Pausa, ErrorFatal,
                      GetAncho, GetAlto, definiciones de teclas
   0.21  09-Dic-2008  Eduardo y Javi
                      Completado, CargarFuente, EscribirTextoOculta
                      Enmascarado puntero                      
   0.22  09-Ene-2009  Nacho Cabanes
                      "Inicializar" prepara también SDL_Mixer, para poder
                      reproducir sonidos
   0.23  03-Mar-2009  Nacho Cabanes
                      Se puede comprobar si se ha pulsado el ratón
   0.24  07-Ene-2010  Nacho Cabanes
                      La posición de pulsación del ratón se devuelve con 
                        parametros out
                      El comenzar en pantalla completa o no, es un parámetro
                        booleano de "inicializar"
                        
   En AstroAttack:
   0.05 25-Mar-2010  Nacho Cabanes
                      Añadido soporte de Joystick

   En ManicMiner:
   0.11 02-Ene-2011  Nacho Cabanes
                      EscribirTextoOculta no falla si recibe un texto vacío
 
 ---------------------------------------------------- */

public class Hardware
{
    // Atributos
    
    static IntPtr pantallaOculta;
    static short ancho, alto;
    
    // Pausa entre clics, para evitar dos clic demasiado cercanos
    static int pausaClics;
    static int instanteClic;
    static int posXraton, posYraton;
    
    static bool existeJoystick;
    static IntPtr joystick;
    
    // Operaciones

    /// Inicializa el modo grafico a un cierto ancho, alto y profundidad de color, p.ej. 640, 480, 24 bits
    public static void Inicializar(short an, short al, int colores, bool pantallaCompleta)
    {
        //System.Console.Write("Inicializando...");
        ancho = an;
        alto = al;
        
        int flags = Sdl.SDL_HWSURFACE | Sdl.SDL_DOUBLEBUF | Sdl.SDL_ANYFORMAT;
        if (pantallaCompleta)
            flags |= Sdl.SDL_FULLSCREEN;
        Sdl.SDL_Init(Sdl.SDL_INIT_EVERYTHING);
        pantallaOculta = Sdl.SDL_SetVideoMode(
          ancho, 
          alto, 
          colores, 
          flags);
          
        // Preparamos el rectángulo de la pantalla
        Sdl.SDL_Rect rect2 =
          new Sdl.SDL_Rect(0,0, (short) ancho, (short) alto);
        Sdl.SDL_SetClipRect(pantallaOculta, ref rect2);    
        
        // Soporte de tipos de letra TTF
        SdlTtf.TTF_Init();
        
        // Inicialización del joystick        
        existeJoystick = true;
        if( Sdl.SDL_NumJoysticks() < 1 )
          existeJoystick = false;
        
        if (existeJoystick)
        {
            joystick = Sdl.SDL_JoystickOpen( 0 );
            if( joystick == IntPtr.Zero )
                existeJoystick = false;
        }
        
        // Inicializamos sonidos con SDL mixer
          if (SdlMixer.Mix_OpenAudio(22050, 
              unchecked(Sdl.AUDIO_S16LSB), 2, 1024) == -1)
            ErrorFatal("No se ha podido inicializar el Sonido"); 
      
        // Pausa entre clics, para evitar dos clic demasiado cercanos
        pausaClics = 10;
        instanteClic = Sdl.SDL_GetTicks();
    }

    /// Dibuja una imagen en pantalla oculta, en ciertas coordenadas
    public static void BorrarPantallaOculta(byte r, byte g, byte b)
    {
      RectanguloRellenoRGBA(0,0,ancho,alto, r,g,b, 0xFF);
    }

    /// Dibuja una imagen en pantalla oculta, en ciertas coordenadas
    public static void DibujarImagenOculta(IntPtr imagen, short x, short y)
    {
      Sdl.SDL_Rect origen = new Sdl.SDL_Rect(0,0,ancho,alto);
      Sdl.SDL_Rect dest = new Sdl.SDL_Rect(x,y,ancho,alto);
      Sdl.SDL_BlitSurface(imagen, ref origen, pantallaOculta, ref dest);
    }

    /// Dibuja una imagen en pantalla oculta, en ciertas coordenadas
    public static void DibujarImagenOculta(Imagen imagen, short x, short y)
    {
      DibujarImagenOculta(imagen.GetPuntero(), x,  y);
    }    
    
    /// Visualiza la pantalla oculta
    public static void VisualizarOculta()
    {
      Sdl.SDL_Flip(pantallaOculta);
    }
    
    
    public static IntPtr CargarImagen(string fichero) 
    {
      IntPtr imagen;
      imagen = SdlImage.IMG_Load(fichero);
      if (imagen == IntPtr.Zero) {
        System.Console.WriteLine("Imagen inexistente: {0}", fichero);
        Environment.Exit(4);
        }
      return imagen;
    }

    public static void EscribirTextoOculta(string texto,
      short x, short y, byte r, byte g, byte b, Fuente f)
    {
        EscribirTextoOculta(texto, x, y, r, g, b, f.LeerPuntero());
    }

    public static void EscribirTextoOculta(string texto,
      short x, short y, byte r, byte g, byte b, IntPtr fuente)
    {
      if ((texto == "") || (texto == null)) return;
      Sdl.SDL_Color color = new Sdl.SDL_Color(r, g, b);
      IntPtr textoComoImagen = SdlTtf.TTF_RenderText_Solid(
        fuente, texto, color);
      if (textoComoImagen == IntPtr.Zero)  
        Environment.Exit(5);
       
      Sdl.SDL_Rect origen = new Sdl.SDL_Rect(0,0,ancho,alto);
      Sdl.SDL_Rect dest = new Sdl.SDL_Rect(x,y,ancho,alto);
       
      Sdl.SDL_BlitSurface(textoComoImagen, ref origen,
        pantallaOculta, ref dest);
    }

    public static IntPtr CargarFuente(string fichero, short tamanyo)
    {
      IntPtr fuente =  SdlTtf.TTF_OpenFont(fichero, tamanyo);
      if (fuente == IntPtr.Zero)  {
        System.Console.WriteLine("Fuente inexistente: {0}", fichero);
        Environment.Exit(6);
      }
      return fuente;
    }

    public static bool TeclaPulsada(int c)
    {
      bool pulsada = false;
      Sdl.SDL_PumpEvents();
      Sdl.SDL_Event suceso;
      Sdl.SDL_PollEvent(out suceso);
      /*if (suceso.type == Sdl.SDL_KEYDOWN)
        if (suceso.key.keysym.sym == c)
          pulsada = true;*/
      int numkeys;
      byte[] teclas = Tao.Sdl.Sdl.SDL_GetKeyState(out numkeys);
      if (teclas[c] == 1)
        pulsada = true;
      return pulsada;
    }

    public static void Pausa(int milisegundos)
    {
      Thread.Sleep(milisegundos);
    }

    public static void CirculoRGBA()
    {
      // ##TODO: Por hacer
    }

    public static void RectanguloRGBA(short x1, short y1, short x2, short y2,
      byte r, byte g, byte b, byte a)
    {
      SdlGfx.rectangleRGBA(pantallaOculta, 
        x1, y1, x2, y2, r, g, b, a);
    }

    public static void RectanguloRellenoRGBA(short x1, short y1, short x2, short y2,
      byte r, byte g, byte b, byte a)
    {
      SdlGfx.boxRGBA(pantallaOculta, 
        x1, y1, x2, y2, r, g, b, a);
    }

    public static void LineaRGBA()
    {
      // ##TODO: Por hacer
    }
    
    /// Devuelve la anchura de la pantalla, en pixeles
    public static int GetAncho()
    {
      return ancho;
    }
    
    /// Devuelve la altura de la pantalla, en pixeles
    public static int GetAlto()
    {
      return alto;
    }
    
    /// Abandona el programa, mostrando un cierto mensaje de error
    public static void ErrorFatal(string texto)
    {
      System.Console.WriteLine(texto);
      Environment.Exit(1);
    }    

    
   /** ratonPulsado: devuelve TRUE si
     *  ha sido pulsado un botón del ratón
     */
    public static bool RatonPulsado(out int posX, out int posY)
    {
        posX = 0; posY = 0;
        
        Sdl.SDL_PumpEvents();
        //SDL_PollEvents();

        // Truco para evitar dos pulsaciones muy cercanas
        int ahora = Sdl.SDL_GetTicks();
        if (ahora-instanteClic < pausaClics)
          return false;

        // Ahora miro si realmente hay pulsación
        if((Sdl.SDL_GetMouseState(out posXraton, out posYraton) & Sdl.SDL_BUTTON(1)) == 1)
        {
            posX = posXraton;
            posY = posYraton;
            return true;
        }
        else
            return false;
    }
    
    
    /** JoyPulsado: devuelve TRUE si
     *  ha sido pulsado un botón del jostick
     *  (cualquiera, por ahora)
     */
    public static bool JoystickPulsado(int boton)
    {
      if (! existeJoystick)
            return false;

      if (Sdl.SDL_JoystickGetButton(joystick, boton) > 0) 
          return true;
      else
          return false;
    }
    
    /** ratonPulsado: devuelve TRUE si
     *  ha sido pulsado un botón del ratón
     */
    public static bool JoystickMovido(out int posX, out int posY)
    {        
        posX = 0; posY = 0;
        if (! existeJoystick)
            return false;
        
        posX = Sdl.SDL_JoystickGetAxis(joystick, 0);  // Leo valores (hasta 32768)
        posY = Sdl.SDL_JoystickGetAxis(joystick, 1);
        // Normalizo valores
        if (posX == -32768) posX = -1;  // Normalizo, a -1, +1 o 0
            else if (posX == 32767) posX = 1;
                else posX = 0;
        if (posY == -32768) posY = -1;
            else if (posY == 32767) posY = 1;
                else posY = 0;

        if ((posX != 0) || (posY != 0))
            return true;
        else
            return false;
    }

    
    
    // Destructor
    ~Hardware()
    {
        Sdl.SDL_FreeSurface( pantallaOculta ); 
        Sdl.SDL_JoystickClose( joystick ); 
        Sdl.SDL_Quit(); 
    }

    
    // Definiciones de teclas
    public static int TECLA_ESC = Sdl.SDLK_ESCAPE;
    public static int TECLA_ESP = Sdl.SDLK_SPACE;
    public static int TECLA_A = Sdl.SDLK_a;
    public static int TECLA_B = Sdl.SDLK_b;
    public static int TECLA_C = Sdl.SDLK_c;
    public static int TECLA_D = Sdl.SDLK_d;
    public static int TECLA_E = Sdl.SDLK_e;
    public static int TECLA_F = Sdl.SDLK_f;
    public static int TECLA_G = Sdl.SDLK_g;
    public static int TECLA_H = Sdl.SDLK_h;
    public static int TECLA_I = Sdl.SDLK_i;
    public static int TECLA_J = Sdl.SDLK_j;
    public static int TECLA_K = Sdl.SDLK_k;
    public static int TECLA_L = Sdl.SDLK_l;
    public static int TECLA_M = Sdl.SDLK_m;
    public static int TECLA_N = Sdl.SDLK_n;
    public static int TECLA_O = Sdl.SDLK_o;
    public static int TECLA_P = Sdl.SDLK_p;
    public static int TECLA_Q = Sdl.SDLK_q;
    public static int TECLA_R = Sdl.SDLK_r;
    public static int TECLA_S = Sdl.SDLK_s;
    public static int TECLA_T = Sdl.SDLK_t;
    public static int TECLA_U = Sdl.SDLK_u;
    public static int TECLA_V = Sdl.SDLK_v;
    public static int TECLA_W = Sdl.SDLK_w;
    public static int TECLA_X = Sdl.SDLK_x;
    public static int TECLA_Y = Sdl.SDLK_y;
    public static int TECLA_Z = Sdl.SDLK_z;
    public static int TECLA_1 = Sdl.SDLK_1;
    public static int TECLA_2 = Sdl.SDLK_2;
    public static int TECLA_3 = Sdl.SDLK_3;
    public static int TECLA_4 = Sdl.SDLK_4;
    public static int TECLA_5 = Sdl.SDLK_5;
    public static int TECLA_6 = Sdl.SDLK_6;
    public static int TECLA_7 = Sdl.SDLK_7;
    public static int TECLA_8 = Sdl.SDLK_8;
    public static int TECLA_9 = Sdl.SDLK_9;
    public static int TECLA_0 = Sdl.SDLK_0;
    public static int TECLA_ARR = Sdl.SDLK_UP;
    public static int TECLA_ABA = Sdl.SDLK_DOWN;
    public static int TECLA_DER = Sdl.SDLK_RIGHT;
    public static int TECLA_IZQ = Sdl.SDLK_LEFT;

    
} /* end class Hardware */
