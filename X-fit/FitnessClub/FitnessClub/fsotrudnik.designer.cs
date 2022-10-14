namespace FitnessClub
{
    partial class fsotrudnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fsotrudnik));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbimyakor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Ifoto = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbkodsotrudnika = new System.Windows.Forms.TextBox();
            this.cbdoljn = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Labelfam = new System.Windows.Forms.Label();
            this.tobrazov = new System.Windows.Forms.TextBox();
            this.tfam = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbrol = new System.Windows.Forms.ComboBox();
            this.tparol = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tmobtel = new System.Windows.Forms.TextBox();
            this.sqlCon = new System.Data.SqlClient.SqlConnection();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ifoto)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tbimyakor);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.Ifoto);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.tbkodsotrudnika);
            this.panel4.Controls.Add(this.cbdoljn);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Labelfam);
            this.panel4.Controls.Add(this.tobrazov);
            this.panel4.Controls.Add(this.tfam);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 238);
            this.panel4.TabIndex = 59;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Имя короткое (для расписания)";
            // 
            // tbimyakor
            // 
            this.tbimyakor.Location = new System.Drawing.Point(412, 23);
            this.tbimyakor.Margin = new System.Windows.Forms.Padding(2);
            this.tbimyakor.Name = "tbimyakor";
            this.tbimyakor.Size = new System.Drawing.Size(222, 22);
            this.tbimyakor.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Фото";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 7.926606F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(478, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 73);
            this.button5.TabIndex = 75;
            this.button5.Text = "Загрузить с диска";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 7.926606F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(478, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 69);
            this.button3.TabIndex = 74;
            this.button3.Text = "Вставить из буфера обмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ifoto
            // 
            this.Ifoto.Location = new System.Drawing.Point(328, 84);
            this.Ifoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ifoto.Name = "Ifoto";
            this.Ifoto.Size = new System.Drawing.Size(145, 146);
            this.Ifoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ifoto.TabIndex = 73;
            this.Ifoto.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 69);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 20);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Работает";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(6, 101);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 20);
            this.label28.TabIndex = 69;
            this.label28.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(147, 25);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 20);
            this.label21.TabIndex = 62;
            this.label21.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 59;
            this.label18.Text = "Код сотрудника";
            // 
            // tbkodsotrudnika
            // 
            this.tbkodsotrudnika.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbkodsotrudnika.Location = new System.Drawing.Point(22, 23);
            this.tbkodsotrudnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbkodsotrudnika.Name = "tbkodsotrudnika";
            this.tbkodsotrudnika.ReadOnly = true;
            this.tbkodsotrudnika.Size = new System.Drawing.Size(126, 22);
            this.tbkodsotrudnika.TabIndex = 58;
            // 
            // cbdoljn
            // 
            this.cbdoljn.DisplayMember = "КодДолжности";
            this.cbdoljn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoljn.FormattingEnabled = true;
            this.cbdoljn.Location = new System.Drawing.Point(26, 145);
            this.cbdoljn.Margin = new System.Windows.Forms.Padding(2);
            this.cbdoljn.Name = "cbdoljn";
            this.cbdoljn.Size = new System.Drawing.Size(289, 24);
            this.cbdoljn.TabIndex = 57;
            this.cbdoljn.ValueMember = "КодДолжности";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 126);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Образование";
            // 
            // Labelfam
            // 
            this.Labelfam.AutoSize = true;
            this.Labelfam.Location = new System.Drawing.Point(163, 2);
            this.Labelfam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Labelfam.Name = "Labelfam";
            this.Labelfam.Size = new System.Drawing.Size(167, 16);
            this.Labelfam.TabIndex = 39;
            this.Labelfam.Text = "Фамилия Имя Отчество";
            // 
            // tobrazov
            // 
            this.tobrazov.Location = new System.Drawing.Point(26, 101);
            this.tobrazov.Margin = new System.Windows.Forms.Padding(2);
            this.tobrazov.Name = "tobrazov";
            this.tobrazov.Size = new System.Drawing.Size(289, 22);
            this.tobrazov.TabIndex = 31;
            // 
            // tfam
            // 
            this.tfam.Location = new System.Drawing.Point(164, 23);
            this.tfam.Margin = new System.Windows.Forms.Padding(2);
            this.tfam.Name = "tfam";
            this.tfam.Size = new System.Drawing.Size(242, 22);
            this.tfam.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(328, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 41);
            this.button2.TabIndex = 71;
            this.button2.Text = "Отмена";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(328, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 41);
            this.button1.TabIndex = 60;
            this.button1.Text = "Сохранить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.tmobtel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 288);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 281);
            this.panel5.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbrol);
            this.panel1.Controls.Add(this.tparol);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.tlogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 125);
            this.panel1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Роль";
            // 
            // cbrol
            // 
            this.cbrol.FormattingEnabled = true;
            this.cbrol.Location = new System.Drawing.Point(272, 39);
            this.cbrol.Margin = new System.Windows.Forms.Padding(2);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(119, 24);
            this.cbrol.TabIndex = 5;
            // 
            // tparol
            // 
            this.tparol.Location = new System.Drawing.Point(75, 87);
            this.tparol.Margin = new System.Windows.Forms.Padding(2);
            this.tparol.Name = "tparol";
            this.tparol.Size = new System.Drawing.Size(168, 22);
            this.tparol.TabIndex = 4;
            this.tparol.UseSystemPasswordChar = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 87);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 16);
            this.label22.TabIndex = 3;
            this.label22.Text = "Пароль";
            // 
            // tlogin
            // 
            this.tlogin.Location = new System.Drawing.Point(75, 42);
            this.tlogin.Margin = new System.Windows.Forms.Padding(2);
            this.tlogin.Name = "tlogin";
            this.tlogin.Size = new System.Drawing.Size(168, 22);
            this.tlogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель администратора";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Телефон";
            // 
            // tmobtel
            // 
            this.tmobtel.Location = new System.Drawing.Point(22, 41);
            this.tmobtel.Margin = new System.Windows.Forms.Padding(2);
            this.tmobtel.Name = "tmobtel";
            this.tmobtel.Size = new System.Drawing.Size(289, 22);
            this.tmobtel.TabIndex = 33;
            // 
            // sqlCon
            // 
            this.sqlCon.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|datadirectory|KadrBs.mdf;Integrated Se" +
                "curity=True;Connect Timeout=30;User Instance=True";
            this.sqlCon.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 37);
            this.panel2.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(646, 33);
            this.label12.TabIndex = 0;
            this.label12.Text = "Сотрудник";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fsotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fsotrudnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.fsotrudnik_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ifoto)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbkodsotrudnika;
        private System.Windows.Forms.ComboBox cbdoljn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Labelfam;
        private System.Windows.Forms.TextBox tobrazov;
        private System.Windows.Forms.TextBox tfam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tmobtel;
        private System.Windows.Forms.Button button1;
       // private KadrBsDataSet kadrBsDataSet1;
        private System.Data.SqlClient.SqlConnection sqlCon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tparol;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tlogin;
        private System.Windows.Forms.ComboBox cbrol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Ifoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbimyakor;
    }
}