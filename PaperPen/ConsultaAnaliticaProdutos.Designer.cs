namespace PaperPen
{
    partial class ConsultaAnaliticaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAnaliticaProdutos));
            this.Consultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(11, 307);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Search);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(815, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(110, 13);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Descrição do Produto";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 71);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(815, 230);
            this.dataGridView.TabIndex = 4;
            // 
            // ConsultaAnaliticaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 342);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaAnaliticaProdutos";
            this.Text = "ConsultaAnaliticaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}