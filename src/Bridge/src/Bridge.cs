using System;

namespace src
{
    interface WebSite {
        void acessarNavegador(string nav);
        void acessarSite(string url);

    }

    abstract class Navegador {
        protected WebSite website;

        public Navegador(WebSite website){
            this.website = website;
        }

        public void acessarNavegador(string nav) {
            website.acessarNavegador(nav);
        }
        public void acessarSite(string url) {
            website.acessarSite(url);
        }

        public abstract void acessar();
    }

    class Chrome: Navegador {

        public Chrome(WebSite webSite): base(webSite) {
        
        }

        public override void acessar() {
            acessarNavegador("Chrome");
            acessarSite(website.GetType().Name);
        }
    }

     class Firefox: Navegador {

        public Firefox(WebSite webSite): base(webSite) {
        
        }

        public override void acessar() {
            acessarNavegador("Firefox");
            acessarSite(website.GetType().Name);
        }
    }

     class Edge: Navegador {

        public Edge(WebSite webSite): base(webSite) {
        
        }

        public override void acessar() {
            acessarNavegador("Edge");
            acessarSite(website.GetType().Name);
        }
    }

    class Facebook : WebSite {
        public void acessarNavegador(string navegador) {
            Console.WriteLine(string.Format("Acessando pelo: {0}", navegador));
        }

        public void acessarSite(string url) {
            Console.WriteLine(string.Format("Url: {0}", url));
        }
    }

    class Youtube : WebSite {
        public void acessarNavegador(string navegador) {
            Console.WriteLine(string.Format("Acessando pelo: {0}", navegador));
        }

        public void acessarSite(string url) {
            Console.WriteLine(string.Format("Url: {0}", url));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Chrome(new Facebook());
            navegador.acessar();

            navegador = new Firefox(new Youtube());
            navegador.acessar();
        }
    }
}
