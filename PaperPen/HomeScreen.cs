using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaperPen
{
    public partial class HomeScreen : Form
    {
        const string DEVELOPER_PREFIX = "Desenvolvido por";
        const string DEVELOPER = "Victor";
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void PPMain_Load(object sender, EventArgs e)
        {
            InitTimeUpdate();
            developerName.Text = DEVELOPER_PREFIX + " " + DEVELOPER;
        }

        private void InitTimeUpdate()
        {
            Timer changeTime = new Timer();
            changeTime.Tick += new EventHandler(ChangeTime_Tick);
            changeTime.Interval = 1000;
            changeTime.Start();
        }

        private void ChangeTime_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonFornecedores_Click(object sender, EventArgs e)
        {
            openCrudFornecedores();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCrudFornecedores();
        }

        private void openCrudFornecedores()
        {
            CrudFornecedores form = new CrudFornecedores();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemFornecedores_Click(object sender, EventArgs e)
        {
            openCrudFornecedores();
        }

        private void toolStripMenuItemProdutos_Click(object sender, EventArgs e)
        {
            openCrudProdutos();
        }

        private void openCrudProdutos()
        {
            CrudProdutos form = new CrudProdutos();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButtonProdutos_Click(object sender, EventArgs e)
        {
            openCrudProdutos();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCrudProdutos();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCadastralFornecedores form = new ConsultaCadastralFornecedores();
            form.MdiParent = this;
            form.Show();
        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RelatorioCadastralFornecedores form = new RelatorioCadastralFornecedores();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCadastralProdutos form = new ConsultaCadastralProdutos();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultaAnaliticaProdutos form = new ConsultaAnaliticaProdutos();
            form.MdiParent = this;
            form.Show();
        }

        private void fornecedoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultaAnaliticaFornecedor form = new ConsultaAnaliticaFornecedor();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RelatorioCadastralProdutos form = new RelatorioCadastralProdutos();
            form.MdiParent = this;
            form.Show();
        }

        private void analíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioAnalitico form = new RelatorioAnalitico();
            form.MdiParent = this;
            form.Show();
        }
    }
}
