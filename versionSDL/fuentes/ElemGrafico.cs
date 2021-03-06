/** 
         *   ElemGrafico: elemento grafico (sprite)
         *  
         *       @see Hardware Juego Imagen
         *       @author  Nacho
         */

/* --------------------------------------------------         
   Parte de ManicMiner Remake (y antes de Saboteur - Remake)
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
   0.01  14-May-2009  Nacho Cabanes
                      Version inicial, basada en la 0.08 de ElectroFreddy
   0.02  10-Ene-2010  Nacho Cabanes
                      Convertidos a "int" los MoverA, para evitar tantas
                        conversiones de tipo
                      A�adido "anguloCon": angulo entre dos ElemGrafico
                      Cambiado "activo" por "visible" y "chocable" para
                        que se pueda dibujar un elemento pero sin comprobar
                        colisiones con �l y viceversa
                      A�adidas varias direcciones m�s (esquinas, 
                        APARECIENDO, MOVIENDO)
   0.06  25-Mar-2010  Nacho Cabanes
                      A�adida colisi�n con ciertas coordenadas
   0.07  27-Dic-2010  Nacho Cabanes
                      Reiniciar tambi�n recuperar las velocidades
   0.09  29-Dic-2010  Nacho Cabanes
                      A�adidos GetAncho y GetAlto
   0.14  23-Ene-2011  Nacho Cabanes
                      A�adidos minX, maxX, minY, maxY y sus Set correspondientes
   0.15  09-Dic-2011  Nacho Cabanes
                      No falla en SiguienteFotograma ni en CambiarDireccion
                        si hay imagen est�tica en vez de secuencia
 ---------------------------------------------------- */


public class ElemGrafico
{
    // ----- Atributos -----
    protected short x, y;
    protected short incrX, incrY;
    protected short minX, maxX, minY, maxY;
    protected short alto;
    protected short ancho;
    //protected bool activo;
    protected bool visible;
    protected bool chocable;
    
    protected short xOriginal;  // Para llevar a su posicion inicial
    protected short yOriginal;
    protected short incrXOriginal;
    protected short incrYOriginal;

    // La imagen que se mostrar� en pantalla, si es estatica
    protected Imagen  miImagen;
    
    // La secuencia de imagenes, si es animada
    protected Imagen[][] secuencia;
    protected byte fotogramaActual;
    protected byte tamanyoSecuencia;

    protected byte numDirecciones = 10;
    protected byte direccion;
    public const byte ABAJO = 0;
    public const byte ARRIBA = 1;
    public const byte DERECHA = 2;
    public const byte IZQUIERDA = 3;
    public const byte ABAJOD = 4;
    public const byte ABAJOI = 5;
    public const byte ARRIBAD = 6;
    public const byte ARRIBAI = 7;
    public const byte APARECIENDO = 8;
    public const byte MURIENDO = 9;
    
    bool contieneImagen;        // Si no contiene imagen, no se podra dibujar
    bool contieneSecuencia;     // La alternativa: imagenes multiples
        
    // ----- Operaciones -----

    /// Constructor vacio
    public  ElemGrafico()
    {
      contieneImagen = false;
      contieneSecuencia = false;
      //activo = true;
      visible = true;
      chocable = true;
      direccion = ABAJO;
      fotogramaActual = 0;
      secuencia = new Imagen[numDirecciones][];
      maxX = 800;
      maxY = 600;
    }
    
    /// Constructor: Carga la imagen que representara a este elemento grafico
    public  ElemGrafico(string nombre)
    {
      CargarImagen(nombre);
      direccion = ABAJO;
      //activo = true;
      visible = true;
      chocable = true;
      fotogramaActual = 0;
      // Valores por defecto para ancho y alto
      ancho = 32;
      alto = 32;
    }
    
    /// Mueve el elemento grafico a otra posicion
    public  void MoverA(int nuevaX, int nuevaY)
    {
          x = (short) nuevaX;
          y = (short) nuevaY;
          if ( (xOriginal==0) && (yOriginal==0) )
          {
                xOriginal = (short) nuevaX;
                yOriginal = (short) nuevaY;
          }
    }
    
    /// Cambia la velocidad (incrX e incrY) de un elemento
    public  void SetVelocidad(int vX, int vY)
    {
        incrX = (short) vX;
        incrY = (short) vY;
        if ((incrXOriginal == 0) && (incrYOriginal == 0))
        {
            incrXOriginal = (short)vX;
            incrYOriginal = (short)vY;
        }
    }


    /// Carga la imagen que representara a este elemento grafico
    public  void CargarImagen(string nombre)
    {
      miImagen = new Imagen();
      miImagen.Cargar(nombre);
      contieneImagen = true;
      contieneSecuencia = false;
    }

    
    /// Carga una secuencia de imagenes para un elemento animado
    public void CargarSecuencia(byte direcc, string[] nombres)
    {
      contieneImagen = true;
      contieneSecuencia = true;
      tamanyoSecuencia = (byte) nombres.Length;
      secuencia[direcc] = new Imagen[tamanyoSecuencia];
      for (byte i=0; i< tamanyoSecuencia; i++) {
        secuencia[direcc][i] = new Imagen(nombres[i]);
        }
      // Valores por defecto para ancho y alto
      ancho = 32;
      alto = 32;
    }

    /// Mueve el elemento grafico a otra posicion
    public  void CambiarDireccion(byte nuevaDir)
    {
      if (!contieneSecuencia) return;
      if (direccion != nuevaDir)
      {
        direccion = nuevaDir;
        fotogramaActual = 0;
        tamanyoSecuencia = (byte) secuencia[direccion].Length;
      }
      
    }    
    
    /// Devuelve el personaje a su posici�n inicial
    public  void Reiniciar()
    {
      x = xOriginal;
      y = yOriginal;
      incrX = incrXOriginal;
      incrY = incrYOriginal;
    } 

    
    /// Dibuja el elemento grafico en su posicion actual en pantalla oculta
    public  void DibujarOculta()
    {
      if (visible==false) return;
      if (contieneSecuencia)
        secuencia[direccion][fotogramaActual].DibujarOculta(x, y);
      else if (contieneImagen)
        miImagen.DibujarOculta(x, y);
      else
        Hardware.ErrorFatal("Se ha intentado dibujar una imagen no cargada!");
    } 
    
    /// Dibuja el elemento grafico en una posicion cualquiera en pantalla oculta
    public  void DibujarOculta(int nuevaX, int nuevaY)
    {
      MoverA(nuevaX, nuevaY);
      DibujarOculta();
    }

    /// Comprueba si ha chocado con otro elemento gr�fico
    public bool ColisionCon(ElemGrafico otroElem)
    {
      // No se debe chocar con un elemento oculto      
      if ((chocable == false) || (otroElem.chocable == false))
        return false;
      // Ahora ya compruebo coordenadas
      if ((otroElem.x+otroElem.ancho > x)
          && (otroElem.y+otroElem.alto > y)
          && (x+ancho > otroElem.x)
          && (y+alto > otroElem.y))
        return true;
      else
        return false;
    }


    /// Comprueba si choca con un rectangulo
    public bool ColisionCon(short nx, short ny,
      short nxmax, short nymax)
    {
        // No se debe chocar con un elemento oculto      
        if (chocable == false)
            return false;
        // Ahora ya compruebo coordenadas
        if ((nxmax > x)
            && (nymax > y)
            && (x + ancho > nx)
            && (y + alto > ny))
            return true;
        else
            return false;
    }
 
    
    /// Prepara el siguiente fotograma, para animar el movimiento de
    /// un personaje
    public void SiguienteFotograma()
    {
      if (!contieneSecuencia) return;

      if (fotogramaActual < secuencia[direccion].Length -1 )
        fotogramaActual ++;
      else 
        fotogramaActual = 0;
    }
    
    public void Mover()
    {
      // Para ser redefinido en las clases "hijas"
    }
    
    /// Devuelve el valor de x
    public short GetX()
    {
      return x;
    }
    
    /// Devuelve el valor de y
    public short GetY()
    {
      return y;
    }
    
    /// Cambia el ancho y el alto
    public  void SetAnchoAlto(short an, short al)
    {
      alto = al;
      ancho = an;
    }

    /// Devuelven ancho y alto
    public short GetAncho()
    {
        return ancho;
    }

    public short GetAlto()
    {
        return alto;
    }

    /// Devuelve si est� visible
    public  bool GetActivo()
    {
      return visible;
    }
    
    /// Cambia si est� visible o no )
    public  void SetVisible(bool a)
    {
      visible = a;
    }
    
    
    /// Devuelve la direccion del personaje
    public  byte GetDireccion()
    {
      return direccion;
    }
    
     ///Devuelve el angulo que forma el ElementoGraf con otro
    public int AnguloCon(ElemGrafico e2)
    {
        return AnguloCon(e2.x, e2.y, e2.ancho, e2.alto);
    }
    
    
    /// devuelve el angulo que forma el ElementoGraf con
    /// un rectangulo dado por sus coordenadas
    int AnguloCon(int x2, int y2, int ancho2, int alto2)
    {
        // Halla el angulo que forman los centros
        int centro1x = x + ancho/2;
        int centro1y = y + alto/2;
        int centro2x = x2 + ancho2/2;
        int centro2y = y2 + alto2/2;
        if (centro1x == centro2x) return 90;
        return (int) (System.Math.Atan2 (centro2y-centro1y,
            centro2x-centro1x) * (180 / System.Math.PI));
    }

    public void setMinMaxX(short minimo, short maximo)
    {
        minX = minimo;
        maxX = maximo;
    }

    public void setMinMaxY(short minimo, short maximo)
    {
        minY = minimo;
        maxY = maximo;
    }

        
} /* end class ElemGrafico */
