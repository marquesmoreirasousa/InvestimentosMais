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
        private int Id;
        public FormUser()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            LtvList.Items.Clear();

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
                    int id = (int)dr["Id"];
                    string name = (string)dr["Name"];
                    string job = (string)dr["Job"];
                    string email = (string)dr["Email"];
                    string cpf = (string)dr["Cpf"];
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
        private void ClearFields()
        {
            txbName.Clear();
            txbJob.Clear();
            txbEmail.Clear();
            mtbCPF.Clear();
            cmbGender.ResetText();
            btnInsert.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
            ClearFields();
            UpdateListView();

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

        private void mtbCEP_TextChanged(object sender, EventArgs e)
        {
            if (mtbCEP.Text.Length == 9)
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        MessageBox.Show(mtbCEP.Text.Replace('-', ' '));
                        var end = ws.consultaCEP(mtbCEP.Text.Replace("-", ""));
                        txbStreet.Text = end.end;
                        txbNeighborhood.Text = end.bairro;
                        txbCity.Text = end.cidade;
                        txbState.Text = end.uf;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO ao consultar CEP\n" + ex.Message);
                    }
                }
            }
        }

        private void LtvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = LtvList.FocusedItem.Index;
            Id = int.Parse(LtvList.Items[index].SubItems[0].Text);
            txbName.Text = LtvList.Items[index].SubItems[1].Text;
            txbJob.Text = LtvList.Items[index].SubItems[2].Text;
            txbEmail.Text = LtvList.Items[index].SubItems[3].Text;
            mtbCPF.Text = LtvList.Items[index].SubItems[4].Text;
            cmbGender.Text = LtvList.Items[index].SubItems[5].Text;
            btnInsert.Enabled = false;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE TB_User SET 
            Name = @name, 
            Job = @job, 
            Email = @email, 
            Cpf = @cpf, 
            Gender = @gender
            WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@name", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@job", txbJob.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@gender", cmbGender.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);

            try
            {
                //IEditar o cliente
                sqlCommand.ExecuteNonQuery();

                ClearFields();

                MessageBox.Show(
                "Atualizado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: Problemas ao editar usuário no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            
            UpdateListView();   
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM TB_User WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@id", Id);

            try
            {
                //Excluir o cliente
                sqlCommand.ExecuteNonQuery();

                ClearFields();

                MessageBox.Show(
                "Excluído com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: Problemas ao excluir usuário no banco.\n"
                    + error.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            UpdateListView();
        }
    }
}
