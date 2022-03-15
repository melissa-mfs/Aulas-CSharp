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

namespace alterarcategoria
{
    public partial class Form1 : Form
    {

        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblcategorias;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; //Ativo
            groupBox2.Visible = false; //Invisivel
        }

        private void Btnalterar_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conn = new SqlConnection(strconex);
            conn.Open();

            tblcategorias = new DataTable();

            strsql = $"select * from categorias where codcategoria = '{txtcodcat.Text}'";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblcategorias);

            if (tblcategorias.Rows.Count == 1)
            {
                groupBox1.Enabled = false; //Desativado
                groupBox2.Visible = true; //Visivel

                txtcat.Text = tblcategorias.Rows[0]["categoria"].ToString();
                txtdesc.Text = tblcategorias.Rows[0]["descricao"].ToString();
                txtvalor.Text = tblcategorias.Rows[0]["valor"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não existe", "informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btngravar_Click(object sender, EventArgs e)
        {
            //nao preciso abrir a conexao novamente, abriu no botao alterar ja

            /*strsql = $@"update categorias set categoria='{txtcat.Text}', descricao='{txtdesc.Text}',
                            valor='{txtvalor.Text}' where codcategoria='{txtcodcat.Text}'";*/
            strsql = $@"update categorias set categoria='xxx', descricao='xxx',
                            valor='11' where codcategoria='1'";
            MessageBox.Show("Registro com sucesso", "informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; //Ativo
            groupBox2.Visible = false; //Invisivel
        }
    }
}
