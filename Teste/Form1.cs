using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;

            Lib1.Adicionar20Void(a);

            label1.Text = $"Valor: {a}";
        } //label = 2

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 2;

            a = Lib1.Adicionar20(a);

            label1.Text = $"Valor: {a}";
        } //label = 22

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa(); // inicializa a classe
            string antigo = "Mei";


            p1.Nome = antigo;
            p1.Idade = 20;
            p1.Documento = "1234";

            Lib1.TrocarNome(p1, "Melissa");

            label1.Text = $"Nome antigo: {antigo}, Novo: {p1.Nome} ";
        } // Label = Antigo: Mei Novo: Melissa

        private void button4_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa(); // inicializa a classe
            string antigo = "Mei";

            p1.Nome = antigo;
            p1.Idade = 20;
            p1.Documento = "1234";

            Pessoa p2 = p1.Clone();

            label1.Text = $"P1 nome: {p1.Nome} \n P2 nome:{p2.Nome}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pares = new int[] { 0, 2, 4, 6, 8 };

            Lib1.MudarParaImpar(pares);

            label1.Text = $"Impares: {string.Join(",", pares)}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[] { 0, 2, 4, 6, 8 };

            var numero = int.Parse(textBox1.Text);
            var idxEncontrado = Lib1.Encontrarnumero(numeros, numero);

            if(idxEncontrado >= 0)
            {
                label1.Text = $"Posição:{idxEncontrado}";
            }
            else
            {
                label1.Text = "Número não encontrado";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Ricardo"},
                new Pessoa(){Nome = "José"},
                new Pessoa(){Nome = "Rodrigo"},
                new Pessoa(){Nome = "Day"},
                new Pessoa(){Nome = "Carol"},
            };

            var nome = textBox2.Text;
        }
    }
}
