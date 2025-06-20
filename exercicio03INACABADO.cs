using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Jogador {
        private string nome;
        private int pontuacao = 0;

        public Jogador(string nome, int pontuacao)
        {
            this.nome = nome;
            this.pontuacao = pontuacao;
        }

        public void atualizarPontuacao(int pontuacao)
        {
            this.pontuacao = pontuacao;
        }

        public string Nome {
            get { return this.nome; } 
            set{ this.nome = value; }
        }



    }
    internal class Teste
    {
        static void Main(string[] args)
        {
            string nome;
            int pontuacao;

        }
    }
}
