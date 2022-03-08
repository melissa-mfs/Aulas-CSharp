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
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable tblcategorias;
        private string strconnex, strsql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            strsql =  $@"insert into categorias (marca, modelo, cor, placa, ano, imagem, codcatagoria) 
                    values ('Ford', 'ka', 'prata', 'xxx-1239', '2018', 'ka.jpg', '1')";
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
