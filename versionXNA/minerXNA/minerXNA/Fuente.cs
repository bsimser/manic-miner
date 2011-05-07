/** 
 *   Fuente
 * 
 *   Parte de "galaxian-remake"
 *  
 *   @author 1-DAI IES San Vicente 2010/11
 */

/* --------------------------------------------------         
   Versiones hasta la fecha:
   
   Num.   Fecha       Por / Cambios
   ---------------------------------------------------
  0.01  17-Feb-2011  Alejandro Guijarro, Andrés Marotta
                     Pedro Zalacain
            	      Clase "Fuente" para poder utilizar
                      "EscribirTextoOculta" con parámetros similares
 ---------------------------------------------------- */

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


public class Fuente
{
    SpriteFont miLetra;
    public Fuente(string nombreLetra, ContentManager c)
    {
        miLetra = c.Load<SpriteFont>( nombreLetra );
    }

    public void EscribirTextoOculta(string texto, int x, int y, Color miColor, SpriteBatch listaSprites)
    {
        if (texto == "") 
            return;
        listaSprites.DrawString(miLetra, texto, new Vector2(x, y), miColor);
    }

    public void EscribirTextoOculta(string texto, int x, int y, int r, int g, int b, SpriteBatch listaSprites)
    {
        listaSprites.DrawString(miLetra, texto, new Vector2(x, y), new Color(r, g, b));
    }
        
}