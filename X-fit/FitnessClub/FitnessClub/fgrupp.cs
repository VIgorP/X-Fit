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
    public partial class fgrupp : Form
    {
        int kod;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public fgrupp(int kod)
        {
            InitializeComponent();
            this.kod = kod;
        }

        private void fgrupp_Load(object sender, EventArgs e)
        {
            //загружаем combobox
            string sql = @"SELECT коднаправления, направление FROM направления order by направление";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbnaprav.DataSource = null;
            cbnaprav.DataSource = ds.Tables[0];
            cbnaprav.DisplayMember = "направление";
            cbnaprav.ValueMember = "коднаправления";
            if (!Program.insert)
            {
                 sql = @"SELECT  КодГруппы, Группа, КодНаправления, Описание, Цвет
FROM Группы

WHERE КодГруппы=" + kod.ToString();


                //   MessageBox.Show(sql);
                this.Text = "Редактирование группы";
                button1.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();

                BaseFIT.gettable(sql, dsa);



                BaseFIT.gettable(sql, dsa);


                tbnamegruppa.Text = dsa.Tables[0].Rows[0]["Группа"].ToString();
                tbopis.Text = dsa.Tables[0].Rows[0]["Описание"].ToString();
                lkodgruppa.Text = dsa.Tables[0].Rows[0]["КодГруппы"].ToString();
                if (!(dsa.Tables[0].Rows[0]["КодНаправления"] is DBNull)) cbnaprav.SelectedValue = Int32.Parse(dsa.Tables[0].Rows[0]["КодНаправления"].ToString());
                if (!(dsa.Tables[0].Rows[0]["Цвет"] is DBNull)) lblolor.BackColor = Color.FromArgb(Int32.Parse(dsa.Tables[0].Rows[0]["Цвет"].ToString()));

            }
            else
            {
                this.Text = "Добавление группы";
                button1.Text = "Добавить группу";
                lkodgruppa.Text = "";
                cbnaprav.SelectedIndex = -1;

            }

            if (!BaseFIT.editspravochniki(Program.BaseFIT.roleuser))
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Button)) c.Enabled = false;
                    if (c.GetType() == typeof(TextBox)) (c as TextBox).ReadOnly = true;

                    if (c.GetType() == typeof(ComboBox)) (c as ComboBox).Enabled = false;
                }

                button2.Enabled = true;
                button1.Visible = false;
                this.Text = "Просмотр выбранной группы";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка
            string s = "";


            if (tbnamegruppa.Text.Trim() == "") s += "Название Группы" + Environment.NewLine;
            if (cbnaprav.SelectedIndex == -1) s += "Направление" + Environment.NewLine;

            if (s != "")
            {
                MessageBox.Show("Не заполнено:" + Environment.NewLine+s);
                return; //если что-то не заполнено
            }

            //проверка целостности
            if (Program.insert)
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Группы  where Группа = '" + tbnamegruppa.Text.Trim() + "'", BaseFIT.con);
                BaseFIT.con.Open();       //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка добавление,  такое название группы  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            else
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Группы  where Группа =  '" + tbnamegruppa.Text.Trim()
                    + @"' and  КодГруппы <>" + kod.ToString(), BaseFIT.con);
                BaseFIT.con.Open();           //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка изменения, такое название группы  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            try
            {

                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Группы set " +
@"Группа=@Группа, 
Коднаправления=@Коднаправления,
Описание=@Описание,
Цвет=@Цвет
where КодГруппы=@КодГруппы", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка


                    oleDbCommand.CommandText = "insert into Группы  " +
@" (Группа, 
Коднаправления, 
Описание, Цвет) VALUES 
( @Группа, 
@Коднаправления,
@Описание, 
@Цвет)";
                }

                //добавляем параметры

                OleDbParameter oleDbParameter1 = new OleDbParameter("@Группа", OleDbType.VarChar);
                oleDbParameter1.Value = tbnamegruppa.Text; oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter1n = new OleDbParameter("@Коднаправления", OleDbType.Integer);
                oleDbParameter1n.Value = cbnaprav.SelectedValue; oleDbCommand.Parameters.Add(oleDbParameter1n);

                OleDbParameter oleDbParameter9 = new OleDbParameter("@Описание", OleDbType.VarChar);
                oleDbParameter9.Value = tbopis.Text; oleDbCommand.Parameters.Add(oleDbParameter9);

                OleDbParameter oleDbParameter9n = new OleDbParameter("@Цвет", OleDbType.Integer);
                oleDbParameter9n.Value = lblolor.BackColor.ToArgb(); oleDbCommand.Parameters.Add(oleDbParameter9n);

                OleDbParameter oleDbParameter10 = new OleDbParameter("@КодГруппы", OleDbType.Integer);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblolor.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            //установка цвета фона эллипса
            lblolor.BackColor = colorDialog1.Color;
        }
    }
}
