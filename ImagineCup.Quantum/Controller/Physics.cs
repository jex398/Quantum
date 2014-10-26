using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineCup.Quantum.Model
{
    public class Physics
    {
        private List<GameObject> bodies;
        private List<GameObject> quant;
        const double G = 0.00001; // m^3 kg^-1 s^-2
        const double DT = 1000;
        public Physics() {
            bodies = new List<GameObject>();
        }
        
        public Physics(List<GameObject> objects, List<GameObject> quant) {
            bodies = objects;
            this.quant = quant;
        }

        public void addObject(GameObject obj){
            bodies.Add(obj);
        }

        public void calculatePhysics() { 
            foreach (GameObject obj1 in bodies){
                foreach (GameObject obj2 in bodies)
                {
                    if (obj1 == obj2)
                        continue;
                    double R2 = ((obj1.m_x-obj2.m_x)*(obj1.m_x-obj2.m_x) + (obj1.m_y - obj2.m_y)*(obj1.m_y - obj2.m_y));
                    double a_scalar = 1000000;
                    if (R2 > 0.000001)
                        a_scalar = G * obj2.m_mass / R2;
                    int sign_x =  (obj2.m_x - obj1.m_x) > 0 ? 1 : -1;
                    int sign_y =  (obj2.m_y - obj1.m_y) > 0 ? 1 : -1;
                    double dy = (obj1.m_y - obj2.m_y);
                    double dx =(obj1.m_x - obj2.m_x);
                    if (dx < 0.00000000001)
                        dx = 0.00000000001;
                    if (dy < 0.00000000001)
                        dy = 0.00000000001;
                    double alpha =  Math.Atan(dy/dx);

                    obj1.m_a_x += sign_x*a_scalar * Math.Cos(alpha);
                    obj1.m_a_y += sign_y*a_scalar * Math.Sin(alpha);

                    isShooted(obj1, obj2);
                }
                obj1.m_speed_x += obj1.m_a_x;
                obj1.m_speed_y += obj1.m_a_y;
                obj1.m_x += obj1.m_speed_x;
                obj1.m_y += obj1.m_speed_y;
            }
        }

        private void isShooted(GameObject shooter, GameObject obj) {
            double x = shooter.m_x - obj.m_x;
            double y = shooter.m_y - obj.m_y;
            double r = obj.m_radius;
            if (x * x + y * y < r * r)
                obj.onShoot(shooter);
        }
    }
}
