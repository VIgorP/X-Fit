using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace FitnessClub
{
    public partial class fsotrudnik : Form
    {
        int kod;

        public fsotrudnik(int kod)
        {
            InitializeComponent();
            this.kod = kod;

        }
        private void fsotrudnik_Load(object sender, EventArgs e)
        {
            if (Program.BaseFIT.roleuser == "Администратор") panel1.Visible = true;
            else panel1.Visible = false;

            string sql = @"SELECT КодДолжности, Должность FROM Должности";
            Program.BaseFIT.con.Open();
            OleDbDataAdapter da5 = new OleDbDataAdapter(sql, Program.BaseFIT.con);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            Program.BaseFIT.con.Close();
            cbdoljn.DataSource = null;
            cbdoljn.DataSource = dt5;
            cbdoljn.DisplayMember = "Должность";
            cbdoljn.ValueMember = "КодДолжности";

            sql = @"SELECT КодРоли, роль FROM Роли";
            Program.BaseFIT.con.Open();
            OleDbDataAdapter da6 = new OleDbDataAdapter(sql, Program.BaseFIT.con);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            Program.BaseFIT.con.Close();
            cbrol.DataSource = null;
            cbrol.DataSource = dt6;
            cbrol.DisplayMember = "Роль";
            cbrol.ValueMember = "КодРоли";

            //sql = @"SELECT КодОтдела, Отдел FROM Отделы";
            //Program.BaseFIT.con.Open();
            //OleDbDataAdapter da7 = new OleDbDataAdapter(sql, Program.BaseFIT.con);
            //DataTable dt7 = new DataTable();
            //da7.Fill(dt7);
            //Program.BaseFIT.con.Close();
            //cbotdel.DataSource = null;
            //cbotdel.DataSource = dt7;
            //cbotdel.DisplayMember = "Отдел";
            //cbotdel.ValueMember = "КодОтдела";


            if (!Program.insert)
            {
                this.Text = "Редактирование данных сотрудника";
                 sql = @"SELECT 
КодСотрудника, 
ФИО, 
КодДолжности,
Работает,
Логин,
Пароль,
кодроли,
Телефон,
Образование,
Фото, ИмяКороткое
FROM Сотрудники where кодсотрудника=" + kod.ToString();
                Program.BaseFIT.con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, Program.BaseFIT.con);
                DataTable dt = new DataTable();
                da.Fill(ds);
                da.Fill(dt);

                Program.BaseFIT.con.Close();
                tbkodsotrudnika.Text = dt.Rows[0].ItemArray[0].ToString();
                tfam.Text = dt.Rows[0].ItemArray[1].ToString();
              
                cbdoljn.SelectedValue = dt.Rows[0].ItemArray[2].ToString();
              
                checkBox1.Checked = Convert.ToBoolean(dt.Rows[0].ItemArray[3]);//пол
                tlogin.Text = dt.Rows[0].ItemArray[4].ToString();
                tparol.Text = dt.Rows[0].ItemArray[5].ToString();
                tbimyakor.Text = dt.Rows[0]["ИмяКороткое"].ToString();  
                cbrol.SelectedValue = dt.Rows[0].ItemArray[6].ToString();
           
               
              
                tmobtel.Text = dt.Rows[0].ItemArray[7].ToString();
                tobrazov.Text = dt.Rows[0].ItemArray[8].ToString();
                if (!(dt.Rows[0].ItemArray[9] is DBNull))
                {
                    Ifoto.DataBindings.Clear();
                    Ifoto.DataBindings.Add("Image",  dt, "Фото", true);
                }
             
               
             
              
                 
            } // конец загрузки для редактирования
            else //вставка
            {
                this.Text = "Добавление нового сотрудника";
               


               
                cbdoljn.SelectedIndex = -1;
            
                cbrol.SelectedValue = -1;

              

            }
        }
        public Boolean proverka_zapolneniya_polei()
        {
            // проверяем заполнение полей
          
           
            if (tfam.Text.Trim() == "")
            {
                MessageBox.Show("Не введены фамилия имя отчество");
                tfam.Focus();
                return false;
            }
            if (tbimyakor.Text.Trim() == "")
            {
                MessageBox.Show("Не введено короткое имя (необходимо для расписания)");
                tbimyakor.Focus();
                return false;
            }

            if (tobrazov.Text.Trim() == "")
            {
                MessageBox.Show("Не введено образование");
                tobrazov.Focus();
                return false;
            }

           
                       if (cbdoljn.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте выбор должности");
                cbdoljn.Focus();
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (proverka_zapolneniya_polei())
            {
                if (Program.insert)
                {
                    Program.BaseFIT.con.Open();
                    OleDbCommand command2 = new OleDbCommand(@"INSERT INTO Сотрудники 
(ФИО, 
КодДолжности,
Работает,
Логин,
Пароль,
КодРоли,
Образование,                 
Телефон,
Фото, 
ИмяКороткое
   
) 
                            values 
(
@fam,
@koddoljn,
@rabotaet,
@login,
@parol,
@rol,
 @Образование,
 @telefon,
@Фото, 
@ИмяКороткое



)", Program.BaseFIT.con);
                    try
                    {
                        
                        if (tlogin.Text.Trim() == "") tlogin.Text = tbkodsotrudnika.Text + "_" + tfam.Text; ;
                        if (tparol.Text.Trim() == "") tparol.Text = "1111";
                        if (cbrol.SelectedIndex == -1) cbrol.SelectedIndex = 0;
                        command2.Parameters.Add("@fam", SqlDbType.Char).Value = tfam.Text;


                  

                        command2.Parameters.Add("@koddoljn", SqlDbType.Int).Value = cbdoljn.SelectedValue;
                        if (checkBox1.Checked) command2.Parameters.Add("@rabotaet", SqlDbType.Bit).Value = 1;
                        else command2.Parameters.Add("@rabotaet", SqlDbType.Bit).Value = 0;
                        command2.Parameters.Add("@login", SqlDbType.Char).Value = tlogin.Text;
                        command2.Parameters.Add("@parol", SqlDbType.Char).Value = tparol.Text;
                        command2.Parameters.Add("@rol", SqlDbType.Int).Value = cbrol.SelectedValue;


                        command2.Parameters.Add("@Образование", SqlDbType.Char).Value = tobrazov.Text;
                        command2.Parameters.Add("@telefon", SqlDbType.Char).Value = tmobtel.Text;

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
                          command2.Parameters.Add(oleDbParameterfoto);
                          command2.Parameters.Add("@ИмяКороткое", SqlDbType.Char).Value = tbimyakor.Text.Trim();

                       // command2.Parameters.Add("@kodotdela", SqlDbType.Int).Value = cbotdel.SelectedValue;

                        command2.ExecuteNonQuery();
                        Program.BaseFIT.con.Close();
                        Program.modified = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Program.modified = true;
                    this.Close();
                }
                else
                {


                    Program.BaseFIT.con.Open();
                    OleDbCommand command2 = new OleDbCommand(@"UPDATE  Сотрудники set
ФИО=@fam, 
КодДолжности=@koddoljn,
Работает=@rabotaet,
Логин=@login,
Пароль=@parol,
КодРоли=@rol,
Образование=@Образование,
Телефон=@telefon,
Фото=@Фото,
ИмяКороткое=@ИмяКороткое

 where кодсотрудника=" + kod.ToString(), Program.BaseFIT.con);

                    try
                    {
                        command2.Parameters.Add("@fam", SqlDbType.Char).Value = tfam.Text;


                        command2.Parameters.Add("@koddoljn", SqlDbType.Int).Value = cbdoljn.SelectedValue;
                        if (checkBox1.Checked) command2.Parameters.Add("@rabotaet", SqlDbType.Bit).Value = 1;
                        else command2.Parameters.Add("@rabotaet", SqlDbType.Bit).Value = 0;
                        command2.Parameters.Add("@login", SqlDbType.Char).Value = tlogin.Text;
                        command2.Parameters.Add("@parol", SqlDbType.Char).Value = tparol.Text;
                        command2.Parameters.Add("@rol", SqlDbType.Int).Value = cbrol.SelectedValue;


                        command2.Parameters.Add("@Образование", SqlDbType.Char).Value = tobrazov.Text;
                                             command2.Parameters.Add("@telefon", SqlDbType.Char).Value = tmobtel.Text;
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
                                             command2.Parameters.Add(oleDbParameterfoto);
                                             command2.Parameters.Add("@ИмяКороткое", SqlDbType.Char).Value = tbimyakor.Text.Trim();

                       //                      command2.Parameters.Add("@kodotdela", SqlDbType.Int).Value = cbotdel.SelectedValue;

                        command2.ExecuteNonQuery();
                        Program.BaseFIT.con.Close();
                        Program.modified = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        if (Program.BaseFIT.con != null && Program.BaseFIT.con.State != ConnectionState.Closed)
                        {
                            Program.BaseFIT.con.Close();
                        }
                    }

                    this.Close();

                }
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
