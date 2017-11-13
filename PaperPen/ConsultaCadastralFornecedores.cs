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
    public partial class ConsultaCadastralFornecedores : Form
    {
        public ConsultaCadastralFornecedores()
        {
            InitializeComponent();
        }
        OleDbConnection conn = Conexao.abrirConexao();

        OleDbDataReader dr_Fornecedor;

        BindingSource bs_Fornecedor = new BindingSource();

        String _query;

        private void carregar_grid()
        {

            _query = "Select * from fornecedores";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_Fornecedor = _dataCommand.ExecuteReader();

            if (dr_Fornecedor.HasRows == true)
            {
                bs_Fornecedor.DataSource = dr_Fornecedor;
                dataGridView.DataSource = bs_Fornecedor;
                
            }
        }

        private void ConsultaCadastralFornecedor_Load(object sender, EventArgs e)
        {
            comboBoxPesquisar.SelectedIndex = 0;
            carregar_grid();
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPesquisar.Text == "Código do Fornecedor")
            {
               
                    _query = "Select * from fornecedores where cod_fornecedor=" + textBoxPesquisa.Text;
                
            }
            else if (comboBoxPesquisar.Text == "Razão Social")
            {
                _query = "Select * from fornecedores where razao_social like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Nome Fantasia")
            {
                _query = "Select * from fornecedores where nome_fantasia like '%" + textBoxPesquisa.Text + "%'";
            }
            else if(comboBoxPesquisar.Text == "CNPJ")
            {
                _query = "Select * from fornecedores where cnpj like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Endereço")
            {
                _query = "Select * from fornecedores where endereco like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Número")
            {
                _query = "Select * from fornecedores where numero like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Bairro")
            {
                _query = "Select * from fornecedores where bairro  like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Cidade")
            {
                _query = "Select * from fornecedores where cidade like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Telefone")
            {
                _query = "Select * from fornecedores where telefone like '%" + textBoxPesquisa.Text + "%'";
            }
            else if(comboBoxPesquisar.Text == "Nome do Contato")
            {
                _query = "Select * from fornecedores where nome_contato like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "E-mail")
            {
                _query = "Select * from fornecedores where email like '%" + textBoxPesquisa.Text + "%'";
            }
            else if (comboBoxPesquisar.Text == "Site")
            {
                _query = "Select * from fornecedores where site like '%" + textBoxPesquisa.Text + "%'";
            }
           
            textBoxPesquisa.Focus();

            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_Fornecedor = _dataCommand.ExecuteReader();
            } 
            catch (Exception ex)
            {
                _query = "Select * from fornecedores";
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_Fornecedor = _dataCommand.ExecuteReader();
            }
            if (dr_Fornecedor.HasRows == true)
            {
                bs_Fornecedor.DataSource = dr_Fornecedor;
            }
            else
            {
                MessageBox.Show("Nenhum reg encontrado com esse parâmetro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPesquisa.Clear();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dataGridView.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("fountain-pen-relatorios.PNG"), 50, 25);
            
            e.Graphics.DrawString("FICHA DO FORNECEDOR", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Gray, 300, 50);
            

            e.Graphics.DrawLine(new Pen(Color.Red, 3), 50, 75, 800, 75);
            
            e.Graphics.DrawString("CÓDIGO DO FORNECEDOR:  " + linha.Cells["cod_Fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 120);
           
            e.Graphics.DrawString("RAZÃO SOCIAL:   " + linha.Cells["Razao_Social"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 150);
            
            e.Graphics.DrawString("NOME FANTASIA: " + linha.Cells["Nome_Fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 180);

            e.Graphics.DrawString("CNPJ:  " + linha.Cells["CNPJ"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 210);

            e.Graphics.DrawString("ENDEREÇO:   " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 240);

            e.Graphics.DrawString("NÚMERO: " + linha.Cells["Numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 270);

            e.Graphics.DrawString("BAIRRO:  " + linha.Cells["Bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 300);

            e.Graphics.DrawString("CIDADE:   " + linha.Cells["Cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 330);

            e.Graphics.DrawString("TELEFONE: " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 360);

            e.Graphics.DrawString("NOME DO CONTATO:  " + linha.Cells["Nome_Contato"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 390);

            e.Graphics.DrawString("E-MAIL:   " + linha.Cells["Email"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 420);

            e.Graphics.DrawString("SITE: " + linha.Cells["Site"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Gray, 50, 450);

            e.Graphics.DrawLine(new Pen(Color.Red, 3), 50, 1100, 800, 1100);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Tomato, 550, 1125);
            e.Graphics.DrawString("Pág: 1", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Tomato, 50, 1125);

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
