using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spel_project_ht25
{
    public class Player :  Apple, PlayerInterface
    {
        private KeyboardState KState; 
        private Texture2D snake;
        private Vector2 postitions;
        private int v;
        private Rectangle hitbox;

        public Rectangle Hitbox
        {
            get { return hitbox; }
        }
        public void Update()
        {
            KState = Keyboard.GetState();
            Move();
        }

        public Player(Texture2D snake, Vector2 postitons, int v)
        {
            this.snake = snake;
            this.postitions = postitions;
            hitbox = new Rectangle((int)postitions.X,(int)postitions.Y,v,v);
        }

        public void Size()
        {
            int size = 2;
            if(hitbox == hitboxa)
            {
                size++;
            }
            
        }
        public void Move()
        {
            if (KState.IsKeyDown(Keys.A)&& postitions.X>0)
            {
                postitions.X -= 100;
            }

            if (KState.IsKeyDown(Keys.S)&& position.Y < 430)
            {
                postitions.Y += 100;
            }

            if (KState.IsKeyDown(Keys.W)&& postitions.Y>0)
            {
                postitions.Y -= 100;
            }

            if (KState.IsKeyDown(Keys.D) && postitions.X < 750)
            {
                postitions.X += 100;
            }
            hitbox.X = (int)postitions.X;
    hitbox.Y = (int)postitions.Y;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(snake, hitbox, Color.Blue);
        }

        
    }
}