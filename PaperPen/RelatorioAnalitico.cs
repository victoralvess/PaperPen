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
    public partial class RelatorioAnalitico : Form
    {
        public RelatorioAnalitico()
        {
            InitializeComponent();
        }

        OleDbConnection oleDbConnection = Conexao.abrirConexao();

        OleDbDataReader oleDbDataReader;

        BindingSource bindingSource = new BindingSource();

        String query;

        public int page = 1, pageProd = 1;
        int reg, line = 0 , column=0;
        int eof = 0;
        String previous = "";

        DataGridViewRow reg_grid_forn;
        DataGridViewRow reg_grid_prod;

        private void loadData()
        {

            query = "SELECT Fornecedores.Cod_Fornecedor,Produtos.Descricao FROM  Produtos INNER JOIN Fornecedores ON Fornecedores.Cod_Fornecedor = Produtos.Cod_Fornecedor  order by Fornecedores.Cod_Fornecedor ";

            OleDbCommand _dataCommand = new OleDbCommand(query, oleDbConnection);

            oleDbDataReader = _dataCommand.ExecuteReader();

            if (oleDbDataReader.HasRows == true)
            {
                bindingSource.DataSource = oleDbDataReader;
                dataGridView.DataSource = bindingSource;
                
            }
        }

        private void RelatorioAnalitico_Load(object sender, EventArgs e)
        {
            loadData();
            eof = bindingSource.Count;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "Fornecedor")
            {
                query = "SELECT Fornecedores.Cod_Fornecedor,Produtos.Descricao FROM  Produtos INNER JOIN Fornecedores ON Fornecedores.Cod_Fornecedor = Produtos.Cod_Fornecedor  order by Fornecedores.Cod_Fornecedor";

            }
            else if (comboBox.Text == "Produtos")
            {
                query = "SELECT Produtos.Descricao,Fornecedores.Cod_Fornecedor FROM Produtos INNER JOIN Fornecedores ON Produtos.Cod_Fornecedor = Fornecedores.Cod_Fornecedor  order by Produtos.Descricao";
            }
            OleDbCommand _dataCommand = new OleDbCommand(query, oleDbConnection);
            oleDbDataReader = _dataCommand.ExecuteReader();
            if (oleDbDataReader.HasRows == true)
            {
                bindingSource.DataSource = oleDbDataReader;
            }
            else
            {
                MessageBox.Show("Nenhum reg compativel encontrado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void printDoc(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);

            e.Graphics.DrawString("RELATÓRIO ANALITICO DE FORNECEDORES", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Gray, 280, 50);
                
            line = 100;
            column = 50;
            
            if (page == 1)
            {
                reg_grid_forn = dataGridView.CurrentRow;
            }

             while (reg != eof)
            {
                 
                 if (!previous.Equals(reg_grid_forn.Cells["Cod_Fornecedor"].Value.ToString()))
                {
                    reg_grid_forn = dataGridView.CurrentRow;
                    e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, line, 800, line);
                    e.Graphics.DrawString("Código do Fornecedor = " + reg_grid_forn.Cells["Cod_Fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 15, FontStyle.Bold), Brushes.Gray, column, line);
                    line += 25;
                    e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, line, 800, line);
                    line += 15;
                    e.Graphics.DrawString("Descrição do Produto", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Red, column, line);
                    line += 35;
                }
                

                previous = reg_grid_forn.Cells["Cod_Fornecedor"].Value.ToString();  

                e.Graphics.DrawString(reg_grid_forn.Cells["Descricao"].Value.ToString(), new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, 50, line);
                
                line += 30;


                bindingSource.MoveNext();
                reg++;
                reg_grid_forn = dataGridView.CurrentRow;
                 line += 20;
                 if (line > 1000)
                 {
                     if (reg != eof)
                     {
                         page += 1;
                         e.HasMorePages = true;
                         return;
                     }
                 }
                 else {
                     e.HasMorePages = false; 
                 }

                if (reg == eof)
                {
                    e.Graphics.DrawString("Total de Registros: " + reg, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1100);
                    e.Graphics.DrawLine(new Pen(Color.Red, 1), 50, 1115, 800, 1115);
                    e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 50, 1120);
                    e.Graphics.DrawString("Pág: " + page, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1120);
                }    

                
            }


             if (reg == eof)
             {
                 page = 1;
                 bindingSource.MoveFirst();
                 reg = 0;
             }
           
             e.Graphics.DrawLine(new Pen(Color.Red, 2), 30,1115 , 800, 1115);

        }

        private void PrintDocProducts(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pageProd == 1)
            {
                reg_grid_prod = dataGridView.CurrentRow;
            }

            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);

            e.Graphics.DrawString("RELATÓRIO ANALITICO DE PRODUTOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Gray, 280, 50);

            line = 100;
            column = 50;


            while (reg != eof)
            {

                if (!previous.Equals(reg_grid_prod.Cells["Descricao"].Value.ToString()))
                {

                    e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, line, 800, line);
                    e.Graphics.DrawString("Descrição do Produto = " + reg_grid_prod.Cells["Descricao"].Value.ToString(), new System.Drawing.Font("Arial", 15, FontStyle.Bold), Brushes.Gray, column, line);
                    line += 25;
                    e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, line, 800, line);
                    line += 15;
                    e.Graphics.DrawString("Código do Fornecedor", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Red, column, line);
                    line += 35;
                }
                previous = reg_grid_prod.Cells["Descricao"].Value.ToString();




                e.Graphics.DrawString(reg_grid_prod.Cells["Cod_Fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, 50, line);

                line += 30;


                bindingSource.MoveNext();
                reg++;
                reg_grid_prod = dataGridView.CurrentRow;
                line += 20;

                if (line > 1000)
                {
                    if (reg != eof)
                    {
                        pageProd += 1;
                        e.HasMorePages = true;
                        return;
                    }
                }
                else
                {
                    e.HasMorePages = false;
                }

                if (reg == eof)
                {
                    e.Graphics.DrawString("Total de Registros: " + reg, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1100);
                    e.Graphics.DrawLine(new Pen(Color.Red, 1), 50, 1115, 800, 1115);
                    e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 50, 1120);
                    e.Graphics.DrawString("Pág: " + page, new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 550, 1120);
                }


            }


            if (reg == eof)
            {
                pageProd = 1;
                bindingSource.MoveFirst();
                reg = 0;
            }
           
            e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, 1115, 800, 1115);
        }

        private void View(object sender, EventArgs e)
        {
            if (comboBox.Text == "Fornecedor")
            {
                printPreviewDialog1.Text = " Visualizando a impressão";
                printPreviewDialog1.WindowState = FormWindowState.Maximized;
                printPreviewDialog1.PrintPreviewControl.Columns = 2;
                printPreviewDialog1.PrintPreviewControl.Zoom = 0.6;
                printPreviewDialog1.ShowDialog();

            }

            if (comboBox.Text == "Produtos")
            {
                printPreviewDialog2.Text = " Visualizando a impressão";
                printPreviewDialog2.WindowState = FormWindowState.Maximized;
                printPreviewDialog2.PrintPreviewControl.Columns = 2;
                printPreviewDialog2.PrintPreviewControl.Zoom = 0.6;
                printPreviewDialog2.ShowDialog();
            }

            
        }

        private void Print(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print(); 
        }

        
    }
}
