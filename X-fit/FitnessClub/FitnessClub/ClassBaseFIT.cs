using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace FitnessClub
{
    class ClassBaseFIT
    {
      public  struct superlabel
      {
    public Label MyLabel;
    public int kodrasp;
    public string guppa;
    public string sotrudnik;
  
        }
        public OleDbConnection con = new OleDbConnection();
        public string connection;
        OleDbDataAdapter daspr;
        DataSet dsspr;
      
        public string fiouser;
        
        public int koduser;
        public string loginuser;
        public string roleuser;
        public string doljnuser;
        public string tekparol;
         public superlabel[,] rooster=new superlabel[50,8];// массив супер label
         public Label [] zagolvki = new Label[8];// массив супер label
      
        //инициализация
        public ClassBaseFIT()
        {
            string pathfile = Directory.GetCurrentDirectory() + "\\Path.inf";
            if (File.Exists(pathfile))
            {
                try
                {
                    FileStream fs = new FileStream(pathfile, FileMode.Open);
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    connection = sr.ReadLine();
                   sr.Close();
                }
                catch (Exception ex)
                {
                    connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BaseFit.mdb;Persist Security Info=True";
                }
            }
            else
            {
                connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BaseFit.mdb;Persist Security Info=True";
            }
            con.ConnectionString = connection;
      
        
        
        }
        public Boolean editspravochniki(string roluser)
        {
            if (((Program.BaseFIT.roleuser == "Администратор")
                || (Program.BaseFIT.roleuser == "Менеджер")
                || (Program.BaseFIT.roleuser == "Системный администратор"))) return true;
            else return false;

        }
        public void createraspisanie(int kodzala,int kodperioda)
        {
           
            string sql = "select времятекст from времяначала order by времятекст";
 DataTable dttime = new DataTable();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(dttime);
            con.Close();
            OleDbCommand oleDbCommand = new OleDbCommand("insert into Расписание  " +
@" (КодЗала, 
КодПериода, ВремяНачала,
НомерДняНедели) VALUES 
( @КодЗала, 
@КодПериода, @ВремяНачала,
@НомерДняНедели)", con);
              
                
                //добавляем параметры


            OleDbParameter oleDbParameter1 = new OleDbParameter("@КодЗала", OleDbType.Integer);
                oleDbParameter1.Value = kodzala; oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("@КодПериода", OleDbType.Integer);
                oleDbParameter2.Value = kodperioda; oleDbCommand.Parameters.Add(oleDbParameter2);

                             


                


            string s = "";
            //Добавляем параметр
          
            try
            {
                con.Open(); //Открываем соединение с БД
                foreach (DataRow row in dttime.Rows)
                {
                    s = row["времятекст"].ToString();
                    for
                    (int i = 1; i <= 7; i++)
                    {
                        oleDbCommand.CommandText = @"insert into Расписание  " +
    @" (КодЗала, 
КодПериода, ВремяНачала,
НомерДняНедели) VALUES 
( @КодЗала, 
@КодПериода, '" + s + "'," + i.ToString() + ")";


                        oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                        //Закрываем соединение


                    }
                }
                con.Close();
                MessageBox.Show("Расписание создано");
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }
       
        
       
        
        //получаем данные по сотруднику
        public void Login( String s, String p, ref Int32 count)
        {
         
            string sql = @"
                    SELECT 
                        Сотрудники.Логин, 
Сотрудники.Пароль, 
Сотрудники.ФИО, 
Роли.Роль, 
Должности.Должность, 
Сотрудники.КодСотрудника
                    FROM Роли INNER JOIN 
(Должности INNER JOIN Сотрудники ON Должности.КодДолжности = Сотрудники.КодДолжности) ON Роли.КодРоли = Сотрудники.КодРоли
                    WHERE  (Сотрудники.Логин = '" + s + "') AND (Сотрудники.Пароль = '" + p + "')";
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                con.Open();
                
                count = dt.Rows.Count;

                if (count > 0)
                {
                    string passwordDB = dt.Rows[0].ItemArray[1].ToString();//доступ для конкретной строки
                    if (p == passwordDB.Trim())
                    {
                        count = 1;
                        loginuser = dt.Rows[0].ItemArray[0].ToString();
                        tekparol = dt.Rows[0].ItemArray[1].ToString();
                        fiouser = dt.Rows[0].ItemArray[2].ToString();
                        roleuser = dt.Rows[0].ItemArray[3].ToString();
                        koduser = Int32.Parse(dt.Rows[0].ItemArray[5].ToString());
                        doljnuser = dt.Rows[0].ItemArray[4].ToString();
                        koduser = Convert.ToInt32(dt.Rows[0].ItemArray[5]);
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
        //универсальный метод добавления данных в grid
        public void gettable(string sql, DataSet ds)
        {
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                da.Fill(ds);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных из таблицы");
            }
         finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }
        //универсальный метод добавления данных в grid
        public void gettablesotrudnik(  ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT 
Сотрудники.КодСотрудника, 
Сотрудники.ФИО, 
Сотрудники.ИмяКороткое, 
Сотрудники.Телефон, 
Сотрудники.Образование, 
Должности.Должность
FROM Должности INNER JOIN Сотрудники ON Должности.КодДолжности = Сотрудники.КодДолжности;
";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
          } 
        //получение таблицы Клиент
        public void gettableklient(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT 
КодКлиента, Клиент, 
Телефон, Email, Примечания 

FROM Клиенты";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }
        //поиск в таблице
        public void poisk(DataGridView grid,string s)
        {
            if (s.Trim() == "")
            {
                MessageBox.Show("Нет запроса");
                return;
            }
            for (int i = 0; i < grid.RowCount; i++)
            {

                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    grid.Rows[i].Cells[j].Selected = false;
                    if (grid.Rows[i].Cells[j].Value != null)
                        if (grid.Rows[i].Cells[j].Value.ToString().ToLower().Contains(s.ToLower()))
                        {
                            grid.Rows[i].Cells[j].Selected = true;
                            break;
                        }
                }
            }
        }
        //универсальный метод получения значения
        public  string  getname(string sql)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string s = "";
            if (ds.Tables[0].Rows.Count==1)
            s = ds.Tables[0].Rows[0][0].ToString();
           

            return s;
        }
        
        //универсальный метод добавления данных в grid поставщика
        public void gettablevidabonementa(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT ВидыАбонементов.КодВидаАбонемента, 
НазванияВидовАбонемента.НазваниеВидаАбонемента, Залы.Зал, ВидыАбонементов.Цена, 
ВидыАбонементов.КоличествоПосещений
FROM Залы INNER JOIN 
(НазванияВидовАбонемента INNER JOIN ВидыАбонементов 
ON НазванияВидовАбонемента.КодНазванияВидаАбонемента = ВидыАбонементов.КодНазванияВидаАбонемента) 
ON Залы.КодЗала = ВидыАбонементов.КодЗала order by Залы.Зал, ВидыАбонементов.КоличествоПосещений";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }
        
        //универсальный метод добавления данных в grid периоддействия
        public void gettableperiod(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT КодПериода, 
НазваниеПериода as Название, 
НачалоПериода as Начало, 
КонецПериода as Конец
FROM ПериодДействия order by НачалоПериода Desc;
";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }
        //универсальный метод добавления данных в grid направлений групп
        public void gettablenapr(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT КодНаправления, 
Направление
FROM Направления;
";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        } 
        //универсальный метод добавления данных в grid  групп
        public void gettablegruppa(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT Группы.КодГруппы, Группы.Группа, Направления.Направление,  Группы.Цвет
FROM Направления INNER JOIN Группы ON Направления.КодНаправления = Группы.КодНаправления";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }
        
        //универсальный метод добавления данных в grid зал
        public void gettablezal(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT 
Залы.КодЗала, 
Залы.Зал, 
Залы.Площадь, 
Залы.Вместимость, 
Залы.Адрес
FROM Залы;

";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }

 //универсальный метод добавления данных в grid абонементы
        public void gettableabonement(ref  OleDbDataAdapter da)
        {
            string sql = @"SELECT Абонементы.КодАбонемента, Клиенты.Клиент, Клиенты.Телефон, НазванияВидовАбонемента.НазваниеВидаАбонемента as [Абонемент], 
Залы.Зал, Абонементы.ИтогоКОплате as [К оплате], Абонементы.Оплачено, Абонементы.ДатаНачала as [C], Абонементы.ДатаКонца as По, Сотрудники.ФИО as Менеджер
FROM Залы INNER JOIN (Сотрудники INNER JOIN (Клиенты INNER JOIN (НазванияВидовАбонемента INNER JOIN (ВидыАбонементов INNER JOIN Абонементы 
ON ВидыАбонементов.КодВидаАбонемента = Абонементы.КодВидаАбонемента) 
ON НазванияВидовАбонемента.КодНазванияВидаАбонемента = ВидыАбонементов.КодНазванияВидаАбонемента) 
ON Клиенты.КодКлиента = Абонементы.КодКлиента) ON Сотрудники.КодСотрудника = Абонементы.КодСотрудника) ON Залы.КодЗала = ВидыАбонементов.КодЗала";
            con.Open();
            da = new OleDbDataAdapter(sql, con);
            con.Close();
        }




        //вставка записи
        public void insertrecord(string nametable, DataGridView grid, Boolean updategrid)
        {
            Program.modified = false;
            Program.insert = true;
            selectrecord(nametable, 0, "");
           
//обновляем таблицу если изменяли  
            if (Program.modified &&  updategrid)
            {
                selecttable(nametable, grid);
                grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[1];
            }


        }
        //выбор записей
        public void selectrecord(string nametable, int id,string name)
        {
            switch (nametable)
            {
                
                
                case "НазванияВидовАбонемента":
                    FormSpr w4 = new FormSpr("НазванияВидовАбонемента", id, "КодНазванияВидаАбонемента", "НазваниеВидаАбонемента", name);
                    w4.ShowDialog();
                    break;
                case "Должности":
                    FormSpr w5 = new FormSpr("Должности", id, "КодДолжности", "Должность", name);
                    w5.ShowDialog();
                    break;
                case "Абонементы":
                    fabonement w6 = new fabonement(id);
                    w6.ShowDialog();
                    break;
                  
                
                case "Сотрудники":
                    fsotrudnik w12 = new fsotrudnik(id);
                    w12.ShowDialog();
                    break;
                case "Клиенты":
                    fklient w13 = new fklient(id);
                    w13.ShowDialog();
                    break;
                case "Направления":
                    fnapr w13n = new fnapr(id);
                    w13n.ShowDialog();
                    break;
                case "Группы":
                    fgrupp w13nn = new fgrupp(id);
                    w13nn.ShowDialog();
                    break;
                case "Залы":
                    fobject w14 = new fobject(id);
                    w14.ShowDialog();
                    break;
                case "ПериодДействия":
                    fperiod w15 = new fperiod(id);
                    w15.ShowDialog();
                    break;
                case "ВидыАбонементов":
                    fvidabonementa w16 = new fvidabonementa(id);
                    w16.ShowDialog();
                    break;
                

                default: // все иное
                    MessageBox.Show("Таблица " + nametable + " не найдена");
                    return;
            } //конец case

        }
        //удаление записей
        public void deleterecord(string nametable, DataGridView grid)
        {
            try
            {
                int nrows = indexselectedgrid(grid);

                if (nrows == -1)
                {
                    MessageBox.Show("Не выбрана запись");
                    return;
                }
                int index = 0;

                if (!Int32.TryParse(grid[0, nrows].Value.ToString(), out index))
                {
                    MessageBox.Show("Ошибка удаления ");
                    return;
                }
                string pole = grid.Columns[0].HeaderText;
                OleDbCommand command1 = new OleDbCommand();
                
                switch (nametable)
                {
                    
                    case "Группы":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Расписание  where КодГруппы = " + index.ToString(), con);
                        break;
                    case "НазванияВидовАбонемента":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from ВидыАбонементов  where КодНазванияВидаАбонемента = " + index.ToString(), con);
                        break;
                    case "Направления":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Группы  where Коднаправления = " + index.ToString(), con);
                        break;
                    case "Должности":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Сотрудники  where коддолжности = " + index.ToString(), con);
                        break;

                    case "Абонементы":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Абонементы  where кодабонемента = " + index.ToString()+
                    " and  оплачено=true", con);
                        break;
                    
                   
                  
                    case "Сотрудники":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from ЖурналЗанятий  where (КодСотрудника = " + index.ToString() +
                                                        ") ", con);
                      
                        break;
                    case "Клиенты":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Абонементы  where КодКлиента = " + index.ToString(), con);
                        break;
                    
                     case "ПериодДействия":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from  Расписание where КодПериода = " + index.ToString(), con);
                        break;
                     case "ВидыАбонементов":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Абонементы  where КодВидаАбонемента = " + index.ToString(), con);
                        break;
                    
                   
                   
                    case "Залы":
                        command1 = new OleDbCommand(@" SELECT COUNT(*) from Расписание  where КодЗала= " + index.ToString(), con);
                        break;
                    
                    default:
                        MessageBox.Show("Таблица отсутствует в списке для обработки");
                        return;
                }

                //дополнительная проверка
                if ((nametable == "Залы"))
                {
                    command1 = new OleDbCommand(@" SELECT COUNT(*) from ВидыАбонементов  where КодЗала= " + index.ToString(), con);
                    con.Open();                                                                                               //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    con.Close();
                    if (a > 0)
                    {
                        MessageBox.Show("Ошибка удаления, на зал есть виды абонементов.",
                                            "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
              
                {
                    con.Open();                                                                                               //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    con.Close();
                    if (a > 0)
                    {
                        if (nametable == "Абонементы") 
                        MessageBox.Show("Ошибка удаления, абонемент оплачен",
                                            "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else MessageBox.Show("Ошибка удаления, данная запись используется в других таблицах.",
                                          "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                //дополнительная проверка
                if ((nametable == "Сотрудники"))
                {
                    command1 = new OleDbCommand(@" SELECT COUNT(*) from Расписание  where КодСотрудника= " + index.ToString(), con);
                    con.Open();                                                                                               //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    con.Close();
                    if (a > 0)
                    {
                        MessageBox.Show("Ошибка удаления, в Расписании есть записи связанные с данным сотрудником.",
                                            "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                if ((nametable == "Сотрудники"))
                {
                    command1 = new OleDbCommand(@" SELECT COUNT(*) from ЖурналЗанятий  where КодСотрудника= " + index.ToString(), con);
                    con.Open();                                                                                               //Открываем соединение с БД
                    object result = command1.ExecuteScalar();
                    int a = Convert.ToInt32(result);//Выполняем запрос.
                    con.Close();
                    if (a > 0)
                    {
                        MessageBox.Show("Ошибка удаления, в Журнале занятий есть записи связанные с данным сотрудником.",
                                            "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                

                string s = "Вы действительно хотите удалить ";
                if (nametable == "Абонементы") s = "Вы действительно хотите удалить абонемент клиента ";
                var resultt = MessageBox.Show(s + grid[1, nrows].Value.ToString() + "?", "Выбор",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                // If the no button was pressed ...
                if (resultt == DialogResult.Yes)
                {
                    
                            command1 = new OleDbCommand(@"delete FROM " + nametable + " where " + pole + "=" + index.ToString(), con);
                          
                   

                    con.Open();
                    command1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Удаление прошло успешно ");


                    grid.Rows.RemoveAt(nrows);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления " + ex.ToString(),
                    "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();

                }

            }
        }
        //проверка выбора строки в таблице
        public int indexselectedgrid(DataGridView grid)
        {

            if (grid.Rows.Count == 0)
            {
                return -1;
            }
            if (grid.CurrentRow != null)
                return grid.CurrentRow.Index;
            else return -1;


        }
        //редактирование записи
        public void edittable(string nametable, DataGridView grid, Boolean updategrid)
         {
             int nrows = indexselectedgrid(grid);

             if (nrows == -1)
             {
                 MessageBox.Show("Не выбрана строка для редактирования");
                 return;
             }
             int id = Int32.Parse(grid[0, nrows].Value.ToString());

             Program.insert = false;
             Program.modified = false;


             selectrecord(nametable, id, grid[1, nrows].Value.ToString());
             if (Program.modified && updategrid)
             {
                 selecttable(nametable, grid);
                 grid.CurrentCell = grid.Rows[nrows].Cells[1];
             } 
         }
        //выборка из таблицы
        public    void selecttable(string nametable, DataGridView grid)
        {

            try
            {
                switch (nametable)
                {
                    
                    case "Сотрудники":
                        gettablesotrudnik(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        break;
                    case "Залы":
                        gettablezal(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;
                    case "ВидыАбонементов":
                        gettablevidabonementa(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;
                    case "ПериодДействия":
                        gettableperiod(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;
                    case "Клиенты":
                        gettableklient(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        break;
                    case "Направления":
                        gettablenapr(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                       
                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;
                    case "Группы":
                        gettablegruppa(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);

                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;
                    
                   
                    case "Абонементы":
                        gettableabonement(ref  daspr);
                        dsspr = new DataSet();
                        daspr.Fill(dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        break;
                    default:
                        string sql = "Select * from " + nametable;  //универсальный метод добавления данных в grid
                        dsspr = new DataSet();
                        gettable(sql, dsspr);
                        grid.DataSource = dsspr.Tables[0];
                        grid.Columns[0].Visible = false;
                        break;

                }//switch
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        
    }
}
