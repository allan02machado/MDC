using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
             int n1;
             int n2;
             //##########
             int div;
             int divdndo;
             int resto;
             //##########
             bool n1Val;
             bool n2Val;
             //##########
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bem-vindo!!. Digite apenas números inteiros");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("1o Valor(A)= ");
                n1Val = int.TryParse(Console.ReadLine(), out n1);

                Console.Write("2o Valor(B)= ");
                n2Val = int.TryParse(Console.ReadLine(), out n2);

                if(n1 > n2)
                {
                    divdndo = n1;
                    div = n2;
                }
                else
                {
                    divdndo = n2;
                    div = n1;
                }
                while(divdndo % div != 0)
                {
                    resto = divdndo % div;
                    divdndo = div;
                    div = resto;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Máximo divisor comum entre A e B = " + div);
                Console.ResetColor();
        }
    }
}
