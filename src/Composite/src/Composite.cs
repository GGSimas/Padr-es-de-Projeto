using System;
using System.Collections.Generic;

namespace src
{
    abstract class Pessoa {
        public string nomeFamilia;
        public string nomePessoa;
        public string sexoPessoa;

        public virtual void mostrarPessoas() {
            Console.WriteLine(string.Format("Nome: {0}", nomePessoa));
        }

        public virtual void adicionarPessoaNaArvore(Pessoa pessoa) {
            Console.WriteLine(string.Format("Pessoa {0} adicionada na arvore", pessoa.nomePessoa));
        }
    }

    class Homen : Pessoa {
        public Homen(string nome){
            nomePessoa = nome;
            sexoPessoa = "Masculino";
        }
    }


    class Mulher: Pessoa {
        public List<Pessoa> filhos = new List<Pessoa>();
        public Mulher(string nome){
            nomePessoa = nome;
            sexoPessoa = "Feminino";
        }

        public void AdicionarFilho(Pessoa pessoa) {
          this.filhos.Add(pessoa);
        }
    }

    class ArvoreGenealogica: Pessoa {
        public List<Pessoa> pessoas = new List<Pessoa>();

        public ArvoreGenealogica(string familia) {
            nomeFamilia = familia;
        }

        public override void adicionarPessoaNaArvore(Pessoa pessoa) {
            this.pessoas.Add(pessoa);
        }

        public override void mostrarPessoas() {
            foreach(Pessoa pessoa in pessoas){
                Console.WriteLine(pessoa.nomePessoa);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Homen filho = new Homen("Gabriel");
           Mulher mae = new Mulher("Silvia");
           Homen pai = new Homen("Willian");
           Mulher filha = new Mulher("Luisa");

           mae.AdicionarFilho(filho);
           mae.AdicionarFilho(filha);

           ArvoreGenealogica arvore = new ArvoreGenealogica("Simoes");
           arvore.adicionarPessoaNaArvore(pai);
           arvore.adicionarPessoaNaArvore(mae);
           arvore.mostrarPessoas();
        }
    }
}
