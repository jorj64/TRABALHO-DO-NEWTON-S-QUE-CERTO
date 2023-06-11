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

namespace Login
{
    public partial class VerLivros : Form
    {
        public VerLivros()
        {
            InitializeComponent();
        }

        private void VerLivros_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Livros";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Livros Where ID_Livro = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtNLivro.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNAutor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtNEditora.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNPublicação.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Livros where Título LIKE '" + txtBookName.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Livros";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible = false;
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados serão atualizados. confirma?", "Sucesso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String Título = txtNLivro.Text;
                String Autor = txtNAutor.Text;
                String Editora = txtNEditora.Text;
                String Publicação = txtNPublicação.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update Livros set Título = '" + Título + "' , Autor = '" + Autor + "' , Editora = '" + Editora + "' , Ano_Publicação = '" + Publicação + "' where ID_Livro =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                VerLivros_Load(this, null);
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados serão deletados. Confirma?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Livros where ID_Livro =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                VerLivros_Load(this, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

