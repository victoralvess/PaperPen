namespace PaperPen
{
    partial class ConsultaCadastralFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCadastralFornecedores));
            this.buttonSelecionados = new System.Windows.Forms.Button();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxPesquisar = new System.Windows.Forms.ComboBox();
            this.labelEscolha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelecionados
            // 
            this.buttonSelecionados.Location = new System.Drawing.Point(168, 19);
            this.buttonSelecionados.Name = "buttonSelecionados";
            this.buttonSelecionados.Size = new System.Drawing.Size(155, 23);
            this.buttonSelecionados.TabIndex = 13;
            this.buttonSelecionados.Text = "Quantidade de Selecionados";
            this.buttonSelecionados.UseVisualStyleBackColor = true;
            this.buttonSelecionados.Click += new System.EventHandler(this.Selecionados_Click);
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.Location = new System.Drawing.Point(6, 19);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonVisualizar.TabIndex = 12;
            this.buttonVisualizar.Text = "Visualizar";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(87, 19);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 11;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(788, 156);
            this.dataGridView.TabIndex = 10;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(12, 56);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(311, 20);
            this.textBoxPesquisa.TabIndex = 9;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // comboBoxPesquisar
            // 
            this.comboBoxPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquisar.FormattingEnabled = true;
            this.comboBoxPesquisar.Items.AddRange(new object[] {
            "Código do Fornecedor",
            "Razão Social",
            "Nome Fantasia",
            "CNPJ",
            "Endereço",
            "Número",
            "Bairro",
            "Cidade",
            "Telefone",
            "Nome do Contato",
            "E-mail",
            "Site"});
            this.comboBoxPesquisar.Location = new System.Drawing.Point(12, 26);
            this.comboBoxPesquisar.Name = "comboBoxPesquisar";
            this.comboBoxPesquisar.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPesquisar.TabIndex = 8;
            // 
            // labelEscolha
            // 
            this.labelEscolha.AutoSize = true;
            this.labelEscolha.Location = new System.Drawing.Point(9, 10);
            this.labelEscolha.Name = "labelEscolha";
            this.labelEscolha.Size = new System.Drawing.Size(71, 13);
            this.labelEscolha.TabIndex = 7;
            this.labelEscolha.Text = "Pesquisar por";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImprimir);
            this.groupBox1.Controls.Add(this.buttonSelecionados);
            this.groupBox1.Controls.Add(this.buttonVisualizar);
            this.groupBox1.Location = new System.Drawing.Point(471, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // ConsultaCadastralFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBoxPesquisar);
            this.Controls.Add(this.labelEscolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaCadastralFornecedores";
            this.Text = "Consulta Cadastral de Fornecedores";
            this.Load += new System.EventHandler(this.ConsultaCadastralFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecionados;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisar;
        private System.Windows.Forms.Label labelEscolha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}