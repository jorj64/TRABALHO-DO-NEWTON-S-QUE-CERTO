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
    public partial class DevolverLivro : Form
    {
        public DevolverLivro()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Emissão where Nome ='" + txtAluno.Text + "' and Data_da_Devolução IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Este Aluno Não Existe ou Não Possui Nenhum Livro Pendente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevolverLivro_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtAluno.Clear();
        }

        String bname;
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            txtLivro.Text = bname;
            txtEmissao.Text = bdate;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update Emissão set Data_da_devolução ='" + dateTimePicker.Text + "' where Nome = '" + txtAluno.Text + "' and id =" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("O Livro Foi Devolvido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DevolverLivro_Load(this, null);
        }

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtAluno.Text == "")
            {
                panel1.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtAluno.Clear();
        }
    }
}
