using System;

namespace ProjetoCalculadoraBarbara
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiron=0, segundon=0, result=0, n=0; // n = número
            string op, vlusuario; // op = operação
            bool vlvalido=false; // vl = valor
        
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ----- CALCULADORA <3 ----- ");
            
            Console.ResetColor();

            Console.Write("Olá! Bem-vindo(a) a ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine ("calculadora <3");

            Console.ResetColor();

            Console.WriteLine("Pressione enter para continuar.\n ");
            Console.ReadKey();

            string tecla = "";
            while(tecla != ".")

            {

             Console.Write("Escolha a ação desejada [+] [-] [*] [/] [%] [1 (exponenciação)] [2 (raiz quadrada)] [; (créditos)] [. (finalizar)].....: ");
             op = Console.ReadLine();

             switch (op)

             {
              case ";":
                  Console.WriteLine("Este programa foi desenvolvido pela aluna da Etec Adolpho Berezin Bárbara Oliveira, ");
                  Console.WriteLine("instruída pelos professores Ermogenes Palacio e Diego Neri.");
                  Console.WriteLine("Link do site: ");
                  Console.WriteLine("Link do projeto no GitHub: https://github.com/barbararoliveira/CalculadoraBarbara");
                  Environment.Exit(-1);
                  break;

              case ".":
                  Console.BackgroundColor = ConsoleColor.White;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.Write("Obrigada por utilizar o software");
                  Console.BackgroundColor = ConsoleColor.White;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write(" <3");
                  Console.BackgroundColor = ConsoleColor.White;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.Write(" !");
                  Console.ResetColor();
                  Console.WriteLine(" Pressione enter para finalizar: ");
                  Console.ReadKey();
                  Environment.Exit(0);
                  break;

              case "2":
                  double valor, result1;
                  Console.Write("digite o valor.....: ");
                  valor = Convert.ToDouble(Console.ReadLine());
                  result1 = Math.Sqrt(valor);
                  Console.WriteLine($"= {result1}");
                  Environment.Exit(-1);
                  break;
             }

             Console.Write("Digite o primeiro número.....:  ");
             vlusuario = Console.ReadLine();
             vlvalido = double.TryParse(vlusuario, out n);

               if (vlvalido)

              {
               primeiron = Math.Round(double.Parse(vlusuario), 5);
              }
           
               else

              {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.Write("NÚMERO INVÁLIDO. ");
               Console.ResetColor();
               Console.WriteLine($" Pressione enter: ");
               Console.ReadKey();
               Environment.Exit(-1);
              }

               Console.Write("Digite o segundo número.....: ");
               vlusuario = Console.ReadLine();
     
               if (vlvalido)

              {
               segundon = Math.Round(double.Parse(vlusuario), 5);
              }
            
               else

              {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("NÚMERO INVÁLIDO. ");
               Console.ResetColor();
               Console.WriteLine($" Pressione enter: ");
               Console.ReadKey();
               Environment.Exit(-1);
              }

               switch (op)

              {
               case "+":
                   result = primeiron + segundon;
                   Console.WriteLine($"{primeiron} + {segundon} = {result}\n");
                   break;

               case "-":
                   result = primeiron - segundon ;
                   Console.WriteLine($"{primeiron} - {segundon} = {result}\n");
                   break;

               case "*":
                   result = primeiron * segundon ;
                   Console.WriteLine($"{primeiron} * {segundon} = {result}\n");
                   break;

               case "/":
                   result = primeiron / segundon;
                   Console.WriteLine($"{primeiron} / {segundon} = {result}\n");
                   break;

               case "%":
                   result = (primeiron * segundon) / 100 ;
                   Console.WriteLine($"{primeiron} % {segundon} = {result}\n");
                   break;

               case "1":
                   result = Math.Pow(primeiron, segundon);
                   Console.WriteLine($"{primeiron} ^ {segundon} = {result}\n");
                   break;

               default:
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.Write($"OPERAÇÃO INVÁLIDA. ");
                   Console.ResetColor();
                   Console.WriteLine($" Pressione enter: ");
                   Console.ReadKey();
                   Environment.Exit(-1);
                   break;
               }  
            
             Console.WriteLine("Digite . para sair ou qualquer outra tecla para retornar ao menu: ");
             tecla = Console.ReadLine();  
             
            }
             
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Black;
              Console.Write("Obrigada por utilizar o software");
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write(" <3");
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Black;
              Console.Write(" !");
              Console.ResetColor();
              Console.WriteLine(" Pressione enter para finalizar: ");
              Console.ReadKey();
              Environment.Exit(0);
        }
    }
}
