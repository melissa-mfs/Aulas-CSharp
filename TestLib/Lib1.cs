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

        public static void TrocarNome (Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        public static void MudarParaImpar(int[] pares)
        {
            for(int i = 0; i < pares.Length; i++)
            {
                pares[i] += 1; 
            }
        }

        public static int Encontrarnumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                    return i;
            }
            return -1;
        }

        //terminar
        public static int EncontrarPessoa(list, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                    return i;
            }
            return -1;
        }
    }

    public class Pessoa
    {
        public int Idade { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public Pessoa Clone()
        {
            return new Pessoa()
            {
                Idade = this.Idade,
                Nome = this.Nome,
                Documento = this.Documento
            };
        } 
    }

}
