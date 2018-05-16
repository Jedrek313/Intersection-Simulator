

using System.Drawing;

namespace WindowsFormsApplication1
{
    public class TrafficLight
    {
        public Rectangle rectangle;
        public Color color;

        public TrafficLight(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            color = Color.Red;
        }
    }
}
