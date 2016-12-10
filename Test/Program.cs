using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Category
    {
        //private string name;
        public Category(string name)
        {
            if (QuerySQL.Query(name) == null)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Email.Dispatch(name);
            }
        }

    }
    class QuerySQL
    {
        public static string Query(string name)
        {
            return "результат запроса";
        }
    }
    class Email
    {
        public static void Dispatch(string name)
        {
            Console.WriteLine("Создана категория " + name); //отправка email
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category("Тест");

        }
    }
}
