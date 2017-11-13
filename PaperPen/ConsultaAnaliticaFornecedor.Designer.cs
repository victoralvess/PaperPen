namespace PaperPen
{
    partial class ConsultaAnaliticaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAnaliticaFornecedor));
            this.Consultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(12, 316);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(790, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(9, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(112, 13);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Código do Fornecedor";
            // 
            // dataGridView
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView";
            this.dataGridView1.Size = new System.Drawing.Size(790, 231);
            this.dataGridView1.TabIndex = 4;
            // 
            // ConsultaAnaliticaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 351);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaAnaliticaFornecedor";
            this.Text = "ConsultaAnaliticaFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}