﻿namespace ex02;
class Program
{
    static void Main(string[] args)
    {
        int number;
        
        Console.WriteLine("Digite um número inteiro:");
        number = int.Parse(Console.ReadLine());

        if(number % 2 == 0){
            Console.WriteLine("PAR");
        }
        else{
            Console.WriteLine("IMPAR");
        };
    }
}
