using System;

namespace src
{
    public enum IDJogadores  { 
        JogadorA,
        JogadorB, 
        JogadorC,
        JogadorD,
        JogadorE,
        JogadorF
    }

    abstract class MesaChain {
        protected MesaChain next;
        protected IDJogadores identificadorJogadores;

        public MesaChain(IDJogadores idJogador) {
            next = null;
            identificadorJogadores = idJogador;
        }
        
        public void setNext(MesaChain mesa) {
            if(next == null) {
                next = mesa;
            }
            else {
                next.setNext(mesa);
            }
        }

        public void jogadoresNaMesa(IDJogadores jogador) {
            if(podeJogar(jogador)) {
                jogadoresNaMesa();
            } else {
                if (next == null) {
                    throw new Exception("Jogador não foi encontrado");
                }
                next.jogadoresNaMesa(jogador);
            }
            
        } 

        private Boolean podeJogar(IDJogadores id) {
        if (identificadorJogadores == id) {
            return true;
        }
        return false;
    }

        protected abstract void jogadoresNaMesa();

    }
    class JogadorA: MesaChain {
        public JogadorA(): base(IDJogadores.JogadorA) {}

        protected override void jogadoresNaMesa() {
            Console.WriteLine("Este jogador está fora da mesa");
        }
  }
     class JogadorB: MesaChain {
        public JogadorB(): base(IDJogadores.JogadorB) {}

        protected override void jogadoresNaMesa() {
            Console.WriteLine("Esse jogador está na mesa");
        }
    }
     class JogadorC:MesaChain {
        public JogadorC(): base(IDJogadores.JogadorC) {}

        protected override void jogadoresNaMesa() {
            Console.WriteLine("Esse jogador está na mesa");
        }
    }
     class JogadorD: MesaChain {
        public JogadorD(): base(IDJogadores.JogadorD) {}

        protected override void jogadoresNaMesa() {
            Console.WriteLine("Esse jogador está na mesa");
        }
    }
     class JogadorE: MesaChain {
        public JogadorE(): base(IDJogadores.JogadorE) {}
        protected override void jogadoresNaMesa() {
            Console.WriteLine("Esse Jogador está fora da mesa");
        }
    }
     class JogadorF: MesaChain {
        public JogadorF(): base(IDJogadores.JogadorF) {}
        protected override void jogadoresNaMesa() {
            Console.WriteLine("Esse Jogador está na mesa");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MesaChain mesa = new JogadorA();
            mesa.setNext(new JogadorB());
            mesa.setNext(new JogadorC());
            mesa.setNext(new JogadorD());
            mesa.setNext(new JogadorE());
            mesa.setNext(new JogadorF());

            try{
                mesa.jogadoresNaMesa(IDJogadores.JogadorA);
                mesa.jogadoresNaMesa(IDJogadores.JogadorB);
                mesa.jogadoresNaMesa(IDJogadores.JogadorC);
                mesa.jogadoresNaMesa(IDJogadores.JogadorD);
                mesa.jogadoresNaMesa(IDJogadores.JogadorE);
                mesa.jogadoresNaMesa(IDJogadores.JogadorF);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
          
            
        }
    }
}
