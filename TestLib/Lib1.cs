using System;

namespace TestLib
{
    public class Lib1
    {
        public static void Adicionar20Void(int x)
        {
            x += 20;
        }

        public static int Adicionar20(int x)
        {
            return x + 20;
        }

        public static void TrocarNome (NamePessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
    }

    public class NamePessoa
    {
        public int Idade { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public NamePessoa Clone()
        {
            return new NamePessoa()
            {
                Idade = this.Idade,
                Nome = this.Nome,
                Documento = this.Documento
            };
        } // falta dar exemplo no botão
    }

}
