using System;
using System.Collections.Generic;

namespace src
{
   public interface Percorrer {
        void percorrerVetor(List<int> vetor);
    }

    class PercorrerVetorCrescente : Percorrer {
        public void percorrerVetor(List<int> vetor) {
            foreach(var v in vetor) {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n---------------");
        }
    }

     class PercorrerVetorDecrescente : Percorrer {
        public void percorrerVetor(List<int> vetor) {
            vetor.Reverse();
            foreach(var v in vetor) {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n---------------");
        }
    }
    class Vetor {

        public List<int> vetor;
        private Percorrer _percorrerVetor;
        public Vetor(string ordem) {
            vetor = new List<int> {1,2,3,4,5,6};
            if (ordem.Equals("crescente")) {
                _percorrerVetor = new PercorrerVetorCrescente();
            }
            else {
                _percorrerVetor = new PercorrerVetorDecrescente();
            }
        }


        public void percorrerVetor() {
            _percorrerVetor.percorrerVetor(vetor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor = new Vetor("crescente");
            vetor.percorrerVetor();
            Vetor rotev = new Vetor("decrescente");
            rotev.percorrerVetor();
        }
    }
}
