using System.Runtime.Intrinsics.X86;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do

            {
                Console.Clear();

                Console.WriteLine("Calculadora 2023");

                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para gerar tabuada");
                Console.WriteLine("Digite S para Sair");

                //

                string operacao = Console.ReadLine();

                //

                if(operacao == "S" || operacao == "s")
                {
                    break;
                }

                if(operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4"
                   && operacao != "5" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operacao inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }
               
                if(operacao == "5")
                {
                    Console.Write("Digite o número para gerar a tabuada: ");

                    int tabuada = Convert.ToInt32(Console.ReadLine());

                    for(int numero = 1; numero <= 10; numero = numero + 1)
                    {
                        int resultadoMultiplicacao = tabuada * numero;

                        Console.WriteLine(tabuada + " X " + numero + " = " + resultadoMultiplicacao);
                    }

                    Console.ReadLine();
                    continue;

                }

                //
                Console.WriteLine();
                //

                Console.Write("Digite o primeiro número: ");

                decimal numero1 = Convert.ToDecimal(Console.ReadLine());

                //

                Console.Write("Digite o segundo número: ");

                decimal numero2 = Convert.ToDecimal(Console.ReadLine());

                //
                    
                decimal resultado = 0;


                switch(operacao)
                {
                    case "1": resultado = numero1 + numero2; break;
                    case "2": resultado = numero1 - numero2; break;
                    case "3": resultado = numero1 * numero2; break;
                    case "4":
                        {
                            while (numero2 == 0)
                            {
                                Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                                Console.Write("Digite o segundo número: ");

                                numero2 = Convert.ToDecimal(Console.ReadLine());

                            }

                            resultado = numero1 / numero2; break;


                        }

                    default:
                        break;
                }


                decimal formatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + formatado);

                Console.ReadLine();

            } while (true);



        }
    }
}
