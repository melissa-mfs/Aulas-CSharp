using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace locadpranoite
{
    public partial class Form1 : Form
    {
        //Declaração de objetos
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable tblfuncionarios;
        private string strsql, strconn;
           

        public Form1()
        {
            InitializeComponent();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnenter_Click(object sender, EventArgs e)
        {
            strconn = "data source=(local); initial catalog = locadora; integrated security=sspi";
            conn = new SqlConnection(strconn);
            conn.Open();

            tblfuncionarios = new DataTable();

            strsql = "select * from funcionarios where usuario = '" + txtuser.Text + "'and senha = '" + txtpasswd.Text + "';";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblfuncionarios);

            if (tblfuncionarios.Rows.Count >= 1)
            {
                lblresposta.Text = "Seja Bem-Vindo!";
            }
            else
            {
                lblresposta.Text = "Erro de Login. Tente novamente.";
            }

        }
    }
}
