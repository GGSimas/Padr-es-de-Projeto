using System;

namespace src
{
    class Contabilidade {
        public void pagarCompra() {
            Console.WriteLine("Compra paga, mandando processo para setor de qualidade");
        }
    }

    class Qualidade {
        public void validarCompra() {
            Console.WriteLine("Validando compra, mandando para Logistica");
        }
    }

    class Logistica {
        public void embrulharPacote() {
            Console.WriteLine("Pacote embrulhado, enviando para transportadora");
        }
    }

    class Transportadora {
        public void enviandoParaCorreios() {
            Console.WriteLine("Pacote entregue aos correios");
        }
    }

    class Correios {
        public void entregandoParaClientes() {
            Console.WriteLine("Destinatario Ausente");
        }
    }

    class Compra {
        private Contabilidade _contabilidade;
        private Qualidade _qualidade;
        private Logistica _logistica;
        private Transportadora _transportadora;
        private Correios _correios;

        public Compra() {
            this._contabilidade = new Contabilidade();
            this._qualidade = new Qualidade();
            this._logistica = new Logistica();
            this._transportadora = new Transportadora();
            this._correios = new Correios();
        }

        public void Comprar() {
            _contabilidade.pagarCompra();
            _qualidade.validarCompra();
            _logistica.embrulharPacote();
            _transportadora.enviandoParaCorreios();
            _correios.entregandoParaClientes();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Compra compra = new Compra();
           compra.Comprar();
        }
    }
}
