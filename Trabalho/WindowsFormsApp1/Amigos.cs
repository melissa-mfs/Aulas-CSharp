using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Amigos : Form
    {
        //strings de conexão com o banco de dados
        private SqlConnection Conex;
        private SqlCommand comand;
        private string strsql, strconex;

        public Amigos()
        {
            InitializeComponent();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            //fecha o formulário atual
            this.Close();
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as txtbox
            txtnome.Clear();
            txtend.Clear();
            txtcid.Clear();
            txtbairro.Clear();
            txttel.Clear();
        }

        private void lblCodAmigo_Click(object sender, EventArgs e)
        {
            //Criar consulta no DB para atualizar o número de cadastro
        }

        private void Btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Conecta com o Banco de dados
                strconex = "data source=(local); initial catalog=LocadoraLivros;integrated security=sspi";
                Conex = new SqlConnection(strconex);
                Conex.Open();

                //faz inserção dos campos de acordo com o Banco de dados
                strsql = $@"insert into Amigos (CodAmigo, Nome, Endereco, Bairro, Cidade, Telefone)
                            values ({lblCodAmigo}, {txtnome}, {txtend}, {txtbairro}, {txtcid}, {txttel});";

                //executa o comando de consulta no banco
                comand = new SqlCommand(strsql, Conex);
                comand.ExecuteNonQuery();

            }
            catch
            {
                //colocar uma msgbox com msg de erro no cadastro
                MessageBox.Show("Cadastro não realizado", "Erro ao Cadastrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
