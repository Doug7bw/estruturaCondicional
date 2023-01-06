namespace ex04;
class Program
{
    static void Main(string[] args)
    {
        int horaInicio, horaFim, duracao = 0;

        Console.WriteLine("Digite a hora que o jogo começou:");
        horaInicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a hora que o jogo terminou:");
        horaFim = int.Parse(Console.ReadLine());

        if(horaInicio > horaFim){
            duracao = 24 - horaInicio + horaFim;
        }
        else{
            duracao = 24 + horaInicio - horaFim;
        };

        if(duracao >+ 1 && duracao <= 24){
            Console.WriteLine($"O jogo durou {duracao} horas");
        }
        else{
            Console.WriteLine("A partida precisa ter uma duração mínima de 1 hora e duração máxima de 24 horas!");
        };      
    }
}
