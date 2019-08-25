using System;

namespace src
{
    abstract class Comida {

        public abstract void montarComida();
    }

    class Ingredientes: Comida {
        protected Comida comida;

        public Ingredientes(Comida comida) {
            this.comida = comida;
        }

        public override void montarComida() {
            
        }
    }

    class Queijo: Ingredientes {
        public Queijo(Comida comida): base(comida) {}

        public void preparar() {
            comida.montarComida();
            Console.WriteLine("Foi adicionado queijo");
        }
    }

    class Bacon: Ingredientes {
        public Bacon(Comida comida): base(comida) {}

        public void preparar() {
            comida.montarComida();
            Console.WriteLine("Foi adicionado Bacon");
        }
    }

    class Catupiry: Ingredientes {
        public Catupiry(Comida comida): base(comida) {}

        public void preparar() {
            comida.montarComida();
            Console.WriteLine("Foi adicionado Catupiry");
        }
        
    }

    class Burguer: Comida {
        public void addPao() {
            Console.WriteLine("Adicionando pão");
        }
        public void addHamburguer() {
            Console.WriteLine("Adicionando Hamburguer");
        }
        public override void montarComida() {
            this.addPao();
            this.addHamburguer();
        }
    }

    class Pizza: Comida {

        public void addMolho(){
            Console.WriteLine("Passando molho na massa");
        }
        public void addAzeitona() {
            Console.WriteLine("Colocando azeitonas na pizza");
        }

        public void addQueijo() {
            Console.WriteLine("Adicionando Queijo na pizza");
        }

        public override void montarComida(){
            addMolho();
            addQueijo();
            addAzeitona();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Burguer burguer = new Burguer();
            Pizza pizza = new Pizza();
            Bacon bacon = new Bacon(burguer);
            Catupiry catupiry = new Catupiry(pizza);
            bacon.preparar();
            catupiry.preparar();
        }
    }
}
