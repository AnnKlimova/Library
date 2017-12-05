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
    public partial class Lending : Form
    {
                        











        private SqlConnection sqlConnection = null;

        private int id_book;

        public Lending(SqlConnection connection, int id_book)
        {

            InitializeComponent();

            sqlConnection = connection;

            this.id_book = id_book;
        }

        private void Lending_Load(object sender, EventArgs e)
        {

            LendingLV.GridLines = true;
            LendingLV.FullRowSelect = true;
            LendingLV.View = View.Details;
            LoadLendReaders();



            SqlCommand getBookInfoCommand = new SqlCommand("SELECT [id_book],[name_author],[title] FROM [Books],[Authors] WHERE [Books].[id_author]=[Authors].[id_author] and [id_book]=@id_book", sqlConnection);
            getBookInfoCommand.Parameters.AddWithValue("id_book", id_book);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = getBookInfoCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    InverNumtxt.Text = Convert.ToString(sqlReader["id_book"]);
                    Authortxt.Text = Convert.ToString(sqlReader["name_author"]);
                    NameBooktxt.Text = Convert.ToString(sqlReader["title"]);
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

        private void LoadLendReaders() //Select 
        {
            SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

            SqlCommand command = new SqlCommand("SELECT [surname],[name],[patronymic],[id_reader] FROM [Readers]", sqlConnection);
            try
            {
                sqlReader = command.ExecuteReader();//ExecuteReaderAsync() для считывания табличных представлений метод считывает бд 
                while (sqlReader.Read())
                {

                    ListViewItem item = new ListViewItem(new string[]
                    {


                        Convert.ToString(sqlReader["surname"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["patronymic"]),
                        Convert.ToString(sqlReader["id_reader"]),

                    });

                    LendingLV.Items.Add(item);
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


            /* SqlDataReader sqlReader = null;//получить таблицу в табличном представлении,считывание бд 

             SqlCommand command = new SqlCommand("SELECT [Lending].[id_reader],[surname],[name],[patronymic],[Books].[id_book],[name_author],[title],[date_of_issue],[date_of_return],[actual_date] FROM [Readers],[Lending],[Books],[Authors] WHERE [Readers].[id_reader]= [Lending].[id_reader] and [Lending].[id_book]=[Books].[id_book] and [Books].[id_author]=[Authors].[id_author] order by  actual_date", sqlConnection);

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
                         Convert.ToString(sqlReader["id_book"]),
                         Convert.ToString(sqlReader["name_author"]),
                         Convert.ToString(sqlReader["title"]),
                         Convert.ToString(sqlReader["date_of_issue"]),
                         Convert.ToString(sqlReader["date_of_return"]),
                         Convert.ToString(sqlReader["actual_date"])
                        });

                     LendiglistView2.Items.Add(item);
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
             }*/
        }

        private void LendingBut_Click(object sender, EventArgs e)
        {
            if ((ReturnDateTime.Value.Date) < (IssuDateTime.Value.Date))
            { MessageBox.Show( "Книга не может быть выдана! Дата возврата меньше даты выдачи!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                SqlCommand insertLengingCommand = new SqlCommand("INSERT INTO [Lending] (id_book,id_reader,date_of_issue,date_of_return) VALUES (@id_book, @id_reader, @date_of_issue,@date_of_return); UPDATE [Books] SET [id_status]=1 where [id_book]=@id_book", sqlConnection);
                insertLengingCommand.Parameters.AddWithValue("id_book", InverNumtxt.Text);
                insertLengingCommand.Parameters.AddWithValue("id_reader", Readertxt.Text);
                insertLengingCommand.Parameters.AddWithValue("date_of_issue", IssuDateTime.Value.Date);
                insertLengingCommand.Parameters.AddWithValue("date_of_return", ReturnDateTime.Value.Date);

                try
                {
                    insertLengingCommand.ExecuteNonQuery();
                    Close();
                }

                catch (Exception ex)//обработчик исключения 
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } }
        }

        private void ReaderSearchtxt_TextChanged(object sender, EventArgs e)
        {
            if (ReaderSearchtxt.Text != "")
            {
                for (int i = LendingLV.Items.Count - 1; i >= 0; i--)
                {
                    var item = LendingLV.Items[i];
                    if (item.Text.ToLower().Contains(ReaderSearchtxt.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.GrayText;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        LendingLV.Items.Remove(item);
                    }
                }
                if (LendingLV.SelectedItems.Count == 1)
                {
                    LendingLV.Focus();
                }
            }
            else
                LoadLendReaders();
        }
    }
}
    