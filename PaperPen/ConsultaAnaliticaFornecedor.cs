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
    public partial class ConsultaAnaliticaFornecedor: Form
    {
        OleDbConnection conn = Conexao.abrirConexao();

        OleDbDataReader dr_Fornecedor;
        BindingSource bs_Fornecedor = new BindingSource();

        String _query;

        public ConsultaAnaliticaFornecedor()
        {
            InitializeComponent();
        }
        private void carregar_grid()
        {
            dataGridView1.DataSource = null;
            _query = "SELECT fornecedores.cod_fornecedor,Produtos.Descricao FROM  Produtos INNER JOIN fornecedores ON fornecedores.cod_fornecedor = Produtos.Cod_Fornecedor  WHERE fornecedores.cod_fornecedor like '%" + textBox1.Text + "%'";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_Fornecedor = _dataCommand.ExecuteReader();

            if (dr_Fornecedor.HasRows == true)
            {
                bs_Fornecedor.DataSource = dr_Fornecedor;
                dataGridView1.DataSource = bs_Fornecedor;

            }
            else
            {
                MessageBox.Show("SEM REGISTROS!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

          private void Consultar_Click_1(object sender, EventArgs e)
        {
            carregar_grid();
        }
    }




}



