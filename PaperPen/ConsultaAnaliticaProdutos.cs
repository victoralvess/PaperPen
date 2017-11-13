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
        OleDbConnection oleDbConnection = Conexao.abrirConexao();

        OleDbDataReader oleDbDataReaderProdutos;
        BindingSource bindingSourceProdutos = new BindingSource();

        String query;

        public ConsultaAnaliticaProdutos()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            dataGridView.DataSource = null;
            query = "SELECT Produtos.Descricao,Fornecedores.Cod_Fornecedor FROM Produtos INNER JOIN Fornecedores ON Produtos.Cod_Fornecedor = Fornecedores.Cod_Fornecedor  WHERE Descricao like '%" + textBox1.Text + "%'";

            OleDbCommand _dataCommand = new OleDbCommand(query, oleDbConnection);

            oleDbDataReaderProdutos = _dataCommand.ExecuteReader();

            if (oleDbDataReaderProdutos.HasRows == true)
            {
                bindingSourceProdutos.DataSource = oleDbDataReaderProdutos;
                dataGridView.DataSource = bindingSourceProdutos;

            }
            else
            {
                MessageBox.Show("SEM REGISTROS!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Search(object sender, EventArgs e)
        {
            loadData();
        }
    }




}
