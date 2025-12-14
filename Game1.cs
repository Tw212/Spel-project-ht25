using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spel_project_ht25;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Grid grid;
    private Texture2D rec;
    private Texture2D apple;
    private Player player;
    private Texture2D snake;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        rec = new Texture2D(GraphicsDevice, 1, 1);
        rec.SetData(new[] { Color.Green });
        apple = Content.Load<Texture2D>("pngtree-apple-fruit-cartoon-apple-cartoon-fruit-png-image_330305");
        snake = Content.Load<Texture2D>("reen-block-11563665390uel60ahr8p");
        player = new Player(snake, new Vector2(200, 200), 5);
        grid = new Grid(rec, 10, 10);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        

        // TODO: Add your update logic here
        player.Update();    
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Green);
        _spriteBatch.Begin();
        player.Draw(_spriteBatch);
        grid.Gridspace(_spriteBatch, rec);
        _spriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
