using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace Login
{
    public partial class VerAlunos : Form
    {
        public VerAlunos()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchE_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchE.Text != "")
            {
                txtVer.Visible = false;
                System.Drawing.Image image = System.Drawing.Image.FromFile("C:\\Users\\jonat\\Downloads\\imagens\\Liberay Management System\\PROCURANDO.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Usuários where Matrícula LIKE '" + txtSearchE.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                txtVer.Visible = true;
                System.Drawing.Image image = System.Drawing.Image.FromFile("C:\\Users\\jonat\\Downloads\\imagens\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Usuários";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void VerAlunos_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Usuários";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            cmd.CommandText = "select * from Usuários where ID_Aluno = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtNnome.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNmatrícula.Text = ds.Tables[0].Rows[0][2].ToString();
            txtNendereço.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNtelefone.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            String Nome = txtNnome.Text;
            String Matrícula = txtNmatrícula.Text;
            String Endereço = txtNendereço.Text;
            String Telefone = txtNtelefone.Text;

            if (MessageBox.Show("Os dados serão atualizados. confirma?", "Sucesso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update Usuários set Nome = '" + Nome + "', Matrícula = '" + Matrícula + "', Endereço = '" + Endereço + "', Telefone = '" + Telefone + "' where ID_Aluno = " + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            VerAlunos_Load(this, null);
        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchE.Clear();
            panel2.Visible = false;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados serão deletados. Confirma?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Usuários where ID_Aluno =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                VerAlunos_Load(this, null);
            }
        }
    }
}
