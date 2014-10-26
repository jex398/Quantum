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
        private List<GameObject> objects;
        public double m_mass { get; set; }
        public double m_x { get; set; }
        public double m_y { get; set; }
        public double m_radius { get; set; }
        public double m_a_x { get; set; }
        public double m_a_y { get; set; }
        public double m_speed_x { get; set; }
        public double m_speed_y { get; set; }
        public abstract void draw(SpriteBatch context);
        public abstract void onShoot(GameObject shooted);
        public void setObjectList(List<GameObject> objects) { this.objects = objects; }
        public void delete() { objects.Remove(this); }
    }
}
