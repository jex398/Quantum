using ImagineCup.Quantum.Controller;
using ImagineCup.Quantum.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace ImagineCup.Quantum
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<GameObject> objects;
        Physics phys;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            objects = new List<GameObject>();
            Content.RootDirectory = "Content";
        }



        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            TestObject sun = new TestObject();
            sun.m_mass = 300000;
            sun.m_x = 200;
            sun.m_y = 200;
            sun.m_a_x = 0;
            sun.m_a_y = 0;
            sun.m_radius = 1;
            for (int i = 1; i < 100; i++)
            {
                TestObject planet = new TestObject();
                planet.m_mass = 1;
                planet.m_x = 200;
                planet.m_y = 700/i;
                planet.m_a_x = 0;
                planet.m_a_y = 0;
                planet.m_speed_x = 0.1;
                planet.m_speed_y = 0;
                planet.m_radius = 1;
                objects.Add(planet);
            }
            objects.Add(sun);
            
            phys = new Physics(objects);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            int milis_curr = gameTime.ElapsedGameTime.Milliseconds;
            Console.Out.WriteLine(milis_curr);
            if (milis_curr > 10)
            {
                phys.calculatePhysics();
               
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);
            // TODO: Add your drawing code here
            foreach (GameObject planet in objects)
                planet.draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
