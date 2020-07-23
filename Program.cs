using System;

namespace ProjetoCalculadoraBarbara
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiron, segundon, result, n; // n = número
            string operacao, vlusuario;
            bool vlvalido, terminar; // vl = valor
           
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ----- CALCULADORA <3 ----- \n");
            Console.ReadKey();
            
            Console.ResetColor();

            Console.WriteLine("Digite o primeiro número:  ");
            vlusuario = Console.ReadLine();

            vlvalido = double.TryParse(vlusuario, out n);

            while (!terminar)

            { 

             if (vlvalido)

             {
              primeiron = Math.Round(double.Parse(vlusuario), 5);
              terminar = false;
             }
           
             else

             {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("VALOR INVÁLIDO. ");
              terminar = true;
             }

              Console.WriteLine("Digite a operação desejada (+, -, *, /, %): ");
              operacao = Console.ReadLine();

              Console.WriteLine("Digite o segundo número: ");
              vlusuario = Console.ReadLine();
     
             if (vlvalido)

             {
              segundon = Math.Round(double.Parse(vlusuario), 5);
              terminar = false;
             }
            
             else

             {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("VALOR INVÁLIDO. ");
              terminar = true;
             }

             switch (operacao)

             {
              case "+":
                  result = primeiron + segundon;
                  Console.WriteLine($"{primeiron} + {segundon} = {result}");
                  break;

              case "-":
                  result = primeiron - segundon ;
                  Console.WriteLine($"{primeiron} - {segundon} = {result}");
                  break;

              case "*":
                  result = primeiron * segundon ;
                  Console.WriteLine($"{primeiron} * {segundon} = {result}");
                  break;

              case "/":
                  result = primeiron / segundon ;
                  Console.WriteLine($"{primeiron} / {segundon} = {result}");
                  break;

              case "%":
                  result = primeiron % segundon ;
                  Console.WriteLine($"{primeiron} % {segundon} = {result}");
                  break;

              default:
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write($"OPERAÇÃO INVÁLIDA. ");
                  Console.ResetColor();
                  Console.WriteLine($"Pressione enter: ");
                  Console.ReadKey();
                  Environment.Exit(1);
                  break;
              }
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Black;
              Console.Write("Obrigada por utilizar o software");
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write(" <3");
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Black;
              Console.Write("!");
              Console.ResetColor();
              Console.WriteLine(" Pressione enter para finalizar: ");
              Console.ReadKey();
              Environment.Exit(0);
              
             }
        }
    }
}
