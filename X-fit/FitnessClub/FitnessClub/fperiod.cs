using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
//форма редактирования каталога
namespace FitnessClub
{
    public partial class fperiod : Form
    {
        int id;
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        public fperiod(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormKatalog_Load(object sender, EventArgs e)
        {
            if (Program.insert)
            {
                
                dtpstart.Format = DateTimePickerFormat.Custom;
                dtpstart.CustomFormat = "dd/MM/yyyy";
                dtpend.Format = DateTimePickerFormat.Custom;
                dtpend.CustomFormat = "dd/MM/yyyy";
                dtpend.Value = DateTime.Today.AddDays(30);
            }
            else
            {
                string sql = @"SELECT * FROM ПериодДействия  where  кодпериода=" + id.ToString();

                BaseFIT.con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, Program.BaseFIT.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                BaseFIT.con.Close();

       
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dtpstart.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["НачалоПериода"].ToString());
                    dtpend.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["КонецПериода"].ToString());
                    tbnazvperiod.Text = ds.Tables[0].Rows[0]["НазваниеПериода"].ToString();
                   

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (tbnazvperiod.Text.Trim() == "")
            {
                MessageBox.Show("Введите название периода",
                    "Ошибка сохранения данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }
            
            if (dtpend.Value.Date <= dtpstart.Value.Date)
            {
                MessageBox.Show("Конец периода должен быть больше начала периода",
                    "Ошибка сохранения данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


            OleDbCommand command1 = new OleDbCommand (@" SELECT COUNT(*) from ПериодДействия  where (КонецПериода >=@datestart) or (
            КонецПериода >=@dateend)", BaseFIT.con);
            if (Program.insert)
            {
                command1.Parameters.Add("@datestart", OleDbType.Date).Value = dtpstart.Value.Date;
                command1.Parameters.Add("@dateend", OleDbType.Date).Value = dtpend.Value.Date;
                BaseFIT.con.Open();                                                                                               //Открываем соединение с БД
                object result = command1.ExecuteScalar();
                int a = Convert.ToInt32(result);//Выполняем запрос.
                BaseFIT.con.Close();
                if (a > 0)
                {
                    MessageBox.Show("Данный промежуток пересекается с другим",
                                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

            string sql = @"INSERT INTO ПериодДействия
                  (НазваниеПериода, НачалоПериода, КонецПериода)
VALUES ( @НазваниеПериода, @NachaloPerioda, @KonecPerioda)";
            if (!Program.insert) sql = @"UPDATE  ПериодДействия
              set     НазваниеПериода=@НазваниеПериода, НачалоПериода=@NachaloPerioda, КонецПериода=@KonecPerioda 
 where кодпериода= " + id.ToString();
try
{



    command1 = new OleDbCommand(sql, BaseFIT.con);
             command1.Parameters.Clear();

             command1.Parameters.Add("@НазваниеПериода", OleDbType.VarChar).Value = tbnazvperiod.Text.Trim();

            command1.Parameters.Add("@NachaloPerioda", OleDbType.VarChar).Value = dtpstart.Value.ToString("dd/MM/yyyy");

            command1.Parameters.Add("@KonecPerioda", OleDbType.Date).Value = dtpend.Value.ToString("dd/MM/yyyy");


            BaseFIT.con.Open();      //Открываем соединение с БД
                command1.ExecuteNonQuery();   //Выполняем запрос.
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
    }
}
