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
    public partial class formsprcase : Form
    {
        DataSet dsspr;
     
        ClassBaseFIT BaseFIT = new ClassBaseFIT();
        string table;
        Boolean tmpinsert;
        
        string sql;
    
        public formsprcase(string table, string sql)
        {
            InitializeComponent();
            this.table = table;
            this.sql = sql;
           
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
             int nrows = indexselectedgrid(gridspr);
           
            if (nrows == -1)
            {
                MessageBox.Show("Не сделан выбор");
                return;
            }
            switch (table)
            {
            
            
            case "ВидыАбонементов":
            
                fabonement.idtypeabonementa = Int32.Parse(gridspr[0, nrows].Value.ToString());
                fabonement.namezala = gridspr[2, nrows].Value.ToString();
                fabonement.nametypeabonementa = gridspr[1, nrows].Value.ToString();
                fabonement.cena = Int32.Parse(gridspr[4, nrows].Value.ToString());
                fabonement.modified = true;
            break;
                    
            case "Сотрудники":

              
                    fabonement.idmenedger = Int32.Parse(gridspr[0, nrows].Value.ToString());
                    fabonement.namemenedger = gridspr[1, nrows].Value.ToString();
                    fabonement.modified = true;
                
            break;
            
            case "ПериодДействия":

            Form1.idperiod = Int32.Parse(gridspr[0, nrows].Value.ToString());
            Form1.nameperiod = gridspr[1, nrows].Value.ToString();
            Form1.modified = true;
            break;
            case "ПериодДействия2":

            Form1.idperiod2 = Int32.Parse(gridspr[0, nrows].Value.ToString());
            Form1.nameperiod2 = gridspr[1, nrows].Value.ToString();
            Form1.modified = true;
            break;
            case "Группы":

            Form1.idgruppa = Int32.Parse(gridspr[0, nrows].Value.ToString());
            Form1.namegruppa = gridspr[1, nrows].Value.ToString();
            Form1.modified = true;
            break;
            
           

            case "Клиенты":
            
                fabonement.idclient = Int32.Parse(gridspr[0, nrows].Value.ToString());

                fabonement.nameclient = gridspr[1, nrows].Value.ToString();
 fabonement.telefon= gridspr[2, nrows].Value.ToString();
                fabonement.modified = true;
            break;
            
            

            
          
                default:
            MessageBox.Show("Для данной таблицы неопределен выбор");
            return;
            }
           
             
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
            timer1.Enabled = true;
            if (Program.guest == true)
            {
               
                button4.Visible = false;
                button3.Visible = false;

            }
            lbres.Text = table;
           
        }
       

       
        private void gettable()
        {
            dsspr = new DataSet();

            BaseFIT.gettable(sql, dsspr);
            gridspr.DataSource = dsspr.Tables[0];
            gridspr.Columns[0].Visible = false;
            gridspr.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            gridspr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gettable();

        }

        private void gridspr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            tmpinsert = Program.insert;
            //if (table == "Категории") BaseFIT.edittable("ТипыПериодДействия", gridspr, false);
            //else
            BaseFIT.insertrecord(table, gridspr,false);
            if (Program.modified)
            {
                gettable();
                  if (gridspr.RowCount > 0) gridspr.CurrentCell = gridspr.Rows[gridspr.RowCount - 1].Cells[1];
            }
           
          
            Program.insert = tmpinsert;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseFIT.edittable(table, gridspr, false);
            gettable();
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int nrows = indexselectedgrid(gridspr);

            if (nrows == -1)
            {
                MessageBox.Show("Не выбрана строка для редактирования");
                return;
            }
          

            tmpinsert = Program.insert;
            
            BaseFIT.edittable(table, gridspr, false);
            if (Program.modified)
            {
                gettable();
                gridspr.CurrentCell = gridspr.Rows[nrows].Cells[1];
            }
            Program.insert = tmpinsert;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            BaseFIT.poisk(gridspr, tbpoisk.Text);
        }

        private void tbpoiskzakaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbres_Click(object sender, EventArgs e)
        {

        }
    }
}
