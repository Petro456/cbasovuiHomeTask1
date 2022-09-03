using System;

namespace HomeTask3
{
         public class Book 
         {
        

         }
            public class Title
            {
                public string name;
                public Title(string name)
                {
                    this.name = name;
                }
                public void Show()
                {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Назва книги: {name}");
                }
            }
            public class Author
            {
                public string author;
                public Author(string author)
                {
                    this.author = author;
                }
                public void Show()
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Автор книги: {author}");
                }
            }
            public class Content
            {
                public string сontent;
                public Content(string сontent)
                {
                    this.сontent = сontent;
                }
                public void Show()
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Опис книги: {сontent}");
                }
            }


    internal class Program
    {

        /*Задание 3 

            Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
        Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле
        и метод void Show(). Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
        Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. */

       
        static void Main(string[] args)
        {
            // Book biblioteka = new Book ("Пушкин.А.С", "Капитанская дочка", "Вильямс");

            Title biblioteka = new Title ("Вiдьмак");
            Author author = new Author("Анджей Сапковський");
            Content content = new Content("Вiд Яруги до Драконячих гiр мандрує один з останнiх вiдьмакiв — Геральт iз Рiвiї. " +
                "Вiн зустрiчає людей та iстот, якi чимось дуже нагадують персонажiв вiдомих казок, i намагається зрозумiти, " +
                "чи залишилося в ньому самому хоч щось вiд людини Його пригоди тiльки починаються…");


            
            biblioteka.Show();
            author.Show();
            content.Show();
            Console.ReadKey();
        }
    }
}
