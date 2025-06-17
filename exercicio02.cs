using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;


        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public string ToString()
        {
            string diaString = $"{this.dia.ToString()}/";
            string mesString = $"{this.mes.ToString()}/";
            string anoString = $"{this.ano.ToString()}";
            string resultado = diaString + mesString + anoString ;
            return resultado ;

        }

        public int Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        public int Mes
        {
            get { return this.mes; }
            set { this.mes = value; }
        }

        public int Ano
        {
            get { return this.ano; }
            set { this.ano = value; }
        }

    }
        
    internal class Teste
    {
        
        static void Main(string[] args)
        {
            int dia, mes, ano;
            string resultado;
            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            Data d1 = new Data(dia, mes, ano);
            d1.Dia = dia + 1;
            resultado = d1.ToString();

            Console.WriteLine("Resultado:" + resultado);

            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            Data d2 = new Data(dia, mes, ano);
            d2.Dia = dia + 1;
            resultado = d2.ToString();

            Console.WriteLine("Resultado:" + resultado);

        }
    }
}
