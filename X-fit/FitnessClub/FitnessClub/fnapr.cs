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
    public partial class fnapr : Form
    {
        int kod;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public fnapr(int kod)
        {
            InitializeComponent();
            this.kod= kod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка
            string s = ""; 
            

            if (tbnamenapr.Text.Trim() == "") s += "Название направления" + Environment.NewLine;
         
            if (s != "")
            {
                MessageBox.Show("Не заполнено название направления" );
                return; //если что-то не заполнено
            }

            //проверка целостности
            if (Program.insert)
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Направления  where Направление = '" + tbnamenapr.Text.Trim() + "'", BaseFIT.con);
                BaseFIT.con.Open();       //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка добавление,  такое название направления  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            else
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Направления  where Направление =  '" + tbnamenapr.Text.Trim()
                    + @"' and  КодНаправления <>" + kod.ToString(), BaseFIT.con);
                BaseFIT.con.Open();           //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка изменения, такое название направления  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            try
            {

                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Направления set " +
@"Направление=@Направление, 
Описание=@Описание
where КодНаправления=@КодНаправления", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка


                    oleDbCommand.CommandText = "insert into Направления  " +
@" (Направление, 

Описание) VALUES 
( @Направление, 
@Описание)";
                }

                //добавляем параметры

                OleDbParameter oleDbParameter1 = new OleDbParameter("@Направление", OleDbType.VarChar);
                oleDbParameter1.Value = tbnamenapr.Text; oleDbCommand.Parameters.Add(oleDbParameter1);

                                OleDbParameter oleDbParameter9 = new OleDbParameter("@Описание", OleDbType.VarChar);
                oleDbParameter9.Value = tbopis.Text; oleDbCommand.Parameters.Add(oleDbParameter9);

                OleDbParameter oleDbParameter10 = new OleDbParameter("@КодНаправления", OleDbType.Integer);
                oleDbParameter10.Value = kod;
                oleDbCommand.Parameters.Add(oleDbParameter10);

                //Добавляем параметр
                BaseFIT.con.Open(); //Открываем соединение с БД

                oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                BaseFIT.con.Close();        //Закрываем соединение
                Program.modified = true;
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
                this.Close();
            }
        }

        private void fnapr_Load(object sender, EventArgs e)
        {
            if (!Program.insert)
            {
                string sql = @"SELECT КодНаправления, Направление, описание
FROM Направления
WHERE КодНаправления=" + kod.ToString();


                //   MessageBox.Show(sql);
                this.Text = "Редактирование направления";
                button1.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();

                BaseFIT.gettable(sql, dsa);



                BaseFIT.gettable(sql, dsa);


                tbnamenapr.Text = dsa.Tables[0].Rows[0]["Направление"].ToString();
                tbopis.Text = dsa.Tables[0].Rows[0]["Описание"].ToString();

            }
            else
            {
                this.Text = "Добавление направления";
                button1.Text = "Добавить направление";

            }
            if (!((Program.BaseFIT.roleuser == "Администратор") 
                || (Program.BaseFIT.roleuser == "Менеджер") 
                || (Program.BaseFIT.roleuser == "Системный администратор"))) 
           
            {
                tbnamenapr.ReadOnly = true;
                tbopis.ReadOnly = true;
                button1.Enabled = false;
                this.Text = "Просмотр направления";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
