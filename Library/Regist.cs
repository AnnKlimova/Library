using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//сборка для работы с бд
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Regist : Form
    {
        private SqlConnection sqlConnection=null;

        public Regist(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }
        //
        private void Registbutton_Click(object sender, EventArgs e)
        {
            
           
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&

                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&

                !string.IsNullOrEmpty(Passporttxt.Text) && !string.IsNullOrWhiteSpace(Passporttxt.Text) &&

                !string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrWhiteSpace(maskedTextBox1.Text) &&

                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) )

                {

                    SqlCommand insertReadersCommand = new SqlCommand("INSERT INTO [Readers] (surname,name,patronymic,date_of_birth,passport,address,phone,email) VALUES (@surname, @name, @patronymic,@date_of_birth,@passport,@address,@phone,@email)", sqlConnection);
                    insertReadersCommand.Parameters.AddWithValue("surname", textBox1.Text);
                    insertReadersCommand.Parameters.AddWithValue("name", textBox2.Text);
                    insertReadersCommand.Parameters.AddWithValue("patronymic", textBox3.Text);
                    insertReadersCommand.Parameters.AddWithValue("date_of_birth", dateTimePicker1.Value.Date);
                    insertReadersCommand.Parameters.AddWithValue("passport", Passporttxt.Text);
                    insertReadersCommand.Parameters.AddWithValue("address", textBox5.Text);
                    insertReadersCommand.Parameters.AddWithValue("phone", maskedTextBox1.Text);
                    insertReadersCommand.Parameters.AddWithValue("email", textBox9.Text);

                    try
                    {
                        insertReadersCommand.ExecuteNonQuery();
                        Close();
                    }

                    catch (Exception ex)//обработчик исключения 
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } }
            else

            {

                MessageBox.Show("Поля со звёздочкой(*) обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void RegistCloseBut_Click(object sender, EventArgs e)
        {

            Close();
        }

        //событие KeyPress 
        private void Passporttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //условие позволяет вводить только числа, не игнорируя клавиши удаления вводимых символов
            {
                if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    
                e.Handled = true;
            }
        }
    }
}
