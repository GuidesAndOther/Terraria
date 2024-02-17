using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Security.Principal;

namespace Terraria  
{
    public class Main : Game {
        private GraphicsDeviceManager graphicsDeviceManager;
        private SpriteBatch spriteBatch;

        World world;
        public Main() {
            graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

            world = new World();

            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            world.Update();

            base.Update(gameTime); 
        }

        protected override void Draw(GameTime gameTime) 
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);  

            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            world.Draw();

            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}