using System;

namespace src
{
    class TomadaTresPinos {
        public void conectarTomadaTresPinos() {
            Console.WriteLine("Usou a tomada de 3 pinos");
        }
    }

    class TomadaDoisPinos {
        public void conectarTomadaDoisPinos() {
            Console.WriteLine("Usou a tomada de 2 pinos");
        }
    }

    class TomadaTresPinosAdptador: TomadaTresPinos {
        private TomadaDoisPinos _tomadaDoisPinos;

        public TomadaTresPinosAdptador(TomadaDoisPinos tomadaDoisPinos){
            this._tomadaDoisPinos = tomadaDoisPinos;
        }

        public void conectarTomadaTresPinos() {
            _tomadaDoisPinos.conectarTomadaDoisPinos();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TomadaDoisPinos tomadaDoisPinos = new TomadaDoisPinos();
            TomadaTresPinosAdptador Adptador = new TomadaTresPinosAdptador(tomadaDoisPinos);
            Adptador.conectarTomadaTresPinos();
        }
    }
}
