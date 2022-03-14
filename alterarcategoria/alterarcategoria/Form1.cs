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
            Conex = new SqlConnection(strconex);
            Conex.Open();



            groupBox1.Enabled = false; //Desativado
            groupBox2.Visible = true; //Visivel
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; //Ativo
            groupBox2.Visible = false; //Invisivel
        }
    }
}
