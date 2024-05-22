using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoetec
{
    class dal_SQLServerDBManager
    {
        private SqlConnection conexao;

        public dal_SQLServerDBManager(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
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
                using (SqlCommand comando = new SqlCommand(comandoSQL, conexao)) // Alteração aqui
                {
                    comando.ExecuteNonQuery();
                }
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable ConsultarDados(string comandoSQL, params SqlParameter[] parametros)
        {
            DataTable dataTable = new DataTable();
            try
            {
                AbrirConexao();
                using (SqlCommand comando = new SqlCommand(comandoSQL, conexao))
                {
                    // Adiciona os parâmetros ao comando, se houver
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(dataTable);
                    }
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
                using (SqlCommand comando = new SqlCommand(comandoSQL, conexao)) // Alteração aqui
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
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
