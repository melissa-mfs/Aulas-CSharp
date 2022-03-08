using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class veiculos : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable tblcategorias;
        private SqlCommand comando;
        private string strconnex, strsql;

        public veiculos()
        {
            InitializeComponent();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            strsql = $@"insert into veiculos (marca, modelo, cor, placa, ano, imagem, codcategoria) 
                    values ('{txtmarca.Text}', '{txtmodelo.Text}', '{txtcor.Text}', '{txtplaca.Text}', 
                            '{txtano.Text}', '{txtimg.Text}', '{chococategoria.SelectedValue}')";
            // problema com o codcategoria, não converte o varchar para int

            comando = new SqlCommand(strsql, conn);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro gravado", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Chococategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcodcategoria.Text = chococategoria.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strconnex = "data source=(local);initial catalog =locadora;integrated security=sspi";
            conn = new SqlConnection(strconnex);
            conn.Open();

            tblcategorias = new DataTable();

            strsql = "select * from categorias";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblcategorias);

            chococategoria.DataSource = tblcategorias;
            chococategoria.DisplayMember = "categoria"; //pesquisar
            chococategoria.ValueMember = "codcategoria"; //pesquisar

            lblcodcategoria.Text = chococategoria.SelectedValue.ToString();
        }
    }
}
