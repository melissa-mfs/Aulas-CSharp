using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApagarCliente
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblcliente;
        private string strsql, strconex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsim_Click(object sender, EventArgs e)
        {
            strsql = $"delete from clientes where codcliente = '{txtcli.Text}'";
            comando = new SqlCommand(strsql, conn);
            comando.ExecuteNonQuery();
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog=locadora;integrated security=sspi";
            conn = new SqlConnection(strconex);
            conn.Open();

            tblcliente = new DataTable();

            strsql = $"select * from cliente where codcliente = {txtcodcli.Text}";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblcliente);

            if (tblcliente.Rows.Count == 1)
            {
                grupo1.Enabled = false;
                grupo2.Visible = true;

                txtcli.Text = tblcliente.Rows[0]["cliente"].ToString();
                txtendereco.Text = tblcliente.Rows[0]["endereco"].ToString();
                txtbairro.Text = tblcliente.Rows[0]["bairro"].ToString();
                txtestado.Text = tblcliente.Rows[0]["estado"].ToString();
                txtpais.Text = tblcliente.Rows[0]["pais"].ToString();
                txtdatanasc.Text = tblcliente.Rows[0]["datanasc"].ToString ();
                txtcnh.Text = tblcliente.Rows[0]["cnh"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
