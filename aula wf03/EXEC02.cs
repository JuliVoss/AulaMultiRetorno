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

namespace aula_wf03
{
    public partial class EXEC02 : Form
    {
        public EXEC02()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit(1);
        }

        private void EXEC02_Load(object sender, EventArgs e)
        {
            dgProduto.Columns.Add("FornecedorCol", "Fornecedor");
            dgProduto.Columns["FornecedorCol"].Width = 130;
            AtualizaDG();
        }

        private void AtualizaDG()
        {
            dgProduto.Rows.Clear();// limpa o dataGrid
            string select = "SELECT * from dbo.Mercado";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = {dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgProduto.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                //add
                string insert = $"INSERT into dbo.Mercado(Nome, Preco, Fornecedor) values ('{txtNome.Text}', {txtPreco.Text}, '{txtFornecedor.Text}')";
                DBFunction.Executa(insert);
                AtualizaDG();
            }
            else if (checkRemover.Checked)
            {
                //remove
                string revome = $"DELETE from dbo.Mercado WHERE idMercado = '{txtNome.Text}'";
                DBFunction.Executa(revome); 
                AtualizaDG();
            }
            else
            {
                MessageBox.Show("Por Favor, marque o que desejas fazer");
            }
            txtNome.Clear();
            txtPreco.Clear();
            txtFornecedor.Clear();
        }

        private void checkAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                checkRemover.Checked = false;
                lblNome.Text = "Nome";
                txtPreco.Visible = true;
                txtFornecedor.Visible = true;
                lblPreco.Visible = true;
                lblFornecedor.Visible = true;
            }
        }

        private void checkRemover_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRemover.Checked)
            {
                checkAdd.Checked = false;
                lblNome.Text = "Id";
                txtPreco.Visible = false;
                txtFornecedor.Visible = false;
                lblPreco.Visible = false;
                lblFornecedor.Visible = false;
            }
        }
    }
}
