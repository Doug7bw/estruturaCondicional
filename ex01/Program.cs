namespace ex01;
class Program
{
    static void Main(string[] args)
    {
        int number;
        
        Console.WriteLine("Digite um número inteiro:");
        number = int.Parse(Console.ReadLine());

        if(number > 0){
            Console.WriteLine("NAO NEGATIVO");
        }
        else{
            Console.WriteLine("NEGATIVO");
        };
    }
}
