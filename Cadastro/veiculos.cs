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

        private void Btfonte_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            gb1.Font = fontDialog1.Font;
            gb1.ForeColor = fontDialog1.Color;

            btncadastrar.ForeColor = fontDialog1.Color;
            btnlimpar.ForeColor = fontDialog1.Color;
            btncadastrar.Font = fontDialog1.Font;
            btnlimpar.Font = fontDialog1.Font;
        }

        private void Btcores_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void Btabririmg_Click(object sender, EventArgs e)
        {
           int i, tamanho, pos=0;
            string nomeararq;

            openFileDialog1.ShowDialog();
            nomeararq = openFileDialog1.FileName;
            tamanho = nomeararq.Length;

            for(i = tamanho - 1; i >= 0; --i)
            {
                if (nomeararq[i] == '\\')
                {
                    pos = i + 1;
                    break;
                }
            }

            nomeararq = nomeararq.Substring(pos, tamanho - pos);
            txtimg.Text = nomeararq;
            picimg.Load(Application.StartupPath + "\\IMG\\"+nomeararq);
            txtimg.Enabled = false

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
