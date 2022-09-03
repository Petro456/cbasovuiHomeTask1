using System;

namespace HomeTask4
{
    class Point
    {
        int fild1, fild2;
        
        string name;
       public int Fild1 { get { return fild1; } }
        public  int Fild2 { get { return fild2; } }
        public string Name { get { return name; } }
        public Point()
            : this(0, 0, "") { }
        public Point (int fild1, int fild2, string fild3)
        {
            //Console.WriteLine("Введіть назву багатокутника:");
            //this.name = Console.ReadLine();
            Console.WriteLine("Початкова точка  відрізку fild1:");
            
            this.fild1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Кінцева точка відрізку fild2:");
            this.fild2 = int.Parse(Console.ReadLine());

        }

    }

    class Figure
    {
        int number;
       Point[] points;
       string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введіть кількість вершин вашої фігури");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть назву багатокутника:");
            this.name = Console.ReadLine();
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide (Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.Fild1 - B.Fild1, 2) + Math.Pow(A.Fild2 - B.Fild2, 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length-1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }

    }

    internal class Program
    {
        /*Задание 4 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
        Создать классы Point и Figure. Класс Point должен содержать два целочисленных поля и одно строковое поле. 
        Создать три свойства с одним методом доступа get. Создать пользовательский конструктор, 
        в теле которого проинициализируйте поля значениями аргументов. Класс Figure должен содержать конструкторы, 
        которые принимают от 3-х до 5-ти аргументов типа Point. Создать два метода: double LengthSide(Point A, Point B),
        который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
        многоугольника. Написать программу, которая выводит на экран название и периметр многоугольника. */



        static void Main(string[] args)
        {

            Figure kub = new Figure("");

            Console.WriteLine("Периметр багатогранника  " + kub.PerimeterCalculator());
            Console.WriteLine(kub.Name);
            Console.ReadKey();  
        }
    }
}
