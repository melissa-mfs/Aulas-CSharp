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
        private DataTable tblclientes;
        private string strsql, strconex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsim_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = $"delete from clientes where codcliente = '{txtcodcli.Text}'";
                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();
                grupo1.Enabled = true;
                grupo2.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro ao excluir registro.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnnao_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog=locadora;integrated security=sspi";
            conn = new SqlConnection(strconex);
            conn.Open();

            tblclientes = new DataTable();

            strsql = $"select * from clientes where codcliente = {txtcodcli.Text}";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblclientes);

            if (tblclientes.Rows.Count == 1)
            {
                grupo1.Enabled = false;
                grupo2.Visible = true;

                txtcli.Text = tblclientes.Rows[0]["cliente"].ToString();
                txtendereco.Text = tblclientes.Rows[0]["endereco"].ToString();
                txtcidade.Text = tblclientes.Rows[0]["cidade"].ToString();
                txtbairro.Text = tblclientes.Rows[0]["bairro"].ToString();
                txtestado.Text = tblclientes.Rows[0]["estado"].ToString();
                txtpais.Text = tblclientes.Rows[0]["pais"].ToString();
                txtdatanasc.Text = tblclientes.Rows[0]["datanasc"].ToString ();
                txtcnh.Text = tblclientes.Rows[0]["cnh"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
