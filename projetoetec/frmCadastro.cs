using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmCadastro : Form
    {
        private dal_SQLiteDBManager dbManager;

        public frmCadastro()
        {
            InitializeComponent();
            dbManager = new dal_SQLiteDBManager(@"D:\etecja_reservas.db");
            dbManager.AbrirConexao();
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
                string comandoSQL = "SELECT lab_nome || ' - ' || lab_sala AS nome_sala FROM laboratorio";

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

                    // Pede confirmação ao usuário antes de excluir o laboratório
                    DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o laboratório '{nomeLab}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica se o usuário confirmou a exclusão
                    if (result == DialogResult.Yes)
                    {
                        // Cria a string SQL para excluir o registro da tabela laboratorio com base no nome do laboratório
                        string comandoSQL = $"DELETE FROM laboratorio WHERE lab_nome || ' - ' || lab_sala = '{nomeLab}'";

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
                string comandoSQL = "SELECT prof_nome || ' - ' || prof_disciplina AS nome_disciplina FROM professor";

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
                // Cria a string SQL para inserir os dados na tabela professor
                string comandoSQL = $"INSERT INTO professor (prof_nome, prof_disciplina, prof_email, prof_celular) VALUES ('{nomeProf}', '{disciplinaProf}', '{email}', '{cel}')";

                try
                {
                    // Chama o método para inserir dados no banco de dados
                    dbManager.InserirDados(comandoSQL);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa as caixas de texto após o cadastro
                    txtProfessor.Clear();
                    maskedTxtCelular.Clear();
                    txtEmail.Clear();
                    txtDisciplinaProf.Clear();                    
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

                    // Pede confirmação ao usuário antes de excluir o professor
                    DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o professor '{nomeProf}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica se o usuário confirmou a exclusão
                    if (result == DialogResult.Yes)
                    {
                        // Cria a string SQL para excluir o registro da tabela professor com base no nome do professor
                        string comandoSQL = $"DELETE FROM professor WHERE prof_nome || ' - ' || prof_disciplina = '{nomeProf}'";

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
                
    }
}
