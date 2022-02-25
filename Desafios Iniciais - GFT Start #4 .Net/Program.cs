// See https://aka.ms/new-console-template for more information

// Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor,  
        //deve ser apresentado como resposta o mês do ano por extenso, em inglês, com a 
        //primeira letra maiúscula.

        //Entrada
        //A entrada contém um único valor inteiro.

        // Saída
        //Imprima por extenso o nome do mês correspondente ao número existente

using System;

public class Problem {
    public static void Main() {

        int mes = int.Parse(Console.ReadLine());

        switch (mes) {
      case 1:
          Console.WriteLine("January");
          break;
      case 2:
          Console.WriteLine("February");
          break;
      case 3:
          Console.WriteLine("March");
          break;
      case 4:
          Console.WriteLine("April");
          break;
      case 5:
          Console.WriteLine("May");
          break;
      case 6:
          Console.WriteLine("June");
          break;
      case 7:
          Console.WriteLine("July");
          break;
      case 8:
          Console.WriteLine("August");
          break;
      case 9:
          Console.WriteLine("September");
          break;
      case 10:
          Console.WriteLine("October");
          break;
      case 11:
          Console.WriteLine("November");
          break;
      case 12:
          Console.WriteLine("December");
          break;
           //continue o código com sua solução


            default:
                Console.WriteLine("Digite um número válido de 1 a 12");
                break;
        }
        Console.ReadLine();
    }
}
        //Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). 
        //Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

        //Entrada
        //O arquivo de entrada contém um número inteiro positivo N.

        //Saída
        // Imprima a saída conforme o exemplo fornecido.

using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                var result = $"{i} {i * i} {i * i * i}";
                
                Console.WriteLine(result);
                 
                
            }
        }
    }
}

        //O programa deve ler um valor inteiro D indefinidas vezes, 
        //ele só irá parar quando o valor de D for igual a 0. Para cada D lido, 
        //imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , 
        //se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o 
        //resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, 
        //a saída deve ser 80, que é a soma de 12+14+16+18+20.

        //Entrada
        //O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

        //Saída
        //Imprima a saida conforme a explicação acima e o exemplo abaixo.

using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int cont = 0;
            int D = int.Parse(Console.ReadLine());
            
            while (D != 0)
            {
                while (cont < 5)
                {
                    if (D % 2 == 0)
                    {
                        soma += D;
                        cont++;
                        D++;
                    }
                    else
                    {
                        D++;
                    }
                }
                Console.WriteLine(soma);
                cont = 0;
                soma = 0;
                D = int.Parse(Console.ReadLine());
            }
          }
      }
}
    
