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
    public partial class fklient : Form
    {
        int kod;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public fklient(int kod)
        {
            InitializeComponent();
            //получаем код
            this.kod = kod;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка
            string s = "";
            foreach (Control c in Controls)
                if (c is TextBox)
                    if (((TextBox)c).Text.Trim() == "")
                    {
                        if (((TextBox)c).Tag!="Примечания")
                        s=s+((TextBox)c).Tag+Environment.NewLine;
                    }
         
            if (s != "")
            {
                MessageBox.Show("Не заполнены поля:"+Environment.NewLine+ s);
                return; //если что-то не заполнено
            }
            try
            {
//по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Клиенты set " +
@"Клиент=@Клиент, 
Телефон=@Телефон, 
Email=@Email, 
Примечания=@Примечания
where кодКлиента=@кодКлиента", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка
                    oleDbCommand.CommandText = "insert into Клиенты  " +
@" (Клиент,   Телефон, Email, Примечания) VALUES 
(@Клиент,  @Телефон,@Email,@Примечания)";
                }
                //добавляем параметры
                OleDbParameter oleDbParameter0 = new OleDbParameter("@Клиент", OleDbType.VarChar);
                oleDbParameter0.Value = tbklient.Text;
                oleDbCommand.Parameters.Add(oleDbParameter0);
                             

                OleDbParameter oleDbParameter3 = new OleDbParameter("@Телефон", OleDbType.VarChar);
                oleDbParameter3.Value = tbtelefonklient.Text;
                oleDbCommand.Parameters.Add(oleDbParameter3);

                OleDbParameter oleDbParameter4 = new OleDbParameter("@Email", OleDbType.VarChar);
                oleDbParameter4.Value = tbemailklient.Text ;
                oleDbCommand.Parameters.Add(oleDbParameter4);
         

            
               

                OleDbParameter oleDbParameter9 = new OleDbParameter("@Примечания", OleDbType.VarChar);
                oleDbParameter9.Value = tbprim.Text;
                oleDbCommand.Parameters.Add(oleDbParameter9);
               
                
                OleDbParameter oleDbParameter10 = new OleDbParameter("@КодКлиента", OleDbType.Integer);
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

        private void fklient_Load(object sender, EventArgs e)
        {
            //настраиваем теги
            tbklient.Tag = "Клиент";

            tbtelefonklient.Tag = "Телефон";

            tbemailklient.Tag = "Email Клиента";


       
            tbprim.Tag = "Примечания";
           
          
            //если добавление Клиента
            if (Program.insert)
            {
                //очищаем все поля
                foreach (Control c in Controls)
                    if (c is TextBox)
                        ((TextBox)c).Text = "";
              
                this.Text = "Добавление Клиента";
            }
            else //если редактирование Клиента
            {
                this.Text = "Редактирование данных Клиента";
                button1.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();

                //получаме данные по Клиенту
                string sql = @"SELECT  * FROM Клиенты WHERE КодКлиента=" + kod.ToString();
                BaseFIT.gettable(sql, dsa);
                lKodklienta.DataBindings.Clear(); lKodklienta.DataBindings.Add("Text", dsa.Tables[0], "КодКлиента");
                tbklient.DataBindings.Clear(); tbklient.DataBindings.Add("Text", dsa.Tables[0], "Клиент");

                tbtelefonklient.DataBindings.Clear(); tbtelefonklient.DataBindings.Add("Text", dsa.Tables[0], "Телефон");

                tbemailklient.DataBindings.Clear(); tbemailklient.DataBindings.Add("Text", dsa.Tables[0], "Email");


               
                tbprim.DataBindings.Clear(); tbprim.DataBindings.Add("Text", dsa.Tables[0], "Примечания");
                this.Text = "Редактирование Клиента";
                button1.Text = "Сохранить изменения";
            }
        }
    } //
}
