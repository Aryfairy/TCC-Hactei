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

        public void InserirDados(string comandoSQL, params SqlParameter[] parametros)
        {
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

        public bool AutenticarAdmin(string email, string senha)
        {
            string comandoSQL = "SELECT COUNT(*) FROM administrador WHERE admin_email = @Email AND admin_senha = @Senha";
            SqlParameter[] parametros = { new SqlParameter("@Email", email), new SqlParameter("@Senha", senha) };
            DataTable resultado = ConsultarDados(comandoSQL, parametros);
            int count = Convert.ToInt32(resultado.Rows[0][0]);
            return count > 0;
        }

        public bool AutenticarEmail(string email)
        {
            string comandoSQL = "SELECT COUNT(*) FROM administrador WHERE admin_email = @Email";
            SqlParameter[] parametros = { new SqlParameter("@Email", email) };
            DataTable resultado = ConsultarDados(comandoSQL, parametros);
            int count = Convert.ToInt32(resultado.Rows[0][0]);
            return count > 0;
        }

        public DataTable CarregarReservasPosteriores(string professor)
        {
            DateTime dataHoraAtual = DateTime.Now.Date; // Ajuste para pegar apenas a data atual sem a hora
            string comandoSQL = "SELECT res_data, res_horainicial, res_horafinal, lab_nome, lab_sala, lab_disc " +
                                "FROM reserva " +
                                "INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                "WHERE reserva.prof_cod = (SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor) " +
                                "AND res_data > @DataHoraAtual";
            SqlParameter[] parametros = { new SqlParameter("@Professor", professor), new SqlParameter("@DataHoraAtual", dataHoraAtual) };
            return ConsultarDados(comandoSQL, parametros);
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
