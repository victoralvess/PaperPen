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
    public partial class ConsultaCadastralProdutos : Form
    {
        public ConsultaCadastralProdutos()
        {
            InitializeComponent();
        }
        OleDbConnection conn = Conexao.abrirConexao();

        OleDbDataReader dr_Produtos;

        BindingSource bs_Produtos = new BindingSource();

        String _query;

        private void carregar_grid()
        {

            _query = "Select * from Produtos";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_Produtos = _dataCommand.ExecuteReader();

            if (dr_Produtos.HasRows == true)
            {
                bs_Produtos.DataSource = dr_Produtos;
                dataGridView.DataSource = bs_Produtos;

            }
            else
            {
                MessageBox.Show("Não temos Produtos cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConsultaCadastralProdutos_Load(object sender, EventArgs e)
        {
            comboBoxPesquise.SelectedIndex = 0;
            carregar_grid();
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPesquise.Text == "Código do Produto")
            {
                _query = "Select * from Produtos where Cod_Produto=" + textBoxPesquise.Text;
            }
            else if (comboBoxPesquise.Text == "Descrição")
            {
                _query = "Select * from Produtos where Descricao like '%" + textBoxPesquise.Text + "%'";
            }
            else if (comboBoxPesquise.Text == "Unidade")
            {
                _query = "Select * from Produtos where Unidade like '%" + textBoxPesquise.Text + "%'";
            }
            else if (comboBoxPesquise.Text == "Quantidade no Estoque")
            {
                _query = "Select * from Produtos where quantidade like '%" + textBoxPesquise.Text + "%'";
            }
            else if (comboBoxPesquise.Text == "Características") 
            {
                _query = "Select * from Produtos where Caracteristicas like '%" + textBoxPesquise.Text + "%'";
            }
            else if (comboBoxPesquise.Text == "Código do Fornecedor") 
            {
                _query = "Select * from Produtos where Cod_Fornecedor like '%" + textBoxPesquise.Text + "%'";
            }

            textBoxPesquise.Focus();
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_Produtos = _dataCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                _query = "Select * from produtos";
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_Produtos = _dataCommand.ExecuteReader();
            }
            if (dr_Produtos.HasRows == true)
            {
                bs_Produtos.DataSource = dr_Produtos;
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado com esse parâmetro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPesquise.Clear();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dataGridView.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);

            e.Graphics.DrawString("FICHA DO PRODUTO", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Gray, 300, 50);

            e.Graphics.DrawLine(new Pen(Color.Red, 3), 50, 75, 800, 75);

            e.Graphics.DrawString("CÓDIGO DO PRODUTO:  " + linha.Cells["Cod_Produto"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 120);

            e.Graphics.DrawString("DESCRIÇÃO:   " + linha.Cells["Descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 150);

            e.Graphics.DrawString("UNIDADE: " + linha.Cells["Unidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 180);

            e.Graphics.DrawString("QUANTIDADE NO ESTOQUE:  " + linha.Cells["quantidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 210);

            e.Graphics.DrawString("CARACTERÍSTICAS:   " + linha.Cells["Caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 240);

            e.Graphics.DrawString("CÓDIGO DO FORNECEDOR: " + linha.Cells["Cod_Fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 270);
                        
            e.Graphics.DrawLine(new Pen(Color.Red, 3), 50, 1100, 800, 1100);
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Text = "Visualizando a impressão";
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Columns = 2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialog1.ShowDialog();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void Selecionados_Click(object sender, EventArgs e)
        {
            int quantidade = dataGridView.SelectedRows.Count;
            MessageBox.Show("Quantidade: " + quantidade, "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
