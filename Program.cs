using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_C_Sharp
{
    class Program
    {
        //Вариант 2

        static void Main(string[] args)
        {
            Console.WriteLine("       /\\");
            Console.WriteLine("    A /  \\ B");
            Console.WriteLine("     /    \\");
            Console.WriteLine("    /______\\");
            Console.WriteLine("        C\n");


            // Створюєио три трикутники задані, своїми сторонами
            double[] triangle1 = SetTriangleParametrs(1);
            double[] triangle2 = SetTriangleParametrs(2);
            double[] triangle3 = SetTriangleParametrs(3);

            FindTheBiggest(triangle1, triangle2, triangle3);
        }

        static double[] SetTriangleParametrs(int numberOfTriangle) // функція задання трикутника його сторонами
        {
            try
            {
                // створюємо масив на 3 елементи, кожному з яких буде відповідати сторона трикутника
                double[] triangle = new double[3];

                //вводимо з клавіатури довільні значення сторін А, B, С і записуємо в масив відповідно
                Console.Write($"Write Side  'A'  Length of {numberOfTriangle} triangle (number)\n->  ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                triangle[0] = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Write Side  'B'  Length of {numberOfTriangle} triangle (number)\n->  ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                triangle[1] = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Write Side  'C'  Length of {numberOfTriangle} triangle (number)\n->  ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                triangle[2] = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                // перевіряємо введений трикутник на існування
                if (triangle[0] + triangle[1] > triangle[2] && triangle[0] + triangle[2] > triangle[1] && triangle[1] + triangle[2] > triangle[0])
                    return triangle;
                //Якщо трикутник не існує, повідомляємо про помилку
                else
                {
                    Console.WriteLine("This triangle doesn't exist");
                    Environment.Exit(1);
                    return null;
                }

            }
            catch (Exception)
            {
                //Якщо користувач ввів некоректні значення, повідомляємо про помилку
                Console.WriteLine("You entered wrong parametrs");
                Environment.Exit(1);
                return null;
            }
        }

        static double FindSquare(double[] triangle) // функція знаходження площі трикутника
        {
            // знаходимо півпериметр для трикутника
            double semi_perimeter = (triangle[0] + triangle[1] + triangle[2]) / 2;
            // знаходимо площу трикутника за формуою Герона
            double square = Math.Sqrt(semi_perimeter * (semi_perimeter - triangle[0]) * (semi_perimeter - triangle[1]) * (semi_perimeter - triangle[2]));

            return square;
        }

        static void FindTheBiggest(double[] triangle1, double[] triangle2, double[] triangle3) // функція знаходження найбільшої площі
        {
            //знаходимо площу кожного трикутника
            double squareFirst = FindSquare(triangle1);
            double squareSecond = FindSquare(triangle2);
            double squareThird = FindSquare(triangle3);

            Console.WriteLine($"First Triangle square:  {squareFirst:0.###}");
            Console.WriteLine($"Second Triangle square: {squareSecond:0.###}");
            Console.WriteLine($"Third Triangle square:  {squareThird:0.###}\n");

            // з трьох площ знаходимо найбільшу і повідомляємо який з трикутників має найбільшу площу
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (squareFirst == squareSecond && squareFirst == squareThird)
                Console.WriteLine("This three triangles have the same square\n");

            else if (squareFirst == squareSecond)
                if (squareFirst > squareThird)
                    Console.WriteLine("Max Square have first and second triangle\n");
                else
                    Console.WriteLine("Max Square has third triangle\n");

            else if (squareFirst == squareThird)
                if (squareFirst > squareSecond)
                    Console.WriteLine("Max Square have first and third triangle\n");
                else
                    Console.WriteLine("Max Square has second triangle\n");

            else if (squareSecond == squareThird)
                if (squareSecond > squareFirst)
                    Console.WriteLine("Max Square have second and third triangle\n");
                else
                    Console.WriteLine("Max Square has first triangle\n");

            else if (squareFirst > squareSecond)
                if (squareFirst > squareThird)
                    Console.WriteLine("Max Square has first triangle\n");
                else Console.WriteLine("Max Square has third triangle\n");

            else
                if (squareSecond > squareThird)
                Console.WriteLine("Max Square has second triangle\n");

            else Console.WriteLine("Max Square has third triangle\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
