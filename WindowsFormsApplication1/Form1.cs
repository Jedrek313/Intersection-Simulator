using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static int up = 0;
        public static int right = 0;
        public static int down = 0;
        public static int left = 0;
        public static int upLeft = 0;
        public static int rightLeft = 0;
        public static int downLeft = 0;
        public static int leftLeft = 0;



        public Semaphore[] startSemaphores = new Semaphore[8];
        public Semaphore[] queueSemaphores = new Semaphore[8];
        public Semaphore[] lightSemaphores = new Semaphore[8];
        public Semaphore drawing = new Semaphore(1, 1);
        public Boolean[] lights = new Boolean[8];
        int lightNumber = 0;
        int[] lightCorrectNumber = { 0, 2, 1, 3 };
        Boolean yellowLight = true;
        Rectangle tram;
        Boolean isTram = false;
        int tramDirection = 0;

        public List<Car>[] lists = new List<Car>[8];
        public List<Car> cars = new List<Car>();
        public TrafficLight[] trafficLights = new TrafficLight[8];
        public Point[] points;
        public Size carSize = new Size(30,30);
        public int Speed = 60;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000 / Speed;
            timer.Start();

            trafficLights[0] = (new TrafficLight(new Rectangle(215, 205, 20, 20)));
            trafficLights[1] = (new TrafficLight(new Rectangle(375, 215, 20, 20)));
            trafficLights[2] = (new TrafficLight(new Rectangle(365, 375, 20, 20)));
            trafficLights[3] = (new TrafficLight(new Rectangle(205, 365, 20, 20)));
            trafficLights[4] = (new TrafficLight(new Rectangle(265, 205, 20, 20)));
            trafficLights[5] = (new TrafficLight(new Rectangle(375, 265, 20, 20)));
            trafficLights[6] = (new TrafficLight(new Rectangle(315, 375, 20, 20)));
            trafficLights[7] = (new TrafficLight(new Rectangle(205, 315, 20, 20)));
            
            for (int i = 0; i<8; i++)
            {
                lights[i] = false;
                startSemaphores[i] = new Semaphore(1, 1);
                queueSemaphores[i] = new Semaphore(0, 10);
                lightSemaphores[i] = new Semaphore(0, 1);
                lists[i] = new List<Car>();
            }
            Thread thread = new Thread(Lights);
            thread.Start();
        }
        
        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawing.WaitOne();
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            for(int i = 0; i< 8; i++)
            {

                SolidBrush brush = new SolidBrush(trafficLights[i].color);
                g.FillEllipse(brush, trafficLights[i].rectangle);
                
                
            }

            foreach (Car car in cars)
            {
                SolidBrush brush = new SolidBrush(car.color);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(car.angle, new PointF(car.rectangle.X + car.rectangle.Width/2, car.rectangle.Y + car.rectangle.Height/2));
                    g.Transform = m;
                    g.FillRectangle(brush, car.rectangle);
                    g.ResetTransform();
                }
            }

            if(tram!= null && isTram)
            {
                SolidBrush brush = new SolidBrush(Color.DarkGray);
                tram.Y += tramDirection;
                g.FillRectangle(brush, tram);
                if (tram.Y ==-70 || tram.Y == 610)
                {
                    isTram = false;
                }
            }

            drawing.Release();
        }

        public void Lights()
        {
            int j = 1;
            int previousLightNumber;
            while (true)
            {
                yellowLight = true;
                j++;
                if (j == 4)
                {
                    j = 0;
                }
                previousLightNumber = lightNumber;
                lightNumber = lightCorrectNumber[j];

                if (lightNumber < 2)
                {
                    trafficLights[lightNumber].color = Color.Yellow;
                    trafficLights[lightNumber + 2].color = Color.Yellow;
                }
                else
                {
                    trafficLights[lightNumber + 2].color = Color.Yellow;
                    trafficLights[lightNumber + 4].color = Color.Yellow;
                }
                Thread.Sleep(3000);
                if (previousLightNumber < 2)
                {
                    trafficLights[previousLightNumber].color = Color.Red;
                    trafficLights[previousLightNumber + 2].color = Color.Red;
                }
                else
                {
                    trafficLights[previousLightNumber + 2].color = Color.Red;
                    trafficLights[previousLightNumber + 4].color = Color.Red;
                }
                if (lightNumber < 2)
                {
                    trafficLights[lightNumber].color = Color.Green;
                    trafficLights[lightNumber + 2].color = Color.Green;
                }
                else
                {
                    trafficLights[lightNumber + 2].color = Color.Green;
                    trafficLights[lightNumber + 4].color = Color.Green;
                }
                yellowLight = false;
                Thread.Sleep(4000);
                if (lightNumber < 2)
                {
                    trafficLights[lightNumber].color = Color.Yellow;
                    trafficLights[lightNumber + 2].color = Color.Yellow;
                }
                else
                {
                    trafficLights[lightNumber + 2].color = Color.Yellow;
                    trafficLights[lightNumber + 4].color = Color.Yellow;
                }
            }
        }

        public void CarRoute(object tempCar)
        {
            Car car = (Car)tempCar;
            Semaphore startSemaphore;
            Semaphore queueSemaphore;
            Semaphore lightSemaphore;
            List<Car> list;
            int number;
            //Queue<Car> queue;
            if (car.direction == "left")
            {
                number = 4 + car.begin;
                startSemaphore = startSemaphores[car.begin + 4];
                queueSemaphore = queueSemaphores[car.begin + 4];
                lightSemaphore = lightSemaphores[car.begin + 4];
                list = lists[car.begin + 4];
            }
            else
            {
                number = car.begin;
                startSemaphore = startSemaphores[car.begin];
                queueSemaphore = queueSemaphores[car.begin];
                lightSemaphore = lightSemaphores[car.begin];
                list = lists[car.begin];
            }

            startSemaphore.WaitOne();
            list.Add(car);
            cars.Add(car);


            if (car.begin == 1) //tram sitution
            {

            }
            else
            {

            }

            car.MoveTo(list.IndexOf(car));
            while (Math.Abs(car.distanceX) < 35 && Math.Abs(car.distanceY) < 35);
            startSemaphore.Release();
            while (list.IndexOf(car) != 0) // jesli nie jest pierwszy w kolejce wykonuje petle
            {
                queueSemaphore.WaitOne();
                car.MoveTo(list.IndexOf(car)); //porusza sie na wyzsze miejsce w kolejce
            }
            car.stop = true;
            car.stopped.WaitOne();
            lights[number] = true ;
            lightSemaphore.WaitOne(); //czeka az zwolni sie dystrybutor
            car.StartMove();
            list.Remove(car);//usuwam z listy

            if (list.Count > 0)
            {
                queueSemaphore.Release(list.Count); //zwalniam wszystkie semafory
            }
            //counts[number]--;
            //up--;
            car.stop = true;
            car.stopped.WaitOne();
            car.changeDirection();
            car.stop = true;
            car.stopped.WaitOne();
            //jade w sina dal xd

            //Thread.Sleep(10000);
            list.Remove(car);
            cars.Remove(car);
            Thread.CurrentThread.Abort();
        }
        

         public void stopThread(Thread thread, Car car)
        {

        }
        public Rectangle SetCar(int begin, int end)
        {
            //semaphores[begin].WaitOne();
            return new Rectangle(points[begin], carSize);
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Car car in cars)
            {
                if(car.rectangle.X != car.positionX && car.rectangle.Y != car.positionY)
                {
                    car.rectangle.Y = car.rectangle.Y + car.directionY;
                    car.distanceY = car.distanceY + car.directionY;
                    car.rectangle.X = car.rectangle.X + car.directionX;
                    car.distanceX = car.distanceX + car.directionX;
                }
                else
                {
                    if (car.stop)
                    {
                        car.stopped.Release();
                        car.stop = false;
                    }
                }
            }

            foreach (TrafficLight trafficLight in trafficLights)
            {

            }
            
            if (!yellowLight)
            {
                if (lightNumber < 2)
                {
                    if(lights[lightNumber])
                    {
                        lightSemaphores[lightNumber].Release();
                        lights[lightNumber] = false;
                    }
                    if (lights[lightNumber + 2])
                    {
                        lightSemaphores[lightNumber + 2].Release();
                        lights[lightNumber+2] = false;
                    }
                }
                else
                {
                    if (lights[lightNumber + 2])
                    {
                        lightSemaphores[lightNumber + 2].Release();
                        lights[lightNumber+2] = false;
                    }
                    if (lights[lightNumber + 4])
                    {
                        lightSemaphores[lightNumber + 4].Release();
                        lights[lightNumber+4] = false;
                    }
                }
            }
            
            pictureBox1.Invalidate();


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void right_DOWN_Click(object sender, EventArgs e)
        {
            if (down < 6)
            {
                down++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(2, "right"));
            }
        }

        private void straight_down_Click(object sender, EventArgs e)
        {
            if (down < 6)
            {
                down++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(2, "straight"));
            }
        }
        private void left_down_Click(object sender, EventArgs e)
        {
            if (downLeft < 6)
            {
                downLeft++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(2, "left"));
            }
        }
        //
        private void right_UP_Click(object sender, EventArgs e)
        {
            if (up < 6)
            {
                up++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(0, "right"));
            }

        }

        private void straight_UP_Click(object sender, EventArgs e)
        {
            if (up < 6)
            {
                up++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                Thread thread2 = new Thread(CarRoute);
                thread.Start(new Car(0, "straight"));
            }

        }

        private void left_UP_Click(object sender, EventArgs e)
        {
            if (upLeft < 6)
            {
                upLeft++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(0, "left"));
            }

        }

        private void left_LEFT_Click(object sender, EventArgs e)
        {
            if (leftLeft < 6)
            {
                leftLeft++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(3, "left"));
            }

        }

        private void straight_LEFT_Click(object sender, EventArgs e)
        {
            if (left < 6)
            {
                left++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(3, "straight"));
            }

        }

        private void right_LEFT_Click(object sender, EventArgs e)
        {
            if (left < 6)
            {
                left++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(3, "right"));
            }

        }

        private void right_RIGHT_Click(object sender, EventArgs e)
        {
            if (right < 6)
            {
                right++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(1, "right"));
            }

        }

        private void straight_RIGHT_Click(object sender, EventArgs e)
        {
            if (right < 6)
            {
                right++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(1, "straight"));
            }

        }

        private void left_RIGHT_Click(object sender, EventArgs e)
        {
            if (rightLeft < 6)
            {
                rightLeft++;
                Thread thread = new Thread(new ParameterizedThreadStart(CarRoute));
                thread.Start(new Car(1, "left"));
            }

        }

        private void tram_UP_Click(object sender, EventArgs e)
        {
            if (!isTram)
            {
                tram = new Rectangle(600,-60,29,60);
                tramDirection = 1;
                isTram = true;
            }

        }

        private void tram_DOWN_Click(object sender, EventArgs e)
        {
            if (!isTram)
            {
                tram = new Rectangle(600, 600, 29, 60);
                tramDirection = -1;
                isTram = true;
            }
        }
    }
}
