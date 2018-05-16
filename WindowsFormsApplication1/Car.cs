using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Car
    {
        
        public Rectangle rectangle;
        public Color color;
        public String direction;
        public int speed = 3;
        public int angle = 0;
        public int begin;
        public int directionX = 0;
        public int directionY = 0;
        public int positionY = -100;
        public int positionX = -100;
        public int distanceX = 0;
        public int distanceY = 0;
        public Boolean startMove = false;
        public int[] startPositionX = { 210, 800, 360, -30 };
        public int[] startPositionY = { -30, 210, 600, 360 };
        public int[] startLeftPositionX = { 260, 800, 310, -30 };
        public int[] startLeftPositionY = { -30, 260, 600, 310 };
        public Rectangle bigRectangle = new Rectangle(200, 200, 200, 200);
        public Semaphore stopped = new Semaphore(0, 1);
        public Boolean stop;
        public static Random random = new Random();
        public Color[] colors = { Color.Tomato, Color.RoyalBlue, Color.SaddleBrown, Color.SeaGreen, Color.Silver, Color.Violet };

        public Car(int begin, String direction)
        {
            this.direction = direction;
            this.begin = begin;
            color = colors[random.Next(colors.Length)];

            if (direction == "left")
            {
                rectangle = new Rectangle(startLeftPositionX[begin], startLeftPositionY[begin], 30, 30);

            }
            else
            {
                rectangle = new Rectangle(startPositionX[begin], startPositionY[begin], 30, 30);

            }
            if (begin % 4 == 0)
            {
                directionY = 1;
            }
            else if (begin % 4 == 1)
            {
                directionX = -1;
            }
            else if (begin % 4 == 2)
            {
                directionY = -1;
            }
            else if (begin % 4 == 3)
            {
                directionX = 1;
            }

        }

        public void MoveTo(int position)
        {
            stop = false;
            switch (begin)
            {
                case 0:
                    positionY = (-position - 1) * rectangle.Height + bigRectangle.Y;
                    break;

                case 1:
                    positionX = (position) * rectangle.Width + bigRectangle.X + bigRectangle.Width;
                    break;

                case 2:
                    positionY = (position) * rectangle.Height + bigRectangle.Y + bigRectangle.Height;
                    break;

                case 3:
                    positionX = (-position - 1) * rectangle.Width + bigRectangle.X;
                    break;
            }
            /*
            while(rectangle.X != (-position-1)*rectangle.Width + bigRectangle.X ||
                rectangle.X != (position) * rectangle.Width + bigRectangle.X +bigRectangle.Width ||
                rectangle.Y != (-position-1) * rectangle.Height + bigRectangle.Y ||
                rectangle.Y != (position) * rectangle.Height + bigRectangle.Y + bigRectangle.Height)
            {

            }
            */
            //while (rectangle.Y > (position) * rectangle.Height + bigRectangle.Y + bigRectangle.Height) ;
            //stopMove();
        }

        public void stopMove()
        {

        }

        public void changeDirection()
        {
            switch (begin)
            {
                case 0:
                    switch (direction)
                    {
                        case "left":
                            directionY = 0;
                            directionX = 1;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;

                        case "right":
                            directionY = 0;
                            directionX = -1;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                    }
                    break;

                case 1:
                    switch (direction)
                    {
                        case "left":
                            directionY = 1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                            
                        case "right":
                            directionY = -1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                    }
                    break;

                case 2:
                    switch (direction)
                    {
                        case "left":
                            directionY = 0;
                            directionX = -1;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                            

                        case "right":
                            directionY = 0;
                            directionX = 1;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                    }
                    break;

                case 3:
                    switch (direction)
                    {
                        case "left":
                            directionY = -1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;

                        case "straight":
                            break;

                        case "right":
                            directionY = 1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            angle = 0;
                            break;
                    }
                    break;
            }

        }
        public void StartMove()
        {
            switch (begin)
            {
                case 0:
                    switch (direction)
                    {
                        case "left":
                            directionY = 1;
                            directionX = 1;
                            positionY = 0;
                            positionX = 400;
                            angle = 45;
                            break;

                        case "straight":
                            directionY = 1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            break;

                        case "right":
                            directionY = 1;
                            directionX = -1;
                            positionY = 0;
                            positionX = 170;
                            angle = 45;
                            break;
                    }
                    break;

                case 1:
                    switch (direction)
                    {
                        case "left":
                            directionY = 1;
                            directionX = -1;
                            positionY = 400;
                            positionX = 0;
                            angle = 45;
                            break;

                        case "straight":
                            directionY = 0;
                            directionX = -1;
                            positionY = 0;
                            positionX = 0;
                            break;

                        case "right":
                            directionY = -1;
                            directionX = -1;
                            positionY = 170;
                            positionX = 0;
                            angle = 45;
                            break;
                    }
                    break;

                case 2:
                    switch (direction)
                    {
                        case "left":
                            directionY = -1;
                            directionX = -1;
                            positionY = 0;
                            positionX = 170;
                            angle = 45;
                            break;

                        case "straight":
                            directionY = -1;
                            directionX = 0;
                            positionY = 0;
                            positionX = 0;
                            break;

                        case "right":
                            directionY = -1;
                            directionX = 1;
                            positionY = 0;
                            positionX = 400;
                            angle = 45;
                            break;
                    }
                    break;

                case 3:
                    switch (direction)
                    {
                        case "left":
                            directionY = -1;
                            directionX = 1;
                            positionY = 170;
                            positionX = 0;
                            angle = 45;
                            break;

                        case "straight":
                            directionY = 0;
                            directionX = 1;
                            positionY = 0;
                            positionX = 0;
                            break;

                        case "right":
                            directionY = 1;
                            directionX = 1;
                            positionY = 400;
                            positionX = 0;
                            angle = 45;
                            break;
                    }
                    break;
            }

        }
    }
}
