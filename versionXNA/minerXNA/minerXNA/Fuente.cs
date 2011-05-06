// Fuente: para escribir textos en pantalla

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace minerXNA
{

    public class Fuente
    {
        SpriteFont miLetra;

        public Fuente(string nombreLetra, ContentManager c)
        {
            miLetra = c.Load<SpriteFont>(nombreLetra);
        }

        public void EscribirTextoOculta(string texto, int x, int y, Color miColor, SpriteBatch listaSprites)
        {
            listaSprites.DrawString(miLetra, texto, new Vector2(x, y), miColor);
        }

        public void EscribirTextoOculta(string texto, int x, int y, int r, int g, int b, SpriteBatch listaSprites)
        {
            listaSprites.DrawString(miLetra, texto, new Vector2(x, y), new Color(r, g, b));
        }

    }
}
