using System;

namespace ExercicioAula01
{
    class Program
    {





        static void Main(string[] args)
        {
            DetalharData();
            CalcularDescontoINSS();
        }

        /*Criar um método chamado DetalharData que apresente a mensagem para o usuário digitar uma data e 
        armazene em uma variável compatível. Você deverá usar formatação para imprimir na tela qual o dia da 
        Semana (Segunda, Terça...etc) e qual o nome do mês por extenso (Janeiro, Fevereiro etc). Comparar o 
        dia da semana da data, se ela for um domingo, imprimir na tela a hora atual com os minutos (Ex: 14:35)*/
        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Essa data é {data.ToString("dddd")} e pertence ao mês de {data.ToString("MMMM")}.");

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("{0:HH:mm}", DateTime.Now);
            }


        }
        /*Criar um método chamado CalcularDescontoINSS que apresente a mensagem que solicite para o 
        usuário digitar o valor do salário e armazene em uma variável compatível. Você deverá observar a tabela 
        em anexo e apresentar ao usuário o valor de INSS que ele terá que pagar e qual o valor do salário 
        descontado o INSS. Você pode declarar a quantidade de variáveis que quiser para fazer os cálculos.*/

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o valor do salário: ");
            double ValorSalario = double.Parse(Console.ReadLine());
            

            if (ValorSalario <= 1212)
            {
                double result = ValorSalario * 0.075;
            Console.WriteLine($"O valor da contribuição de INSS é de {result}");
            double resultado = ValorSalario - (ValorSalario * 0.075);
            Console.WriteLine($"O salário com o desconto da contribuição de INSS é {resultado}");
            }
            else if (ValorSalario > 1212 && ValorSalario <= 2427.35)
            {
                double result = ValorSalario * 0.09;
            Console.WriteLine($"O valor da contribuição de INSS é de {result}");
            double resultado = ValorSalario - (ValorSalario * 0.09);
            Console.WriteLine($"O salário com o desconto da contribuição de INSS é {resultado}");
            }
            else if (ValorSalario > 2427.35 && ValorSalario <= 3641.03)
            {
                double result = ValorSalario * 0.12;
                 Console.WriteLine($"O valor da contribuição de INSS é de {result}");
                double resultado = ValorSalario - (ValorSalario * 0.12);
            Console.WriteLine($"O salário com o desconto da contribuição de INSS é {resultado}");
            }

            else
            {
                double result = ValorSalario * 0.14;
            Console.WriteLine($"O valor da contribuição de INSS é de {result}");
            double resultado = ValorSalario - (ValorSalario * 0.14);
            Console.WriteLine($"O salário com o desconto da contribuição de INSS é {resultado}");
            }
        }





    }

}