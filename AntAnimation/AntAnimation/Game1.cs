using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Threading;

namespace AntAnimation
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D cube;
        Texture2D ant;
        
        int windowWidth = 850;
        int windowHeight = 600;
        SpriteFont Arial;

        KeyboardState oldstate = Keyboard.GetState();
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";           
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;        
            this.Window.Title = "Ant Simulation";
            
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            cube = Content.Load<Texture2D>("cube");
            ant = Content.Load<Texture2D>("ants2");
            Arial = Content.Load<SpriteFont>("Arial");

            // TODO: use this.Content to load your game content here
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            KeyboardState newstate = Keyboard.GetState();
            if (newstate.IsKeyDown(Keys.Down) && !oldstate.IsKeyDown(Keys.Down))
            {
                Ant.moves = Ant.moves - 5; ;                
            }
            if (newstate.IsKeyDown(Keys.Up) && !oldstate.IsKeyDown(Keys.Up))
            {
                Ant.moves = Ant.moves + 5;                
            }

            oldstate = newstate;

            // TODO: Add your update logic here
            if (Data.running == false)
            {
                KeyboardState state = Keyboard.GetState();
                if (state.IsKeyDown(Keys.Space) == true)
                {
                    Data.running = true;
                }
            }
            Ant.Run();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(cube, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(ant, Data.antPosition, Color.White);
            spriteBatch.DrawString(Arial, "Steps:", new Vector2(600, 50), Color.Black, 0F,
                    new Vector2(0, 0), 1F, SpriteEffects.None, 0);
            
            for (int i = Math.Max(1,Data.numAnts-15); i <= Data.numAnts; i++)
            {
                spriteBatch.DrawString(Arial, "Ant " + i + " uses " + Data.steps[i - 1] + " steps.", 
                    new Vector2(600, 90 + 20 * (i - Math.Max(1, Data.numAnts - 15))), Color.Black, 0F,
                    new Vector2(0, 0), 1F, SpriteEffects.None, 0);
            }

            spriteBatch.DrawString(Arial, "Average Steps: "+Data.average.ToString("n3"), new Vector2(600, 550), Color.Black, 0F,
                    new Vector2(0, 0), 1F, SpriteEffects.None, 0);
            spriteBatch.DrawString(Arial, "Move rate: " + Ant.moves +"\n Larger rate = Slower", new Vector2(120, 540), Color.Black, 0F,
                    new Vector2(0, 0), 1F, SpriteEffects.None, 0);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
