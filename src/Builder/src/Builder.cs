using System;

namespace src
{
    abstract class CasaBuilder {
        protected Casa casa;
        public CasaBuilder() {
            casa = new Casa();
        }

        public abstract void PadraoDaCasa();
    }

    class Casa {
        public string tipo;
        public double preco;
    }

    class ApartamentoBuilder: CasaBuilder {

        public override void PadraoDaCasa() {
            casa.preco = 2000;
            casa.tipo = "Apartamento";

            Console.WriteLine(string.Format("Tipo: {0} Valor: {1}", casa.tipo, casa.preco));
        }
    }

    class SobradoBuilder: CasaBuilder {
        public override void PadraoDaCasa() {
            casa.preco = 10000;
            casa.tipo = "Sobrado";

            Console.WriteLine(string.Format("Tipo: {0} Valor: {1}", casa.tipo, casa.preco));
        }
    }

    class Construtora {
        protected CasaBuilder _casaBuilder;

        public Construtora (CasaBuilder casaBuilder)
        {
            this._casaBuilder = casaBuilder;
        }

        public void construirCasa() {
            _casaBuilder.PadraoDaCasa();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Construtora construtora = new Construtora(new SobradoBuilder());
            construtora.construirCasa();

            Construtora construtora2 = new Construtora(new ApartamentoBuilder());
            construtora2.construirCasa();
        }
    }
}
