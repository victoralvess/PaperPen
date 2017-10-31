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
    public partial class CrudProdutos : Form
    {
        OleDbConnection conn = Conexao.abrirConexao();
        OleDbDataReader dataReader;
        BindingSource bindingSource = new BindingSource();

        public CrudProdutos()
        {
            InitializeComponent();
            getProdutos();
        }

        private void getProdutos()
        {
            String query = "select * from produtos";
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            dataReader = oleDbCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                bindingSource.DataSource = dataReader;
                dataGridViewProdutos.DataSource = bindingSource;
                query = "SELECT cod_fornecedor FROM fornecedores";
                OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(query, conn));
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                comboBoxFornecedor.DataSource = ds.Tables[0];
                comboBoxFornecedor.DisplayMember = "cod_fornecedor";
                comboBoxFornecedor.ValueMember = "cod_fornecedor";
            }
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from produtos where descricao like '%" + textBoxPesquisar.Text + "%'";
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                bindingSource.DataSource = dataReader;
                setData();
            }
        }

        private void setData()
        {
            textBoxCod.DataBindings.Add("Text", bindingSource, "cod_produto");
            textBoxCod.DataBindings.Clear();

            textBoxDescricao.DataBindings.Add("Text", bindingSource, "descricao");
            textBoxDescricao.DataBindings.Clear();

            textBoxUnidade.DataBindings.Add("Text", bindingSource, "unidade");
            textBoxUnidade.DataBindings.Clear();

            textBoxQtdEstoque.DataBindings.Add("Text", bindingSource, "quantidade");
            textBoxQtdEstoque.DataBindings.Clear();

            textBoxCaracteristicas.DataBindings.Add("Text", bindingSource, "caracteristicas");
            textBoxCaracteristicas.DataBindings.Clear();

            comboBoxFornecedor.DataBindings.Add("Text", bindingSource, "cod_fornecedor");
            comboBoxFornecedor.DataBindings.Clear();
        }

        private void dataGridViewProdutos_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void dataGridViewProdutos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setData();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            String query = "insert into produtos (descricao, unidade, quantidade, caracteristicas, cod_fornecedor) values('" + textBoxDescricao.Text + "','"
               + textBoxUnidade.Text + "','"
               + textBoxQtdEstoque.Text + "','"
               + textBoxCaracteristicas.Text + "','"
               + comboBoxFornecedor.SelectedValue + "');";
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.RecordsAffected == 1)
            {
                getProdutos();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            String query = "update produtos set descricao='" + textBoxDescricao.Text + "', quantidade='"
                  + textBoxQtdEstoque.Text + "',unidade='"
                  + textBoxUnidade.Text + "',caracteristicas='"
                  + textBoxCaracteristicas.Text + "',cod_fornecedor='"
                  + comboBoxFornecedor.SelectedValue + "' where cod_produto=" + textBoxCod.Text + ";";
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.RecordsAffected == 1)
            {
                getProdutos();
                bindingSource.Position = bindingSource.Count - 1;
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            String query = "delete from produtos where cod_produto=" + textBoxCod.Text;
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            dataReader = oleDbCommand.ExecuteReader();
            if (dataReader.RecordsAffected == 1)
            {
                getProdutos();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDescricao.Text = "";
            textBoxQtdEstoque.Text = "";
            textBoxUnidade.Text = "";
            textBoxCaracteristicas.Text = "";
            comboBoxFornecedor.SelectedIndex = 0;
            textBoxCod.Text = "";
        }
    }
}
