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
    public partial class RelatorioCadastralFornecedores : Form
    {
        OleDbConnection oleDbConnection = Conexao.abrirConexao();

        OleDbDataReader dataReader;

        BindingSource bindingSource = new BindingSource();

        String query;

        public int page = 1;
        int reg, line = 0;
        int end = 0;

        public RelatorioCadastralFornecedores()
        {
            InitializeComponent();
        }

        private void RelatorioCadastralFornecedores_Load(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.Landscape = true;
            getData();
            end = bindingSource.Count;
        }

        private void getData()
        {
            query = "Select * from fornecedores";

            OleDbCommand _dataCommand = new OleDbCommand(query, oleDbConnection);

            dataReader = _dataCommand.ExecuteReader();

            if (dataReader.HasRows == true)
            {
                bindingSource.DataSource = dataReader;
                dataGridView.DataSource = bindingSource;

            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bindingSource.MoveFirst();
            DataGridViewRow reg_grid;
            reg_grid = dataGridView.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);

            e.Graphics.DrawString("RELATÓRIO CADASTRAL DE FORNECEDORES", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Gray, 280, 50);


            line = 120;


            e.Graphics.DrawString("Código", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 30, line);
            e.Graphics.DrawString("Razão Social", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 95, line);
            e.Graphics.DrawString("Nome Fantasia", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 320, line);
            e.Graphics.DrawString("CNPJ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 430, line);
            e.Graphics.DrawString("Endereço", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 560, line);
            e.Graphics.DrawString("nº", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 750, line);
            e.Graphics.DrawString("Telefone", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 790, line);
            e.Graphics.DrawString("Contato", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 890, line);
            e.Graphics.DrawString("E-mail", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 980, line);


            line = 150;

            e.Graphics.DrawLine(new Pen(Color.Red, 3), 30, 95, 1100, 95);

            while ((line < 1075) & (reg != end))
            {

                e.Graphics.DrawString(reg_grid.Cells["cod_fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 30, line);

                e.Graphics.DrawString(reg_grid.Cells["razao_social"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 95, line);

                e.Graphics.DrawString(reg_grid.Cells["nome_fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 320, line);

                e.Graphics.DrawString(reg_grid.Cells["cnpj"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 430, line);

                e.Graphics.DrawString(reg_grid.Cells["endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 560, line);

                e.Graphics.DrawString(reg_grid.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 750, line);

                e.Graphics.DrawString(reg_grid.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 790, line);

                e.Graphics.DrawString(reg_grid.Cells["nome_contato"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 890, line);

                e.Graphics.DrawString(reg_grid.Cells["email"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Gray, 980, line);




                bindingSource.MoveNext();

                reg_grid = dataGridView.CurrentRow;

                reg += 1;

                line += 20;
                
                if (reg == end)
                {
                    
                    e.Graphics.DrawString("Total de Registros: " + reg, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Tomato, 1000, 745);
                    e.Graphics.DrawLine(new Pen(Color.Red, 3), 10, 760, 1100, 760);
                    e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Tomato, 50, 765);
                    e.Graphics.DrawString("Pág: " + page, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Tomato, 1000, 765); 
                    page += 1;
                }

                if (line >= 1075)
                {
                    page += 1;
                }   
               

                if ((page > 1) & (reg < end))
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    page = 1;
                }
            }

            if (reg == end)
            {
                page = 1;
                bindingSource.MoveFirst();
                reg = 0;
            }
        }

        private void View(object sender, EventArgs e)
        {
            printPreviewDialog.Text = "Visualizando a impressão";
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.PrintPreviewControl.Columns = 2;
            printPreviewDialog.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialog.ShowDialog();
        }

        private void Print(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
            printDocument.Print(); 
        }
    }
}
