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





        private int numOfCells;
        private int cellSize;
        //private Vector2 position;
        private Color color = Color.LimeGreen;

        public Grid(Texture2D rec, int numOfCells, int cellSize/*,Vector2 position*/)
        {
            this.numOfCells = numOfCells;
            this.cellSize = cellSize;
            //this.position = position;
        }

        public void Gridspace(SpriteBatch spriteBatch, Texture2D rec)
        {
            int gridSize = numOfCells * cellSize;




            for (int x = 0; x <= numOfCells; x++)
            {
                spriteBatch.Draw(
                    rec,
                    new Rectangle(x * cellSize, 0, 1, gridSize),
                    color
                );
            }

            
        
            for (int y = 0; y <= numOfCells; y++)
            {
                spriteBatch.Draw(
                    rec,
                    new Rectangle(0, y * cellSize, gridSize, 1),
                    color
                );
            }
        }
    }
} 
