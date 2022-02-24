using System;

namespace Tipos_Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Digite o valor para A" );
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor para B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor para C");
            C = Convert.ToInt32(Console.ReadLine());

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
                Console.ReadLine();
            }
            else
            {
                if(A == B || A == C || B == C) 
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("TRIANGULO ESCALENO");
                    Console.ReadLine();
                }
            }
        }
    }
}
