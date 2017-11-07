using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace PaperPen
{
    public partial class ConsultaAnaliticaProdutos : Form
    {
        OleDbConnection conn = Conexao.abrirConexao();

        OleDbDataReader dr_Produtos;
        BindingSource bs_Produtos = new BindingSource();

        String _query;

        public ConsultaAnaliticaProdutos()
        {
            InitializeComponent();
        }
        private void carregar_grid()
        {
            dataGridView1.DataSource = null;
            _query = "SELECT Produtos.Descricao,Fornecedores.Cod_Fornecedor FROM Produtos INNER JOIN Fornecedores ON Produtos.Cod_Fornecedor = Fornecedores.Cod_Fornecedor  WHERE Descricao like '%" + textBox1.Text + "%'";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_Produtos = _dataCommand.ExecuteReader();

            if (dr_Produtos.HasRows == true)
            {
                bs_Produtos.DataSource = dr_Produtos;
                dataGridView1.DataSource = bs_Produtos;

            }
            else
            {
                MessageBox.Show("SEM REGISTROS!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            carregar_grid();
        }
    }




}
