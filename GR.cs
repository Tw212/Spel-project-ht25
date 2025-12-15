using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Spel_project_ht25
{
    public class GR
    {
        public Rectangle Bounds;
        public bool Happle;
        public bool Hsnake;

        public GR(Rectangle bounds)
        {
            bounds = Bounds;
            Happle = false;
            Hsnake = false;
        }
    }
}