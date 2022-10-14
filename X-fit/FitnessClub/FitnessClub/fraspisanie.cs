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
    public partial class fraspisanie : Form
    {
        int kodrasp;
        string namedennedeli = "";
        int nomdennedeli;
        int idperiod;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        Boolean flagfoto = false;
        public fraspisanie(int kodrasp)
        {
            InitializeComponent();
            this.kodrasp = kodrasp;
        }

        private void fraspisanie_Load(object sender, EventArgs e)
        {
            //загружаем combobox

            string sql = @"SELECT Сотрудники.КодСотрудника, Сотрудники.ФИО, Должности.Должность
FROM Должности INNER JOIN Сотрудники ON Должности.КодДолжности = Сотрудники.КодДолжности
WHERE ((((Должности.Должность) Like '%нструктор%') or (Должности.Должность) Like '%ренер%'))
ORDER BY Сотрудники.ФИО";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbsotrudnik.DataSource = null;
            cbsotrudnik.DataSource = ds.Tables[0];
            cbsotrudnik.DisplayMember = "ФИО";
            cbsotrudnik.ValueMember = "Кодсотрудника";
            //загружаем combobox
            sql = @"SELECT КодГруппы, группа FROM Группы order by Группа";
            ds = new DataSet();
            da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbgruppa.DataSource = null;
            cbgruppa.DataSource = ds.Tables[0];
            cbgruppa.DisplayMember = "группа";
            cbgruppa.ValueMember = "КодГруппы";

            sql = @"SELECT Расписание.КодРасписания,Расписание.КодПериода, 
Расписание.ВремяНачала, Расписание.КодГруппы, 
Расписание.КодСотрудника, Расписание.НомерДняНедели, 
ПериодДействия.НазваниеПериода, Залы.Зал, 
Залы.Описание, Залы.Площадь,Залы.Фото, 
Залы.Вместимость
FROM Залы INNER JOIN (ПериодДействия INNER JOIN Расписание ON ПериодДействия.КодПериода = Расписание.КодПериода) ON Залы.КодЗала = Расписание.КодЗала

WHERE КодРасписания=" + kodrasp.ToString();

            DataSet dsa = new DataSet();
            BaseFIT.gettable(sql, dsa);
            lbperiod.Text = dsa.Tables[0].Rows[0]["НазваниеПериода"].ToString();
            lbtime.Text = dsa.Tables[0].Rows[0]["ВремяНачала"].ToString();
            lbzal.Text = dsa.Tables[0].Rows[0]["Зал"].ToString();
            idperiod = Int32.Parse(dsa.Tables[0].Rows[0]["КодПериода"].ToString());
            nomdennedeli = Int32.Parse(dsa.Tables[0].Rows[0]["НомерДняНедели"].ToString());
            if (!(dsa.Tables[0].Rows[0]["Фото"] is DBNull))
            {
                Ifoto1.DataBindings.Clear();
                Ifoto1.DataBindings.Add("Image", dsa.Tables[0], "Фото", true);
            }
            switch (nomdennedeli)
                {
                case 1:
                namedennedeli = "Понедельник";
                break;
                case 2:
                namedennedeli = "Вторник";
                break;
                case 3:
                namedennedeli = "Среда";
                break;

                case 4:
                namedennedeli = "Четверг";
                break;

                case 5:
                namedennedeli = "Пятница";
                break;

                case 6:
                namedennedeli = "Суббота";
                break;

                case 7:
                namedennedeli = "Воскресенье";
                break;

            }

            lbden.Text = namedennedeli;
            tbzal.Text = dsa.Tables[0].Rows[0]["Описание"].ToString();
            lbsq.Text = dsa.Tables[0].Rows[0]["Площадь"].ToString(); 
            lbvmestimost.Text = dsa.Tables[0].Rows[0]["Вместимость"].ToString();
           
            if (!(dsa.Tables[0].Rows[0]["КодСотрудника"] is DBNull))
            {// надо много чего написать

             

                cbsotrudnik.SelectedValue = Int32.Parse(dsa.Tables[0].Rows[0]["КодСотрудника"].ToString());

                sql = @"SELECT Фото  FROM Сотрудники where кодсотрудника=" + cbsotrudnik.SelectedValue.ToString();
                DataSet dsafoto = new DataSet();
                BaseFIT.gettable(sql, dsafoto);

                if (!(dsafoto.Tables[0].Rows[0]["Фото"] is DBNull))
                {
                    Ifoto.DataBindings.Clear();
                    Ifoto.DataBindings.Add("Image", dsafoto.Tables[0], "Фото", true);
                }

               

            }
            else cbsotrudnik.SelectedValue = -1;
            if (!(dsa.Tables[0].Rows[0]["КодГруппы"] is DBNull)) 
            {// надо много чего написать
                    cbgruppa.SelectedValue = Int32.Parse(dsa.Tables[0].Rows[0]["КодГруппы"].ToString());
        }
            else cbgruppa.SelectedValue = -1;
            timer1.Enabled = true;
            if (Program.guest == true)
            {
                cbgruppa.Enabled = false;
                cbsotrudnik.Enabled = false;
                button1.Visible = false;
                button3.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка
            string s = "";
           
            if (cbgruppa.SelectedIndex == -1) s = s + "Группа";
            if (cbsotrudnik.SelectedIndex == -1) s = s + "Тренер";
            if (s != "")
            {
                MessageBox.Show("Не заполнены поля:" + Environment.NewLine + s);
                return; //если что-то не заполнено
            }
            try
            {
                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Расписание set " +
@"КодГруппы=@КодГруппы, 
КодСотрудника=@КодСотрудника


where КодРасписания=@КодРасписания", BaseFIT.con);         //Запрос на вставку
               
                //добавляем параметры
                OleDbParameter oleDbParameter0 = new OleDbParameter("@КодГруппы", OleDbType.Integer);
                oleDbParameter0.Value = cbgruppa.SelectedValue;
                oleDbCommand.Parameters.Add(oleDbParameter0);

                OleDbParameter oleDbParameter1 = new OleDbParameter("@КодСотрудника", OleDbType.Integer);
                oleDbParameter1.Value = cbsotrudnik.SelectedValue;
                oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("@КодРасписания", OleDbType.Integer);
                oleDbParameter2.Value = kodrasp;
                oleDbCommand.Parameters.Add(oleDbParameter2);


                //Добавляем параметр
                BaseFIT.con.Open(); //Открываем соединение с БД

                oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                                BaseFIT.con.Close();        //Закрываем соединение
                Program.modified = true;

                //проверяем наличие журналов в занятии


                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from ЖурналЗанятий  where КодРасписания =  " 
                    + kodrasp.ToString(), BaseFIT.con);
                BaseFIT.con.Open();           //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {



                }
                else
                {
                    getdni(nomdennedeli);
                }




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
        public void getdni(int nomdennedeli)
        {
            if (nomdennedeli == 0) return;
            if (nomdennedeli == 7) nomdennedeli = 0; ;
            string sql = @"SELECT  ПериодДействия.НачалоПериода, ПериодДействия.КонецПериода
FROM ПериодДействия
WHERE ПериодДействия.КодПериода=" + idperiod.ToString();
            DataSet ds = new DataSet();
            BaseFIT.gettable(sql, ds);


            if (ds.Tables[0].Rows.Count > 0)
            {




                DateTime StartDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["НачалоПериода"]);
                DateTime EndDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["КонецПериода"]); ;
                var selectedDates = new List<DateTime?>();

                for (var date = StartDate; date <= EndDate; date = date.AddDays(1))
                {
                    selectedDates.Add(date);
                }
                string s = "";
                sql = @"Insert into ЖурналЗанятий 
                
                    (
                ДатаЗанятия,
                КодРасписания,
                Выполнено
                    )
                values
                    (@ДатаЗанятия,
                    @КодРасписания,
                    False
                    
                    )";
                //*******************************
                foreach (DateTime date in selectedDates)
                {
                    if ((int)date.DayOfWeek == nomdennedeli)
                    {
                        OleDbCommand oleDbCommand = new OleDbCommand(sql, BaseFIT.con);

                        OleDbParameter oleDbParameter1 = new OleDbParameter("@ДатаЗанятия", OleDbType.Date);
                        oleDbParameter1.Value = date;
                        oleDbCommand.Parameters.Add(oleDbParameter1);

                        OleDbParameter oleDbParameter2 = new OleDbParameter("@КодРасписания", OleDbType.Integer);
                        oleDbParameter2.Value = kodrasp;
                        oleDbCommand.Parameters.Add(oleDbParameter2);


                        //Добавляем параметр
                        BaseFIT.con.Open(); //Открываем соединение с БД

                        oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                        BaseFIT.con.Close();
                    }
  
                }
                
            }

        }

        private void cbsotrudnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flagfoto)
            {
                string sql = @"SELECT Фото  FROM Сотрудники where кодсотрудника=" + cbsotrudnik.SelectedValue.ToString();
                DataSet dsafoto = new DataSet();
                BaseFIT.gettable(sql, dsafoto);

                if (!(dsafoto.Tables[0].Rows[0]["Фото"] is DBNull))
                {
                    Ifoto.DataBindings.Clear();
                    Ifoto.DataBindings.Add("Image", dsafoto.Tables[0], "Фото", true);
                }
            }
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            flagfoto = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from ЖурналЗанятий  where КодРасписания =  "
                   + kodrasp.ToString()+ " and Выполнено=true " , BaseFIT.con);
            BaseFIT.con.Open();           //Открываем соединение с БД
            object result = command1.ExecuteScalar();
            int a = Convert.ToInt32(result);//Выполняем запрос.
            BaseFIT.con.Close();
            if (a > 0)
            {
                var resultt = MessageBox.Show("В журнале занятий есть отметки о проведении занятий по этому расписанию. Удаляем?", "Выбор",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                // If the no button was pressed ...
                if (resultt == DialogResult.Yes)
                {
                    flag = true;
                }

            }
            else
            {
                var resultt = MessageBox.Show("Очистить расписание. Удаляем?", "Выбор",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                // If the no button was pressed ...
                if (resultt == DialogResult.Yes) flag = true;


            }

            if (flag)
            {
                try
                {
                    OleDbCommand oleDbCommand = new OleDbCommand("update Расписание set " +
    @"КодГруппы= NULL, 
КодСотрудника= NULL


where КодРасписания=@КодРасписания", BaseFIT.con);         //Запрос на вставку



                    OleDbParameter oleDbParameter2 = new OleDbParameter("@КодРасписания", OleDbType.Integer);
                    oleDbParameter2.Value = kodrasp;
                    oleDbCommand.Parameters.Add(oleDbParameter2);
                    //Добавляем параметр
                    BaseFIT.con.Open(); //Открываем соединение с БД
                    oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                    BaseFIT.con.Close();        //Закрываем соединение



                    oleDbCommand = new OleDbCommand("update ЖурналЗанятий set " +
    @"Выполнено= False, 
КодСотрудника= NULL
where КодРасписания=@КодРасписания", BaseFIT.con);         //Запрос на вставку
                    OleDbParameter oleDbParameter3 = new OleDbParameter("@КодРасписания", OleDbType.Integer);
                    oleDbParameter3.Value = kodrasp;
                    oleDbCommand.Parameters.Add(oleDbParameter3);

                    BaseFIT.con.Open(); //Открываем соединение с БД
                    oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                    BaseFIT.con.Close();        //Закрываем соединение
                    Program.modified = true;
                    this.Close();
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
        }
    }
}
