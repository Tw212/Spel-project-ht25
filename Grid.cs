using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;

namespace Spel_project_ht25
{
    public class Grid: Apple
    {
        private int numOfCells;
        private int cellSize;
        private Vector2 position;
        public GR[,] GRs;
        private Random random = new Random();
        public GR ARuta;

        
        private Color color = Color.LimeGreen;

        public Grid(Texture2D rec, int numOfCells, int cellSize, Vector2 position)
        {
            this.numOfCells = numOfCells;
            this.cellSize = cellSize;
            this.position = position;

            GRs = new GR[numOfCells, numOfCells];
            TGR();
        }

        public void TGR()
        {
            for (int x = 0; x <= numOfCells; x++)
            {
                for (int y = 0; y < numOfCells; y++)
                {
                    Rectangle rect = new Rectangle((int)position.X + x * cellSize,
                    (int)position.Y + y * cellSize,
                    cellSize,
                    cellSize
                    );

                    GRs[x, y] = new GR(rect);
                }


            }
        }
        public GR RadomGridsq(Random random)
        {
            List<GR> FriaGR = new List<GR>();

            for (int y = 0; y < numOfCells; y++)
            {
                for (int x = 0; x < numOfCells; x++)
                {
                    if (!GRs[x, y].Hsnake && !GRs[x, y].Happle)
                    {
                        FriaGR.Add(GRs[x, y]);
                    }
                }
            }
            if (FriaGR.Count == 0)
            {
                return null;
            }

            return FriaGR[random.Next(FriaGR.Count)];
        }
        public void SpawnApple()
        {
            if (ARuta != null)
            {
                ARuta.Happle = false;
            }
            ARuta = grid.GetRandomFriaGR(random);

            if(ARuta != null)
            {
                ARuta.Happle = true;
            }
        }

        public void Gridspace(SpriteBatch spriteBatch, Texture2D rec)
        {
            int gridSize = numOfCells * cellSize;




            for (int x = 0; x < numOfCells; x++)
            {
                for (int y = 0; y < numOfCells; y++)
                {
                    spriteBatch.Draw(
                    rec,
                    GRs[x, y].Bounds,
                    color
                    );

                }
                
            }

            
        
            
        }
    }
} 
