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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
                Conex = new SqlConnection(strconex);
                Conex.Open();

                strsql = "insert into categorias (categoria, descricao, valor)" +
                    "values ('" + txtcat.Text + "', '" + txtdesc.Text + "'," +
                    "'" + txtdia.Text.Replace(',', '.') + "')";

                Comando = new SqlCommand(strsql, Conex);
                Comando.ExecuteNonQuery();

                lblmensagem.Text = "Registro Gravado";
                txtcat.Clear();
                txtdesc.Clear();
                txtdia.Clear();
            }
            catch
            {
                lblmensagem.Text="Erro ao Gravar Registro";
            }
        }
    }
}
