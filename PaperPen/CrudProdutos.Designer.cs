namespace PaperPen
{
    partial class CrudProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.textBoxQtdEstoque = new System.Windows.Forms.TextBox();
            this.labelQtdEstoque = new System.Windows.Forms.Label();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(854, 150);
            this.dataGridViewProdutos.TabIndex = 63;
            this.dataGridViewProdutos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProdutos_DataBindingComplete);
            this.dataGridViewProdutos.Click += new System.EventHandler(this.dataGridViewProdutos_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(12, 29);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(855, 20);
            this.textBoxPesquisar.TabIndex = 62;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(9, 13);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(53, 13);
            this.labelPesquisar.TabIndex = 61;
            this.labelPesquisar.Text = "Pesquisar";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(512, 475);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 60;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(431, 474);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 59;
            this.buttonExcluir.Text = "EXCLUIR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(351, 474);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 58;
            this.buttonAtualizar.Text = "ATUALIZAR";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(270, 475);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 57;
            this.buttonInserir.Text = "INSERIR";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(13, 278);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(854, 20);
            this.textBoxDescricao.TabIndex = 56;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(10, 262);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 55;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(9, 432);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(109, 13);
            this.labelFornecedor.TabIndex = 53;
            this.labelFornecedor.Text = "Código do fornecedor";
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(13, 404);
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(854, 20);
            this.textBoxCaracteristicas.TabIndex = 46;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(10, 388);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(78, 13);
            this.labelCaracteristicas.TabIndex = 45;
            this.labelCaracteristicas.Text = "Características";
            // 
            // textBoxQtdEstoque
            // 
            this.textBoxQtdEstoque.Location = new System.Drawing.Point(13, 363);
            this.textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            this.textBoxQtdEstoque.Size = new System.Drawing.Size(854, 20);
            this.textBoxQtdEstoque.TabIndex = 40;
            // 
            // labelQtdEstoque
            // 
            this.labelQtdEstoque.AutoSize = true;
            this.labelQtdEstoque.Location = new System.Drawing.Point(10, 346);
            this.labelQtdEstoque.Name = "labelQtdEstoque";
            this.labelQtdEstoque.Size = new System.Drawing.Size(120, 13);
            this.labelQtdEstoque.TabIndex = 39;
            this.labelQtdEstoque.Text = "Quantidade em estoque";
            // 
            // textBoxUnidade
            // 
            this.textBoxUnidade.Location = new System.Drawing.Point(13, 318);
            this.textBoxUnidade.Name = "textBoxUnidade";
            this.textBoxUnidade.Size = new System.Drawing.Size(854, 20);
            this.textBoxUnidade.TabIndex = 38;
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Location = new System.Drawing.Point(10, 302);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(47, 13);
            this.labelUnidade.TabIndex = 37;
            this.labelUnidade.Text = "Unidade";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(13, 238);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(854, 20);
            this.textBoxCod.TabIndex = 36;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(10, 221);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(94, 13);
            this.labelCod.TabIndex = 35;
            this.labelCod.Text = "Código do produto";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(13, 448);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(854, 21);
            this.comboBoxFornecedor.TabIndex = 64;
            // 
            // CrudProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 514);
            this.Controls.Add(this.comboBoxFornecedor);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.labelPesquisar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.textBoxCaracteristicas);
            this.Controls.Add(this.labelCaracteristicas);
            this.Controls.Add(this.textBoxQtdEstoque);
            this.Controls.Add(this.labelQtdEstoque);
            this.Controls.Add(this.textBoxUnidade);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelCod);
            this.Name = "CrudProdutos";
            this.Text = "CrudProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.TextBox textBoxQtdEstoque;
        private System.Windows.Forms.Label labelQtdEstoque;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
    }
}