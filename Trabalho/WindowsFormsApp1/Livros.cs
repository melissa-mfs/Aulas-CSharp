using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Livros : Form
    {
        //strings de conexão com o banco de dados
        private SqlConnection Conex;
        private SqlCommand comand;
        private string strsql, strconex;

        public Livros()
        {
            InitializeComponent();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtCodLivro.Clear();
            txteditora.Clear();
            txttitulo.Clear();
            txtautor.Clear();
        }

        private void Btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Conecta com o Banco de dados
                strconex = "data source=MEI\\SQLEXPRESS;initial catalog=LocadoraLivros;integrated security=sspi";
                Conex = new SqlConnection(strconex);
                Conex.Open();

                //faz inserção dos campos de acordo com o Banco de dados
                strsql = $@"insert into Livros(CodLivro, Titulo, Autor, Editora)
                            values ('{txtCodLivro.Text}','{txttitulo.Text}','{txtautor.Text}','{txteditora.Text}');";

                //executa o comando de consulta no banco
                comand = new SqlCommand(strsql, Conex);
                comand.ExecuteNonQuery();

                //limpa as txtbx
                txtCodLivro.Clear();
                txteditora.Clear();
                txttitulo.Clear();
                txtautor.Clear();

                //colocar uma msgbox com msg de Sucesso
                MessageBox.Show("Cadastro realizado com Sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                //colocar uma msgbox com msg de erro no cadastro
                MessageBox.Show("Cadastro não realizado","Erro ao Cadastrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
