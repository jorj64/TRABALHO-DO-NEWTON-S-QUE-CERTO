using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Título from Livros", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    ComboBoxLivro.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
            con.Close();
        }
        int count;
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtMatrícula.Text != "")
            {
                String eid = txtMatrícula.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Usuários where Matrícula = '" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtNome.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtEndereço.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtTelefone.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    txtNome.Clear();
                    txtEndereço.Clear();
                    txtTelefone.Clear();
                    MessageBox.Show("Matrícula Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEfetuar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (ComboBoxLivro.SelectedIndex != -1 && count <= 2)
                {
                    String Nome = txtNome.Text;
                    String Telefone = txtTelefone.Text;
                    String Endereço = txtEndereço.Text;
                    String Livro = ComboBoxLivro.Text;
                    String Data_da_emissão = DataTimePicker.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into Emissão (Nome,Telefone,Endereço,Livro, Data_da_emissão) values ('" + Nome + "','" + Telefone + "','" + Endereço + "','" + Livro + "','" + Data_da_emissão + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Os dados foram salvos", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por Favor, Preencha Todos os Espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatrícula.Clear();
            txtEndereço.Clear();
            txtTelefone.Clear();
            
        }
    }
}
