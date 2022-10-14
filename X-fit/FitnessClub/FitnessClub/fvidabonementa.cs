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
    public partial class fvidabonementa : Form
    {
        int kod;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public fvidabonementa(int kod)
        {
            InitializeComponent();
            this.kod = kod;
        }

        private void farendator_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка
            string s = "";
            foreach (Control c in Controls)
                if (c is TextBox)
                    if (((TextBox)c).Text.Trim() == "")
                    {
                      
                            s = s + ((TextBox)c).Tag + Environment.NewLine;
                    }
            if (cbzall.SelectedIndex == -1) s = s + "Зал";
            if (s != "")
            {
                MessageBox.Show("Не заполнены поля:" + Environment.NewLine + s);
                return; //если что-то не заполнено
            }
            try
            {
                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update ВидыАбонементов set " +
@"КодНазванияВидаАбонемента=@КодНазванияВидаАбонемента, 
Цена=@Цена, 
КоличествоПосещений=@КоличествоПосещений, 
КодЗала=@КодЗала

where КодВидаАбонемента=@КодВидаАбонемента", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка
                    oleDbCommand.CommandText = "insert into ВидыАбонементов  " +
@" (КодНазванияВидаАбонемента, Цена, КоличествоПосещений,  КодЗала) VALUES 
(@КодНазванияВидаАбонемента, @Цена, @КоличествоПосещений,@КодЗала)";
                }
                //добавляем параметры
                OleDbParameter oleDbParameter0 = new OleDbParameter("@КодНазванияВидаАбонемента", OleDbType.Integer);
                oleDbParameter0.Value = cbname.SelectedValue;
                oleDbCommand.Parameters.Add(oleDbParameter0);

                OleDbParameter oleDbParameter1 = new OleDbParameter("@Цена", OleDbType.Integer);
                oleDbParameter1.Value = Int32.Parse(tbcena.Text.Trim());
                oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("@КоличествоПосещений", OleDbType.Integer);
                oleDbParameter2.Value = Int32.Parse(tbkolposesh.Text.Trim()); 
                oleDbCommand.Parameters.Add(oleDbParameter2);

               
               
                OleDbParameter oleDbParameter8 = new OleDbParameter("@КодЗала", OleDbType.Integer);
                oleDbParameter8.Value = cbzall.SelectedValue;
                oleDbCommand.Parameters.Add(oleDbParameter8);

                

                OleDbParameter oleDbParameter10 = new OleDbParameter("@КодВидаАбонемента", OleDbType.Integer);
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

        private void fvidabonementa_Load(object sender, EventArgs e)
        {
            //настраиваем теги


            tbcena.Tag = "Цена";
            tbkolposesh.Tag = "Количество посещений";

            //загружаем combobox
            string sql = @"SELECT кодзала, зал FROM Залы order by Зал";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbzall.DataSource = null;
            cbzall.DataSource = ds.Tables[0];
            cbzall.DisplayMember = "Зал";
            cbzall.ValueMember = "КодЗала";
            //загружаем combobox
            sql = @"SELECT * FROM НазванияВидовАбонемента order by НазваниеВидаАбонемента";
            ds = new DataSet();
            da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbname.DataSource = null;
            cbname.DataSource = ds.Tables[0];
            cbname.DisplayMember = "НазваниеВидаАбонемента";
            cbname.ValueMember = "КодНазванияВидаАбонемента";
            //если добавление Арендодателя
            if (Program.insert)
            {
                //очищаем все поля
                foreach (Control c in Controls)
                    if (c is TextBox)
                        ((TextBox)c).Text = "";
                cbzall.SelectedIndex = -1;
                cbname.SelectedIndex = -1;
                this.Text = "Добавление Вида абонемента";
                lkodgrupp.Text = "";
            }
            else //если редактирование вида абонемента
            {
                this.Text = "Редактирование  вида абонемента";
                button1.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();

                //получаме данные по вида абонемента
                sql = @"SELECT  * FROM ВидыАбонементов WHERE КодВидаАбонемента=" + kod.ToString();
                BaseFIT.gettable(sql, dsa);
                lkodgrupp.DataBindings.Clear(); lkodgrupp.DataBindings.Add("Text", dsa.Tables[0], "КодВидаАбонемента");


                tbcena.DataBindings.Clear(); tbcena.DataBindings.Add("Text", dsa.Tables[0], "Цена");
                tbkolposesh.DataBindings.Clear(); tbkolposesh.DataBindings.Add("Text", dsa.Tables[0], "КоличествоПосещений");


                if (!(dsa.Tables[0].Rows[0]["КодЗала"] is DBNull)) cbzall.SelectedValue = Int32.Parse(dsa.Tables[0].Rows[0]["КодЗала"].ToString());
                if (!(dsa.Tables[0].Rows[0]["КодНазванияВидаАбонемента"] is DBNull)) cbname.SelectedValue = Int32.Parse(dsa.Tables[0].Rows[0]["КодНазванияВидаАбонемента"].ToString());



                button1.Text = "Сохранить изменения";
            }

        }
    }
}
