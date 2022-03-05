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
            NamePessoa p1 = new NamePessoa(); // inicializa a classe
            string antigo = "Mei";


            p1.Nome = antigo;
            p1.Idade = 20;
            p1.Documento = "1234";

            Lib1.TrocarNome(p1, "Melissa");

            label1.Text = $"Nome antigo: {antigo}, Novo: {p1.Nome} ";
            
            /*
            BTN 4
            
            NamePessoa p1 = new NamePessoa(); // inicializa a classe
            string antigo = "Mei";

            p1.Nome = antigo;
            p1.Idade = 20;
            p1.Documento = "1234";

            NamePessoa p2 = Lib1.Clone(p1);

            label1.Text = $"P1 nome: {p1.nome} \n P2 nome:{p2.nome}"*/
        } // Label = Antigo: Mei Novo: Melissa
    }
}
