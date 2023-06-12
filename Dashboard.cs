using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void verLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerLivros verLivros = new VerLivros();
            verLivros.Show();
        }

        public static int restrict = 0;

        private void adicionarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrict == 0)
            {

                restrict++;
                AddLivro abs = new AddLivro();
                abs.Show();
            }
            else
            {
                MessageBox.Show("A página já está aberta");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer vazar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void adicionarNovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarUsuário ast = new AdicionarUsuário();
            ast.Show();
        }

        private void verAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAlunos vsi = new VerAlunos();
            vsi.Show();
        }

        private void emitirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo ib = new Emprestimo();
            ib.Show();
        }

        private void devolverLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverLivro DV = new DevolverLivro();
            DV.Show();
        }

        private void informaçõesDosLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoLivros info = new InfoLivros();
            info.Show();
        }
    }
}
