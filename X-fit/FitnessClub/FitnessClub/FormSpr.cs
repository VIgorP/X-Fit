using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace FitnessClub
{
    public partial class FormSpr : Form
    {
        string tablica;
        int id;
        string pole;
string poleid;
ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public FormSpr(string tablica,int id,string  poleid,string pole,string text1)
        {
           
            InitializeComponent();
            this.tablica = tablica;
            this.poleid = poleid;
            this.pole = pole;
            tb1.Text = text1;
            this.id = id;
        }
        private void FormSpr_Load(object sender, EventArgs e)
        {
            if (Program.insert) 
            {
                this.Text = "Добавление записи в таблицу " + tablica;
                button1.Text = "Добавить";
            }
            else {
                this.Text = "Редактирование записи в таблице " + tablica;
                button1.Text = "Сохранить изменения";
            }
            lbpole.Text = pole;
            lbtablica.Text = tablica;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Trim() == "")
            {
                MessageBox.Show("Необходимо заполнить поле " + pole,
                    "Ошибка сохранения данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand("update " + tablica+" set " +pole +" =@pole where " +poleid+"=@id", BaseFIT.con);
             //Запрос на вставку
                if (Program.insert)
                {
                    OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from " + tablica + "  where " + pole + " = '" + tb1.Text.Trim() + "'", BaseFIT.con);
                    BaseFIT.con.Open();       //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    BaseFIT.con.Close();
                    if (a > 0)
                    {
                        MessageBox.Show("Ошибка добавления,  такое значение уже есть в таблице.",
                                            "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    oleDbCommand.CommandText = "insert into   " + tablica +
" (" + pole + ") VALUES (@pole)";
                }
                else
                {
                    OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from " + tablica + "  where " + pole + " = '" + tb1.Text.Trim() + @"'
                     and "+poleid+"<>"+id.ToString(), BaseFIT.con);
                    BaseFIT.con.Open();           //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    BaseFIT.con.Close();
                    if (a > 0)
                    {
                        MessageBox.Show("Ошибка изменения, такое значение уже есть в таблице.",
                                            "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }

                
                OleDbParameter oleDbParameter2 = new OleDbParameter("@pole", OleDbType.VarChar);
                oleDbParameter2.Value = tb1.Text.Trim();
                oleDbCommand.Parameters.Add(oleDbParameter2);
               
                OleDbParameter oleDbParameter4 = new OleDbParameter("@id", OleDbType.Integer);
                oleDbParameter4.Value = id;
                oleDbCommand.Parameters.Add(oleDbParameter4);
                
                BaseFIT.con.Open(); //Открываем соединение с БД
                oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                BaseFIT.con.Close();        //Закрываем соединение
                Program.modified = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении данных в базе. \n\r" + ex.ToString(),
                    "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (BaseFIT.con != null && BaseFIT.con.State != ConnectionState.Closed)
                {
                    BaseFIT.con.Close();
                }
               
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
