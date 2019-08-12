/* EXERCICIO FACTORY METHODE
Implemente o padrão Factory Method para a criação de um gerador de objetos que herdem da
classa abstrata Animais ( Gato, Cachorro, Peixe).
 */
using System;

namespace FactoryMethod
{
    abstract class Animal {
        protected Animal _animal;

        public Animal()
        {
            estaFazendo();
        }

        public abstract void estaFazendo();
    }

    class Gato : Animal {
        private string _fazendo;
        public Gato(string fazendo)
        {
            this._fazendo = fazendo;
        }
        public override void estaFazendo() {
            Console.Write(string.Format("O gato está {0}", this._fazendo));
        }

    }

    class Cachorro : Animal {
        private string _fazendo;

        public Cachorro(string fazendo) {
            this._fazendo = fazendo;
        }

        public override void estaFazendo() {
            Console.WriteLine(string.Format("O cachorro está {0}", this._fazendo));
        }
    }

    class Peixe : Animal {
        private string _fazendo;

        public Peixe(string fazendo) {
            this._fazendo = fazendo;
        }

        public override void estaFazendo() {
            Console.WriteLine(string.Format("O peixe está {0}", this._fazendo));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal gato     = new Gato("Comendo");
            Animal cachorro = new Cachorro("Correndo atrás da moto");
            Animal peixe    = new Peixe("Nadando");
            
            gato.estaFazendo();
            cachorro.estaFazendo();
            peixe.estaFazendo();
        }
    }
}
