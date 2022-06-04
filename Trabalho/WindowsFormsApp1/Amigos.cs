using System;
using System.Data;
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
        private SqlDataAdapter adapter;
        private DataTable tblCodAmigo;
        private string consulta;


        public Amigos()
        {
            InitializeComponent();

            //Conecta com o Banco de dados
            strconex = "data source=MEI\\SQLEXPRESS;initial catalog=LocadoraLivros;integrated security=sspi";
            Conex = new SqlConnection(strconex);
            Conex.Open();

            lblCodAmigo.Text = ConsultaCodAmigo();
        }

        public string ConsultaCodAmigo()
        {
                //Criar consulta no DB para atualizar o número de cadastro
                try
                {
                    string db;
                    int add;

                    //faz busca dos campos de acordo com o Banco de dados
                    strsql = $@"Select CodAmigo from Amigos where CodAmigo = (select max(CodAmigo) from Amigos);";

                    //executa o comando de consulta no banco

                    tblCodAmigo = new DataTable();

                    adapter = new SqlDataAdapter(strsql, Conex);
                    adapter.Fill(tblCodAmigo);

                    if (tblCodAmigo.Rows.Count == 1)
                    {
                        db = tblCodAmigo.Rows[0]["CodAmigo"].ToString();//filtra da tabela o valor
                        add = Int16.Parse(db) + 1;//converte para int e add +1
                        consulta = add.ToString();
                    }

                    return consulta;
                }
                catch
                {
                    return "Não foi possível";
                }
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

        private void Btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //faz inserção dos campos de acordo com o Banco de dados
                strsql = $@"insert into Amigos (CodAmigo, Nome, Endereco, Bairro, Cidade, Telefone)
                            values ('{lblCodAmigo.Text}','{txtnome.Text}', '{txtend.Text}', 
                                    '{txtbairro.Text}', '{txtcid.Text}', '{txttel.Text}');";

                //executa o comando de consulta no banco
                comand = new SqlCommand(strsql, Conex);
                comand.ExecuteNonQuery();

                //Limpa as txtbox
                txtnome.Clear();
                txtend.Clear();
                txtcid.Clear();
                txtbairro.Clear();
                txttel.Clear();

                lblCodAmigo.Text = ConsultaCodAmigo();

                //colocar uma msgbox com msg de Sucesso
                MessageBox.Show("Cadastro realizado com Sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
