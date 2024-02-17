#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace Terraria
{
    public class Basic2d
    {

        public Vector2 pos, dims;

        public Texture2D model;


        public Basic2d(string PATH, Vector2 POS, Vector2 DIMS) 
        {
            pos = POS;
            dims = DIMS;

            model = Globals.content.Load<Texture2D>(PATH);

        }

        public virtual void Update()
        {

        }


        public virtual void Draw()
        {
            if (model != null)
            {
                Globals.spriteBatch.Draw(model, new Rectangle((int)(pos.X), (int)(pos.Y), (int)(dims.X), (int)(dims.Y)), null, Color.White, 0.0f, new Vector2(model.Bounds.Width / 2, model.Bounds.Height / 2), SpriteEffects.None, 0);
            }        
        }
    }
}
