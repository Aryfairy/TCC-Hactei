using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmCadastro : Form
    {
        private dal_SQLServerDBManager dbManager;
        public frmCadastro()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
            this.FormClosing += new FormClosingEventHandler(frmCadastro_FormClosing);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            CarregarLaboratorios();
            CarregarProfessores();
            cboLaboratorio.SelectedIndex = -1;
            cboProfessor.SelectedIndex = -1;
            cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
            cboProfessor.Text = "Selecione o professor que deseja deletar";
        }

        private void CarregarLaboratorios()
        {
            try
            {
                string comandoSQL = "SELECT CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) AS nome_sala FROM laboratorio";
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarLab_Click(object sender, EventArgs e)
        {
            string nomeLaboratorio = txtLaboratorio.Text;
            string disciplina = txtDisciplinaLab.Text;
            string sala = txtSala.Text;

            if (!string.IsNullOrEmpty(nomeLaboratorio) && !string.IsNullOrEmpty(disciplina) && !string.IsNullOrEmpty(sala))
            {
                try
                {
                    if (dbManager.VerificarLaboratorioDuplicado(nomeLaboratorio, disciplina, sala))
                    {
                        MessageBox.Show("Já existe um laboratório cadastrado com essas informações.");
                        return;
                    }

                    string comandoSQL = $"INSERT INTO laboratorio (lab_nome, lab_disc, lab_sala) VALUES ('{nomeLaboratorio}', '{disciplina}', '{sala}')";
                    dbManager.InserirDados(comandoSQL);

                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtLaboratorio.Clear();
                    txtDisciplinaLab.Clear();
                    txtSala.Clear();
                    CarregarLaboratorios();
                    cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarLab_Click(object sender, EventArgs e)
        {
            if (cboLaboratorio.SelectedItem != null)
            {
                if (cboLaboratorio.SelectedItem is DataRowView rowView)
                {
                    string nomeLab = rowView["nome_sala"].ToString();
                    string verificarReservasSQL = $"SELECT COUNT(*) FROM reserva " +
                                                  $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                                  $"WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}' " +
                                                  $"AND res_data >= CONVERT(date, GETDATE())";

                    int reservaCount = (int)dbManager.ConsultarDados(verificarReservasSQL).Rows[0][0];

                    if (reservaCount > 0)
                    {
                        DialogResult result = MessageBox.Show($"Existem {reservaCount} reservas futuras associadas a este laboratório. Deseja continuar com a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }

                        string deletarReservasSQL = $"DELETE reserva FROM reserva " +
                                                    $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                                    $"WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}' " +
                                                    $"AND res_data >= CONVERT(date, GETDATE())";

                        try
                        {
                            dbManager.InserirDados(deletarReservasSQL);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir as reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o laboratório '{nomeLab}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string comandoSQL = $"DELETE FROM laboratorio WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}'";

                        try
                        {
                            dbManager.InserirDados(comandoSQL);
                            MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cboLaboratorio.DataSource = null;
                            cboLaboratorio.Items.Clear();
                            CarregarLaboratorios();
                            cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um laboratório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregarProfessores()
        {
            try
            {
                string comandoSQL = "SELECT CONCAT(prof_nome, ' - ', prof_disciplina) AS nome_disciplina FROM professor";
                dbManager.CarregarComboBox(cboProfessor, comandoSQL, "nome_disciplina");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarProf_Click(object sender, EventArgs e)
        {
            string nomeProf = txtProfessor.Text;
            string cel = maskedTxtCelular.Text;
            string email = txtEmail.Text;
            string disciplinaProf = txtDisciplinaProf.Text;

            if (!string.IsNullOrEmpty(nomeProf) && !string.IsNullOrEmpty(disciplinaProf))
            {
                long? celular = null;
                if (!string.IsNullOrEmpty(cel) && long.TryParse(cel, out long parsedCelular))
                {
                    celular = parsedCelular;
                }

                try
                {
                    if (dbManager.VerificarProfessorDuplicado(nomeProf, disciplinaProf))
                    {
                        MessageBox.Show("Já existe um professor cadastrado com essas informações.");
                        return;
                    }

                    string comandoSQL = $"INSERT INTO professor (prof_nome, prof_disciplina, prof_email, prof_celular) VALUES ('{nomeProf}', '{disciplinaProf}', '{email}', ";
                    if (celular != null)
                    {
                        comandoSQL += $"{celular}";
                    }
                    else
                    {
                        comandoSQL += "NULL";
                    }
                    comandoSQL += ")";

                    dbManager.InserirDados(comandoSQL);
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtProfessor.Clear();
                    maskedTxtCelular.Clear();
                    txtEmail.Clear();
                    txtDisciplinaProf.Clear();
                    CarregarProfessores();
                    cboProfessor.Text = "Selecione o professor que deseja deletar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarprof_Click(object sender, EventArgs e)
        {
            if (cboProfessor.SelectedItem != null)
            {
                if (cboProfessor.SelectedItem is DataRowView rowView)
                {
                    string nomeProf = rowView["nome_disciplina"].ToString();
                    string verificarReservasSQL = $"SELECT COUNT(*) FROM reserva " +
                                                  $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                                  $"WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}' " +
                                                  $"AND res_data >= CONVERT(date, GETDATE())";

                    int reservaCount = (int)dbManager.ConsultarDados(verificarReservasSQL).Rows[0][0];

                    if (reservaCount > 0)
                    {
                        DialogResult result = MessageBox.Show($"Existem {reservaCount} reservas futuras associadas a este professor. Deseja continuar com a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }

                        string deletarReservasSQL = $"DELETE reserva FROM reserva " +
                                                    $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                                    $"WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}' " +
                                                    $"AND res_data >= CONVERT(date, GETDATE())";

                        try
                        {
                            dbManager.InserirDados(deletarReservasSQL);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir as reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o professor '{nomeProf}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string comandoSQL = $"DELETE FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}'";

                        try
                        {
                            dbManager.InserirDados(comandoSQL);
                            MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cboProfessor.DataSource = null;
                            cboProfessor.Items.Clear();
                            CarregarProfessores();
                            cboProfessor.Text = "Selecione o professor que deseja deletar";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um professor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //
        //
        //
        //
        // Mudança de telas
        private void lnkConsultaDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaDia abrir = new frmConsultaDia();
            abrir.Show();
            this.Hide();
        }


        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Hide();
        }

        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Hide();
        }

        //
        //
        //
        //
        // Encerrando o programa
        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
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
