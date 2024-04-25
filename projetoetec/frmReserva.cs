using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace projetoetec
{
    public partial class frmReserva : Form
    {
        private dal_SQLiteDBManager dbManager;
        public frmReserva()
        {
            InitializeComponent();
            dbManager = new dal_SQLiteDBManager(@"C:\Users\Laboratorio-Info\source\repos\TCC-Hactei\etecja_reservas.db");
            dbManager.AbrirConexao();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            CarregarLaboratorios();
            CarregarProfessores();
            cboLaboratorio.SelectedIndex = -1;
            cboProfessor.SelectedIndex = -1;
            cboLaboratorio.Text = "Selecione um laboratório para a reserva";
            cboProfessor.Text = "Selecione um professor para a reserva";
        }

        //
        //
        //
        //
        //CarregarCombobox Lab e Prof
        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT lab_nome || ' - ' || lab_sala AS nome_sala FROM laboratorio";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarProfessores()
        {
            try
            {
                // Consulta SQL para selecionar o nome do professor e a disciplina, concatenando-os
                string comandoSQL = "SELECT prof_nome || ' - ' || prof_disciplina AS nome_disciplina FROM professor";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboProfessor, comandoSQL, "nome_disciplina");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        //
        //
        //
        // Botão reserva
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cboLaboratorio.SelectedItem == null)
            {
                MessageBox.Show("Selecione um laboratório para a reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboProfessor.SelectedItem == null)
            {
                MessageBox.Show("Selecione um professor para a reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(maskedTBInicial.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaInicial) ||
                !DateTime.TryParseExact(maskedTBFinal.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaFinal))
            {
                MessageBox.Show("Insira horas válidas nos campos de hora inicial e final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataReserva = dtpReserva.Value.Date;

            if (dataReserva < DateTime.Today)
            {
                MessageBox.Show("Não é possível fazer reservas em datas passadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (horaInicial >= horaFinal)
            {
                MessageBox.Show("A hora final deve ser posterior à hora inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeLab = cboLaboratorio.Text.Split('-')[0].Trim();
            string nomeProf = cboProfessor.Text.Split('-')[0].Trim();

            DialogResult result = MessageBox.Show(
                $"Deseja reservar o laboratório '{nomeLab}' para o professor '{nomeProf}' no dia {dataReserva:dd/MM/yyyy} das {horaInicial:HH:mm} às {horaFinal:HH:mm}?",
                "Confirmar Reserva",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int labCod = ObterCodigoLaboratorio(nomeLab);
                int profCod = ObterCodigoProfessor(nomeProf);

                string comandoSQL = $"INSERT INTO reserva (lab_cod, prof_cod, res_data, res_horainicial, res_horafinal, res_status) " +
                                    $"VALUES ({labCod}, {profCod}, '{dataReserva:yyyy-MM-dd}', '{horaInicial:HH:mm}', '{horaFinal:HH:mm}', 'reservado')";
                try
                {
                    // Executa o comando SQL para inserir os dados no banco de dados
                    dbManager.InserirDados(comandoSQL);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Reserva realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa os controles após a reserva
                    LimparControlesReserva();
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibe uma mensagem de erro
                    MessageBox.Show($"Erro ao realizar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ObterCodigoLaboratorio(string nomeLaboratorio)
        {
            // Consulta SQL para obter o código do laboratório com base no nome
            string comandoSQL = $"SELECT lab_cod FROM laboratorio WHERE lab_nome = '{nomeLaboratorio}'";

            // Executa a consulta e retorna o código do laboratório
            DataTable resultado = dbManager.ConsultarDados(comandoSQL);

            // Verifica se há algum resultado retornado
            if (resultado.Rows.Count > 0)
            {
                // Acessa o valor retornado na primeira linha e primeira coluna
                return Convert.ToInt32(resultado.Rows[0][0]);
            }
            else
            {
                // Se não houver resultados, retorna -1 (ou outro valor que indique erro)
                return -1;
            }
        }

        private int ObterCodigoProfessor(string nomeProfessor)
        {
            // Consulta SQL para obter o código do professor com base no nome
            string comandoSQL = $"SELECT prof_cod FROM professor WHERE prof_nome = '{nomeProfessor}'";

            // Executa a consulta e retorna o código do professor
            DataTable resultado = dbManager.ConsultarDados(comandoSQL);

            // Verifica se há algum resultado retornado
            if (resultado.Rows.Count > 0)
            {
                // Acessa o valor retornado na primeira linha e primeira coluna
                return Convert.ToInt32(resultado.Rows[0][0]);
            }
            else
            {
                // Se não houver resultados, retorna -1 (ou outro valor que indique erro)
                return -1;
            }
        }

        private void LimparControlesReserva()
        {
            // Limpa os controles após a reserva
            dtpReserva.Value = DateTime.Now.Date;
            maskedTBInicial.Clear();
            maskedTBFinal.Clear();
            cboLaboratorio.SelectedIndex = -1;
            cboProfessor.SelectedIndex = -1;
            cboLaboratorio.Text = "Selecione um laboratório para a reserva";
            cboProfessor.Text = "Selecione um professor para a reserva";
        }

        //
        //
        //
        //
        // Mudança de telas
        private void linkConsultaDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaDia abrir = new frmConsultaDia();
            abrir.Show();
            this.Close();
        }

        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Close();
        }

        private void lnkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Close();
        }        
    }
}
