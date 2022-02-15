using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace locadpranoite
{
    public partial class Form2 : Form
    {

        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable tblveiculos;
        private string strsql, strconn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Btnpesquisa_Click(object sender, EventArgs e)
        {
            strconn = "data source=(local); initial catalog = locadora; integrated security=sspi";
            conn = new SqlConnection(strconn);
            conn.Open();

            tblveiculos = new DataTable();

            strsql = "select * from veiculos where marca = '" + txtpesquisa.Text + "';";
            adapter = new SqlDataAdapter(strsql, conn);
            adapter.Fill(tblveiculos);

            pnlpesquisa.Datasource = tblveiculos; //erro na class datasource

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
