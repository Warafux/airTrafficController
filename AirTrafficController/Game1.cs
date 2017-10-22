﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using AirTrafficController.forms;
using System.Collections.Generic;
using C3.XNA;

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
        private double lastSecond;

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
            mapSize = new Vector2(100000, 100000);
            this.lastSecond = 0;
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
            
            //1 second delay event call
            if(this.lastSecond != gameTime.TotalGameTime.Seconds)
            {
                updateByOneSecond();
            }
            this.lastSecond = gameTime.TotalGameTime.Seconds;

            //UPDATE KEYBOARD & MOUSE STATES
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();

            //FRAMECOUNTER
            frameCounter.Update(float.Parse(gameTime.ElapsedGameTime.TotalSeconds.ToString()));

            //Click on an airplane
           
            List<iAirplane> airplanes = this.map.getAirplanes();
            foreach (iAirplane airplane in airplanes)
            {
                //Primitives2D.DrawLine(spriteBatch, currentMouseState.Position.ToVector2(), airplane.getDrawPos(), Color.Black);
                if (Vector2.Distance(currentMouseState.Position.ToVector2(), airplane.getDrawPos()) < 30)
                {
                    if (previousMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
                    {
                        airplane.switchDrawInfo();
                    }
                }
            }
        }
        private void updateByOneSecond()
        {
            map.Update(this.gameTime);
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
        public string generateRandomId()
        {
            Random random = new Random();
            string randomGeneratedId = random.Next(0, 9999).ToString();
            while (map.existIdInMap(randomGeneratedId))
            {
                //Checks if the id already exists
                randomGeneratedId = random.Next(0, 9999).ToString();
            }

            //Adds 0 at the beggining if the number is under 1000
            int idLenght = randomGeneratedId.Length;
            for (int i = 0; i < (4 - idLenght); i++)
            {
                randomGeneratedId = "0" + randomGeneratedId;
            }
            return randomGeneratedId;
        }
    }
}
