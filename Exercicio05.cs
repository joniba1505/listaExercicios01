using System;

namespace listaExercicios01
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
        decimal numeroEleitores = 0;
        decimal votosBrancos = 0;
        decimal votosNulos = 0;
        decimal votosValidos = 0;


Console.WriteLine("Digite o número total de eleitores:");
        numeroEleitores = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite os votos em branco:");
votosBrancos = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite os votos nulos:");
votosNulos = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Digite os votos válidos:");
votosValidos = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Votos brancos: " + (numeroEleitores*votosBrancos/10000) + " por cento.");
        }
    }
}
        