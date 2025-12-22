using System;
using System.Net;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary;

public class Core : Game
{
    internal static Core s_instance;

    /// <summary>
    /// Gets a reference to the Core instance.
    /// </summary>
    public static Core Instance => s_instance;

    // gets the graphics device used to create graphical resources and perform primitive rendering
    public static GraphicsDeviceManager Graphics { get; private set;}

    public static GraphicsDevice GraphicsDevice {get; private set;}

    // gets the sprite batch used for all 2D rendering
    public static SpriteBatch SpriteBatch {get; private set;}

    // gets the content manager used to load global assets
    public static new ContentManager Content {get; private set;}

    // create a new core instance
    public Core(string title, int width, int height, bool fullscreen)
    {   
        // ensures only one core can be created
        if (s_instance != null)
        {
            throw new InvalidOperationException($"only a single core instance can be created");
        }

        // store reference to engine for global member access
        s_instance = this;

        // create a new graphics device manager
        Graphics = new GraphicsDeviceManager(this);

        Graphics.PreferredBackBufferWidth = width;
        Graphics.PreferredBackBufferHeight = height;
        Graphics.IsFullScreen = fullscreen;

        // apply the graphic presentation changes
        Graphics.ApplyChanges();

        // set window title
        Window.Title = title;

        // set the core's content manager to a reference of the base Game's
        Content = base.Content;

        Content.RootDirectory = "Content";

        // mouse is visible by default
        IsMouseVisible = true;

    }

    protected override void Initialize()
    {
        base.Initialize();

        // set the core's graphic device to a reference of the base game's
        GraphicsDevice = base.GraphicsDevice;
        SpriteBatch = new SpriteBatch(GraphicsDevice);
    }
}
