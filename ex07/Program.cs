using System;
using System.Globalization;

namespace ex07;
class Program
{
    static void Main(string[] args)
    {
        double x, y;

        Console.WriteLine("Digite o valor de X:");
        x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Ditite o valor de Y");
        y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(x == 0 && y == 0){
            Console.WriteLine("Origem");
        }
        else if(x >= 0 && y >= 0){
            Console.WriteLine("Q1");
        }
        else if(x >= 0 && y <= 0){
            Console.WriteLine("Q4");
        }
        else if(x <= 0 && y >= 0){
            Console.WriteLine("Q2");
        }
        else if(x <= 0 && y <= 0){
            Console.WriteLine("Q3");
        };
    }
}
