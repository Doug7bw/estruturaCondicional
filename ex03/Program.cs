namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Digite um número inteiro para 'A':");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número inteiro para 'B'");
        b = int.Parse(Console.ReadLine());

        if((a % b == 0 || b % a == 0)){
            Console.WriteLine("São Multiplos");
        }
        else{
            Console.WriteLine("Não são Multiplos");
        }
    }
}
