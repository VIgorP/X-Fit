using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace FitnessClub
{
    public partial class fobject : Form
    {
        
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        int kod;
        public fobject(int kod)
        {
            this.kod = kod;
            InitializeComponent();


        }

        private void fobject_Load(object sender, EventArgs e)
        {
            if (!Program.insert)
            {
                string sql = @"SELECT Зал, Адрес,Описание,Площадь,Вместимость, Фото
FROM Залы
WHERE КодЗала=" + kod.ToString() ;

                
                //   MessageBox.Show(sql);
                this.Text = "Редактирование данных выбранного зала";
                button9.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();

             

               

                BaseFIT.gettable(sql, dsa);

             
                tbnamezala.Text = dsa.Tables[0].Rows[0]["Зал"].ToString();
tbadres.Text = dsa.Tables[0].Rows[0]["Адрес"].ToString();
tbopis.Text = dsa.Tables[0].Rows[0]["Описание"].ToString();
tbsquarezala.Text = dsa.Tables[0].Rows[0]["Площадь"].ToString();


                tbkolchel.Text = dsa.Tables[0].Rows[0]["Вместимость"].ToString();
               
                if (!(dsa.Tables[0].Rows[0]["Фото"] is DBNull))
                {
                    Ifoto.DataBindings.Clear();
                    Ifoto.DataBindings.Add("Image", dsa.Tables[0], "Фото", true);
                }
                              
               


            }

              if (!((Program.BaseFIT.roleuser == "Администратор") 
                || (Program.BaseFIT.roleuser == "Менеджер") 
                || (Program.BaseFIT.roleuser == "Системный администратор"))) 
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Button)) c.Enabled = false;
                    if (c.GetType() == typeof(TextBox)) (c as TextBox).ReadOnly= true;
                   

                }
             
                button10.Enabled = true;
                this.Text = "Просмотр выбранного зала";
                

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //проверка
            string s = ""; double sq = 0;
            int vm = 0;
          
            if (tbnamezala.Text.Trim() == "") s += "Название зала" + Environment.NewLine;
            if (tbkolchel.Text.Trim() == "") s += "Вместимость" + Environment.NewLine;
            else if (!Int32.TryParse(tbkolchel.Text.Trim().ToString(), out vm)) s += "Ошибка в воде вместимости" + Environment.NewLine;
            if (tbsquarezala.Text.Trim() == "") s += "Площадь" + Environment.NewLine;
            else if (!double.TryParse(tbsquarezala.Text.Trim().ToString(), out sq)) s += "Ошибка в воде площади" + Environment.NewLine;
            if (tbadres.Text.Trim() == "") s += "Адрес" + Environment.NewLine;
          
            
            
            if (s != "")
            {
                MessageBox.Show("Не заполнены поля:" + Environment.NewLine + s);
                return; //если что-то не заполнено
            }

            //проверка целостности
            if (Program.insert)
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Залы  where Зал = '" + tbnamezala.Text.Trim() + "'", BaseFIT.con);
                BaseFIT.con.Open();       //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка добавление,  такое название зала  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

               

            }
            else
            {
                OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Залы  where Зал =  '" + tbnamezala.Text.Trim()
                    + @"' and  КодЗала <>" + kod.ToString(), BaseFIT.con);
                BaseFIT.con.Open();           //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Ошибка изменения, такое название зала  уже есть в таблице.",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

               

            }
            try
            {
                
               


                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Залы set " +
@"Зал=@Зал, 
Площадь=@Площадь, 
Вместимость=@Вместимость, 
Адрес=@Адрес, 
Описание=@Описание,
Фото=@Фото
where КодЗала=@КодЗала", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка
                    

                    oleDbCommand.CommandText = "insert into Залы  " +
@" (Зал, 
Площадь, Вместимость, 
 Адрес, 
Описание, Фото) VALUES 
( @Зал, 
@Площадь, @Вместимость, 
@Адрес, 
@Описание,
@Фото)";
                }
                
                //добавляем параметры
              

                OleDbParameter oleDbParameter1 = new OleDbParameter("@Зал", OleDbType.VarChar);
                oleDbParameter1.Value = tbnamezala.Text; oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("@Площадь", OleDbType.Double);
                oleDbParameter2.Value = Convert.ToDouble(tbsquarezala.Text); oleDbCommand.Parameters.Add(oleDbParameter2);

                OleDbParameter oleDbParameter3 = new OleDbParameter("@Вместимость", OleDbType.VarChar);
                oleDbParameter3.Value = tbkolchel.Text; oleDbCommand.Parameters.Add(oleDbParameter3);

               
         
                OleDbParameter oleDbParameter8 = new OleDbParameter("@Адрес", OleDbType.VarChar);
                oleDbParameter8.Value = tbadres.Text; oleDbCommand.Parameters.Add(oleDbParameter8);


                OleDbParameter oleDbParameter9 = new OleDbParameter("@Описание", OleDbType.VarChar);
                oleDbParameter9.Value = tbopis.Text; oleDbCommand.Parameters.Add(oleDbParameter9);
                OleDbParameter oleDbParameterfoto = new OleDbParameter("@Фото", OleDbType.VarBinary);

                if (Ifoto.Image == null) oleDbParameterfoto.Value = null;
                else
                {

                    //Изображение из файла.
                    MemoryStream memoryStream = new MemoryStream();                             //Поток в который запишем изображение
                    Ifoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);      //Сохраняем изображение в поток.
                    memoryStream.ToArray();
                    oleDbParameterfoto.Value = memoryStream.ToArray();

                }
                oleDbCommand.Parameters.Add(oleDbParameterfoto);


                OleDbParameter oleDbParameter10 = new OleDbParameter("@КодЗала", OleDbType.Integer);
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

        

       

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage()) Ifoto.Image = Clipboard.GetImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    Bitmap image = new Bitmap(open_dialog.FileName);

                    //   this.Ifoto.Size = image.Size;
                    Ifoto.Image = image;
                    Ifoto.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
