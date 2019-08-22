using System;

namespace src
{
    abstract class DocumentoPrototype {
        protected string tipoDocumento;
        protected string nomeDocumento;
        public abstract DocumentoPrototype clone();

        public abstract void ExibirTipoDocumento();

        public string getNomeDocumento() {
            return nomeDocumento;
        }

        public void setNomeDocumento(string nomeDocumento) {
            this.nomeDocumento = nomeDocumento;
        }
    }

    class DocumentoPDF: DocumentoPrototype {
        protected DocumentoPDF(DocumentoPDF documentoPDF) {
            tipoDocumento = "pdf";
        }

        public DocumentoPDF() {
            tipoDocumento = "";
        }

        public override void ExibirTipoDocumento() {
            Console.WriteLine(string.Format("Nome: {0} Tipo: {1}", getNomeDocumento(), tipoDocumento));
        }

        public override DocumentoPrototype clone() {
            return new DocumentoPDF(this);
        }
    }

    class DocumentoDOCX: DocumentoPrototype {
        protected DocumentoDOCX(DocumentoDOCX documentoDOCX) {
            tipoDocumento = "docx";
        }

        public DocumentoDOCX() {
            tipoDocumento = "";
        }

        public override void ExibirTipoDocumento() {
            Console.WriteLine(string.Format("Nome: {0} Tipo: {1}", getNomeDocumento(), tipoDocumento));
        }

        public override DocumentoPrototype clone() {
            return new DocumentoDOCX(this);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           DocumentoPDF documentoPDF = new DocumentoPDF();

           DocumentoPrototype contrato = documentoPDF.clone();
           contrato.setNomeDocumento("contrato");
           contrato.ExibirTipoDocumento();

           DocumentoPrototype relatorioImportante = documentoPDF.clone();
           relatorioImportante.setNomeDocumento("relatorio rendimentos");
           relatorioImportante.ExibirTipoDocumento();
        }
    }
}
