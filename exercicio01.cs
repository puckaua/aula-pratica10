using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{

    internal class Cliente
    {
        private string nome;
        private string endereco;
        private int telefone;

        public Cliente(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }

        public Cliente(string nome, string endereco, int telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public string Nome 
        {
            get { return nome; } 
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNome, inputEndereco; int inputTelefone;
            Cliente[] clientes = new Cliente[3];
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Digite o nome do cliente {i + 1}");
                inputNome = Console.ReadLine();
                Console.WriteLine($"Digite o telefone do cliente {i + 1}");
                inputTelefone = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o endereço do cliente {i + 1}");
                inputEndereco = Console.ReadLine();
                clientes[i] = new Cliente(inputNome, inputEndereco);
                clientes[i].Telefone = inputTelefone;

            }

            Console.WriteLine();

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Cliente {i+1}:");
                Console.WriteLine(clientes[i].Nome);
                Console.WriteLine(clientes[i].Telefone);
                Console.WriteLine(clientes[i].Endereco);
                Console.WriteLine();


            }
        }
    }
}
