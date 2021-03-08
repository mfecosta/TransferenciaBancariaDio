using Conta_Bancaria.Classes;
using System;
using System.Collections.Generic;

namespace Conta_Bancaria
{
    class Program
    {
        static List<Conta> listcontas = new List<Conta>();


        static void Main(string[] args)
        {

            string ObterOpcaoUsuario = Opcaousuario();

            while (ObterOpcaoUsuario.ToUpper() != "X")
            { 
                switch (ObterOpcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Sacar();
                        break;
                    case "4":
                        //ListarContas();
                        break;
                    case "5":
                        //ListarContas();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

            ObterOpcaoUsuario = Opcaousuario();

        }
            Console.WriteLine("Obrigado por usar nossos serviços");
            Console.ReadLine();
        

    }

        private static void Sacar()
        {
            Console.WriteLine("Digite o numero da conta");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser sacado");
            double valor = double.Parse(Console.ReadLine());
            listcontas[conta].Sacar(valor); 
        }

        private static void ListarContas()
        {

            if (listcontas.Count ==0)
            {
                Console.WriteLine("Não existem contas cadastradas.");

                    return ;
            }

            for (int i = 0; i < listcontas.Count; i++)
            {
                Conta conta = listcontas[i];
                Console.Write("# {0} - ", i);
                Console.WriteLine(conta);

            }
                    
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            Console.WriteLine("Digite 1 para físoca e 2 para jurídica");
            int tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o saldo da conta");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o crédito:");
            double credito = double.Parse(Console.ReadLine());

            Conta novaconta = new Conta(nome,saldo,credito,(TipoConta)tipo);
            listcontas.Add(novaconta);
            
        }

        private static string Opcaousuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Bank ao seu dispor");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir novas Contas");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
