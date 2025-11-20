using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spel_project_ht25
{
    public class Grid
    {
        int numOfCells = 20;
        int cellSize = 10;
        public void Gridspace(SpriteBatch g, Texture2D p)
        {
            for (int x = 0; x < numOfCells; ++x)
            {
                for (int y = 0; y < numOfCells; ++y)
                {
                    Rectangle rec = new(x*cellSize, y*cellSize, cellSize, cellSize);
                    g.Draw(p, rec, Color.Green);
                }
                
            }
        }
        
    }
}