using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using AirTrafficController.forms;
namespace AirTrafficController
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;
        private MouseState currentMouseState;
        private MouseState previousMouseState;

        private menuForm menu;

        public GameTime gameTime;

        private int maxAirplanes = 5;

        private FrameCounter frameCounter;
        private notificationsManager notificationsManager;
        private Vector2 mapSize;

        public Texture2D lineTexture;
        public SpriteFont defaultFont;
        private map map;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 600;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
            mapSize = new Vector2(1000, 1000);
        }
        protected override void Initialize()
        {
            base.Initialize();
            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            this.IsMouseVisible = true;
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            map = new map(this, Vector2.Zero, mapSize);
            defaultFont = Content.Load<SpriteFont>("defaultFont");
            frameCounter = new FrameCounter();
            notificationsManager = new notificationsManager(this);
            lineTexture = new Texture2D(GraphicsDevice, 1, 1);
            lineTexture.SetData(new Color[] { Color.White });

        }
        protected override void UnloadContent()
        {
        }
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.gameTime = gameTime;

            notificationsManager.Update();
            previousKeyboardState = currentKeyboardState;
            previousMouseState = currentMouseState;

            //UPDATE KEYBOARD & MOUSE STATES
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();

            //FRAMECOUNTER
            frameCounter.Update(float.Parse(gameTime.ElapsedGameTime.TotalSeconds.ToString()));

            // Recognize a single click of the left mouse button
            if (previousMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
            {
                //ADD NOTIFICATION
                //notificationsManager.addNotification(new notification(this, "HEY xD"));
            }
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            base.Draw(gameTime);
            spriteBatch.Begin();
                //airplane.Draw(spriteBatch);
                map.Draw(spriteBatch);
            notificationsManager.Draw(spriteBatch);
            //FPS
            spriteBatch.DrawString(defaultFont, Math.Ceiling(frameCounter.CurrentFramesPerSecond).ToString(), Vector2.Zero, Color.Green);
            spriteBatch.End();
        }
        public void addNotification(string message)
        {
            notificationsManager.addNotification(message);
        }
        public void setMenu(menuForm menu)
        {
            this.menu = menu;
        }
        public map getMap()
        {
            return this.map;
        }
        public Vector2 getMapSize()
        {
            return this.mapSize;
        }
        public void addAirplaneToMap(iAirplane airplane)
        {
            if(map.getAirplanes().Count >= this.maxAirplanes)
            {
                notificationsManager.addNotification($"Max airplanes reached {map.getAirplanes().Count}/{this.maxAirplanes}");
            }
            else
            {
                notificationsManager.addNotification($"Adding airplane {airplane.getId()} to the map.");
            }
        }
    }
}
