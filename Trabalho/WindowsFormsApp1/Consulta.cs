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

        private void btConsultaLivro_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta no Banco de dados

                short inteiro; //valor para comparar se a txtbx é só num inteiro
                tblConsulta = new DataTable();

                //executa o comando de consulta no banco

                if (Int16.TryParse(txtcodnome.Text, out inteiro))
                {
                    strsql = $@"Select Livros.CodLivro, Livros.Titulo, Amigos.CodAmigo, Amigos.Nome, 
                            Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
                            inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
                            inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
                            where Livros.Titulo like '%{txtcodnome.Text}%' 
                            or Livros.CodLivro like '%{txtcodnome.Text}%';";

                    adapter = new SqlDataAdapter(strsql, Conex);
                    adapter.Fill(tblConsulta);
                }
                else if(txtcodnome.Text =="") 
                {
                    for (int i = 0; i < dgConsulta.RowCount; i++)
                    {
                        dgConsulta.Rows[i].DataGridView.Columns.Clear();
                    }
                }
                else
                {
                    strsql = $@"Select Livros.CodLivro, Livros.Titulo, Amigos.CodAmigo, Amigos.Nome,
                            Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
                            inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
                            inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
                            where Livros.Titulo like '%{txtcodnome.Text}%';";

                    adapter = new SqlDataAdapter(strsql, Conex);
                    adapter.Fill(tblConsulta);
                }

                //mostra no datagrid
                dgConsulta.DataSource = tblConsulta;
            }
            catch
            {
                //colocar uma msgbox com msg de erro
                MessageBox.Show("Erro", "Erro ao consultar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConsultaData_Click(object sender, EventArgs e)
        {
            try
            {
                tblConsulta = new DataTable();

                //precisa inverter a data para 2022-05-24

                strsql = $@"Select Amigos.CodAmigo, Amigos.Nome, Livros.CodLivro, Livros.Titulo, 
                            Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
                            inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
                            inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
                            where DataEmprestimo like '%2022-05%' 
                            or DataDevolucao like '%2022-06%';";

                adapter = new SqlDataAdapter(strsql, Conex);
                adapter.Fill(tblConsulta);

                //mostra no datagrid
                dgConsulta.DataSource = tblConsulta;
            }
            catch
            {
                //colocar uma msgbox com msg de erro
                MessageBox.Show("Erro", "Erro ao consultar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
