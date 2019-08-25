using System;
using System.Collections.Generic;

namespace src
{
    class Arquivo {
        public string nome;

        public Arquivo(string nome) {
            this.nome = nome;
        }

        public void MoverArquivo() {
            Console.WriteLine(string.Format("Arquivo {0} foi movido", nome));
        }
    }

    class ArquivoFlyWeight {
        public List<Arquivo> arquivos;

        public ArquivoFlyWeight() {
            arquivos = new List<Arquivo>();
            arquivos.Add(new Arquivo("Arquivo A"));
            arquivos.Add(new Arquivo("Arquivo B"));
            arquivos.Add(new Arquivo("Arquivo C"));
        }

        public void movendoArquivos(string nome) {
            foreach(Arquivo arquivo in arquivos) {
                if(arquivo.nome == nome) {
                    arquivo.MoverArquivo();
                }
            }
        }
    } 

    class Cliente {
        private ArquivoFlyWeight _arquivoFlyWeight;

        public Cliente() {
            _arquivoFlyWeight = new ArquivoFlyWeight();
        }

        public void mover(string nome) {
            _arquivoFlyWeight.movendoArquivos(nome);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Cliente cliente = new Cliente();
           cliente.mover("Arquivo A");
        }
    }
}
