namespace PaperPen
{
    partial class ConsultaCadastralProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCadastralProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonSelecionados = new System.Windows.Forms.Button();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPesquise = new System.Windows.Forms.TextBox();
            this.comboBoxPesquise = new System.Windows.Forms.ComboBox();
            this.labelPesquise = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImprimir);
            this.groupBox1.Controls.Add(this.buttonSelecionados);
            this.groupBox1.Controls.Add(this.buttonVisualizar);
            this.groupBox1.Location = new System.Drawing.Point(481, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 52);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 99);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(801, 156);
            this.dataGridView.TabIndex = 18;
            // 
            // textBoxPesquise
            // 
            this.textBoxPesquise.Location = new System.Drawing.Point(9, 60);
            this.textBoxPesquise.Name = "textBoxPesquise";
            this.textBoxPesquise.Size = new System.Drawing.Size(307, 20);
            this.textBoxPesquise.TabIndex = 17;
            this.textBoxPesquise.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // comboBoxPesquise
            // 
            this.comboBoxPesquise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquise.FormattingEnabled = true;
            this.comboBoxPesquise.Items.AddRange(new object[] {
            "Código do Produto",
            "Descrição",
            "Unidade",
            "Quantidade no Estoque",
            "Características",
            "Código do Fornecedor"});
            this.comboBoxPesquise.Location = new System.Drawing.Point(9, 30);
            this.comboBoxPesquise.Name = "comboBoxPesquise";
            this.comboBoxPesquise.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPesquise.TabIndex = 16;
            // 
            // labelPesquise
            // 
            this.labelPesquise.AutoSize = true;
            this.labelPesquise.Location = new System.Drawing.Point(6, 14);
            this.labelPesquise.Name = "labelPesquise";
            this.labelPesquise.Size = new System.Drawing.Size(68, 13);
            this.labelPesquise.TabIndex = 15;
            this.labelPesquise.Text = "Pesquise por";
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // ConsultaCadastralProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxPesquise);
            this.Controls.Add(this.comboBoxPesquise);
            this.Controls.Add(this.labelPesquise);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaCadastralProdutos";
            this.Text = "Consulta Cadastral de Produtos";
            this.Load += new System.EventHandler(this.ConsultaCadastralProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonSelecionados;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxPesquise;
        private System.Windows.Forms.ComboBox comboBoxPesquise;
        private System.Windows.Forms.Label labelPesquise;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}