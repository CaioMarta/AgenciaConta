using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaConta
{
    class Agencia
    {
        // Declaração dos atributos
        private string numero;
        private string nome;
        private string endereco;

        // Construtor sem parâmetro
        public Agencia()
        {
            Console.WriteLine("Executando o construtor de Agência");
            numero = null;
            nome = null;
            endereco = null;
        }

        // Métodos 
        public void LerDadosAgencia()
        {
            Console.WriteLine("*** Agência JPBank ***");
            Console.Write("No. da agência: ");
            numero = Console.ReadLine();

            Console.Write("Nome da agência: ");
            nome = Console.ReadLine();

            Console.Write("Endereço da agência: ");
            endereco = Console.ReadLine();
        }

        public void MostrarDadosAgencia()
        {
            Console.WriteLine("DADOS DA AGÊNCIA");
            Console.WriteLine("Nome: " + nome +
                "\nNo.: " + numero +
                "\nEndereço: " + endereco);
        }

    }
}
