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
    public partial class CrudFornecedores : Form
    {
        OleDbConnection oleDbConnection = Conexao.abrirConexao();
        OleDbDataReader dataReader;
        BindingSource bindingSource = new BindingSource();

        public CrudFornecedores()
        {
            InitializeComponent();
            getFornecedores();
        }

        private void getFornecedores()
        {
            String query = "select * from fornecedores";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            dataReader = oleDbCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                bindingSource.DataSource = dataReader;
                dataGridViewFornecedores.DataSource = bindingSource;                
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            String query = "insert into fornecedores (razao_social, nome_fantasia, cnpj, endereco, numero, bairro, cidade, telefone, nome_contato, email, site) values('" + textBoxRazaoSocial.Text + "','"
               + textBoxNomeFantasia.Text + "','"
               + maskedTextBoxCNPJ.Text + "','"
               + textBoxEndereco.Text + "','"
               + textBoxNumero.Text + "','"
               + textBoxBairro.Text + "','"
               + textBoxCidade.Text + "','"
               + maskedTextBoxTelefone.Text + "','"
               + textBoxResponsavelLinha.Text + "','"
               + textBoxEmail.Text + "','"
               + textBoxSite.Text + "');";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.RecordsAffected == 1)
            {
                getFornecedores();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from fornecedores where nome_fantasia like '%" + textBoxPesquisar.Text + "%'";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                bindingSource.DataSource = dataReader;
                setData();
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            String query = "update fornecedores set razao_social='" + textBoxRazaoSocial.Text + "', nome_fantasia='"
               + textBoxNomeFantasia.Text + "',cnpj='"
               + maskedTextBoxCNPJ.Text + "',endereco='"
               + textBoxEndereco.Text + "',numero='"
               + textBoxNumero.Text + "',bairro='"
               + textBoxBairro.Text + "',cidade='"
               + textBoxCidade.Text + "',telefone='"
               + maskedTextBoxTelefone.Text + "',nome_contato='"
               + textBoxResponsavelLinha.Text + "',email='"
               + textBoxEmail.Text + "',site='"
               + textBoxSite.Text + "' where cod_fornecedor="+ textBoxCod.Text + ";";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            dataReader = oleDbCommand.ExecuteReader();

            if (dataReader.RecordsAffected == 1)
            {
                getFornecedores();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            String query =  "delete from fornecedores where cod_fornecedor="+ textBoxCod.Text;
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            dataReader = oleDbCommand.ExecuteReader();
            if (dataReader.RecordsAffected == 1)
            {
                getFornecedores();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxRazaoSocial.Text = "";
            textBoxNomeFantasia.Text = "";
            maskedTextBoxCNPJ.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxResponsavelLinha.Text = "";
            textBoxEmail.Text = "";
            textBoxSite.Text = "";
            textBoxCod.Text = "";
        }

        private void dataGridViewFornecedores_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void setData() {        
        textBoxCod.DataBindings.Add("Text", bindingSource, "cod_fornecedor");
            textBoxCod.DataBindings.Clear();

            textBoxRazaoSocial.DataBindings.Add("Text", bindingSource, "razao_social");
            textBoxRazaoSocial.DataBindings.Clear();

            textBoxNomeFantasia.DataBindings.Add("Text", bindingSource, "nome_fantasia");
            textBoxNomeFantasia.DataBindings.Clear();

            maskedTextBoxCNPJ.DataBindings.Add("Text", bindingSource, "cnpj");
            maskedTextBoxCNPJ.DataBindings.Clear();

            textBoxEndereco.DataBindings.Add("Text", bindingSource, "endereco");
            textBoxEndereco.DataBindings.Clear();

            textBoxNumero.DataBindings.Add("Text", bindingSource, "numero");
            textBoxNumero.DataBindings.Clear();

            textBoxBairro.DataBindings.Add("Text", bindingSource, "bairro");
            textBoxBairro.DataBindings.Clear();

            textBoxCidade.DataBindings.Add("Text", bindingSource, "cidade");
            textBoxCidade.DataBindings.Clear();

            maskedTextBoxTelefone.DataBindings.Add("Text", bindingSource, "telefone");
            maskedTextBoxTelefone.DataBindings.Clear();

            textBoxResponsavelLinha.DataBindings.Add("Text", bindingSource, "nome_contato");
            textBoxResponsavelLinha.DataBindings.Clear();

            textBoxEmail.DataBindings.Add("Text", bindingSource, "email");
            textBoxEmail.DataBindings.Clear();

            textBoxSite.DataBindings.Add("Text", bindingSource, "site");
            textBoxSite.DataBindings.Clear();
        }

        private void CrudFornecedores_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void dataGridViewFornecedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setData();
        }

        private void dataGridViewFornecedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            setData();
        }

        private void dataGridViewFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            setData();
        }

        private void dataGridViewFornecedores_BindingContextChanged(object sender, EventArgs e)
        {
            setData();
        }
    }
}
