using System;
using System.Globalization;

namespace ex05;
class Program
{
    static void Main(string[] args)
    {
        int codigo, quantidade;
        string item = "";
        double precoItem = 0.0, precoTotal = 0.0;

        Console.WriteLine("Digite o código do item que deseja levar (De 1 a 5):");
        codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de itens que vai levar:");
        quantidade = int.Parse(Console.ReadLine());

        if(codigo >= 1 && codigo <= 5){
            if(codigo == 1){
                precoTotal = 4.00 * quantidade;
                item = "Cachorro quente";
            }
            else if(codigo == 2){
                precoTotal = 4.50 * quantidade;
                item = "X-Salada";
            }
            else if(codigo == 3){
                precoTotal = 5.00 * quantidade;
                item = "X-Bacon";
            }
            else if(codigo == 4){
                precoTotal = 2.00 * quantidade;
                item = "Torrada simples";
            }
            else if(codigo == 5){
                precoTotal = 1.50 * quantidade;
                item = "Refrigerante";
            };
            Console.WriteLine($"Comprando {quantidade} {item}(s), o total a pagar é: R$ {precoTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else{
            Console.WriteLine($"Não existe um item com o código {codigo}");
        };
    }
}
