    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private SqlConnection Conex;
        private SqlCommand Comando;
        private string strsql, strconex;


        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            Conex = new SqlConnection(strconex);
            Conex.Open();

            strsql = "insert into categorias (categoria, descricao, valor)" +
                "values ('"+ txtcat.Text + "', '" + txtdesc.Text + "'," +
                "'" + txtdia.Text +"')";

            Comando = new SqlCommand(strsql, Conex);
            Comando.ExecuteNonQuery();

            lblmensagem.Text = "Registro gravado";



        }
    }
}
