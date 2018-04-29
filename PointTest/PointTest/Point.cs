using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Point
    {

        /// Абсцисса точки "X"
        public double x;

        /// Свойство для чтения и записи абциссы точки
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        /// Ордината точки "Y"
        public double y;

        /// Свойство для чтения и записи ординаты точки
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// Значание скаляра 
        private double r;

        /// Свойство для чтения и записи значения скаляра
        public double R
        {
            get { return r; }
            set { r = value; }
        }


        /// Свойство, умножающее координаты точки на скаляр 
        public double Scalar
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }


        /// Конструктор, создающий точку с заданными координатами и значение скаляра
        public Point(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        /// Конструктор, создающий точку с нулевыми координатами
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }


        /// Метод выведения координаты точки на экран
        public void Print()
        {
            Console.WriteLine("Координата точки = ({0};{1})", x, y);
        }

        /// Метод выведения на экран расстояния от начала координат до точки
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /// Метод перемещения точки на вектор (а,b)
        public void Move(double a, double b)
        {
            x += a;
            y += b;
        }

        /// Индексатор,позволяющий по индексу 0 обращаться к полю x, по индексу 1 - к полю y.
        public double this[int index]
        {
            get
            {
                if (index == 0) return x;
                if (index == 1) return y;
                else
                {
                    throw new Exception();
                }
            }
            set
            {
                if (index == 0) x = value;
                if (index == 1) y = value;

            }
        }

        /// Одновременно увеличивает значение полей x и y
        public static Point operator ++(Point ob)
        {
            ob.x = ob.x + 1;
            ob.y = ob.y + 1;
            return ob;
        }

        /// Одновременно уменьшает значение полей x и y
        public static Point operator --(Point ob)
        {
            try
            {
                ob.x = ob.x - 1;
                ob.y = ob.y - 1;
                if (ob.y < 0 | ob.x < 0) throw new System.ArithmeticException();
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Уменьшение не возможно !");
                ob.x = ob.x + 1;
                ob.y = ob.y + 1;
            }
            return ob;

        }



        /// Возращает значение true, если поле x = y, иначе false
        public static bool operator ==(Point x, Point y)
        {
            return (x.X == y.X) && (x.Y == y.Y);
        }


        /// Возращает значение true, если поле x != y, иначе false
        public static bool operator !=(Point x, Point y)
        {
            return (x.X != y.X) || (x.Y != y.Y);
        }

        /// Добавляет к значению поля x и y значение скаляра n
        public static Point operator +(Point ob, double n)
        {
            ob.x = ob.x + n;
            ob.y = ob.y + n;
            return ob;
        }

    }