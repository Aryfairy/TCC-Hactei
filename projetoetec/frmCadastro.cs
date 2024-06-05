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

        //
        //
        //
        //
        //CarregarCombobox Lab, Cadastro e Deleção de Laboratórios
        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) AS nome_sala FROM laboratorio";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarLab_Click(object sender, EventArgs e)
        {
            // Captura os valores das TextBoxes
            string nomeLaboratorio = txtLaboratorio.Text;
            string disciplina = txtDisciplinaLab.Text;
            string sala = txtSala.Text;

            // Verifica se os campos não estão vazios
            if (!string.IsNullOrEmpty(nomeLaboratorio) && !string.IsNullOrEmpty(disciplina) && !string.IsNullOrEmpty(sala))
            {
                try
                {
                    // Verifica se já existe um laboratório com as mesmas informações
                    if (dbManager.VerificarLaboratorioDuplicado(nomeLaboratorio, disciplina, sala))
                    {
                        MessageBox.Show("Já existe um laboratório cadastrado com essas informações.");
                        return;
                    }

                    // Constrói o comando SQL de inserção
                    string comandoSQL = $"INSERT INTO laboratorio (lab_nome, lab_disc, lab_sala) VALUES ('{nomeLaboratorio}', '{disciplina}', '{sala}')";

                    // Executa o comando SQL para inserir os dados no banco de dados
                    dbManager.InserirDados(comandoSQL);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa as TextBoxes após o cadastro
                    txtLaboratorio.Clear();
                    txtDisciplinaLab.Clear();
                    txtSala.Clear();
                    CarregarLaboratorios();
                    cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibe uma mensagem de erro
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem de aviso se os campos estiverem vazios
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarLab_Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado no ComboBox de laboratórios
            if (cboLaboratorio.SelectedItem != null)
            {
                // Verifica se o item selecionado é do tipo DataRowView
                if (cboLaboratorio.SelectedItem is DataRowView rowView)
                {
                    // Recupera o nome do laboratório selecionado
                    string nomeLab = rowView["nome_sala"].ToString();

                    // Verifica se há reservas associadas ao laboratório
                    string verificarReservasSQL = $"SELECT COUNT(*) FROM reserva " +
                                                  $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                                  $"WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}'";

                    int reservaCount = (int)dbManager.ConsultarDados(verificarReservasSQL).Rows[0][0];

                    if (reservaCount > 0)
                    {
                        DialogResult result = MessageBox.Show($"Existem {reservaCount} reservas associadas a este laboratório. Deseja continuar com a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }

                        // Exclui as reservas associadas ao laboratório
                        string deletarReservasSQL = $"DELETE reserva FROM reserva " +
                                                    $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                                    $"WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}'";

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

                    // Pede confirmação ao usuário antes de excluir o laboratório
                    DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o laboratório '{nomeLab}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica se o usuário confirmou a exclusão
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Cria a string SQL para excluir o registro da tabela laboratorio com base no nome do laboratório
                        string comandoSQL = $"DELETE FROM laboratorio WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{nomeLab}'";

                        try
                        {
                            // Chama o método para executar o comando de exclusão no banco de dados
                            dbManager.InserirDados(comandoSQL);

                            // Exibe uma mensagem de sucesso
                            MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remova o vínculo da fonte de dados para evitar o erro
                            cboLaboratorio.DataSource = null;

                            // Atualiza a lista de laboratórios
                            cboLaboratorio.Items.Clear();
                            CarregarLaboratorios();
                            cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
                        }
                        catch (Exception ex)
                        {
                            // Em caso de erro, exibe uma mensagem de erro
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Exibe uma mensagem de aviso se nenhum laboratório estiver selecionado no ComboBox
                MessageBox.Show("Selecione um laboratório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //
        //
        //
        //
        //CarregarCombobox Prof, Cadastro e Deleção de Professores
        private void CarregarProfessores()
        {
            try
            {
                // Consulta SQL para selecionar o nome do professor e a disciplina, concatenando-os
                string comandoSQL = "SELECT CONCAT(prof_nome, ' - ', prof_disciplina) AS nome_disciplina FROM professor";

                // Chama o método para carregar o ComboBox
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

            // Verifica se os campos não estão vazios
            if (!string.IsNullOrEmpty(nomeProf) && !string.IsNullOrEmpty(disciplinaProf))
            {
                // Verifica se o celular não está vazio e se é um número válido
                long? celular = null; // Definido como nullable para permitir valor nulo
                if (!string.IsNullOrEmpty(cel) && long.TryParse(cel, out long parsedCelular))
                {
                    celular = parsedCelular;
                }

                try
                {
                    // Verifica se já existe um professor com as mesmas informações
                    if (dbManager.VerificarProfessorDuplicado(nomeProf, disciplinaProf))
                    {
                        MessageBox.Show("Já existe um professor cadastrado com essas informações.");
                        return;
                    }

                    // Cria a string SQL para inserir os dados na tabela professor
                    string comandoSQL = $"INSERT INTO professor (prof_nome, prof_disciplina, prof_email, prof_celular) VALUES ('{nomeProf}', '{disciplinaProf}', '{email}', ";

                    // Adiciona o valor do celular, se estiver presente
                    if (celular != null)
                    {
                        comandoSQL += $"{celular}";
                    }
                    else
                    {
                        comandoSQL += "NULL";
                    }
                    comandoSQL += ")";

                    // Chama o método para inserir dados no banco de dados
                    dbManager.InserirDados(comandoSQL);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa as caixas de texto após o cadastro
                    txtProfessor.Clear();
                    maskedTxtCelular.Clear();
                    txtEmail.Clear();
                    txtDisciplinaProf.Clear();
                    CarregarProfessores();
                    cboProfessor.Text = "Selecione o professor que deseja deletar";
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibe uma mensagem de erro
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem de aviso se os campos estiverem vazios
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarprof_Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado no ComboBox de professores
            if (cboProfessor.SelectedItem != null)
            {
                // Verifica se o item selecionado é do tipo DataRowView
                if (cboProfessor.SelectedItem is DataRowView rowView)
                {
                    // Recupera o nome do professor selecionado
                    string nomeProf = rowView["nome_disciplina"].ToString();

                    // Verifica se há reservas associadas ao professor
                    string verificarReservasSQL = $"SELECT COUNT(*) FROM reserva " +
                                                  $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                                  $"WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}'";

                    int reservaCount = (int)dbManager.ConsultarDados(verificarReservasSQL).Rows[0][0];

                    if (reservaCount > 0)
                    {
                        DialogResult result = MessageBox.Show($"Existem {reservaCount} reservas associadas a este professor. Deseja continuar com a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }

                        // Exclui as reservas associadas ao professor
                        string deletarReservasSQL = $"DELETE reserva FROM reserva " +
                                                    $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                                    $"WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}'";

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

                    // Pede confirmação ao usuário antes de excluir o professor
                    DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o professor '{nomeProf}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica se o usuário confirmou a exclusão
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Cria a string SQL para excluir o registro da tabela professor com base no nome do professor
                        string comandoSQL = $"DELETE FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = '{nomeProf}'";

                        try
                        {
                            // Chama o método para executar o comando de exclusão no banco de dados
                            dbManager.InserirDados(comandoSQL);

                            // Exibe uma mensagem de sucesso
                            MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remova o vínculo da fonte de dados para evitar o erro
                            cboProfessor.DataSource = null;

                            // Atualiza a lista de professores
                            cboProfessor.Items.Clear();
                            CarregarProfessores();
                            cboProfessor.Text = "Selecione o professor que deseja deletar";
                        }
                        catch (Exception ex)
                        {
                            // Em caso de erro, exibe uma mensagem de erro
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Exibe uma mensagem de aviso se nenhum professor estiver selecionado no ComboBox
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
            this.Close();
        }

        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Close();
        }

        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Close();
        }

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
