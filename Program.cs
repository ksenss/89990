using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89990
{
    internal class Program
    {
        static void Main(string[] args)
        {



         

            //Console.WriteLine("enter symbols");

            //string a = Console.ReadLine();

            //try

            //{

            //    int number = int.Parse(a);

            //    Console.WriteLine("number is: " + number);

            //}

            //catch (FormatException)

            //{

            //    Console.WriteLine("mistaken string format. enter string,which consist only numbers beginning from  0 to 9.");

            //}

            //catch (OverflowException)

            //{

            //    Console.WriteLine("The entered number is outside the range of int.");

            //}

            //2

            //Console.WriteLine("Введіть рядок з 0 і 1:");

            //string input = Console.ReadLine();

            //try

            //{

            //    foreach (char digit in input)

            //    {

            //        if (digit != '0' && digit != '1')

            //        {

            //            throw new FormatException("Рядок містить недопустимі символи. Введіть рядок, що складається лише з 0 і 1.");

            //        }

            //    }

               

            //    int number = Convert.ToInt32(input, 2);

            //    Console.WriteLine("Введене число у десятковому поданні: " + number);

            //}

            //catch (FormatException ex)

            //{

            //    Console.WriteLine(ex.Message);

            //}

            //catch (OverflowException)

            //{

            //    Console.WriteLine("Введене число виходить за межі діапазону int.");

            //}
            try
            {
                Console.WriteLine("Введіть математичний вираз (тільки цілі числа і оператор *):");
                string inp = Console.ReadLine();

                
                string[] elements = inp.Split('*');

              

                int result=1;
              
                foreach (string element in elements)
                {
                    result*= int.Parse(element);
                }

               
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка введення: введений вираз містить нечислові значення.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }
        }
    
    }
}
