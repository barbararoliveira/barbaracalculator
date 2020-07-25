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

             Console.Write("Escolha a ação desejada [+] [-] [*] [/] [%] [1 (exponenciação)] [2 (radiciação)] [C (créditos)] [F (finalizar)].....: ");
             op = Console.ReadLine();

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
               Environment.Exit(1);
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
               Environment.Exit(1);
              }

               switch (op)

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
                   result = (primeiron * segundon) / 100 ;
                   Console.WriteLine($"{primeiron} % {segundon} = {result}");
                   break;

               case "1":
                   result = Math.Pow(primeiron, segundon);
                   Console.WriteLine($"{primeiron} ^ {segundon} = {result}");
                   break;

               case "2":
                   result = Math.Pow(primeiron, (1 / segundon) );
                   Console.WriteLine($"= {result}");
                   break;


               default:
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.Write($"OPERAÇÃO INVÁLIDA. ");
                   Console.ResetColor();
                   Console.WriteLine($" Pressione enter: ");
                   Console.ReadKey();
                   Environment.Exit(1);
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
