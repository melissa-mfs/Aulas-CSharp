using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Consulta : Form
    {
        //strings de conexão com o banco de dados
        private SqlConnection Conex;
        private SqlCommand comand;
        private string strsql, strconex;
        private SqlDataAdapter adapter;
        private DataTable tblConsulta;

        private void btConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta no Banco de dados
                strsql = $@"Select Amigos.CodAmigo, Amigos.Nome, Livros.CodLivro, Livros.Titulo, 
                            Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
                            inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
                            inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
                            where Livros.Titulo like '%{txtcodnome.Text}%' 
                            or Livros.CodLivro = '{txtcodnome.Text}';";

                //executa o comando de consulta no banco

                tblConsulta = new DataTable();

                adapter = new SqlDataAdapter(strsql, Conex);
                adapter.Fill(tblConsulta);

                if (tblConsulta.Rows.Count == 1)
                {
                    dgConsulta.DataSource = tblConsulta.Rows[0]["CodAmigo"].ToString();
                }
            }
            catch
            {
                //colocar uma msgbox com msg de erro no cadastro
            }
        }

        public Consulta()
        {
            InitializeComponent();
            strconex = "data source=MEI\\SQLEXPRESS;initial catalog=LocadoraLivros;integrated security=sspi";
            Conex = new SqlConnection(strconex);
            Conex.Open();
        }
    }
}
