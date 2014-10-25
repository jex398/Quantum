using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineCup.Quantum
{
    public abstract class GameObject
    {
        public double m_mass { get; set; }
        public double m_x { get; set; }
        public double m_y { get; set; }
        public double m_a { get; set; }
        public double m_speed { get; set; }

        public abstract void draw(SpriteBatch context);
    }
}
