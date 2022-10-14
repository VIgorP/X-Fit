using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FitnessClub
{
    public partial class LoginForm : Form
    {

        public Int32 count = 0;
        public int k = 0;
      
        public LoginForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Program.BaseFIT.Login(textBox1.Text, textBox2.Text, ref count);
            if (count > 0) //проверяем пароль. Эта только для примера.
            {
              

                    this.DialogResult = DialogResult.OK; //в зависимости от результатов проверки устанавливаем DialogResult.OK 
              
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Возможно отсутствует подключение к базе. Ошибка авторизации");
                k++;
                if (k == 3)
                {
                    MessageBox.Show("Превышено число попыток");
                    this.DialogResult = DialogResult.Abort; //или DialogResult.Abort
                    this.Close(); //и закрываем форму регистрации
                }
                else return;
            }

        }
      
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);

        }
        //вход по кнопке гость
        private void button2_Click(object sender, EventArgs e)
        {
            Program.guest = true; //признак гостя
            this.DialogResult = DialogResult.OK; //в зависимости от результатов проверки устанавливаем DialogResult.OK 
        }
    }
}

