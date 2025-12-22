using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace my_first_game;

public class Game1 : Core
{   
    // // this is to connect to the graphics hardware GPU etc
    // private GraphicsDeviceManager _graphics;
    
    // // this is to render multiple sprites together if needed
    // private SpriteBatch _spriteBatch;

    // public Game1(): Game()
    public Game1(): base("Dungeon Slime", 2560, 1440, false)
    {
        // _graphics = new GraphicsDeviceManager(this);
        // Content.RootDirectory = "Content";
        // IsMouseVisible = true;
    }

    // This initializes the logic?
    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    // This loads the initial scene
    protected override void LoadContent()
    {
        // _spriteBatch = new SpriteBatch(GraphicsDevice);
        base.LoadContent();
        // TODO: use this.Content to load your game content here
    }

    // This updates the scene
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    // This updates the scene
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        // GraphicsDevice.Clear(Color.MonoGameOrange);//
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
