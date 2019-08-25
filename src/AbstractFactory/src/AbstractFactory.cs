using System;

namespace AbstractFactory
{
    class Animal {
        protected Cor cor;

        public Animal(Cor cor) {
            this.cor = cor;
        }

        public Cor CorAnimal() {
            return cor;
        }
    }
    class Cor {
        public string nomeCor;

        public Cor NomeCor(){
            return nomeCor;
        }
    }

    class Amarelo: Cor {

        public Amarelo() {
            this.nomeCor = "Amarelo";
        }
    }

     class Verde: Cor {

        public Verde() {
            this.nomeCor = "Verde";
        }
    }

    abstract class AnimalFactory {
        protected Animal animal;
        public abstract void criarAnimal(string pais, string raca);

        public Animal retornaAnimal() {
            return animal;
        }

        public Cor corPorPais(string pais) {
            if(pais.Equals("Brasil")) {
                return new BrasilFactory().retornaCor();
            }
             else {
                 return new AfricaFactory().retornaCor();
             }
        }
    }

    class AnimaisAquaticosFactory: AnimalFactory {
        public override void criarAnimal(string pais, string raca) {
            if (raca = "peixe") {
                animal = new Peixe(corPorPais(pais));
            }
        }
    }
    class AnimaisTerrestresFactory: AnimalFactory {

        public override void criarAnimal(string pais, string raca) {
            if (raca = "cachorro") {
                animal = new Cachorro(corPorPais(pais));
            }
            else {
                animal = new Gato(corPorPais(pais));
            }
        }
    }

    public class Gato: Animal {
        public Gato(Cor cor): base(cor) {}
    }
    public class Cachorro: Animal {
        public Cachorro(Cor cor): base(cor) {}
    }
     public class Peixe: Animal {
        public Peixe(Cor cor): base(cor) {}
    }

    abstract class PaisAnimalFactory {
        public abstract Cor retornaCor();
    }

    class AfricaFactory: PaisAnimalFactory {
        public override Cor retornaCor() {
            return Amarelo();
        }
    }

    class BrasilFactory:PaisAnimalFactory {
        public override Cor retornaCor() {
            return Verde();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           AnimalFactory terrestre = new AnimaisTerrestresFactory();
           terrestre.criarAnimal("Brasil", "cachorro");
           string cor = terrestre.retornaAnimal().CorAnimal().NomeCor();
           Cor c = terrestre.retornaAnimal().CorAnimal();
           Console.WriteLine("O cachorro no brasil é " + cor);
           Console.WriteLine(c);
        }
    }
}
