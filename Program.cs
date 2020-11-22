using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
           double i;
           double patinho;

            Console.Write("Numero de patinhos: ");
            patinho =Convert.ToDouble(Console.ReadLine());
            
            for ( i = patinho; i >1 ; i=i-1)
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{i} patinhos foram passear\nAlém das montanhas, para brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas só " +(i-1)+ " patinhos voltaram de lá."); 
            
            }
            Console.WriteLine($"\n{i} patinho foi passear\nAlém das montanhas, para brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas nenhum patinho voltou de lá.");
            Console.WriteLine($"\nA mamãe patinha foi procurar\nAlém das montanhas, na beira do mar\nA mamãe gritou: Quá, quá, quá, quá\nE os {patinho} patinhos voltaram de lá.");
            Console.ResetColor();
        }
    }
}