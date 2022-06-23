using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class Program
    {
        private static String[] colors = new String[]{ "Red", "Green", "Blue", "White", "Black"};
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle =(Circle)ShapeFactory.getCircle(getRandomColor());
                circle.X = getRandomX();
                circle.Y = getRandomY();
                circle.Radius =100;
                circle.draw();
            }
        }

        private static String getRandomColor()
        {
            return colors[new Random().Next() % colors.Length];
        }
        private static int getRandomX()
        {
            return (int)(new Random().Next() * 100);
        }
        private static int getRandomY()
        {
            return (int)(new Random().Next() * 100);
        }
    }
}
