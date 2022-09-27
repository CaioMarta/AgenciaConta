using System;

namespace AgenciaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de varíaveis
            double valor = 0;
            int opcao = 0;

            // Instanciar um objeto da classe Conta
            Conta minhaconta = new Conta();

            minhaconta.LerDadosConta();

            // loop
            do
            {
                Console.WriteLine(" --- Opereções --- \n " +
                    "\n1 - Sacar" +
                    "\n2 - Depositar" +
                    "\n3 - Consultar Saldo" +
                    "\n4 - Sair do Programa" +
                    "\n ===>>> Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Valor do saque R$: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        minhaconta.Sacar(valor);
                        break;

                    case 2:
                        Console.WriteLine("Valor do depósito R$: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        minhaconta.Depositar(valor);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine(minhaconta.VerSaldo());
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Programa Finalizado com Sucesso....");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente");
                        break;

                }

            }
            while (opcao != 4);
        }
    }
}
