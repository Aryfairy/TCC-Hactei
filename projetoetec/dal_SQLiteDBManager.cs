using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace projetoetec
{
    class dal_SQLiteDBManager
    {
        private SQLiteConnection conexao;

        public dal_SQLiteDBManager(string caminhoBanco)
        {
            conexao = new SQLiteConnection($"Data Source={caminhoBanco};Version=3;");
        }

        public void AbrirConexao()
        {
            if (conexao.State != ConnectionState.Open)
                conexao.Open();
        }

        public void FecharConexao()
        {
            if (conexao.State != ConnectionState.Closed)
                conexao.Close();
        }

        public void InserirDados(string comandoSQL)
        {
            try
            {
                AbrirConexao();
                using (SQLiteCommand comando = new SQLiteCommand(comandoSQL, conexao))
                {
                    comando.ExecuteNonQuery();
                }
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable ConsultarDados(string comandoSQL)
        {
            DataTable dataTable = new DataTable();
            try
            {
                AbrirConexao();
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comandoSQL, conexao))
                {
                    adaptador.Fill(dataTable);
                }
            }
            finally
            {
                FecharConexao();
            }
            return dataTable;
        }

        public void CarregarComboBox(ComboBox comboBox, string comandoSQL, string displayMember)
        {
            try
            {
                AbrirConexao();
                DataTable dataTable = new DataTable();
                using (SQLiteCommand comando = new SQLiteCommand(comandoSQL, conexao))
                {
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
