using System;

namespace HomeTask6
{
    /*Задание 6

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс с именем Address.
    В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого поля, создать свойство с
    двумя методами доступа. Создать экземпляр класса Address. В поля экземпляра записать информацию о почтовом адресе. 
    Выведите на экран значения полей, описывающих адрес.*/

    class Address
    {
       int index, house, apartment;
       string country, city, state;
        
        public int Index { get { return index; } set { index = value; } }   
        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public int House { get { return house; } set { house = value; } }
        public int Apartment { get { return apartment; } set { apartment = value; } }

        public Address ()
        {
            index = 7896;
  
        }
        public void Show()
        {
            Console.WriteLine($"Країна: {country}  Мiсто: {city} Поштовий iндекс: {index} ");
            Console.WriteLine($"Вулиця: {state}  Будинок: {house} Квартира: {apartment} ");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Show();

            Console.ReadKey();
        }
    }
}
