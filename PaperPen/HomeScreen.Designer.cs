namespace PaperPen
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dateTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.developerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.PaperPenIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonFornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProdutos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(590, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeLabel,
            this.developerName});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(590, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(74, 17);
            this.dateTimeLabel.Text = "DATA/HORA";
            // 
            // developerName
            // 
            this.developerName.Name = "developerName";
            this.developerName.Size = new System.Drawing.Size(100, 17);
            this.developerName.Text = "DESENVOLVEDOR";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFornecedores,
            this.toolStripButtonProdutos,
            this.toolStripButtonSair});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(590, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // PaperPenIcon
            // 
            this.PaperPenIcon.ContextMenuStrip = this.contextMenuStrip;
            this.PaperPenIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("PaperPenIcon.Icon")));
            this.PaperPenIcon.Text = "PaperPen";
            this.PaperPenIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFornecedores,
            this.toolStripMenuItemProdutos,
            this.toolStripMenuItemSair});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 70);
            // 
            // toolStripMenuItemFornecedores
            // 
            this.toolStripMenuItemFornecedores.Name = "toolStripMenuItemFornecedores";
            this.toolStripMenuItemFornecedores.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemFornecedores.Text = "Fornecedores";
            this.toolStripMenuItemFornecedores.Click += new System.EventHandler(this.toolStripMenuItemFornecedores_Click);
            // 
            // toolStripMenuItemProdutos
            // 
            this.toolStripMenuItemProdutos.Name = "toolStripMenuItemProdutos";
            this.toolStripMenuItemProdutos.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemProdutos.Text = "Produtos";
            this.toolStripMenuItemProdutos.Click += new System.EventHandler(this.toolStripMenuItemProdutos_Click);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemSair.Text = "Sair";
            this.toolStripMenuItemSair.Click += new System.EventHandler(this.toolStripMenuItemSair_Click);
            // 
            // toolStripButtonFornecedores
            // 
            this.toolStripButtonFornecedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFornecedores.Image")));
            this.toolStripButtonFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFornecedores.Name = "toolStripButtonFornecedores";
            this.toolStripButtonFornecedores.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFornecedores.Text = "Cadastro de Fornecedores";
            this.toolStripButtonFornecedores.Click += new System.EventHandler(this.toolStripButtonFornecedores_Click);
            // 
            // toolStripButtonProdutos
            // 
            this.toolStripButtonProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProdutos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProdutos.Image")));
            this.toolStripButtonProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProdutos.Name = "toolStripButtonProdutos";
            this.toolStripButtonProdutos.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonProdutos.Text = "Cadastro de Produtos";
            this.toolStripButtonProdutos.Click += new System.EventHandler(this.toolStripButtonProdutos_Click);
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonSair.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.Click += new System.EventHandler(this.ToolStripButtonSair_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem.Image")));
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastralToolStripMenuItem,
            this.analíticaToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // cadastralToolStripMenuItem
            // 
            this.cadastralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem1,
            this.produtosToolStripMenuItem1});
            this.cadastralToolStripMenuItem.Name = "cadastralToolStripMenuItem";
            this.cadastralToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cadastralToolStripMenuItem.Text = "Cadastral";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem1.Image")));
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem1.Image")));
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // analíticaToolStripMenuItem
            // 
            this.analíticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem3,
            this.produtosToolStripMenuItem3});
            this.analíticaToolStripMenuItem.Name = "analíticaToolStripMenuItem";
            this.analíticaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.analíticaToolStripMenuItem.Text = "Analítica";
            // 
            // fornecedoresToolStripMenuItem3
            // 
            this.fornecedoresToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem3.Image")));
            this.fornecedoresToolStripMenuItem3.Name = "fornecedoresToolStripMenuItem3";
            this.fornecedoresToolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem3.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem3.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem3_Click);
            // 
            // produtosToolStripMenuItem3
            // 
            this.produtosToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem3.Image")));
            this.produtosToolStripMenuItem3.Name = "produtosToolStripMenuItem3";
            this.produtosToolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem3.Text = "Produtos";
            this.produtosToolStripMenuItem3.Click += new System.EventHandler(this.produtosToolStripMenuItem3_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastralToolStripMenuItem1,
            this.analíticoToolStripMenuItem});
            this.relatórioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatórioToolStripMenuItem.Image")));
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // cadastralToolStripMenuItem1
            // 
            this.cadastralToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem2,
            this.produtosToolStripMenuItem2});
            this.cadastralToolStripMenuItem1.Name = "cadastralToolStripMenuItem1";
            this.cadastralToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cadastralToolStripMenuItem1.Text = "Cadastral";
            // 
            // fornecedoresToolStripMenuItem2
            // 
            this.fornecedoresToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem2.Image")));
            this.fornecedoresToolStripMenuItem2.Name = "fornecedoresToolStripMenuItem2";
            this.fornecedoresToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.fornecedoresToolStripMenuItem2.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem2.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem2_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem2.Image")));
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            this.produtosToolStripMenuItem2.Click += new System.EventHandler(this.produtosToolStripMenuItem2_Click);
            // 
            // analíticoToolStripMenuItem
            // 
            this.analíticoToolStripMenuItem.Name = "analíticoToolStripMenuItem";
            this.analíticoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.analíticoToolStripMenuItem.Text = "Analítico";
            this.analíticoToolStripMenuItem.Click += new System.EventHandler(this.analíticoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HomeScreen";
            this.Text = "PaperPen - PP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PPMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analíticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analíticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel developerName;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButtonFornecedores;
        private System.Windows.Forms.ToolStripButton toolStripButtonProdutos;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.NotifyIcon PaperPenIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFornecedores;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProdutos;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem3;
    }
}

