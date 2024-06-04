using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaGeral : Form
    {
        private dal_SQLServerDBManager dbManager;

        public frmConsultaGeral()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
        }

        private void frmConsultaGeral_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
            cboProfessor.Text = "Selecione um(a) professor(a)";
            cboProfessor.SelectedIndexChanged += cboProfessor_SelectedIndexChanged;
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

        private void cboProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProfessor.SelectedIndex >= 0)
            {
                // Obter o professor selecionado do ComboBox
                string professorSelecionado = cboProfessor.SelectedItem.ToString().Split('-')[0].Trim();

                // Consultar o banco de dados para obter informações do professor selecionado
                string comandoSQL = $"SELECT prof_disciplina, prof_email, prof_celular FROM professor WHERE prof_nome = '{professorSelecionado}'";

                DataTable dtProfessor = dbManager.ConsultarDados(comandoSQL);

                // Verificar se há informações do professor
                if (dtProfessor.Rows.Count > 0)
                {
                    // Obter as informações do professor a partir do DataTable
                    string disciplina = dtProfessor.Rows[0]["prof_disciplina"].ToString();
                    string email = dtProfessor.Rows[0]["prof_email"].ToString();
                    string celular = dtProfessor.Rows[0]["prof_celular"].ToString();

                    // Atualizar os rótulos com as informações do professor
                    lblNomeSelected.Text = professorSelecionado;
                    lblDisciplinaProfSelected.Text = disciplina != "" ? disciplina : "—";
                    lblEmailSelected.Text = email != "" ? email : "—";
                    lblCelularSelected.Text = celular != "" ? celular : "—";

                    // Contar e exibir o número de reservas do professor
                    int profCod = Convert.ToInt32(dtProfessor.Rows[0]["prof_cod"]);
                    lblReservasSelected.Text = ContarReservas(profCod).ToString();
                }
            }


        }



        // Função para contar as reservas do professor
        private int ContarReservas(int profCod)
        {
            int numReservas = 0;
            try
            {
                string comandoSQL = $"SELECT COUNT(*) FROM reserva WHERE prof_cod = {profCod}";
                DataTable dtReservas = dbManager.ConsultarDados(comandoSQL);

                if (dtReservas.Rows.Count > 0)
                    numReservas = Convert.ToInt32(dtReservas.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao contar as reservas do professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return numReservas;
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

        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
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
