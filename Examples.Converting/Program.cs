using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            float floatNum = num;

            floatNum += 0.15f;

            Console.WriteLine(floatNum);

            string lucho = "15";

            int luchoNum;
            
            if (int.TryParse(lucho, out luchoNum))
            {
                Console.WriteLine("lucho " + luchoNum);
            }
            else
            {
                Console.WriteLine("Not a number!");
            }

            object obj = new ExampleClass { Name = "lucho" };

            var exampleObj = obj as ExampleClass;

            if (exampleObj != null)
            {
                Console.WriteLine("Conversion succesfull!");
            }
            else
            {
                Console.WriteLine("No conversion!");
            }

            if (obj.GetType().Name == typeof(ExampleClass).Name)
            {
                Console.WriteLine("It is example!!!");
            }
            else
            {
                Console.WriteLine("No example!");
            }
        }
    }
}
