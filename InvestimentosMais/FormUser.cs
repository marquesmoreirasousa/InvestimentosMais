using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestimentosMais
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM TB_User";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id        = (int)dr["Id"];
                    string name   = (string)dr["Name"];
                    string job    = (string)dr["Job"];
                    string email  = (string)dr["Email"];
                    string cpf    = (string)dr["Cpf"];
                    string gender = (string)dr["Gender"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(job);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(cpf);
                    lv.SubItems.Add(gender);
                    LtvList.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            txbJob.Clear();
            txbEmail.Clear();
            mtbCPF.Clear();
            cmbGender.ResetText();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO TB_User VALUES 
            (@name, @job, @email, @cpf, @gender)";

            sqlCommand.Parameters.AddWithValue("@name", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@job", txbJob.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@gender", cmbGender.Text);

            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            MessageBox.Show(
                "Cadastrado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
