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
    public partial class funcionarios : Form
    {
        private SqlConnection Conex;
        private SqlCommand comand;
        private string strsql, strconex;

        public funcionarios()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btcad_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source=(local); initial catalog=locadora;integrated security=sspi";
                Conex = new SqlConnection(strconex);
                Conex.Open();

                strsql = "insert into clientes (cliente, endereço, bairro, cidade, estado, pais, dataNasc,cnh)" +
                    "values ('" + txtcli.Text + "', '" + txtend.Text + "','" + txtbai.Text + "'," +
                    "'" + txtcid.Text + "','"+ txtest.Text+"', '"+ txtpai.Text+"','"+txtnasc.Text.Replace('-', '/') + "'," +
                    "'"+txtcnh+"')";

            }   
            catch
            {
                lblmensagem.Text = "Erro no cadastro";
            }
        }
    }
}
