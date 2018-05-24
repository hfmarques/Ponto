using System;

namespace Ponto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pontoReflete = new PontoReflete(2, 1);
            var pontoMove = new PontoMove(2, 1);

            Console.WriteLine($"Ponto Reflete com valores X: {pontoReflete.X} Y: {pontoReflete.Y}");
            Console.WriteLine($"Ponto Move com valores X: {pontoMove.X} Y: {pontoMove.Y}");

            Console.WriteLine();
            Console.WriteLine("Refletindo os pontos...");
            pontoReflete.Reflete();

            Console.WriteLine();
            const int x = 1;
            const int y = -5;
            Console.WriteLine($"Movendo os pontos em X: {x} e Y: {y}");
            pontoMove.Move(x, y);

            Console.WriteLine();
            Console.WriteLine($"Ponto Reflete com valores X: {pontoReflete.X} Y: {pontoReflete.Y}");
            Console.WriteLine($"Ponto Move com valores X: {pontoMove.X} Y: {pontoMove.Y}");

            Console.ReadLine();
        }
    }
}