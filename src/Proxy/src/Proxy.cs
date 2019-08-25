using System;

namespace src
{
    class ReceitaFederal {

        public void pagarFisico(double valorDocumento, double valorImposto, string cpf) {
            Console.WriteLine("Paga como fisica");
        }

        public void pagarJuridico(double valorDocumento, double valorImposto, string cnpj) {
            Console.WriteLine("Paga como Juridico");
        }
    }

    class ProxyReceita {
        private ReceitaFederal _receitaFederal;

        public ProxyReceita() {
            _receitaFederal = new ReceitaFederal();
        }

        public void pagarFisico(double valorDocumento, double valorImposto, string cpf) {
            _receitaFederal.pagarFisico(valorDocumento,valorImposto,cpf);
        }

        public void pagarJuridico(double valorDocumento, double valorImposto, string cnpj) {
            _receitaFederal.pagarJuridico(valorDocumento, valorImposto, cnpj);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProxyReceita receita = new ProxyReceita();

            receita.pagarFisico(10,10,"12312312332");
            receita.pagarJuridico(99,99,"123432113");
        }
    }
}
