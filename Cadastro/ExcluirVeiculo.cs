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

namespace Cadastro
{
    public partial class ExcluirVeiculo : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblveiculos;
        private string strsql, strconex;

        public ExcluirVeiculo()
        {
            InitializeComponent();
        }

        private void Btnsim_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = $"delete from veiculos where codveiculo = '{txtcodvei.Text}'";
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

        private void ExcluirVeiculo_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog=locadora;integrated security=sspi";
            conn = new SqlConnection(strconex);
            conn.Open();

            tblveiculos = new DataTable();

            strsql = $"select * from veiculos where codveiculo = {txtcodvei.Text}";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblveiculos);

            if (tblveiculos.Rows.Count == 1)
            {
                grupo1.Enabled = false;
                grupo2.Visible = true;

                txtmarca.Text = tblveiculos.Rows[0]["marca"].ToString();
                txtmodelo.Text = tblveiculos.Rows[0]["modelo"].ToString();
                txtcor.Text = tblveiculos.Rows[0]["cor"].ToString();
                txtplaca.Text = tblveiculos.Rows[0]["placa"].ToString();
                txtano.Text = tblveiculos.Rows[0]["ano"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
