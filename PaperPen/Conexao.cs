using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PaperPen
{
    class Conexao
    {
        private static string connectionString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=bd_empresa.accdb";
        private static OleDbConnection conexao = null;

        public static OleDbConnection abrirConexao()
        {
            conexao = new OleDbConnection(connectionString);

            try
            {
                conexao.Open();
            }
            catch (Exception)
            {
                conexao = null;
                MessageBox.Show("Conexão não estabelecida!!");
            }

            return conexao;

        }

        public static void fecharConexao()
        {
            if (conexao != null)
            {
                conexao.Close();
            }
        }
    }
}
