using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace projetoetec
{
    public partial class frmReserva : Form
    {
        private dal_SQLServerDBManager dbManager;
        private bool repetirReserva = false;
        private ToolTip toolTip; // Declaração do ToolTip

        public frmReserva()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
            // Associa o evento FormClosing ao método frmConsultaDia_FormClosing
            this.FormClosing += new FormClosingEventHandler(frmReserva_FormClosing);
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            CarregarLaboratorios();
            CarregarProfessores();
            CarregarHorarios();
            cboLaboratorio.SelectedIndex = -1;
            cboProfessor.SelectedIndex = -1;
            cboInicial.SelectedIndex = 0;
            cboFinal.SelectedIndex = 0;
            cboLaboratorio.Text = "Selecione um laboratório para a reserva";
            cboProfessor.Text = "Selecione um professor para a reserva";
            lblDataFinal.Visible = false; // Oculta o label lblDataFinal
            dtpReservaRepetir.Visible = false; // Oculta o DateTimePicker dtpReservaRepetir
        }

        // Carregar ComboBox de Laboratórios
        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) AS nome_sala FROM laboratorio";

                // Carrega o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carregar ComboBox de Professores
        private void CarregarProfessores()
        {
            try
            {
                // Consulta SQL para selecionar o nome do professor e a disciplina, concatenando-os
                string comandoSQL = "SELECT CONCAT(prof_nome, ' - ', prof_disciplina) AS nome_disciplina FROM professor";

                // Carrega o ComboBox
                dbManager.CarregarComboBox(cboProfessor, comandoSQL, "nome_disciplina");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carregar ComboBox de Horários
        private void CarregarHorarios()
        {
            string[] horariosInicial = {
                "07:30", "07:40", "07:50", "08:00", "08:10", "08:20", "08:30", "08:40", "08:50", "09:00",
                "09:10", "09:20", "09:30", "09:40", "09:50", "10:00", "10:10", "10:20", "10:30", "10:40",
                "10:50", "11:00", "11:10", "11:20", "11:30", "11:40", "11:50", "12:00", "12:10", "12:20",
                "12:30", "12:40", "12:50", "13:00", "13:10", "13:20", "13:30", "13:40", "13:50", "14:00",
                "14:10", "14:20", "14:30", "14:40", "14:50", "15:00", "15:10", "15:20"
            };

            string[] horariosFinal = {
                "07:40", "07:50", "08:00", "08:10", "08:20", "08:30", "08:40", "08:50", "09:00",
                "09:10", "09:20", "09:30", "09:40", "09:50", "10:00", "10:10", "10:20", "10:30", "10:40",
                "10:50", "11:00", "11:10", "11:20", "11:30", "11:40", "11:50", "12:00", "12:10", "12:20",
                "12:30", "12:40", "12:50", "13:00", "13:10", "13:20", "13:30", "13:40", "13:50", "14:00",
                "14:10", "14:20", "14:30", "14:40", "14:50", "15:00", "15:10", "15:20", "15:30"
            };

            cboInicial.Items.AddRange(horariosInicial);
            cboInicial.SelectedIndex = 0; // Seleciona a primeira hora ao carregar a tela
            cboInicial.DropDownStyle = ComboBoxStyle.DropDownList; // Impede que o usuário edite o ComboBox

            cboFinal.Items.AddRange(horariosFinal);
            cboFinal.SelectedIndex = 0; // Seleciona a primeira hora ao carregar a tela
            cboFinal.DropDownStyle = ComboBoxStyle.DropDownList; // Impede que o usuário edite o ComboBox
        }

        //
        //
        //
        //
        // Repetir
        private void ckbRepetir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRepetir.Checked)
            {
                repetirReserva = true;
                lblDataInicial.Text = "Data Inicial:"; // Altera o texto do label lblDataInicial
                lblDataInicial.Location = new Point(103, lblDataInicial.Location.Y); // Altera a localização do label lblDataInicial
                lblDataFinal.Visible = true; // Torna o label lblDataFinal visível
                dtpReservaRepetir.Visible = true; // Torna o DateTimePicker dtpReservaRepetir visível
                dtpReservaRepetir.Value = dtpReserva.Value.AddDays(1); // Define o valor inicial do dtpReservaRepetir
            }
            else
            {
                repetirReserva = false;
                lblDataInicial.Text = "Data:"; // Restaura o texto original do label lblDataInicial
                lblDataInicial.Location = new Point(183, lblDataInicial.Location.Y); // Restaura a localização original do label lblDataInicial
                lblDataFinal.Visible = false; // Oculta o label lblDataFinal
                dtpReservaRepetir.Visible = false; // Oculta o DateTimePicker dtpReservaRepetir
            }
        }

        //
        //
        //
        //
        // Botão de Reserva
        // Botão de Reserva
        private void btnReservar_Click(object sender, EventArgs e)
        {
            // Verifica se laboratório e professor foram selecionados
            if (cboLaboratorio.SelectedItem == null || cboProfessor.SelectedItem == null)
            {
                MessageBox.Show("Selecione um laboratório e um professor para a reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se as horas inseridas são válidas
            if (cboInicial.SelectedItem == null || cboFinal.SelectedItem == null ||
                !DateTime.TryParseExact(cboInicial.SelectedItem.ToString(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaInicial) ||
                !DateTime.TryParseExact(cboFinal.SelectedItem.ToString(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaFinal))
            {
                MessageBox.Show("Selecione horários válidos nos campos de hora inicial e final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se a data da reserva é válida
            DateTime dataReserva = dtpReserva.Value.Date;
            if (dataReserva < DateTime.Today)
            {
                MessageBox.Show("Não é possível fazer reservas em datas passadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se a hora final é posterior à hora inicial
            if (horaInicial >= horaFinal)
            {
                MessageBox.Show("A hora final deve ser posterior à hora inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se repetirReserva for true, a reserva deve ser repetida
            if (repetirReserva)
            {
                // Cálculo do número de dias de repetição
                int numDias = (int)(dtpReservaRepetir.Value.Date - dtpReserva.Value.Date).TotalDays + 1;

                // Verificação do limite de dias consecutivos de repetição
                if (numDias > 10)
                {
                    MessageBox.Show("Você só pode repetir a reserva por até 10 dias consecutivos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool conflitoReserva = false;
                string datasConflito = "";

                // Verificação de conflito de reserva para cada dia repetido
                for (int i = 0; i < numDias; i++)
                {
                    DateTime dataAtual = dtpReserva.Value.Date.AddDays(i);

                    // Verificação de conflito de reserva para cada dia repetido
                    if (ExisteConflitoReserva(dataAtual, dataAtual, horaInicial, horaFinal))
                    {
                        conflitoReserva = true;
                        datasConflito += $"{dataAtual:dd/MM/yyyy}\n";
                    }
                }

                // Se houver conflito de reserva em qualquer um dos dias, exibe a mensagem de erro e interrompe o processo de reserva
                if (conflitoReserva)
                {
                    MessageBox.Show($"Não foi possível realizar a reserva nos seguintes dias devido a conflitos de horário:\n{datasConflito}\nPor favor, refaça a repetição levando isso em conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmação de reserva para o período de dias
                DialogResult resultConfirmacao = MessageBox.Show(
                    $"Deseja reservar o laboratório para o professor no período de {dtpReserva.Value:dd/MM/yyyy} a {dtpReservaRepetir.Value:dd/MM/yyyy}, das {horaInicial:HH:mm} às {horaFinal:HH:mm}?",
                    "Confirmar Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Se o usuário confirmar a reserva, executa a inserção no banco de dados
                if (resultConfirmacao == DialogResult.Yes)
                {
                    // Reservar laboratório para cada dia repetido
                    for (int i = 0; i < numDias; i++)
                    {
                        DateTime dataAtual = dtpReserva.Value.Date.AddDays(i);
                        ReservarLabProf(dataAtual, horaInicial, horaFinal);
                    }

                    // Exibição de mensagem de sucesso após repetição das reservas
                    MessageBox.Show("Reservas realizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Verifica se há conflito de reserva para reserva única
                if (ExisteConflitoReserva(dataReserva, dataReserva, horaInicial, horaFinal))
                {
                    MessageBox.Show("Este laboratório já contém uma reserva nesse horário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Exibe mensagem de confirmação antes de fazer a reserva única
                DialogResult result = MessageBox.Show(
                    $"Deseja reservar o laboratório para o professor no período de {dataReserva:dd/MM/yyyy}, das {horaInicial:HH:mm} às {horaFinal:HH:mm}?",
                    "Confirmar Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Se o usuário confirmar a reserva, executa a inserção no banco de dados
                if (result == DialogResult.Yes)
                {
                    // Executa a lógica de reserva para a data única selecionada
                    ReservarLabProf(dataReserva, horaInicial, horaFinal);

                    // Exibe mensagem de sucesso após a reserva ser feita
                    MessageBox.Show("Reserva realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Método para verificar se há conflito de reserva
        private bool ExisteConflitoReserva(DateTime dataInicio, DateTime dataFim, DateTime horaInicial, DateTime horaFinal)
        {
            bool conflito = false;

            // Obtém o código do laboratório selecionado
            string[] labInfo = cboLaboratorio.Text.Split('-');
            if (labInfo.Length != 3)
            {
                MessageBox.Show("Selecione um laboratório válido para a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            string nomeLab = labInfo[0].Trim();
            string numLab = labInfo[1].Trim();
            string discLab = labInfo[2].Trim();
            int labCod = ObterCodigoLaboratorio(nomeLab, numLab, discLab);

            // Verifica se há conflito de reserva para o laboratório selecionado
            if (ReservaExistente(labCod, dataInicio, dataFim, horaInicial, horaFinal))
            {
                conflito = true;
            }

            return conflito;
        }


        // Método para realizar a reserva para uma determinada data, hora inicial e hora final
        private void ReservarLabProf(DateTime dataReserva, DateTime horaInicial, DateTime horaFinal)
        {
            // Obtém o nome do laboratório e do professor selecionados
            string nomeLab = cboLaboratorio.Text.Split('-')[0].Trim();
            string numLab = cboLaboratorio.Text.Split('-')[1].Trim();
            string discLab = cboLaboratorio.Text.Split('-')[2].Trim();
            string nomeProf = cboProfessor.Text.Split('-')[0].Trim();

            // Obtém os códigos do laboratório e do professor
            int labCod = ObterCodigoLaboratorio(nomeLab, numLab, discLab);
            int profCod = ObterCodigoProfessor(nomeProf);

            try
            {
                // Verifica se já existe uma reserva para o mesmo laboratório na mesma data e horário
                bool reservaExistente = ReservaExistente(labCod, dataReserva, dataReserva, horaInicial, horaFinal);

                // Se houver reserva conflitante, não faz a reserva e exibe a mensagem apenas uma vez
                if (reservaExistente)
                {
                    MessageBox.Show($"Este laboratório já contém uma reserva nesse horário na data {dataReserva:dd/MM/yyyy}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Monta o comando SQL para a inserção da reserva
                string comandoSQL = $"INSERT INTO reserva (lab_cod, prof_cod, res_data, res_horainicial, res_horafinal, res_status) " +
                                    $"VALUES ({labCod}, {profCod}, '{dataReserva:yyyy-MM-dd}', '{horaInicial:HH:mm}', '{horaFinal:HH:mm}', 'reservado')";

                // Executa o comando SQL para inserir os dados no banco de dados
                dbManager.InserirDados(comandoSQL);

                // Se repetirReserva for false, não exibe a mensagem de sucesso aqui
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe uma mensagem de erro
                MessageBox.Show($"Erro ao realizar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para verificar se já existe uma reserva para o mesmo laboratório na mesma data e horário
        private bool ReservaExistente(int labCod, DateTime dataInicio, DateTime dataFim, DateTime horaInicial, DateTime horaFinal)
        {
            bool conflito = false;

            // Monta a consulta SQL para verificar se já existe uma reserva para o mesmo laboratório na mesma data e horário
            string comandoSQL = $@"SELECT res_data 
       FROM reserva 
       WHERE lab_cod = {labCod}
         AND res_data BETWEEN '{dataInicio:yyyy-MM-dd}' AND '{dataFim:yyyy-MM-dd}' 
         AND ((res_horainicial <= '{horaFinal:HH:mm}' AND '{horaInicial:HH:mm}' <= res_horafinal) 
         OR (res_horainicial <= '{horaInicial:HH:mm}' AND '{horaFinal:HH:mm}' <= res_horafinal))";

            // Executa a consulta e verifica se há reservas conflitantes
            DataTable resultado = dbManager.ConsultarDados(comandoSQL);

            // Se houver reservas conflitantes, retorna true
            return resultado.Rows.Count > 0;
        }



        // Método para obter o código do laboratório com base no nome
        private int ObterCodigoLaboratorio(string nomeLaboratorio, string numLab, string discLab)
        {
            // Consulta SQL para obter o código do laboratório com base no nome, número e disciplina
            string comandoSQL = $"SELECT lab_cod FROM laboratorio WHERE lab_nome = '{nomeLaboratorio}' AND lab_sala = '{numLab}' AND lab_disc = '{discLab}'";

            // Executa a consulta e retorna o código do laboratório
            DataTable resultado = dbManager.ConsultarDados(comandoSQL);

            // Verifica se há algum resultado retornado
            if (resultado.Rows.Count > 0)
            {
                // Retorna o código do laboratório
                return Convert.ToInt32(resultado.Rows[0][0]);
            }
            else
            {
                // Se não houver resultados, retorna -1
                return -1;
            }
        }

        // Método para obter o código do professor com base no nome
        private int ObterCodigoProfessor(string nomeProfessor)
        {
            // Consulta SQL para obter o código do professor com base no nome
            string comandoSQL = $"SELECT prof_cod FROM professor WHERE prof_nome = '{nomeProfessor}'";

            // Executa a consulta e retorna o código do professor
            DataTable resultado = dbManager.ConsultarDados(comandoSQL);

            // Verifica se há algum resultado retornado
            if (resultado.Rows.Count > 0)
            {
                // Retorna o código do professor
                return Convert.ToInt32(resultado.Rows[0][0]);
            }
            else
            {
                // Se não houver resultados, retorna -1
                return -1;
            }
        }

        private TextBox textBoxToolTip; // Declaração do TextBox para exibir a mensagem temporária


        //
        //
        //
        //
        // mouse hover no REPETIR (explicando o que ele faz)
        

        private void ckbRepetir_MouseHover(object sender, EventArgs e)
        {
            // Inicializa o ToolTip se ainda não estiver inicializado
            if (toolTip == null)
            {
                toolTip = new ToolTip();
                toolTip.IsBalloon = true; // Define o estilo do ToolTip como um balão
                toolTip.ToolTipIcon = ToolTipIcon.Info;
            }

            // Define a mensagem do ToolTip
            toolTip.SetToolTip(ckbRepetir, "Ative esta opção se desejar repetir a reserva em vários dias.\nSerão realizadas reservas separadas para cada dia.");
        }

        private void ckbRepetir_MouseLeave(object sender, EventArgs e)
        {
            // Remove o ToolTip quando o mouse sai do controle ckbRepetir
            toolTip.Hide(ckbRepetir);
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

        private void frmReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica se o motivo do fechamento é clicar no botão de fechar da janela
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Exibe uma caixa de diálogo de confirmação
                DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o usuário confirmar a saída, fecha a conexão com o banco e encerra o programa
                if (result == DialogResult.Yes)
                {
                    // Fecha a conexão com o banco
                    // Encerra a aplicação
                    Application.Exit();
                }
                else
                {
                    // Cancela o fechamento da janela
                    e.Cancel = true;
                }
            }

        }

    }
}
