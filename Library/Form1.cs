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
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection;//объект для подключения к бд

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Authors". При необходимости она может быть перемещена или удалена.
            
            string connectionString = @"Data Source=DESKTOP-OBS3UFE\SQLEXPRESS2008R2;Initial Catalog=library;User ID=sa;Password=admin123";//подключение БД
            sqlConnection = new SqlConnection(connectionString);//получение ссылки на экземпляр класса qlConnection

            sqlConnection.Open();
            //прорисовка ListView
            BooksListView1.GridLines = true;
            BooksListView1.FullRowSelect = true;
            BooksListView1.View = View.Details;

            ReaderLV1.GridLines = true;
            ReaderLV1.FullRowSelect = true;
            ReaderLV1.View = View.Details;

            readlistView2.GridLines = true;
            readlistView2.FullRowSelect = true;
            readlistView2.View = View.Details;

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            LoadLocBooks();
            LoadReaders();
            //LoadLendReaders();
            Formulyar();

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void LoadReaders() //вывод таблицы читателей
        {
            SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

            SqlCommand command = new SqlCommand("SELECT [id_reader],[surname],[name],[patronymic],[date_of_birth],[date_of_birth],[phone],[email],[date_regist],[address],[passport] FROM [Readers]", sqlConnection);
            try
            {
                sqlReader = command.ExecuteReader();//ExecuteReader() для считывания табличных представлений метод считывает бд 
                while (sqlReader.Read())
                {

                    ListViewItem item = new ListViewItem(new string[]{

                        Convert.ToString(sqlReader["id_reader"]),
                        Convert.ToString(sqlReader["surname"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["patronymic"]),
                        Convert.ToString(sqlReader["date_of_birth"]),
                        Convert.ToString(sqlReader["phone"]),
                        Convert.ToString(sqlReader["email"]),
                        Convert.ToString(sqlReader["date_regist"]),
                        Convert.ToString(sqlReader["address"]),
                        Convert.ToString(sqlReader["passport"])
                       });

                    ReaderLV1.Items.Add(item);
                }
            }
            catch (Exception ex)//обработчик исключения 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //действия в любом из случаев пройдет или не пройдет код 
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
        }


        private void Formulyar() //вывод таблицы читателей
        {
            SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

            SqlCommand com = new SqlCommand("SELECT [Books].[id_book],[name_author],[title], [date_of_issue],[date_of_return],[actual_date],[Lending].[id_reader],[surname],[name],[patronymic],[phone] FROM [Readers],[Lending],[Books],[Authors] WHERE [Readers].[id_reader]= [Lending].[id_reader] and [Lending].[id_book]=[Books].[id_book] and [Books].[id_author]=[Authors].[id_author]", sqlConnection);



            try
            {
                sqlReader = com.ExecuteReader();//ExecuteReaderAsync() для считывания табличных представлений метод считывает бд 
                while (sqlReader.Read())
                {

                    ListViewItem item = new ListViewItem(new string[]{

                        Convert.ToString(sqlReader["id_book"]),
                        Convert.ToString(sqlReader["name_author"]),
                        Convert.ToString(sqlReader["title"]),
                        Convert.ToString(sqlReader["date_of_issue"]),
                        Convert.ToString(sqlReader["date_of_return"]),
                        Convert.ToString(sqlReader["actual_date"])  ,
                        Convert.ToString(sqlReader["id_reader"]),
                        Convert.ToString(sqlReader["surname"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["patronymic"]),
                        Convert.ToString(sqlReader["phone"])
                       });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)//обработчик исключения 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //действия в любом из случаев пройдет или не пройдет код 
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }

        }

        /* private void LoadLendReaders() //Select 
         {
             SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

             SqlCommand command = new SqlCommand("SELECT [Lending].[id_reader],[surname],[name],[patronymic],[date_of_birth],[phone],[Books].[id_book],[name_author],[title],[date_of_issue],[date_of_return],[actual_date] FROM [Readers],[Lending],[Books],[Authors] WHERE [Readers].[id_reader]= [Lending].[id_reader] and [Lending].[id_book]=[Books].[id_book] and [Books].[id_author]=[Authors].[id_author] order by  actual_date", sqlConnection);



                 try
                 {
                     sqlReader = command.ExecuteReader();//ExecuteReaderAsync() для считывания табличных представлений метод считывает бд 
                     while (sqlReader.Read())
                     {

                         ListViewItem item = new ListViewItem(new string[]{

                         Convert.ToString(sqlReader["id_reader"]),
                         Convert.ToString(sqlReader["surname"]),
                         Convert.ToString(sqlReader["name"]),
                         Convert.ToString(sqlReader["patronymic"]),
                         Convert.ToString(sqlReader["date_of_birth"]),
                         Convert.ToString(sqlReader["phone"]),
                         Convert.ToString(sqlReader["id_book"]),
                         Convert.ToString(sqlReader["name_author"]),
                         Convert.ToString(sqlReader["title"]),
                         Convert.ToString(sqlReader["date_of_issue"]),
                         Convert.ToString(sqlReader["date_of_return"]),
                         Convert.ToString(sqlReader["actual_date"])
                        });

                         readlistView2.Items.Add(item);
                     }
                 }
                 catch (Exception ex)//обработчик исключения 
                 {
                     MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 //действия в любом из случаев пройдет или не пройдет код 
                 finally
                 {
                     if (sqlReader != null && !sqlReader.IsClosed)
                         sqlReader.Close();
                 }
             }
             */
        private void LoadLocBooks() //Таблица с местонахождением книг
        {
            SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

            SqlCommand command = new SqlCommand("SELECT [id_book],[name_author],[title],[genre],[status],[room],[rack],[shelf] FROM [Books],[Authors],[Genre],[Status],[Location] WHERE [Status].[id_status]= [Books].[id_status] and [Books].[id_author]=[Authors].[id_author] AND  [Books].[id_genre]=[Genre].[id_genre] and [Location].[id_location]=[Books].[id_location] order by status desc", sqlConnection);

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {

                    ListViewItem item = new ListViewItem(new string[]{
                        Convert.ToString(sqlReader["id_book"]),
                        Convert.ToString(sqlReader["name_author"]),
                        Convert.ToString(sqlReader["title"]),
                        Convert.ToString(sqlReader["genre"]),
                        Convert.ToString(sqlReader["status"]),
                        Convert.ToString(sqlReader["room"]),
                        Convert.ToString(sqlReader["rack"]),
                        Convert.ToString(sqlReader["shelf"])
                       });

                    BooksListView1.Items.Add(item);
                    
                }
            }
            catch (Exception ex)//обработчик исключения 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //действия в любом из случаев пройдет или не пройдет код 
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
            
        }

        private void ReaderLV1But_Click(object sender, EventArgs e)
        {
            ReaderLV1.Items.Clear();
            LoadReaders();
        }

        private void RegistBut_Click(object sender, EventArgs e)//кнопка для открытия формы регистрации читателя
        {
            Regist insert = new Regist(sqlConnection);
            insert.Show();
        }


        private void Updatebut_Click(object sender, EventArgs e)//кнопка для открытия формы редактирование данных читателя
        {
            if (ReaderLV1.SelectedItems.Count > 0)
            {
                UpdateReader update = new UpdateReader(sqlConnection, Convert.ToInt32(ReaderLV1.SelectedItems[0].SubItems[0].Text));
                update.Show();
            }
            else
            {
                MessageBox.Show("Ни одна строка не выделена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obnovbut_Click(object sender, EventArgs e)//Обновление таблицы читателей
        {
            BooksListView1.Items.Clear();
            LoadLocBooks();
        }

        private void Vidatbut_Click(object sender, EventArgs e)//Кнопка для вызова формы выдачи книги
        {
            if (BooksListView1.SelectedItems.Count > 0)
            {
                Lending update = new Lending(sqlConnection, Convert.ToInt32(BooksListView1.SelectedItems[0].SubItems[0].Text));
                update.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать книгу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
/*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

            SqlCommand command = new SqlCommand("SELECT [name_author] FROM [Authors]", sqlConnection);


            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {

                    ListViewItem item = new ListViewItem(new string[]{


                        Convert.ToString(sqlReader["name_author"])

                       });

                    comboBox1.Items.Add(item);
                }
            }
            catch (Exception ex)//обработчик исключения 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //действия в любом из случаев пройдет или не пройдет код 
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
        }*/

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(textBox3.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.GrayText;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
                Formulyar();

        }

        private void ReaderDeleteBut_Click_1(object sender, EventArgs e)
        {
            if (ReaderLV1.SelectedItems.Count > 0)
            {

                DialogResult res = MessageBox.Show("Вы действительно хотите удалить читателя?", "Удаление строки", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                switch (res)
                {
                    case DialogResult.OK:

                        SqlCommand deleteReadersCommand = new SqlCommand("DELETE FROM [Readers] where [id_reader]=@id_reader", sqlConnection);

                        deleteReadersCommand.Parameters.AddWithValue("id_reader", Convert.ToInt32(ReaderLV1.SelectedItems[0].SubItems[0].Text));

                        try
                        {
                            deleteReadersCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)//обработчик исключения 
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ReaderLV1.Items.Clear();//действия в любом из случаев пройдет или не пройдет код 

                        LoadReaders();

                        break;
                }
            }
            else
            {
                MessageBox.Show("Ни одна строка не выделена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

