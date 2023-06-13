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
    public partial class Dashboardaluno : Form
    {
        public Dashboardaluno()
        {
            InitializeComponent();
        }

        private void emitirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo ib = new Emprestimo();
            ib.Show();
        }

        private void devoverLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverLivro DV = new DevolverLivro();
            DV.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer vazar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void verLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlivrosalunos verlivrosalunos= new verlivrosalunos();
            verlivrosalunos.Show();
        }
    }
}
