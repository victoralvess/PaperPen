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
    public partial class RelatorioCadastralProdutos : Form
    {
        OleDbConnection oleDbConnection = Conexao.abrirConexao();

        OleDbDataReader oleDbDataReader;

        BindingSource bindingSourceProdutos = new BindingSource();

        String query;

        public int page = 1;
        int reg, line = 0;
        int eof = 0;

        public RelatorioCadastralProdutos()
        {
            InitializeComponent();
        }
        private void loadData()
        {

            query = "Select * from Produtos";

            OleDbCommand _dataCommand = new OleDbCommand(query, oleDbConnection);

            oleDbDataReader = _dataCommand.ExecuteReader();

            if (oleDbDataReader.HasRows == true)
            {
                bindingSourceProdutos.DataSource = oleDbDataReader;
                dataGridView.DataSource = bindingSourceProdutos;

            }
        }

        private void RelatorioCadastralProdutos_Load(object sender, EventArgs e)
        {
            loadData();
            eof = bindingSourceProdutos.Count;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow dataGridViewRow;
            dataGridViewRow = dataGridView.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);

            e.Graphics.DrawString("RELATÓRIO CADASTRAL DE PRODUTOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Gray, 280, 50);


            line = 120;


            e.Graphics.DrawString("Cód_Produto  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, line);
            e.Graphics.DrawString("Descrição   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 160, line);
            e.Graphics.DrawString("Unidade ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 300, line);
            e.Graphics.DrawString("Qtd_Estoque  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 400, line);
            e.Graphics.DrawString("Caracteristicas   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 530, line);
            e.Graphics.DrawString("Cód_Fornecedor ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 650, line);

            line = 150;

            e.Graphics.DrawLine(new Pen(Color.Red, 2), 50, 75, 800, 75);

            while ((line < 1075) & (reg != eof))
            {

                e.Graphics.DrawString(dataGridViewRow.Cells["cod_produto"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 75, line);

                e.Graphics.DrawString(dataGridViewRow.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 160, line);

                e.Graphics.DrawString(dataGridViewRow.Cells["unidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 320, line);

                e.Graphics.DrawString(dataGridViewRow.Cells["quantidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 420, line);

                e.Graphics.DrawString(dataGridViewRow.Cells["caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 530, line);

                e.Graphics.DrawString(dataGridViewRow.Cells["cod_fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 710, line);


                bindingSourceProdutos.MoveNext();

                dataGridViewRow = dataGridView.CurrentRow;

                reg += 1;

                line += 20;


                if (reg == eof)
                {
                    e.Graphics.DrawString("Total de Registros: " + reg, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1100);
                    e.Graphics.DrawLine(new Pen(Color.Red, 1), 50, 1115, 800, 1115);
                    e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 50, 1120);
                    e.Graphics.DrawString("Pág: " + page, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1120);
                }

                if (line >= 1075)
                {
                    page += 1;
                }               


                if ((page > 1) & (reg < eof))
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }                

            }

            if (reg == eof)
            {
                page = 1;
                bindingSourceProdutos.MoveFirst();
                reg = 0;
            }


        }

        private void View(object sender, EventArgs e)
        {
            printPreviewDialog1.Text = " Visualizando a impressão";
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Columns = 2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialog1.ShowDialog();
        }

        private void Print(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();   
        }

    }
}
