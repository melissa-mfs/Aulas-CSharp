using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Emprestimos : Form
    {
        //strings de conexão com o banco de dados
        private SqlConnection Conex;
        private SqlCommand comand;
        private string strsql, strconex;


        public Emprestimos()
        {
            InitializeComponent();
            calendEmp.TodayDate = DateTime.Today;
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            //fecha o formulário atual
            this.Close();
        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            //Limpa as txtbox
            txtcodl.Clear();
            txtcoda.Clear();
            txtdtemp.Clear();
            txtdtdev.Clear();
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
                strsql = $@"insert into Emprestimos(CodLivro, CodAmigo, DataEmprestimo, DataDevolucao)
                            values ('{txtcodl.Text}','{txtcoda.Text}','{txtdtemp.Text}','{txtdtdev.Text}');";

                //executa o comando de consulta no banco
                comand = new SqlCommand(strsql, Conex);
                comand.ExecuteNonQuery();

                //Limpa as txtbox
                txtcodl.Clear();
                txtcoda.Clear();
                txtdtemp.Clear();
                txtdtdev.Clear();

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

        private void btConsulta_Click(object sender, EventArgs e)
        {
            //Ir para tela de consultas
            var Consulta = new Consulta();
            Consulta.Show();
        }

        private void CalendEmp_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime datamintoday = DateTime.Today;
            DateTime datamin = calendEmp.SelectionRange.Start.Date;
            if (datamintoday > datamin)
            {
                MessageBox.Show("Selecione uma data a partir de Hoje","Data Inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //seleciona a data inicio e coloca no txtdtemp
                this.txtdtemp.Text = calendEmp.SelectionRange.Start.Date.ToShortDateString();
                //seleciona a data final e coloca na txtdtdev
                this.txtdtdev.Text = calendEmp.SelectionRange.End.Date.ToShortDateString();
                //Console.WriteLine($"{datamin}, {txtdtdev.Text}");
            };
        }
    }
}
