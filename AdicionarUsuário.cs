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
    public partial class AdicionarUsuário : Form
    {
        public AdicionarUsuário()
        {
            InitializeComponent();
        }

        private void AdicionarUsuário_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatrícula.Clear();
            txtEndereço.Clear();
            txtTelefone.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtMatrícula.Text != "" && txtEndereço.Text != "" && txtTelefone.Text != "")
            {

                String Nome = txtNome.Text;
                String Matrícula = txtMatrícula.Text;
                String Endereço = txtEndereço.Text;
                String Telefone = txtTelefone.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VVNLTKF\\SQLSERVER2022; database = Livraria;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Usuários (Nome,Matrícula,Endereço,Telefone) values ('" + Nome + "','" + Matrícula + "','" + Endereço + "','" + Telefone + "')";
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
}
