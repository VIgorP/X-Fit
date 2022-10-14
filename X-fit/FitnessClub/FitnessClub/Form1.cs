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
using Word = Microsoft.Office.Interop.Word;



namespace FitnessClub

{
    public partial class Form1 : Form
    {
        object CellValue;
       ClassBaseFIT BaseFIT = new ClassBaseFIT();
// переменные для передачи в универсальную форму выбора
       public static bool modified { get; set; }
       public static string nameperiod { get; set; }
       public static int idperiod{ get; set; }
       public static string namegruppa{ get; set; }
       public static int idgruppa{ get; set; }
       public static string nameperiod2 { get; set; }
       public static int idperiod2 { get; set; }

     
       DataSet dsjournal = new DataSet();
       DataView dvjournal = new DataView();
       public static Boolean insert { get; set; }
     
            
     
       int rowcount; 
     
        public Form1()
        {
            InitializeComponent();
            idperiod = -1;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
       
            //запускаем форму аутентификации
            LoginForm w = new LoginForm();
            if (!(w.ShowDialog() == DialogResult.OK)) //форма регистрации будет открыта раньше, чем главная форма
            {
                Application.Exit(); //если форма регистрации закроется с неправильным диалогрезалтом, то программу закрываем
                this.Close();
                return;
            }
            
            
            if (!Program.guest)
            {
                LoginLabel.Text = "Логин: " + Program.BaseFIT.loginuser;
                FioLabel.Text = "ФИО: " + Program.BaseFIT.fiouser;
                doljnlabel.Text = "Должность: " + Program.BaseFIT.doljnuser;
                
                lroluser.Text = "Роль: " + Program.BaseFIT.roleuser;
            }
            else
            {
                LoginLabel.Text = "Гость" ;
                FioLabel.Text = "" ;
                doljnlabel.Text = "";
               
                lroluser.Text = "";
            }

            //настраиваем вид скрыаем ярлыки листов
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabStop = false;
           
            DataLabel.Text = "Сегодня: " + DateTime.Now.ToLongDateString();


            gridspr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        
             gridabonement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                 
              gridklient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;    
            gridsotrudnik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
         
           Program.selectspr ="parrent";
         
             for (int i = 0; i < tree.Nodes.Count; i++) {  if (i < 2) tree.Nodes[i].Expand(); }
  
             // загружаем на странице Клиенты Сотрудники абонементы
             BaseFIT.selecttable("Клиенты", gridklient);
             BaseFIT.selecttable("Сотрудники", gridsotrudnik);
            BaseFIT.selecttable("Абонементы", gridabonement);
            
             //заполняем период

             string sql = @"SELECT ПериодДействия.КодПериода, ПериодДействия.НазваниеПериода, ПериодДействия.НачалоПериода, ПериодДействия.КонецПериода
FROM ПериодДействия
WHERE (([НачалоПериода]<=Date() And [КонецПериода]>=Date()));
";
 DataSet ds = new DataSet();
             BaseFIT.gettable(sql,ds);
            

             if (ds.Tables[0].Rows.Count > 0)
             {

                 nameperiod = ds.Tables[0].Rows[0]["НазваниеПериода"].ToString();
                 tbnameperiod.Text = nameperiod;
                 idperiod = Convert.ToInt32( ds.Tables[0].Rows[0]["КодПериода"].ToString());
nameperiod2 = ds.Tables[0].Rows[0]["НазваниеПериода"].ToString();
                 tbnameperiod2.Text = nameperiod2;
                 idperiod2 = Convert.ToInt32( ds.Tables[0].Rows[0]["КодПериода"].ToString());
             }

             //загружаем combobox
              sql = @"SELECT кодзала, зал FROM Залы order by Зал";
              ds = new DataSet();
             OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.connection);
             BaseFIT.con.Open();
             da.Fill(ds);
             BaseFIT.con.Close();
             cbzall.DataSource = null;
             cbzall.DataSource = ds.Tables[0];
             cbzall.DisplayMember = "Зал";
             cbzall.ValueMember = "КодЗала";
            //2-й combobox
             DataSet ds2 = new DataSet();
             OleDbDataAdapter da2 = new OleDbDataAdapter(sql, BaseFIT.connection);
             BaseFIT.con.Open();
             da2.Fill(ds2);
             BaseFIT.con.Close();
             cbzaljournal.DataSource = null;
             cbzaljournal.DataSource = ds2.Tables[0];
             cbzaljournal.DisplayMember = "Зал";
             cbzaljournal.ValueMember = "КодЗала";
            //переходим на заставку
             tabControl1.SelectedIndex = 1;
             zagruzkachb();
             idgruppa=0;
             prava();
        }
        //права для гостя
        private void prava()
        {
            if (Program.guest == true)
            {
                toolStrip2.Visible = false;
                button6.Visible = false;
                видToolStripMenuItem.Visible = false;
                переходToolStripMenuItem.Visible = false;
                сменаПароляToolStripMenuItem.Visible = false;

            }
        }
    //выделение пункт в дереве справочников
        private void tree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null) return;

            // if treeview HideSelection property is "True", 
            // this will always returns "False" on unfocused treeview
            var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
            var unfocused = !e.Node.TreeView.Focused;
                        // we need to do owner drawing only on a selected node
            // and when the treeview is unfocused, else let the OS do it for us
            if (selected && unfocused)
            {
                var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.DrawDefault = true;
            }

        }
        //настраиваем права пользователей
        private  Boolean knopkispr_enabled()
        {
            
            if (Program.selectspr == "parrent")
            {
                btneditspr.Enabled = false;
                btninsertspr.Enabled = false;
                btndeletespr.Enabled = false;
                return false;

            }

            if ((Program.BaseFIT.roleuser == "Администратор") || (Program.BaseFIT.roleuser == "Менеджер") || (Program.BaseFIT.roleuser == "Системный администратор"))
            {
                
                {

                    btneditspr.Enabled = true;
                    btninsertspr.Enabled = true;
                    btndeletespr.Enabled = true;
                  

                }
        }
else 
{

                btneditspr.Enabled = false;
                btninsertspr.Enabled = false;
                btndeletespr.Enabled = false;
                

            }
      return true;
        }
  //обработка событий в дереве справочников    

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Program.selectspr = tree.SelectedNode.Tag.ToString();
            LabelSpavochnik.Text = tree.SelectedNode.Text;

            if (!knopkispr_enabled()) return;
            BaseFIT.selecttable(Program.selectspr, gridspr);
           
        }
        //проверка выбрана ли строка в таблице
         public int indexselectedgrid(DataGridView grid)
        {
          
            if (grid.Rows.Count == 0)
            {
                return -1;
            }
            if (grid.CurrentRow != null)
                return  grid.CurrentRow.Index;
            else return -1;
           
        }

   //кнопка редактировать на вкладке справочники    
        private void btneditspr_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable(Program.selectspr, gridspr, true);

        }

        //кнопка добавить на вкладке справочники  

        private void btninsertspr_Click(object sender, EventArgs e)
        {
            BaseFIT.insertrecord(Program.selectspr, gridspr, true);
          

        }
        //кнопка удалить на вкладке справочники    

        private void btndeletespr_Click(object sender, EventArgs e)
        {
            BaseFIT.deleterecord(Program.selectspr, gridspr);
        }
        //двойной щелчок мыши  на вкладке справочники  
        private void gridspr_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            btneditspr_Click(sender, e);
        }
//кнопка обновить на вкладке абонементы
        private void button5_Click(object sender, EventArgs e)
        {
         
            BaseFIT.selecttable("Абонементы", gridabonement);
          
        }
        //кнопка удалить на вкладке абонементы

        private void button3_Click(object sender, EventArgs e)
        {
            
            BaseFIT.deleterecord("Абонементы", gridabonement);
        }

        //кнопка редактировать на вкладке абонементы  
private void button1_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable("Абонементы", gridabonement,true);
  
        }

//кнопка добавить на вкладке абонементы
        private void button2_Click(object sender, EventArgs e)
        {
            BaseFIT.insertrecord("Абонементы", gridabonement, true);
       
        }
//мненю выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
//вызова о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fabout w = new fabout();
            w.ShowDialog();
        }







        //кнопка экспорт в excel на вкладке абонементы
        private void button24_Click(object sender, EventArgs e)
        {
            ToExcel(gridabonement, lbabonement.Text, 1, 0);
        }
        //таблицу отчета в excel
        public void ToExcel(System.Windows.Forms.DataGridView dgrid, string s, int start,int end)
        {
            if (dgrid.RowCount == 0)
            {
                MessageBox.Show("Нет данных для экспорта");
                return;
            }
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            
            // Выделяем диапазон ячеек от H1 до K1         
            Microsoft.Office.Interop.Excel.Range _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A1", "H1").Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelWorkSheet.Cells[1, 1] = s;





            for (int j = start; j < dgrid.ColumnCount; j++)
                if (end != 0)
                {
                    if (j <= end) ExcelApp.Cells[3, j + 1] = dgrid.Columns[j].HeaderText;
                }
                else ExcelApp.Cells[3, j + 1] = dgrid.Columns[j].HeaderText;
            
            int i;
            for (i = 0; i < dgrid.RowCount; i++)
            {
                for (int j = start; j < dgrid.ColumnCount; j++)
                {
                    if (end != 0)
                    {
                        if (j <= end) ExcelApp.Cells[i + 4, j + 1] = dgrid.Rows[i].Cells[j].Value;
                    }
                    else ExcelApp.Cells[i + 4, j + 1] = dgrid.Rows[i].Cells[j].Value;

                }
            }

            // Выделяем диапазон ячеек от H1 до K1   

            _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A" + (i + 6).ToString(), "F" + (i + 6).ToString()).Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelWorkSheet.Cells[i + 6, 1] = "Отчет подготовлен " + Program.BaseFIT.fiouser + " (" + Program.BaseFIT.doljnuser + ")";

            //  ExcelApp.Cells[i + 6,1] =
            string s1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A" + (i + 7).ToString(), "F" + (i + 7).ToString()).Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelApp.Cells[i + 7, 1] = "Время формирования: " + s1;

            //Вызываем нашу созданную эксельку.
            ExcelApp.Columns.EntireColumn.AutoFit();
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        //таблицу расписания в excel
        public void ToExcelRasp(string s, int start, int end)
        {
            int i;
            Boolean flag=false;
            int counti=0;
            for ( i=0;i<50;i++)
                for (int j = 0; j <= 7; j++)
            {
                if (BaseFIT.rooster[i, j].MyLabel != null)
                {
                    flag = true;
                    counti = i;
                }
               

                

            }
            if (!flag)
            {
                MessageBox.Show("Не сформировано расписание");
                return;
            }

            
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            // Выделяем диапазон ячеек от H1 до K1         
            Microsoft.Office.Interop.Excel.Range _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A1", "H1").Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelWorkSheet.Cells[1, 1] = s;

    // дни недели  
                for (int j = 0; j <= 7; j++)
                {
                    ExcelApp.Cells[3, j + 1] = BaseFIT.zagolvki[j].Text;
                    ExcelApp.Cells[3, j + 1].Interior.Color = BaseFIT.zagolvki[j].BackColor;

                }
           


           
            for (i = 0; i < counti; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    ExcelApp.Cells[i + 4, j + 1] = BaseFIT.rooster[i, j].MyLabel.Text;
                    ExcelApp.Cells[i + 4, j + 1].Interior.Color = BaseFIT.rooster[i, j].MyLabel.BackColor;

                    if (j != 0)
                    {
                        Microsoft.Office.Interop.Excel.Range excelRange = ExcelWorkSheet.Cells[i + 4, j + 1] as Microsoft.Office.Interop.Excel.Range;
                        excelRange.Font.Color = Color.White;
                    }
                    
                    

                }
            }

            // Выделяем диапазон ячеек от H1 до K1   

            _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A" + (i + 6).ToString(), "F" + (i + 6).ToString()).Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelWorkSheet.Cells[i + 6, 1] = "Расписание подготовлено " + Program.BaseFIT.fiouser + " (" + Program.BaseFIT.doljnuser + ")";

            //  ExcelApp.Cells[i + 6,1] =
            string s1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A" + (i + 7).ToString(), "F" + (i + 7).ToString()).Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            ExcelApp.Cells[i + 7, 1] = "Время формирования: " + s1;

            //Вызываем нашу созданную эксельку.
            ExcelApp.Columns.EntireColumn.AutoFit();
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }


        //кнопка в excel

        private void button32_Click(object sender, EventArgs e)

        {
            ToExcel(gridjournal, "Журнал занятий", 1, 14);
           
        }

   // в excel справочник
        private void button62_Click(object sender, EventArgs e)
        {
            ToExcel(gridspr,LabelSpavochnik.Text, 1, 0);
        }

   //меню вызов справки   
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string commandText = Directory.GetCurrentDirectory() + "\\SpravkaFit.pdf";
            if (File.Exists(commandText))
            {
                try
                {
                    var proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = commandText;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка открытия файла справки");
                }

            }
            else MessageBox.Show("Файл справки отсутствует");
        
        }

      //вызов формы смены пароля

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeParol w = new FormChangeParol();
            w.ShowDialog();
        }

        bool IsTheSameCellValue(int column, int row,DataGridView grid )
        {
            if (column != 1) return false;
          
            DataGridViewCell cell1 = grid[column, row];
            DataGridViewCell cell2 = grid[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

  //выделяем кнопку на панели кнопок слева       
      
        private void checked_knopka(object sender)
        {
            
         
            foreach (ToolStripButton item in ((ToolStripButton)sender).GetCurrentParent().Items)
            {
             
                if (item == sender)
                {
                    item.Checked = true;
                   
                }
                if ((item != null) && (item != sender))
                {
                    item.Checked = false;
                   
                }
            }


        }
//расписание
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);
            tabControl1.SelectedIndex = 0;

        }
        // Клиенты
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);
            tabControl1.SelectedIndex = 4;
        }

        // Клиенты

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);
            tabControl1.SelectedIndex = 3;
        }
        // выход
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
//заставка
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);  
            tabControl1.SelectedIndex = 1;
        }
//справочники
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);
 tabControl1.SelectedIndex = 3;
        }
//журнал занятий
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            checked_knopka(sender); 
            tabControl1.SelectedIndex = 2;
        }
//обновить клиенты
        private void button35_Click(object sender, EventArgs e)
        {
            BaseFIT.selecttable("Клиенты", gridklient);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable("Клиенты", gridklient, true);
        }
//вставка клиенты
        private void button37_Click(object sender, EventArgs e)
        {
            BaseFIT.insertrecord("Клиенты", gridklient, true);
        }
//удалить лиенты
        private void button38_Click(object sender, EventArgs e)
        {
            BaseFIT.deleterecord("Клиенты", gridklient);
        }
// в excel rkbtyns
        private void button34_Click(object sender, EventArgs e)
        {
            ToExcel(gridklient, "Клиенты", 1, 0);
        }
//обновить сотрудники
        private void button40_Click(object sender, EventArgs e)
        {
            BaseFIT.selecttable("Сотрудники", gridsotrudnik);
        }
//меню сотрудники
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
  checked_knopka(sender); 
            tabControl1.SelectedIndex = 5;
        }
//в excel сотрудники
        private void button39_Click(object sender, EventArgs e)
        {
            ToExcel(gridsotrudnik, "Сотрудники", 1, 0);
        }
//удалить сотрудника
        private void button43_Click(object sender, EventArgs e)
        {
            BaseFIT.deleterecord("Сотрудники", gridsotrudnik);
        }
//добавить сотрудника
        private void button42_Click(object sender, EventArgs e)
        {
            BaseFIT.insertrecord("Сотрудники", gridsotrudnik, true);
        }
//редактировать сотрудника
        private void button41_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable("Сотрудники", gridsotrudnik, true);
        }

     //двойной щелчок на таблице сотрудники   
        private void gridsotrudnik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button41_Click(sender,e);
        }

     //загрузка combobox
        private void zagruzkachb()
        {

       
        //загружаем combobox
            string sql = @"SELECT кодсотрудника, ФИО, имякороткое  FROM Сотрудники order by ФИО";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da.Fill(ds);
            BaseFIT.con.Close();
            cbsotrvipolnil.DataSource = null;
            cbsotrvipolnil.DataSource = ds.Tables[0];
            cbsotrvipolnil.DisplayMember = "ФИО";
            cbsotrvipolnil.ValueMember = "кодсотрудника";
            DataSet ds2 = new DataSet();
            OleDbDataAdapter da2 = new OleDbDataAdapter(sql, BaseFIT.connection);
            BaseFIT.con.Open();
            da2.Fill(ds2);
            BaseFIT.con.Close();
            cbsotrplan.DataSource = null;
            cbsotrplan.DataSource = ds2.Tables[0];
            cbsotrplan.DisplayMember = "ФИО";
            cbsotrplan.ValueMember = "кодсотрудника";
            sql = @"SELECT КодНаправления, Направление
            FROM Направления order by Направление";
            DataSet ds3 = new DataSet();
            OleDbDataAdapter da3 = new OleDbDataAdapter(sql, BaseFIT.connection);
           
            BaseFIT.con.Open();
            da3.Fill(ds3);
            BaseFIT.con.Close();
            cbnapr.DataSource = null;
            cbnapr.DataSource = ds3.Tables[0];
            cbnapr.DisplayMember = "Направление";
            cbnapr.ValueMember = "КодНаправления";

            cbdennedeli.SelectedIndex = 0;


            
        }
//обновить combobox
        private void button11_Click_1(object sender, EventArgs e)
        {

            zagruzkachb();
        }
//вывод журнала занятий
        private void button12_Click_1(object sender, EventArgs e)
        {
            string sql = @"SELECT 
ЖурналЗанятий.КодЗанятия as Код, 
ЖурналЗанятий.ДатаЗанятия, 
Залы.Зал, 
Группы.Группа, 
Направления.Направление, 
ЖурналЗанятий.Выполнено, 
Расписание.КодСотрудника as [КодТренераПоПлану], 
ЖурналЗанятий.КодСотрудника as [КодТренераПровел], 
Расписание.КодПериода,
Расписание.КодРасписания,
Расписание.НомерДняНедели,
Направления.КодНаправления, 
Группы.КодГруппы, 
Количество
FROM Направления INNER JOIN (Группы INNER JOIN (Залы INNER JOIN (Расписание INNER JOIN ЖурналЗанятий ON Расписание.КодРасписания = ЖурналЗанятий.КодРасписания) ON Залы.КодЗала = Расписание.КодЗала) ON Группы.КодГруппы = Расписание.КодГруппы) ON Направления.КодНаправления = Группы.КодНаправления
WHERE (((Расписание.КодЗала)=" + cbzaljournal.SelectedValue + ") AND ((Расписание.КодПериода)=" + idperiod2.ToString() + "));";
           dsjournal=new DataSet();
       
           gridjournal.DataSource = null;
           for (int i=0; i < gridjournal.Columns.Count; i++)
           {
               gridjournal.Columns.RemoveAt(0);
           }

               BaseFIT.gettable(sql, dsjournal);


           dvjournal = new DataView(dsjournal.Tables[0]);
           gridjournal.DataSource = dvjournal;
           gridjournal.Columns[6].Visible = false; ;
           gridjournal.Columns[7].Visible = false; ;
           gridjournal.Columns[8].Visible = false; ;

           gridjournal.Columns[9].Visible = false; ;
           gridjournal.Columns[10].Visible = false; ;
           gridjournal.Columns[11].Visible = false; ;
           gridjournal.Columns[12].Visible = false; ;
           gridjournal.Columns[3].Width = 200;//группа-
           gridjournal.Columns[4].Width = 200;//направление
           gridjournal.Columns[5].Width = 80;
           gridjournal.Columns[0].Width = 50;
           gridjournal.Columns[6].Width = 80;
           sql = @"
                           SELECT 
                                КодСотрудника, 
                                ФИО 
                                
                            FROM     Сотрудники";

          
           DataSet ds1 = new DataSet();
           OleDbDataAdapter da1 = new OleDbDataAdapter(sql, BaseFIT.con);


            BaseFIT.con.Open();
           da1.Fill(ds1);
           BaseFIT.con.Close();
//добавляем столбцы combobox
           DataGridViewComboBoxColumn comboBoxColumn =
            new DataGridViewComboBoxColumn();
           comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
           comboBoxColumn.ValueType = typeof(int);
           comboBoxColumn.DataSource = ds1.Tables[0];
           comboBoxColumn.ValueMember = "КодСотрудника";
           comboBoxColumn.DisplayMember = "ФИО";
           comboBoxColumn.DataPropertyName = "КодТренераПоПлану";
           comboBoxColumn.HeaderText = "Тренер по плану";
           comboBoxColumn.Width = 200;

           gridjournal.Columns.Add(comboBoxColumn);

           DataSet ds2 = new DataSet();
           OleDbDataAdapter da2 = new OleDbDataAdapter(sql, BaseFIT.con);


           BaseFIT.con.Open();
           da2.Fill(ds2);
           BaseFIT.con.Close();

           DataGridViewComboBoxColumn comboBoxColumn2 =
            new DataGridViewComboBoxColumn();
           comboBoxColumn2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
           comboBoxColumn2.ValueType = typeof(int);
           comboBoxColumn2.DataSource = ds2.Tables[0];
           comboBoxColumn2.ValueMember = "КодСотрудника";
           comboBoxColumn2.DisplayMember = "ФИО";
           comboBoxColumn2.DataPropertyName = "КодТренераПровел";
           comboBoxColumn2.HeaderText = "Кто провел";
           comboBoxColumn2.Width = 200;

           gridjournal.Columns.Add(comboBoxColumn2);
      

for (int i = 0; i < gridjournal.Columns.Count; i++)
             if ((gridjournal.Columns[i].HeaderText == "Выполнено") ||  (gridjournal.Columns[i].HeaderText == "Кто провел")
                 || (gridjournal.Columns[i].HeaderText == "Количество") ) 
                 gridjournal.Columns[i].ReadOnly = false;
             else gridjournal.Columns[i].ReadOnly = true;

        }

        
        //поиск
        private void button44_Click(object sender, EventArgs e)
        {
            BaseFIT.poisk(gridabonement, tbpoiskzakaz.Text);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            BaseFIT.poisk(gridsotrudnik, tbpoisksotr.Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            BaseFIT.poisk(gridklient, tbpoiskzakazchik.Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            BaseFIT.poisk(gridspr, tbpoiskspravochnik.Text);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            checked_knopka(sender);
            tabControl1.SelectedIndex = 6;
        }

       
        public void  proverkaras(int kodzala,int idper)
        {
           
           
            if ((kodzala == -1) || (idper== -1))
            {
                MessageBox.Show("Не выбран зал или период действия расписания");
                return ;

            }


            OleDbCommand command1 = new OleDbCommand(@" SELECT COUNT(*) from Расписание  where КодПериода =  " + idper.ToString()
                    + @" and  КодЗала =" + kodzala.ToString(), BaseFIT.con);
            BaseFIT.con.Open();           //Открываем соединение с БД
            object result = command1.ExecuteScalar();
            int a = Convert.ToInt32(result);//Выполняем запрос.
            BaseFIT.con.Close();
            if (a > 0)
            {

                outraspisanie(kodzala, idper);

            }
            else
            {
              
                var resultt = MessageBox.Show("Для данного зала на выбранный период остутствует расписание. Будет создано новое?", "Выбор",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                // If the no button was pressed ...
                   if (resultt == DialogResult.Yes)
                   {
                       BaseFIT.createraspisanie(kodzala, idper);
                       outraspisanie(kodzala, idper);
                   }
            }
        }

   // формирование и вывод расписания
        //делаем с помощью Label

        public void outraspisanie(int kodzala, int idper)
        {

      

            string sql = @"SELECT  DISTINCT ВремяНачала  
FROM Расписание
WHERE КодПериода=" + idper.ToString()+" and кодзала=" + kodzala.ToString() + " order by ВремяНачала";
            
            DataTable dttime = new DataTable();
          
           OleDbDataAdapter da = new OleDbDataAdapter(sql, BaseFIT.con);
           BaseFIT.con.Open();
            da.Fill(dttime);
            BaseFIT.con.Close();
            string s = "";
           rowcount = dttime.Rows.Count;

            int interval = 2;
            int wtime = 60;
            int globalw = (panelrasp.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth - wtime - 8 * interval) / 7;
            int globalh = globalw * 3 / 5;

int i ;
            //создаем заголовки

//очищаем массив       
for (i = 0; i <= 7; i++)
    
        if (BaseFIT.zagolvki[i] != null)
        {
            panelrasp.Controls.Remove(BaseFIT.zagolvki[i]);
            BaseFIT.zagolvki[i].Dispose();

        }
   
            
         //очищаем массив       
            for ( i = 0; i < 50; i++)
                for (int jj = 0; jj <= 7; jj++)
                {
                    if (BaseFIT.rooster[i, jj].MyLabel != null)
                    {
                        panelrasp.Controls.Remove(BaseFIT.rooster[i, jj].MyLabel);
                        BaseFIT.rooster[i, jj].MyLabel.Dispose();

                    }
                }

//создаем заголовки массив       
for (i = 0; i <=7; i++)
    
       
        {
            BaseFIT.zagolvki[i] = new Label();
            BaseFIT.zagolvki[i].AutoSize = false;
            
            if (i != 0) BaseFIT.zagolvki[i].Size = new Size(globalw, wtime);
            else BaseFIT.zagolvki[i].Size = new Size(wtime, wtime);
            BaseFIT.zagolvki[i].TextAlign = ContentAlignment.MiddleCenter;
            BaseFIT.zagolvki[i].ForeColor = Color.White;
    
            BaseFIT.zagolvki[i].Font = new System.Drawing.Font("Arial", 12);
            if (i != 0)
                BaseFIT.zagolvki[i].Location = new Point(interval + ((globalw + interval) * i) - (globalw - wtime), 0);//+ Panel1.Size.Height + Panel2.Size.Height)
            else BaseFIT.zagolvki[i].Location = new Point(interval + ((globalw + interval) * i), 0);//+ Panel1.Size.Height + Panel2.Size.Height)
            //new Point(5, (i + 1) * 15);
            
            string den = "";
            switch (i)
            {
                case 1:
                    den = "Понедельник";
                    break;
                case 2:
                    den = "Вторник";
                    break;
                case 3:
                    den = "Среда";
                    break;

                case 4:
                    den = "Четверг";
                    break;

                case 5:
                    den = "Пятница";
                    break;

                case 6:
                    den = "Суббота";
                    break;

                case 7:
                    den = "Воскресенье";
                    break;

            }
            BaseFIT.zagolvki[i].Text = den;
    BaseFIT.zagolvki[i].BackColor = Color.LightBlue;
                         BaseFIT.zagolvki[i].ForeColor = Color.Black;



                         panelrasp.Controls.Add(BaseFIT.zagolvki[i]);

        }

int otstuph = BaseFIT.zagolvki[1].Height + interval;

//
// получаем данные по сотрудникам
sql = @"SELECT Расписание.КодРасписания, Расписание.ВремяНачала, Расписание.НомерДняНедели, Сотрудники.ИмяКороткое
FROM Сотрудники INNER JOIN Расписание ON Сотрудники.КодСотрудника = Расписание.КодСотрудника


                              WHERE (КодЗала=" + kodzala.ToString() + ") and (КодПериода=" + idper.ToString() + ")";
DataTable dtraspsotr = new DataTable();

OleDbDataAdapter daraspsotr = new OleDbDataAdapter(sql, BaseFIT.con);
BaseFIT.con.Open();
daraspsotr.Fill(dtraspsotr);
BaseFIT.con.Close();
            //***********************


// получаем данные для текста
sql = @"SELECT Расписание.ВремяНачала, Расписание.НомерДняНедели, Группы.Группа, Группы.Цвет
FROM Группы INNER JOIN Расписание ON Группы.КодГруппы = Расписание.КодГруппы

                              WHERE (КодЗала=" + kodzala.ToString() + ") and (КодПериода=" + idper.ToString() + ")";
DataTable dtrasp = new DataTable();

OleDbDataAdapter darasp = new OleDbDataAdapter(sql, BaseFIT.con);
BaseFIT.con.Open();
darasp.Fill(dtrasp);
BaseFIT.con.Close();
            //***********************
//это отдельный запрос для расстановки кодоврасписания
sql = @"SELECT КодРасписания, ВремяНачала, НомерДняНедели, кодзала
FROM Расписание        WHERE (КодЗала=" + kodzala.ToString() + ") and (КодПериода=" + idper.ToString() + ")";
DataTable dtrasppoln = new DataTable();

OleDbDataAdapter darasppoln = new OleDbDataAdapter(sql, BaseFIT.con);
BaseFIT.con.Open();
darasppoln.Fill(dtrasppoln);
BaseFIT.con.Close();
            //******************





i=-1; //начальное занчение массива


            foreach (DataRow row in dttime.Rows)
            {
              
                i++;
                
                s=row["ВремяНачала"].ToString();
                for (int j = 0; j <= 7; j++)
                {
                   
                   
                    foreach (DataRow row2 in dtrasppoln.Rows)
                    {
                        if ((Int32.Parse(row2["НомерДняНедели"].ToString()) == j) && (row2["ВремяНачала"].ToString() == s))
                        {
                            BaseFIT.rooster[i, j].kodrasp = Int32.Parse(row2["КодРасписания"].ToString());
                            BaseFIT.rooster[i, j].guppa = "";
                            BaseFIT.rooster[i, j].sotrudnik= "";

                             break;
                        }

                    }



                    BaseFIT.rooster[i, j].MyLabel = new Label();
                    BaseFIT.rooster[i, j].MyLabel.AutoSize = false;
                   
                    if (j != 0) BaseFIT.rooster[i, j].MyLabel.Size = new Size(globalw, globalh);
                    else BaseFIT.rooster[i, j].MyLabel.Size = new Size(wtime, globalh);
                    BaseFIT.rooster[i, j].MyLabel.TextAlign = ContentAlignment.MiddleCenter;
                    BaseFIT.rooster[i, j].MyLabel.ForeColor = Color.White;
                    BaseFIT.rooster[i, j].MyLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mylabel_Click);

                    BaseFIT.rooster[i, j].MyLabel.Tag = i.ToString() + "/" + j.ToString();
                    
                    if (j != 0) BaseFIT.rooster[i, j].MyLabel.Font = new System.Drawing.Font("Arial", 10);// Меняем шрифт, размер, начертание 
                    else BaseFIT.rooster[i, j].MyLabel.Font = new System.Drawing.Font("Arial", 12);
                    if (j != 0)
                        BaseFIT.rooster[i, j].MyLabel.Location = new Point(interval + ((globalw + interval) * j) - (globalw - wtime),otstuph+ interval + (globalh + interval) * i);//+ Panel1.Size.Height + Panel2.Size.Height)
                    else BaseFIT.rooster[i, j].MyLabel.Location = new Point(interval + ((globalw + interval) * j),otstuph+ interval + (globalh + interval) * i);//+ Panel1.Size.Height + Panel2.Size.Height)
                   
                    BaseFIT.rooster[i, j].MyLabel.Name = "Label" + i.ToString() + "_" + j.ToString();
                 



 

                    if (j != 0)
                    {
                       Boolean flag=false;
                        foreach (DataRow row1 in dtrasp.Rows)
                        {

                          //сначала проверяем группу 
                            if ((Int32.Parse(row1["НомерДняНедели"].ToString()) == j) && (row1["ВремяНачала"].ToString() == s))
                            {
                               
                              
                                if (!(row1["Цвет"] is DBNull))
                                {
                                    BaseFIT.rooster[i, j].MyLabel.BackColor = Color.FromArgb(Int32.Parse(row1["Цвет"].ToString()));
                                  
                                }
                                else
                                    BaseFIT.rooster[i, j].MyLabel.BackColor = Color.Aqua;
                                BaseFIT.rooster[i, j].guppa = row1["Группа"].ToString();
                                flag=true;
                                break;
                            }
                            
                        }


                         foreach (DataRow row1 in dtraspsotr.Rows)
                        {

                          //сначала проверяем группу 
                            if ((Int32.Parse(row1["НомерДняНедели"].ToString()) == j) && (row1["ВремяНачала"].ToString() == s))
                            {
                               
                             

                                BaseFIT.rooster[i, j].sotrudnik = row1["ИмяКороткое"].ToString();
                                flag=true;
                                break;
                            }
                            
                        }



                      
                           
                           if (!flag) 
                           {BaseFIT.rooster[i, j].MyLabel.BackColor = Color.LightGray;
                                BaseFIT.rooster[i, j].MyLabel.Text ="-";
                           }
                           else 
                         BaseFIT.rooster[i, j].MyLabel.Text =   BaseFIT.rooster[i, j].guppa+Environment.NewLine+ BaseFIT.rooster[i, j].sotrudnik; 
                            
                       

                       

                    }
                    else
                    {


                        BaseFIT.rooster[i, j].MyLabel.Text = s;
                        BaseFIT.rooster[i, j].MyLabel.BackColor = Color.LightBlue;
                        BaseFIT.rooster[i, j].MyLabel.ForeColor = Color.Black;

                    }

                    panelrasp.Controls.Add(BaseFIT.rooster[i, j].MyLabel);

            }

              
               
            }

           
        }
        private void button19_Click_1(object sender, EventArgs e)
        {
            proverkaras(Int32.Parse(cbzall.SelectedValue.ToString()),idperiod);
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
         
            tabControl1.SelectedIndex = 6;
        }

      

        private void button17_Click_1(object sender, EventArgs e)
        {
            ToExcelRasp( "Расписание для зала: "+cbzall.Text+" на период: "+tbnameperiod.Text, 1, 0);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            ToExcel(gridjournal, "Журнал занятий. Зал: " + cbzaljournal.Text + ", на период: " + tbnameperiod2.Text, 1, 5);
        }
      

        private void скрытьТекстВБоковойПанелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripButton item in toolStrip2.Items)
            {
                item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            }
        }

        private void показатьТекстВБоковойПанелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripButton item in toolStrip2.Items)
            {
                item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            }
        }
       

        private void gridworks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button19_Click_1(sender, e);
        }

       

        private void button51_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable("Заказы", gridabonement, true);
        }

     
        private void отчетыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("ПериодДействия", "select КодПериода, НазваниеПериода, НачалоПериода, КонецПериода from ПериодДействия order by НачалоПериода desc");
            w.ShowDialog();
            if (modified)
            {
                tbnameperiod.Text = nameperiod;
            }
        }
//заменяем функцию щелчка по label в массиве rooster
        private void Mylabel_Click(object sender, EventArgs e)
        {
            //здесь самое интересное
            if (Program.guest == true)
            {
                if (((Label)sender).Text == "-") return;           
                }
         
            string s1=((Label)sender).Tag.ToString();
            int i, j;
             char ch = '/';
            int ind = s1.IndexOf(ch);
            if (ind >= 0)
            {
                string[] word = s1.Split(ch);
                i = Convert.ToInt32(word[0]);
                j = Convert.ToInt32(word[1]);
                if (j == 0) return;
             
                Program.modified = false;
 fraspisanie w = new fraspisanie(BaseFIT.rooster[i, j].kodrasp);
 w.ShowDialog();
 if (Program.modified) //обновляем кнопку если что
 {
    string sql=@" SELECT Расписание.КодРасписания, Группы.Группа, Группы.Цвет, Сотрудники.ИмяКороткое
FROM Группы INNER JOIN (Сотрудники INNER JOIN Расписание ON Сотрудники.КодСотрудника = Расписание.КодСотрудника) ON Группы.КодГруппы = Расписание.КодГруппы
WHERE Расписание.КодРасписания=" + BaseFIT.rooster[i, j].kodrasp;
    DataSet dsa = new DataSet();


    BaseFIT.gettable(sql, dsa);
    if (dsa.Tables[0].Rows.Count > 0)
    {
        BaseFIT.rooster[i, j].guppa = dsa.Tables[0].Rows[0]["Группа"].ToString();
        BaseFIT.rooster[i, j].sotrudnik = dsa.Tables[0].Rows[0]["ИмяКороткое"].ToString();
        if (!(dsa.Tables[0].Rows[0]["Цвет"] is DBNull)) BaseFIT.rooster[i, j].MyLabel.BackColor = Color.FromArgb(Int32.Parse(dsa.Tables[0].Rows[0]["Цвет"].ToString()));
        BaseFIT.rooster[i, j].MyLabel.Text = BaseFIT.rooster[i, j].guppa + Environment.NewLine + BaseFIT.rooster[i, j].sotrudnik;
    }
    else
    {
        BaseFIT.rooster[i, j].guppa = "";
        BaseFIT.rooster[i, j].sotrudnik = "";
        BaseFIT.rooster[i, j].MyLabel.Text = "-";
        BaseFIT.rooster[i, j].MyLabel.BackColor = Color.LightGray;


    }

 }
            }
 
        }
//столбец цвет на вкладке справочники группы
        private void gridspr_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Это как раскрашивать ячейки по значениям
            if (gridspr[e.ColumnIndex, e.RowIndex].Value != null)
                if (gridspr.Columns[e.ColumnIndex].HeaderText == "Цвет")
                {
                    int i = 0;
                    if (Int32.TryParse(gridspr[e.ColumnIndex, e.RowIndex].Value.ToString(), out i))
                    {
                        e.CellStyle.BackColor =Color.FromArgb(i);
                        e.CellStyle.ForeColor= Color.FromArgb(i);
                    }
                }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("ПериодДействия2", "select КодПериода, НазваниеПериода, НачалоПериода, КонецПериода from ПериодДействия");
            w.ShowDialog();
            if (modified)
            {
                tbnameperiod2.Text = nameperiod2;
            }
        }

        private void gridjournal_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.CellValue = gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void gridjournal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                if ((gridjournal.Columns[e.ColumnIndex].HeaderText == "Количество"))
                {
                    if (this.CellValue == gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) return;
                    int kol = 0;
                    if (!Int32.TryParse(gridjournal["Количество", e.RowIndex].Value.ToString(), out kol))
                    {
                        kol = 0;
                        MessageBox.Show("Ошибка ввода количества");
                        gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        return;

                    }
                    else
                    {
                        if (kol < 0 || kol >= 100)
                        {
                            MessageBox.Show("Ошибка ввода количества (>0 и меньше 100)");
                            return;
                        }
                    }
                    

                    string sql = @"Update ЖурналЗанятий set Количество=" + gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() +
                        " where кодзанятия=" + gridjournal.Rows[e.RowIndex].Cells[0].Value.ToString();

                    OleDbCommand oleDbCommand = new OleDbCommand(sql, BaseFIT.con);         //Запрос на вставку


                    BaseFIT.con.Open(); //Открываем соединение с БД
                    oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                    BaseFIT.con.Close();
                }

                if ((gridjournal.Columns[e.ColumnIndex].HeaderText == "Кто провел"))
                {
                    if (this.CellValue == gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) return;

                    string sql = @"Update ЖурналЗанятий set КодСотрудника=" + gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() +
                        " where кодзанятия=" + gridjournal.Rows[e.RowIndex].Cells[0].Value.ToString();

                    OleDbCommand oleDbCommand = new OleDbCommand(sql, BaseFIT.con);         //Запрос на вставку


                    BaseFIT.con.Open(); //Открываем соединение с БД
                    oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                    BaseFIT.con.Close();
                }
                

                if ((gridjournal.Columns[e.ColumnIndex].HeaderText == "Выполнено"))
                {
                    if (this.CellValue == gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) return;
                    string sql = "";
                    if (Convert.ToBoolean(gridjournal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    {
                         sql = @"Update ЖурналЗанятий set Выполнено=true  where кодзанятия=" + gridjournal.Rows[e.RowIndex].Cells[0].Value.ToString();
                         OleDbCommand oleDbCommand = new OleDbCommand(sql, BaseFIT.con);         //Запрос на вставку


                         BaseFIT.con.Open(); //Открываем соединение с БД
                         oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                         BaseFIT.con.Close();
                         if (gridjournal.CurrentRow.Cells["КодТренераПровел"].Value == DBNull.Value)
                         {
                             gridjournal.CurrentRow.Cells["КодТренераПровел"].Value = gridjournal.CurrentRow.Cells["КодТренераПоПлану"].Value;

                             sql = @"Update ЖурналЗанятий set КодСотрудника=" + gridjournal.CurrentRow.Cells["КодТренераПровел"].Value.ToString() +
                         " where кодзанятия=" + gridjournal.Rows[e.RowIndex].Cells[0].Value.ToString();
                              oleDbCommand = new OleDbCommand(sql, BaseFIT.con);         //Запрос на вставку
                             BaseFIT.con.Open(); //Открываем соединение с БД
                             oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                             BaseFIT.con.Close();

                         }


                    }
                    else
                    {
                        sql = @"Update ЖурналЗанятий set Выполнено=false,кодсотрудника=null  where кодзанятия=" + gridjournal.Rows[e.RowIndex].Cells[0].Value.ToString();
                        OleDbCommand oleDbCommand = new OleDbCommand(sql, BaseFIT.con);         //Запрос на вставку
                                                BaseFIT.con.Open(); //Открываем соединение с БД
                        oleDbCommand.ExecuteNonQuery();   //Выполняем запрос.
                        BaseFIT.con.Close();
                        // как ячейку в dbnull перевести!!!!!!!!!!!

                        gridjournal.CurrentRow.Cells["КодТренераПровел"].Value = DBNull.Value; ;

                    }
                    
                }
                    
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
            finally
            {
                if (BaseFIT.con != null && BaseFIT.con.State != ConnectionState.Closed)
                {
                    BaseFIT.con.Close();

                }
                
            }


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
//           кнопка фильтр в журнале занятий
            if (dsjournal == null)
            { MessageBox.Show("Журнал не сформирован"); return; }

            string filtr = "";
            if (chbsotrvipolnil.Checked)
                if (cbsotrvipolnil.SelectedIndex>-1)
            {
                string skod = cbsotrvipolnil.SelectedValue.ToString();
                filtr = filtr + "(КодТренераПровел="+skod+")   and ";
            }
            if (chbsotrplan.Checked)
                if (cbsotrplan.SelectedIndex > -1)
                {
                    string skod = cbsotrplan.SelectedValue.ToString();
                    filtr = filtr + "(КодТренераПоПлану=" + skod + ")   and ";
                }

            if (chbdennedeli.Checked)
                if (cbdennedeli.SelectedIndex > -1)
                {
                    string skod = (cbdennedeli.SelectedIndex+1).ToString();
                    filtr = filtr + "(НомерДняНедели=" + skod + ")   and ";
                }
            if (chbnapr.Checked)
                if (cbnapr.SelectedIndex > -1)
                {
                    string skod = cbnapr.SelectedValue.ToString();
                    filtr = filtr + "(КодНаправления=" + skod + ")   and ";
                }
            if (chbgruppa.Checked)
                if (tbnamegruppa.Text!="")
                {
                    string skod =idgruppa.ToString();
                    filtr = filtr + "(КодГруппы=" + skod + ")   and ";
                }
            if (rbvipolneno.Checked) filtr = filtr + "(Выполнено=true)   and ";
            else if (rbnevipolneno.Checked) filtr = filtr + "(Выполнено=false)   and ";
           

            if (rbperiod2.Checked)
            {
                if (dtpend2.Value.Date < dtpstart2.Value.Date)
                {
                    MessageBox.Show("Конец периода должен быть больше или равен начала периода",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                filtr = filtr + @"(((ДатаЗанятия)>=#" + dtpstart2.Value.ToString("MM'/'dd'/'yyyy") + @"# And 
                (ДатаЗанятия)<=#" + dtpend2.Value.ToString("MM'/'dd'/'yyyy") + "#))   and ";
            }
            if (rbzadatu.Checked)
            {
                filtr = filtr + @"(ДатаЗанятия=#" + dtpdata.Value.ToString("MM'/'dd'/'yyyy") + @"#)   And ";
            }


            if (filtr != "")
            {
                filtr = filtr.Substring(0, filtr.Length - 6);
                MessageBox.Show(filtr);
                dvjournal.RowFilter = filtr;
            }
            else dvjournal.RowFilter = "";
          
        }
//выбор группы для фильтра по журналу занятий
        private void button13_Click(object sender, EventArgs e)
        {
            modified = false;
            formsprcase w = new formsprcase("Группы", @"SELECT Группы.КодГруппы, Группы.Группа, Направления.Направление
FROM Направления INNER JOIN Группы ON Направления.КодНаправления = Группы.КодНаправления");
            w.ShowDialog();
            if (modified)
            {
                tbnamegruppa.Text = namegruppa;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dvjournal.RowFilter = "";
        }
//далее настройка меню переход
        private void РасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }

        private void АбонементыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void ЖурналЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void КлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void СотрудникиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void СправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex =3;
        }

        private void ЗаставкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

    }
}
