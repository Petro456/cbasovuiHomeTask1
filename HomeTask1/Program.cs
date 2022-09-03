using System;

namespace HomeTask1
{
    /* Задание 2 

        Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: Создать класс с именем Rectangle.
    В теле класса создать два поля, описывающие длины сторон double side1, side2. Создать пользовательский конструктор 
    Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
    Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - 
    double PerimeterCalculator(). Создать два свойства double Area и double Perimeter с одним методом доступа get. 
    Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр
    и площадь.*/
    
    class Rectangle
    
    {
        double side1, side2;
       
        double S, P;
      
        public Rectangle()
        {
           
        }
        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            

            double AreaCalculator()
            {

                S = side1 * side2;
                return S;
            }

            double PerimeterCalculator()
            {
                P = (side1 + side2) * 2;
                return P;
            }

            Console.WriteLine("Площа прямокутника становить   "+ AreaCalculator());

            Console.WriteLine("Периметр прямокутника становить   " + PerimeterCalculator());
  
        }

        public double Area
        {
            get { return S; }
        }
        public double Perimeter
        {
            get { return P; }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            var rozrachunok = new Rectangle(11.5, 10.5);

            
            Console.ReadKey();

        }
    }
}
