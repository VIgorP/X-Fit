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
    public partial class FormChangeParol : Form
    {
        public FormChangeParol()
        {
            InitializeComponent();
        }
        private void FormChangeParol_Load(object sender, EventArgs e)
        {
            labelfio.Text = Program.BaseFIT.fiouser;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.BaseFIT.tekparol != textBox1.Text)
            {
                MessageBox.Show("Неправильно введен текущий пароль");
                return;
            }
            if ((textBox3.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Проверьте ввод нового пароля");
                return;
            }
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Введенные пароли не совпадают");
                return;
            }
            if (textBox3.Text == textBox2.Text)
            {

                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("Длина пароля должна быть больше 3 символов");
                    return;
                }
                try
                {

                    Program.BaseFIT.con.Open();
                    string sql = "update Сотрудники set Пароль='" + textBox2.Text + "' where кодсотрудника=" + Program.BaseFIT.koduser + ";";
                    OleDbCommand command1 = new OleDbCommand(sql, Program.BaseFIT.con);
                    //Выполняем запрос.
                    command1.ExecuteNonQuery();
                    Program.BaseFIT.con.Close();
                    MessageBox.Show("Пароль изменен");//Закрываем соединение

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении данных в базе. \n\r" + ex.ToString(),
                        "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Program.BaseFIT.con != null && Program.BaseFIT.con.State != ConnectionState.Closed)
                    {
                        Program.BaseFIT.con.Close();
                    }
                   
                    this.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

