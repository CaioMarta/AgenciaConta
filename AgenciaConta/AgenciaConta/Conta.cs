using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaConta
{
    class Conta
    {
        // Declaração dos atributos
        private string numero;
        private double saldo;
        private double limite;

        // Declarando o objeto agencia da Classe Agencia, este objeto é um atributo da Classe Conta
        private Agencia agencia;

        // Construtor da Classe Conta
        public Conta()
        {
            Console.WriteLine("Executando o construtor da classe Conta");
            numero = null;
            saldo = 0;
            limite = 0;
            // Instanciando o objeto agencia da Classe Agencia
            agencia = new Agencia(); // Executar o Construtor
        }

        // Métodos da Classe Conta
        public void LerDadosConta()
        {
            string msg = "";
            try
            {
                agencia.LerDadosAgencia();
                Console.Write("\nN0. da Conta: ");
                numero = Console.ReadLine();
                Console.Write("Saldo R$: ");
                saldo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Limite R$: ");
                limite = Convert.ToDouble(Console.ReadLine());

                msg = "Dados cadastrados com sucesso!";
            }
            catch (Exception ex) // Este campo pode aparacer várias vezes no programa
            {
                msg = "Saldo e Limite tem quer número \n" + ex;
            }
            finally // Campo não obrigatório
            {
                Console.WriteLine(msg);
            }
        }

        public void Sacar(double valor)
        {
            if(valor <= (saldo + limite))
            {
                saldo -= valor; // saldo = saldo - valor
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public string VerSaldo()
        {
            agencia.MostrarDadosAgencia();
            return "\nNo. da Conta: " + numero +
                "\nSaldo R$: " + saldo +
                "\nLimite R$: " + limite +
                "\nSaldo total R$: " + (saldo + limite);
        }
    }
}
