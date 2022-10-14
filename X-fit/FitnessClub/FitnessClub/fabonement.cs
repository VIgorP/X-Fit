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
    
    public partial class fabonement : Form
    {
      
       public static bool modified { get; set; }
        public static string nameclient { get; set; }
        public static int idclient { get; set; }
               public static string nametypeabonementa { get; set; }
        public static int idtypeabonementa { get; set; }
            public static string namezala { get; set; }
        public static int idzala { get; set; }

        public static string telefon { get; set; }
               public static string namemenedger { get; set; }
        public static int idmenedger { get; set; }
             public static int cena { get; set; }
        int skidka = 0;
      //  int itogokoplate = 0;
       
        public static int koplate { get; set; }
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        int kod;
       
       
        public fabonement(int kod)
        {
            InitializeComponent();

            this.kod = kod;
            idclient = 0;
            idtypeabonementa = 0;
            idzala = 0;
            
            idmenedger = 0;
            cena = 0;
            skidka = 0;
            koplate = 0;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("Клиенты", "select кодКлиента, Клиент, телефон, email from Клиенты");
            w.ShowDialog();
            if (modified)
            {
                tbclient.Text = nameclient;
                tbtelefon.Text = telefon;
            }

        }

      

        

        private void tbarendator_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2_Click(sender,e);
        }

       

       

     
        

        private void button6_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("ВидыАбонементов", @"SELECT ВидыАбонементов.КодВидаАбонемента, НазванияВидовАбонемента.НазваниеВидаАбонемента, Залы.Зал, ВидыАбонементов.КоличествоПосещений, ВидыАбонементов.Цена
FROM НазванияВидовАбонемента INNER JOIN (Залы INNER JOIN ВидыАбонементов ON Залы.КодЗала = ВидыАбонементов.КодЗала) ON НазванияВидовАбонемента.КодНазванияВидаАбонемента = ВидыАбонементов.КодНазванияВидаАбонемента;
");
            w.ShowDialog();
            if (modified)
            {
                tbnameabonement.Text = nametypeabonementa;
                tbzal.Text = namezala;
                tbcena.Text = cena.ToString();
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("СтатусыЗаказа", "select КодСтатуса, Статус from СтатусыЗаказа");
            w.ShowDialog();
            if (modified)
            {
           //tbstatuszakaza.Text = namestatus;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("ТипыИзделий", "select КодТипаИзделия, ТипИзделия from ТипыИзделий");
            w.ShowDialog();
            if (modified)
            {
                //tbtypeizdeliya.Text = namezala;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
 modified = false;
 formsprcase w = new formsprcase("Комплектации", "select КодКомплектации, Комплектация from Комплектации");
            w.ShowDialog();
            if (modified)
            {
               // tbkomplect.Text = namekomplect;
            }
        }
       
        private void button16_Click(object sender, EventArgs e)
        {//*********
          // int  idmenedjer = 0;
            string s = "";
            s = BaseFIT.getname("select КодДолжности from Должности where Должность='Менеджер отдела продаж'");
            if (s != "") s=" where коддолжности = "+s;

            modified = false;
                       formsprcase w = new formsprcase("Сотрудники", "select КодСотрудника, ФИО from Сотрудники " +s);
            w.ShowDialog();
            if (modified)
            {
         tbnamemenedger.Text = namemenedger;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        //сохранить
        private void button9_Click(object sender, EventArgs e)
        {
           
                saveabonment();
              
        }
        //сохранение
        void saveabonment()
        {
          
            //проверка
            string s = "";
            if (idclient == 0) s += "Клиент" + Environment.NewLine;
           
            if (idtypeabonementa == 0) s += "Вид абонемента" + Environment.NewLine;
         
           
            if (idmenedger == 0) s += "Менеджер" + Environment.NewLine;
            // доппроверка если редактирование
           
            if (s != "")
            {
                MessageBox.Show("Не заполнены поля:" + Environment.NewLine + s);
               
                return; //если что-то не заполнено
            }
            raschet();
            try
            {
                //по умолчанию - обновление
                OleDbCommand oleDbCommand = new OleDbCommand("update Абонементы set " +
@" КодКлиента=@КодКлиента,  
Цена=@Цена,  
КодВидаАбонемента=@КодВидаАбонемента,
Скидка=@Скидка, 
ИтогокОплате=@ИтогокОплате, 
Оплачено=@Оплачено, 
 ДатаНачала=@ДатаНачала, 
ДатаКонца=@ДатаКонца, 
КодСотрудника=@КодСотрудника
where КодАбонемента=@КодАбонемента", BaseFIT.con);         //Запрос на вставку
                if (Program.insert)
                { //если вставка


                    oleDbCommand.CommandText = "insert into Абонементы  " +
@" (КодКлиента,  
Цена,  
КодВидаАбонемента,
Скидка, 
ИтогокОплате, Оплачено, 
 ДатаНачала, 
ДатаКонца, КодСотрудника
) VALUES 
(@КодКлиента,  
@Цена,  
@КодВидаАбонемента,
@Скидка, 
@ИтогокОплате, @Оплачено, 
 @ДатаНачала, 
@ДатаКонца, @КодСотрудника)";


                }

                  

                    OleDbParameter oleDbParameter1 = new OleDbParameter("@КодКлиента", OleDbType.Integer);
                    oleDbParameter1.Value = idclient; oleDbCommand.Parameters.Add(oleDbParameter1);

                    OleDbParameter oleDbParameter0 = new OleDbParameter("@Цена", OleDbType.Integer);
                    oleDbParameter0.Value = cena; oleDbCommand.Parameters.Add(oleDbParameter0);

                    OleDbParameter oleDbParameter2 = new OleDbParameter("@КодВидаАбонемента", OleDbType.Integer);
                    oleDbParameter2.Value = idtypeabonementa; oleDbCommand.Parameters.Add(oleDbParameter2);

                    OleDbParameter oleDbParameter3 = new OleDbParameter("@Скидка", OleDbType.Integer);
                    oleDbParameter3.Value = skidka; oleDbCommand.Parameters.Add(oleDbParameter3);

                    OleDbParameter oleDbParameter4 = new OleDbParameter("@ИтогокОплате", OleDbType.Integer);
                    oleDbParameter4.Value = koplate; oleDbCommand.Parameters.Add(oleDbParameter4);

                    //OleDbParameter oleDbParameter5 = new OleDbParameter("@СерийныйНомер", OleDbType.VarChar);
                    //oleDbParameter5.Value = tbsernomer.Text; oleDbCommand.Parameters.Add(oleDbParameter5);

                    OleDbParameter oleDbParameter6 = new OleDbParameter("@Оплачено", OleDbType.Boolean);
                    oleDbParameter6.Value = checkBox1.Checked; oleDbCommand.Parameters.Add(oleDbParameter6);


                    OleDbParameter oleDbParameter7 = new OleDbParameter("@ДатаНачала", OleDbType.Date);
                    oleDbParameter7.Value = dtpstart.Value; oleDbCommand.Parameters.Add(oleDbParameter7);
                    OleDbParameter oleDbParameter8 = new OleDbParameter("@ДатаКонца", OleDbType.Date);
                    oleDbParameter8.Value = dtpend.Value; oleDbCommand.Parameters.Add(oleDbParameter8);

                    //OleDbParameter oleDbParameter9 = new OleDbParameter("@ВнешнийВид", OleDbType.VarChar);
                    //oleDbParameter9.Value = tbvnvid.Text; oleDbCommand.Parameters.Add(oleDbParameter9);

                    //OleDbParameter oleDbParameter10 = new OleDbParameter("@Примечания", OleDbType.VarChar);
                    //oleDbParameter10.Value = tbprim.Text;
                    //oleDbCommand.Parameters.Add(oleDbParameter10);

                    OleDbParameter oleDbParameter11 = new OleDbParameter("@КодСотрудника", OleDbType.Integer);
                    oleDbParameter11.Value = idmenedger;  oleDbCommand.Parameters.Add(oleDbParameter11);
                  
                    OleDbParameter oleDbParameter12 = new OleDbParameter("@КодАбонемента", OleDbType.Integer);
                    oleDbParameter12.Value = kod;  oleDbCommand.Parameters.Add(oleDbParameter12);

                   // Program.insert = false;

               




                //Добавляем параметр
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

        private void fzakaz_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
         
           
        
            if(! Program.insert)
            {
                string sql = @"SELECT Абонементы.КодАбонемента, Абонементы.КодКлиента, Абонементы.Цена, Абонементы.Скидка,
Абонементы.КодВидаАбонемента, 
Абонементы.ИтогоКОплате, Абонементы.Оплачено, Абонементы.ДатаНачала, Абонементы.ДатаКонца, Абонементы.КодСотрудника, ВидыАбонементов.КодЗала
FROM ВидыАбонементов INNER JOIN Абонементы ON ВидыАбонементов.КодВидаАбонемента = Абонементы.КодВидаАбонемента 
WHERE Абонементы.КодАбонемента=" + kod.ToString();
                this.Text = "Редактирование данных Абонемента";
                button9.Text = "Сохранить изменения";
                DataSet dsa = new DataSet();
         

                BaseFIT.gettable(sql, dsa);

                tbkodabonement.Text = dsa.Tables[0].Rows[0]["КодАбонемента"].ToString();
                cena = Int32.Parse(dsa.Tables[0].Rows[0]["Цена"].ToString());
                tbcena.Text = cena.ToString();
               // tbclient.Text = dsa.Tables[0].Rows[0]["ВнешнийВид"].ToString();
                tbskidka.Text = dsa.Tables[0].Rows[0]["Скидка"].ToString();
                koplate = Int32.Parse(dsa.Tables[0].Rows[0]["ИтогоКОплате"].ToString());
                tbkoplate.Text = koplate.ToString();

                idtypeabonementa = Int32.Parse(dsa.Tables[0].Rows[0]["КодВидаАбонемента"].ToString());
                idzala = Int32.Parse(dsa.Tables[0].Rows[0]["КодЗала"].ToString());
                namezala= BaseFIT.getname("select Зал from Залы where кодзала=" + idzala.ToString());
                if (!(dsa.Tables[0].Rows[0]["ДатаНачала"] is DBNull)) dtpstart.Value = Convert.ToDateTime(dsa.Tables[0].Rows[0]["ДатаНачала"].ToString());
                if (!(dsa.Tables[0].Rows[0]["ДатаКонца"] is DBNull)) dtpend.Value = Convert.ToDateTime(dsa.Tables[0].Rows[0]["ДатаКонца"].ToString());

                string kodnazv = BaseFIT.getname(@"SELECT ВидыАбонементов.КодНазванияВидаАбонемента
FROM ВидыАбонементов
WHERE ВидыАбонементов.КодВидаАбонемента=" + idtypeabonementa.ToString());

                tbnameabonement.Text = BaseFIT.getname(@"SELECT НазванияВидовАбонемента.НазваниеВидаАбонемента
FROM НазванияВидовАбонемента
WHERE НазванияВидовАбонемента.КодНазванияВидаАбонемента="+kodnazv);

                tbzal.Text =namezala;

                
              
               
                tbtelefon.Text = BaseFIT.getname("select Телефон from Клиенты where кодКлиента=" + idclient.ToString());

               
               
             
               

                if (!(dsa.Tables[0].Rows[0]["КодКлиента"] is DBNull))
                {
                    idclient = Int32.Parse(dsa.Tables[0].Rows[0]["КодКлиента"].ToString());
                    tbclient.Text = BaseFIT.getname("select Клиент from Клиенты where кодклиента=" + idclient.ToString());
                }
                if (!(dsa.Tables[0].Rows[0]["КодСотрудника"] is DBNull))
                {
                    idmenedger = Int32.Parse(dsa.Tables[0].Rows[0]["КодСотрудника"].ToString());
                    tbnamemenedger.Text = BaseFIT.getname("select ФИО from Сотрудники where кодСотрудника=" + idmenedger.ToString());
                }

                checkBox1.Checked=Convert.ToBoolean(dsa.Tables[0].Rows[0]["Оплачено"].ToString());
                if ((checkBox1.Checked) || (!BaseFIT.editspravochniki(Program.BaseFIT.roleuser)))
                {
                    foreach (Control c in Controls)
                    {
                        c.Enabled = false;
 
                    }

                    panel1.Enabled = true;

                    button9.Visible = false; ;
                }



           


            }
            if (Program.insert)
            {
               
                this.Text = "Добавление  Абонемента";
                button9.Text = "Добавить Абонемент";
              
              
            }

           
        }

       

        public void raschet()
        {
            if (Int32.TryParse(tbskidka.Text, out skidka))
            {
                if (skidka < 0 && skidka >= 50)
                {
                    MessageBox.Show("Ошибка в воде скидки");
                    skidka = 0;
                    tbskidka.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Ошибка в воде скидки");
                skidka = 0;
                tbskidka.Text = "0";

            }
            if (cena == 0)
            {
                MessageBox.Show("Отсутствует цена");
                return;
            }
            koplate = cena - cena * skidka / 100;
            tbkoplate.Text = koplate.ToString();
        }

        public void button7_Click_1(object sender, EventArgs e)
        {

            raschet();
        }

    }
}
