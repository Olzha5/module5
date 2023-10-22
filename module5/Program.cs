using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{ 
    public class ExampleClass
    {
        public void GenerateException()
        {
            throw new InvalidOperationException("Ошибка в методе GenerateException!");
        }

        public void ExecuteMethod()
        {
            try
            {
                GenerateException();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Перехвачено исключение: {e.Message}");
                // Здесь можно добавить дополнительную логику обработки исключения
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ExampleClass example = new ExampleClass();
            example.ExecuteMethod(); // Здесь будет перехвачено исключение и выведено сообщение об ошибке
        }
    }

}
