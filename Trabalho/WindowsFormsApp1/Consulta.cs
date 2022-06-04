using System;
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

        public Consulta()
        {
            InitializeComponent();
            strconex = "data source=MEI\\SQLEXPRESS;initial catalog=LocadoraLivros;integrated security=sspi";
            Conex = new SqlConnection(strconex);
            Conex.Open();
        }

        private void btConsultaLivro_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta no Banco de dados
                strsql = $@"Select ";

            }
            catch
            {
                //colocar uma msgbox com msg de erro no cadastro
            }
        }

        private void btConsultaData_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta no Banco de dados
                strsql = $@"Select ";

            }
            catch
            {
                //colocar uma msgbox com msg de erro no cadastro
            }
        }
    }
}
