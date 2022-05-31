using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LocadoraMenu : Form
    {
        public LocadoraMenu()
        {
            InitializeComponent();
        }

        private void Btavancar_Click(object sender, EventArgs e)
        {

            if (rbtamigos.Checked == true)
            {
                var Amigos = new Amigos();
                Amigos.Show();
            }
            else if (rbtemprestimos.Checked == true)
            {
                var Emprestimos = new Emprestimos();
                Emprestimos.Show();
            }
            else
            {
                var Livros = new Livros();
                Livros.Show();
            }

        }
    }
}
