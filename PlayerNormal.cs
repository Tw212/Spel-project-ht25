using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Spel_project_ht25
{
    public class PlayerNormal :  Apple, PlayerInterface
    {
        private KeyboardState KState;

        public void Size()
        {
            int size = 2;
            if (mat = true)
            {
                size++;
            }
        }
        public void move()
        {
            if (KState.IsKeyDown(Keys.A))
            {
                position.X -= 10;
            }

            if (KState.IsKeyDown(Keys.S))
            {
                position.Y -= 10;
            }

            if (KState.IsKeyDown(Keys.W))
            {
                position.Y += 10;
            }

            if (KState.IsKeyDown(Keys.D))
            {
                position.X += 10;
            }
        }

        
    }
}