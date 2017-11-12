using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using AirTrafficController.forms;
using System.Collections.Generic;
using C3.XNA;
using AirTrafficController.util;
using System.IO;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Reflection;

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

        private stats stats;

        public GameTime gameTime;
        private double lastSecond;

        private int maxAirplanes = 500;

        private FrameCounter frameCounter;
        private notificationsManager notificationsManager;
        private Vector2 mapSize;

        //DEBUG
        public bool clickAsRandomAirplaneGenerator = false;

        //ICONS
        // http://www.iconsplace.com/white-icons/
        public Dictionary<string, Texture2D> icons;
        public float iconScale;

        public List<iAirplanePreset> airplanePresets;

        public Texture2D lineTexture;
        public SpriteFont defaultFont;
        private map map;
        private bool gameRunning = true;

        //Min/Max of values
        public static int[] minMaxAcceleration = {0, 20};
        public static int[] minMaxMAXSpeed = {1, 1200};//Max speed
        public static int[] minMaxAltitude = {1, 9000};
        public static int[] minMaxCapacity = {20, 500};
        public static int[] minMaxVerticalAcceleration = {-20, 20};
        //
        private iAirplane closestAirplaneToMouse;

        public Game1()
        {
            this.graphics = new GraphicsDeviceManager(this);
            //this.graphics.PreferredBackBufferWidth = 600;
            //this.graphics.PreferredBackBufferHeight = 600;
            this.graphics.PreferredBackBufferWidth = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * 0.75f);
            this.graphics.PreferredBackBufferHeight = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * 0.75f);
            this.Window.Position = new Point(0, 0);
            this.Content.RootDirectory = "Content";
            this.mapSize = new Vector2(25000, 25000);
            this.iconScale = 1000/mapSize.X; 
            this.lastSecond = 0;
            this.icons = new Dictionary<string, Texture2D>();
        }
        protected override void Initialize()
        {
            base.Initialize();
            this.IsMouseVisible = true;

        }
        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

            this.stats = new stats();

            this.map = new map(this, Vector2.Zero, mapSize);
            this.map.setStats(this.stats);

            this.defaultFont = Content.Load<SpriteFont>("defaultFont");

            this.icons.Add("AirbusA380", Content.Load<Texture2D>("AirbusA380"));
            this.icons.Add("Boeing737", Content.Load<Texture2D>("Boeing737"));

            this.frameCounter = new FrameCounter();

            this.notificationsManager = new notificationsManager(this);

            this.lineTexture = new Texture2D(GraphicsDevice, 1, 1);
            this.lineTexture.SetData(new Color[] { Color.White });

            this.airplanePresets = getAirplanePresets();

        }

        private List<iAirplanePreset> getAirplanePresets()
        {
            //Create a new list
            List<iAirplanePreset> airplanePresets = new List<iAirplanePreset>();

            //Load schema
            
            //string jsonSchema = File.ReadAllText("airplanePresets/AirplanePresetSchema.json");
            string jsonSchema = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AirplanePresetSchema.json"));
            JSchema schema = JSchema.Parse(jsonSchema);

            string[] jsonFiles = Directory.GetFiles("airplanePresets", "*.json");
            //Get filespath in directory
            foreach(string jsonFilePath in jsonFiles)
            {
                if (File.Exists(jsonFilePath))
                {
                    //If the file exists, try to parse it
                    //First read it
                    string jsonFileContent = File.ReadAllText(jsonFilePath);
                    JObject jsonObject = JObject.Parse(jsonFileContent);
                    if (jsonObject.IsValid(schema))
                    {
                        iAirplanePreset airplanePreset = new airplanePreset();
                        airplanePreset.Initialize(
                            jsonObject.GetValue("vendor").ToString(),
                            jsonObject.GetValue("model").ToString(),
                            (int)jsonObject.GetValue("capacity"),
                            (int)jsonObject.GetValue("maxSpeed")
                            );
                        airplanePresets.Add(airplanePreset);
                    }
                }
            }
            return airplanePresets;
        }

        protected override void OnExiting(object sender, EventArgs args)
        {
            this.menu.Close();
            this.menu.Dispose();
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
                if (this.gameRunning)
                {
                    updateByOneSecond();
                }
            }
            this.lastSecond = gameTime.TotalGameTime.Seconds;

            //UPDATE KEYBOARD & MOUSE STATES
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();

            //FRAMECOUNTER
            frameCounter.Update(float.Parse(gameTime.ElapsedGameTime.TotalSeconds.ToString()));

            //Click on an airplane
           
            
            if (!this.clickAsRandomAirplaneGenerator)
            {
                
            }
            else
            {
                if (previousMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
                {
                    iAirplane airplane;
                    Vector2 localPos = new Vector2(
                        utilDraw.convertRange(0, this.map.getGame().GraphicsDevice.Viewport.Width, 0, (int)this.map.getSize().X, (int)(currentMouseState.Position.X)),
                        utilDraw.convertRange(0, this.map.getGame().GraphicsDevice.Viewport.Height, 0, (int)this.map.getSize().Y, (int)(currentMouseState.Position.Y))
                    );
                    if (currentKeyboardState.IsKeyDown(Keys.W))
                    {
                        airplane = this.generateRandomAirplane(localPos, utilVector2.getDirectionFromString("Up"));
                    }
                    else if (currentKeyboardState.IsKeyDown(Keys.A))
                    {
                        airplane = this.generateRandomAirplane(localPos, utilVector2.getDirectionFromString("Left"));
                    }
                    else if (currentKeyboardState.IsKeyDown(Keys.S))
                    {
                        airplane = this.generateRandomAirplane(localPos, utilVector2.getDirectionFromString("Down"));
                    }
                    else if (currentKeyboardState.IsKeyDown(Keys.D))
                    {
                        airplane = this.generateRandomAirplane(localPos, utilVector2.getDirectionFromString("Right"));
                    }
                    else
                    {
                        airplane = this.generateRandomAirplane(localPos);
                    }

                    this.addAirplaneToMap(airplane);
                }
            }
            //Click on the map
            if (previousMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
            {
                if(closestAirplaneToMouse != null)
                {
                    closestAirplaneToMouse.switchDrawInfo();
                }
            }
        }

        private iAirplane getClosestAirplaneToMouse()
        {
            List<iAirplane> airplanes = this.map.getAirplanes();
            if(airplanes.Count == 0) { return null; }
            iAirplane closestAirplane = airplanes[0];
            foreach (iAirplane airplane in airplanes)
            {
                if (Vector2.Distance(currentMouseState.Position.ToVector2(), airplane.getDrawPos()) < Vector2.Distance(currentMouseState.Position.ToVector2(), closestAirplane.getDrawPos()))
                {
                    closestAirplane = airplane;
                }
            }
            if (Vector2.Distance(currentMouseState.Position.ToVector2(), closestAirplane.getDrawPos()) > 50) {
                return null;
            }
            return closestAirplane;
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
            this.closestAirplaneToMouse = this.getClosestAirplaneToMouse();
            if (closestAirplaneToMouse != null && Vector2.Distance(currentMouseState.Position.ToVector2(), closestAirplaneToMouse.getDrawPos()) < 50)
            {
                closestAirplaneToMouse.hover(true);
                Primitives2D.DrawLine(spriteBatch, currentMouseState.Position.ToVector2(), closestAirplaneToMouse.getDrawPos(), Color.Black);
            }
            else
            {

            }
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
        public void addNotification(string message, int notificationTime)
        {
            notificationsManager.addNotification(message, notificationTime);
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
                notificationsManager.addNotification($"Adding airplane {airplane.getId()} to the map. {airplane.getPos().ToString()}");
                this.map.addAirplane(airplane);
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
        public iAirplane generateRandomAirplane(Vector2 pos)
        {
            return generateRandomAirplane(pos, utilVector2.getRandomDirection());
        }
        public iAirplane generateRandomAirplane(Vector2 pos, Vector2 direction)
        {
            airplane airplane = new airplane(map);
            Random random = new Random();
            airplane.Initialize(
                this.generateRandomId(),
                "xd",
                "xd",
                pos,
                direction,
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );
            return airplane;
        }
        public iAirplane generateRandomAirplane()
        {
            Random random = new Random();
            return generateRandomAirplane(new Vector2(random.Next(1, (int)this.map.getSize().X), random.Next(1, (int)this.map.getSize().Y)));
        }
        private bool playerIsPressingWASD()
        {
            return currentKeyboardState.IsKeyDown(Keys.W) || currentKeyboardState.IsKeyDown(Keys.A) || currentKeyboardState.IsKeyDown(Keys.S) || currentKeyboardState.IsKeyDown(Keys.D);
        }
        public void switchGameRunning()
        {
            this.gameRunning = !this.gameRunning;
        }
        public void setGameRunning(bool status)
        {
            this.gameRunning = status;
        }
        public bool getGameRunning()
        {
            return this.gameRunning;
        }
    }
}
