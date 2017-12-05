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

namespace Library
{
    public partial class UpdateReader : Form
    {
        private SqlConnection sqlConnection = null;

        private int id_reader;

        public UpdateReader(SqlConnection connection, int id_reader)
        {
            InitializeComponent();

            sqlConnection = connection;

            this.id_reader = id_reader;
        }

        private void UpdateReader_Load(object sender, EventArgs e)
        {
            SqlCommand getReaderInfoCommand = new SqlCommand("SELECT [surname],[name],[patronymic],[date_of_birth],[passport],[address],[phone],[email] FROM [Readers] WHERE [id_reader]=@id_reader", sqlConnection);
            getReaderInfoCommand.Parameters.AddWithValue("id_reader", id_reader);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = getReaderInfoCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Famtxt.Text = Convert.ToString(sqlReader["surname"]);
                    Nametxt.Text = Convert.ToString(sqlReader["name"]);
                    textBox3.Text = Convert.ToString(sqlReader["patronymic"]);
                    dateTimePicker1.Value= Convert.ToDateTime(sqlReader["date_of_birth"]);
                    textBox6.Text = Convert.ToString(sqlReader["passport"]);
                    textBox5.Text = Convert.ToString(sqlReader["address"]);
                    maskedTextBox1.Text = Convert.ToString(sqlReader["phone"]);
                    textBox9.Text = Convert.ToString(sqlReader["email"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();

            }
        }

        private void ReaderUpdateBut_Click(object sender, EventArgs e)
        {
            SqlCommand updateReaderCommand = new SqlCommand("UPDATE [Readers] SET [surname]=@surname,[name]=@name,[patronymic]=@patronymic,[date_of_birth]=@date_of_birth,[passport]=@passport,[address]=@address,[phone]=@phone,[email]=@email WHERE [id_reader]=@id_reader",sqlConnection);
            
            updateReaderCommand.Parameters.AddWithValue("id_reader", id_reader);
            updateReaderCommand.Parameters.AddWithValue("surname", Famtxt.Text);
            updateReaderCommand.Parameters.AddWithValue("name", Nametxt.Text);
            updateReaderCommand.Parameters.AddWithValue("patronymic", textBox3.Text);
            updateReaderCommand.Parameters.AddWithValue("date_of_birth", dateTimePicker1.Value.Date);
            updateReaderCommand.Parameters.AddWithValue("passport", textBox6.Text);
            updateReaderCommand.Parameters.AddWithValue("address", textBox5.Text);
            updateReaderCommand.Parameters.AddWithValue("phone", maskedTextBox1.Text);
            updateReaderCommand.Parameters.AddWithValue("email", textBox9.Text);

            try
            {
                updateReaderCommand.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelUpdetBut_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string UserEmail
        {
            get
            {
                return textBox9.Text;
            }
        }
        /*private void textBox9_Validating(object sender, CancelEventArgs e)
        {

                string email = textBox9.Text;

                if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                {
                    errorProvider1.SetError(textBox9,
                      "Неправильный адрес E-Mail");
                }
                else
                    errorProvider1.SetError(textBox9, "");
            
        }*/
    }
}
