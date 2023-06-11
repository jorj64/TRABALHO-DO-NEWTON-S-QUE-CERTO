using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AddLivro : Form
    {
        public AddLivro()
        {
            InitializeComponent();
        }
        private void AddLivro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Isso irá APAGAR todos os dados que não foram salvos.", "Tem Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

            }
            this.Close();

            Dashboard.restrict = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "" && txtAutor.Text != "" && txtEditora.Text != "" && txtData.Text != "" && txtCategoria.Text != "")
            {

                String Título = txtTitulo.Text;
                String Autor = txtAutor.Text;
                String Editora = txtEditora.Text;
                String Ano_Publicação = txtData.Text;
                String Categoria = txtCategoria.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Livros (Título,Autor,Editora,Ano_Publicação,Categoria) values ('" + Título + "','" + Autor + "','" + Editora + "','" + Ano_Publicação + "','" + Categoria + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Informações Salvas.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitulo.Clear();
                txtAutor.Clear();
                txtData.Clear();
                txtEditora.Clear();
                txtCategoria.Clear();
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
