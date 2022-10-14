namespace FitnessClub
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Направления групп");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Группы");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Периоды действия расписания");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Залы", 10, 10);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Должности", 10, 10);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Расписание", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Названия абонементов");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Виды абонементов", 11, 11);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Абонементы", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DataLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoginLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FioLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.doljnlabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lroluser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.imlistspravocnik = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridabonement = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbpoiskzakaz = new System.Windows.Forms.TextBox();
            this.button44 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.lbabonement = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridjournal = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbnevipolneno = new System.Windows.Forms.RadioButton();
            this.rbvipolneno = new System.Windows.Forms.RadioButton();
            this.rball = new System.Windows.Forms.RadioButton();
            this.chbnapr = new System.Windows.Forms.CheckBox();
            this.chbgruppa = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.tbnamegruppa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpend2 = new System.Windows.Forms.DateTimePicker();
            this.dtpstart2 = new System.Windows.Forms.DateTimePicker();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.rbolperiod = new System.Windows.Forms.RadioButton();
            this.rbperiod2 = new System.Windows.Forms.RadioButton();
            this.rbzadatu = new System.Windows.Forms.RadioButton();
            this.chbdennedeli = new System.Windows.Forms.CheckBox();
            this.cbnapr = new System.Windows.Forms.ComboBox();
            this.cbdennedeli = new System.Windows.Forms.ComboBox();
            this.cbsotrplan = new System.Windows.Forms.ComboBox();
            this.cbsotrvipolnil = new System.Windows.Forms.ComboBox();
            this.chbsotrplan = new System.Windows.Forms.CheckBox();
            this.chbsotrvipolnil = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tbnameperiod2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbzaljournal = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridspr = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbpoiskspravochnik = new System.Windows.Forms.TextBox();
            this.button49 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.LabelSpavochnik = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btneditspr = new System.Windows.Forms.Button();
            this.btninsertspr = new System.Windows.Forms.Button();
            this.btndeletespr = new System.Windows.Forms.Button();
            this.Tabsheet7 = new System.Windows.Forms.TabPage();
            this.gridklient = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbpoiskzakazchik = new System.Windows.Forms.TextBox();
            this.button48 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gridsotrudnik = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbpoisksotr = new System.Windows.Forms.TextBox();
            this.button45 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panelrasp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.tbnameperiod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbzall = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьТекстВБоковойПанелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТекстВБоковойПанелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.РасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.АбонементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЖурналЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗаставкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.imlistknopki = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridabonement)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridjournal)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridspr)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Tabsheet7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridklient)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridsotrudnik)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataLabel,
            this.toolStripSeparator1,
            this.LoginLabel,
            this.toolStripSeparator2,
            this.FioLabel,
            this.toolStripSeparator3,
            this.doljnlabel,
            this.toolStripSeparator4,
            this.lroluser,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 657);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1285, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DataLabel
            // 
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(74, 22);
            this.DataLabel.Tag = "";
            this.DataLabel.Text = "Datalabel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(82, 22);
            this.LoginLabel.Text = "LoginLabel";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FioLabel
            // 
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(65, 22);
            this.FioLabel.Text = "FioLabel";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // doljnlabel
            // 
            this.doljnlabel.Name = "doljnlabel";
            this.doljnlabel.Size = new System.Drawing.Size(76, 22);
            this.doljnlabel.Text = "doljnlabel";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lroluser
            // 
            this.lroluser.Name = "lroluser";
            this.lroluser.Size = new System.Drawing.Size(111, 22);
            this.lroluser.Text = "toolStripLabel1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // imlistspravocnik
            // 
            this.imlistspravocnik.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlistspravocnik.ImageStream")));
            this.imlistspravocnik.TransparentColor = System.Drawing.Color.Transparent;
            this.imlistspravocnik.Images.SetKeyName(0, "добавить.bmp");
            this.imlistspravocnik.Images.SetKeyName(1, "Редактировать.bmp");
            this.imlistspravocnik.Images.SetKeyName(2, "просмотр.png");
            this.imlistspravocnik.Images.SetKeyName(3, "удалить4.png");
            this.imlistspravocnik.Images.SetKeyName(4, "exit_98101.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.Tabsheet7);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(150, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridabonement);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1127, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абонементы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridabonement
            // 
            this.gridabonement.AllowUserToAddRows = false;
            this.gridabonement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridabonement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridabonement.Location = new System.Drawing.Point(4, 40);
            this.gridabonement.Margin = new System.Windows.Forms.Padding(4);
            this.gridabonement.Name = "gridabonement";
            this.gridabonement.ReadOnly = true;
            this.gridabonement.RowHeadersVisible = false;
            this.gridabonement.Size = new System.Drawing.Size(1119, 556);
            this.gridabonement.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbpoiskzakaz);
            this.panel3.Controls.Add(this.button44);
            this.panel3.Controls.Add(this.button24);
            this.panel3.Controls.Add(this.lbabonement);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 36);
            this.panel3.TabIndex = 0;
            // 
            // tbpoiskzakaz
            // 
            this.tbpoiskzakaz.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpoiskzakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.88991F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpoiskzakaz.Location = new System.Drawing.Point(461, 0);
            this.tbpoiskzakaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpoiskzakaz.Name = "tbpoiskzakaz";
            this.tbpoiskzakaz.Size = new System.Drawing.Size(210, 30);
            this.tbpoiskzakaz.TabIndex = 72;
            // 
            // button44
            // 
            this.button44.Dock = System.Windows.Forms.DockStyle.Right;
            this.button44.Image = ((System.Drawing.Image)(resources.GetObject("button44.Image")));
            this.button44.Location = new System.Drawing.Point(671, 0);
            this.button44.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(39, 32);
            this.button44.TabIndex = 73;
            this.button44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Right;
            this.button24.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.Location = new System.Drawing.Point(710, 0);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(42, 32);
            this.button24.TabIndex = 26;
            this.button24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // lbabonement
            // 
            this.lbabonement.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbabonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbabonement.ForeColor = System.Drawing.Color.Black;
            this.lbabonement.Location = new System.Drawing.Point(38, 0);
            this.lbabonement.Name = "lbabonement";
            this.lbabonement.Size = new System.Drawing.Size(133, 32);
            this.lbabonement.TabIndex = 8;
            this.lbabonement.Text = "Абонементы";
            this.lbabonement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(752, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 32);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(798, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Редактировать";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(930, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1021, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1127, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заставка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1119, 67);
            this.panel4.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Segoe Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(584, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(531, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "Журнал занятий";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.Font = new System.Drawing.Font("Segoe Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(584, 63);
            this.button9.TabIndex = 5;
            this.button9.Text = "Расписание";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridjournal);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1127, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Журнал занятий";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridjournal
            // 
            this.gridjournal.AllowUserToAddRows = false;
            this.gridjournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridjournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridjournal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridjournal.Location = new System.Drawing.Point(4, 183);
            this.gridjournal.Margin = new System.Windows.Forms.Padding(4);
            this.gridjournal.Name = "gridjournal";
            this.gridjournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridjournal.Size = new System.Drawing.Size(1119, 413);
            this.gridjournal.TabIndex = 0;
            this.gridjournal.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridjournal_CellBeginEdit);
            this.gridjournal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridjournal_CellEndEdit);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.cbzaljournal);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1119, 179);
            this.panel5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.chbnapr);
            this.groupBox1.Controls.Add(this.chbgruppa);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpend2);
            this.groupBox1.Controls.Add(this.dtpstart2);
            this.groupBox1.Controls.Add(this.dtpdata);
            this.groupBox1.Controls.Add(this.rbolperiod);
            this.groupBox1.Controls.Add(this.rbperiod2);
            this.groupBox1.Controls.Add(this.rbzadatu);
            this.groupBox1.Controls.Add(this.chbdennedeli);
            this.groupBox1.Controls.Add(this.cbnapr);
            this.groupBox1.Controls.Add(this.cbdennedeli);
            this.groupBox1.Controls.Add(this.cbsotrplan);
            this.groupBox1.Controls.Add(this.cbsotrvipolnil);
            this.groupBox1.Controls.Add(this.chbsotrplan);
            this.groupBox1.Controls.Add(this.chbsotrvipolnil);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(305, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(833, 166);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbnevipolneno);
            this.groupBox5.Controls.Add(this.rbvipolneno);
            this.groupBox5.Controls.Add(this.rball);
            this.groupBox5.Location = new System.Drawing.Point(582, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(150, 134);
            this.groupBox5.TabIndex = 84;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выполнение";
            // 
            // rbnevipolneno
            // 
            this.rbnevipolneno.AutoSize = true;
            this.rbnevipolneno.Location = new System.Drawing.Point(4, 96);
            this.rbnevipolneno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnevipolneno.Name = "rbnevipolneno";
            this.rbnevipolneno.Size = new System.Drawing.Size(141, 20);
            this.rbnevipolneno.TabIndex = 1;
            this.rbnevipolneno.TabStop = true;
            this.rbnevipolneno.Text = "Не выполненные";
            this.rbnevipolneno.UseVisualStyleBackColor = true;
            // 
            // rbvipolneno
            // 
            this.rbvipolneno.AutoSize = true;
            this.rbvipolneno.Location = new System.Drawing.Point(4, 58);
            this.rbvipolneno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbvipolneno.Name = "rbvipolneno";
            this.rbvipolneno.Size = new System.Drawing.Size(122, 20);
            this.rbvipolneno.TabIndex = 1;
            this.rbvipolneno.TabStop = true;
            this.rbvipolneno.Text = "Выполненные";
            this.rbvipolneno.UseVisualStyleBackColor = true;
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.Location = new System.Drawing.Point(4, 21);
            this.rball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(51, 20);
            this.rball.TabIndex = 0;
            this.rball.TabStop = true;
            this.rball.Text = "все";
            this.rball.UseVisualStyleBackColor = true;
            // 
            // chbnapr
            // 
            this.chbnapr.AutoSize = true;
            this.chbnapr.Location = new System.Drawing.Point(396, 106);
            this.chbnapr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbnapr.Name = "chbnapr";
            this.chbnapr.Size = new System.Drawing.Size(141, 20);
            this.chbnapr.TabIndex = 82;
            this.chbnapr.Text = "По направлению";
            this.chbnapr.UseVisualStyleBackColor = true;
            // 
            // chbgruppa
            // 
            this.chbgruppa.AutoSize = true;
            this.chbgruppa.Location = new System.Drawing.Point(4, 103);
            this.chbgruppa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbgruppa.Name = "chbgruppa";
            this.chbgruppa.Size = new System.Drawing.Size(95, 20);
            this.chbgruppa.TabIndex = 82;
            this.chbgruppa.Text = "По группе";
            this.chbgruppa.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(416, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "Конец";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button13);
            this.panel13.Controls.Add(this.tbnamegruppa);
            this.panel13.Location = new System.Drawing.Point(4, 129);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(242, 22);
            this.panel13.TabIndex = 81;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Right;
            this.button13.Location = new System.Drawing.Point(204, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(38, 22);
            this.button13.TabIndex = 7;
            this.button13.Text = "...";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tbnamegruppa
            // 
            this.tbnamegruppa.BackColor = System.Drawing.Color.White;
            this.tbnamegruppa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbnamegruppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnamegruppa.Location = new System.Drawing.Point(0, 0);
            this.tbnamegruppa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnamegruppa.Name = "tbnamegruppa";
            this.tbnamegruppa.ReadOnly = true;
            this.tbnamegruppa.Size = new System.Drawing.Size(242, 27);
            this.tbnamegruppa.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Начало";
            // 
            // dtpend2
            // 
            this.dtpend2.Location = new System.Drawing.Point(416, 81);
            this.dtpend2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpend2.Name = "dtpend2";
            this.dtpend2.Size = new System.Drawing.Size(147, 22);
            this.dtpend2.TabIndex = 41;
            // 
            // dtpstart2
            // 
            this.dtpstart2.Location = new System.Drawing.Point(265, 81);
            this.dtpstart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpstart2.Name = "dtpstart2";
            this.dtpstart2.Size = new System.Drawing.Size(147, 22);
            this.dtpstart2.TabIndex = 41;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(368, 21);
            this.dtpdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(152, 22);
            this.dtpdata.TabIndex = 40;
            // 
            // rbolperiod
            // 
            this.rbolperiod.AutoSize = true;
            this.rbolperiod.Location = new System.Drawing.Point(265, 112);
            this.rbolperiod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbolperiod.Name = "rbolperiod";
            this.rbolperiod.Size = new System.Drawing.Size(113, 20);
            this.rbolperiod.TabIndex = 39;
            this.rbolperiod.TabStop = true;
            this.rbolperiod.Text = "Весь период";
            this.rbolperiod.UseVisualStyleBackColor = true;
            // 
            // rbperiod2
            // 
            this.rbperiod2.AutoSize = true;
            this.rbperiod2.Location = new System.Drawing.Point(265, 43);
            this.rbperiod2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbperiod2.Name = "rbperiod2";
            this.rbperiod2.Size = new System.Drawing.Size(97, 20);
            this.rbperiod2.TabIndex = 39;
            this.rbperiod2.TabStop = true;
            this.rbperiod2.Text = "За период";
            this.rbperiod2.UseVisualStyleBackColor = true;
            // 
            // rbzadatu
            // 
            this.rbzadatu.AutoSize = true;
            this.rbzadatu.Location = new System.Drawing.Point(265, 16);
            this.rbzadatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbzadatu.Name = "rbzadatu";
            this.rbzadatu.Size = new System.Drawing.Size(79, 20);
            this.rbzadatu.TabIndex = 38;
            this.rbzadatu.TabStop = true;
            this.rbzadatu.Text = "За дату";
            this.rbzadatu.UseVisualStyleBackColor = true;
            // 
            // chbdennedeli
            // 
            this.chbdennedeli.AutoSize = true;
            this.chbdennedeli.Location = new System.Drawing.Point(4, 76);
            this.chbdennedeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbdennedeli.Name = "chbdennedeli";
            this.chbdennedeli.Size = new System.Drawing.Size(115, 20);
            this.chbdennedeli.TabIndex = 37;
            this.chbdennedeli.Text = "День недели";
            this.chbdennedeli.UseVisualStyleBackColor = true;
            // 
            // cbnapr
            // 
            this.cbnapr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnapr.FormattingEnabled = true;
            this.cbnapr.Location = new System.Drawing.Point(396, 129);
            this.cbnapr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbnapr.Name = "cbnapr";
            this.cbnapr.Size = new System.Drawing.Size(148, 24);
            this.cbnapr.TabIndex = 36;
            // 
            // cbdennedeli
            // 
            this.cbdennedeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdennedeli.FormattingEnabled = true;
            this.cbdennedeli.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "пятница",
            "Суббота",
            "Воскресенье"});
            this.cbdennedeli.Location = new System.Drawing.Point(112, 81);
            this.cbdennedeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdennedeli.Name = "cbdennedeli";
            this.cbdennedeli.Size = new System.Drawing.Size(137, 24);
            this.cbdennedeli.TabIndex = 36;
            // 
            // cbsotrplan
            // 
            this.cbsotrplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsotrplan.FormattingEnabled = true;
            this.cbsotrplan.Location = new System.Drawing.Point(112, 48);
            this.cbsotrplan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbsotrplan.Name = "cbsotrplan";
            this.cbsotrplan.Size = new System.Drawing.Size(137, 24);
            this.cbsotrplan.TabIndex = 36;
            // 
            // cbsotrvipolnil
            // 
            this.cbsotrvipolnil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsotrvipolnil.FormattingEnabled = true;
            this.cbsotrvipolnil.Location = new System.Drawing.Point(112, 16);
            this.cbsotrvipolnil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbsotrvipolnil.Name = "cbsotrvipolnil";
            this.cbsotrvipolnil.Size = new System.Drawing.Size(137, 24);
            this.cbsotrvipolnil.TabIndex = 36;
            // 
            // chbsotrplan
            // 
            this.chbsotrplan.AutoSize = true;
            this.chbsotrplan.Location = new System.Drawing.Point(4, 48);
            this.chbsotrplan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbsotrplan.Name = "chbsotrplan";
            this.chbsotrplan.Size = new System.Drawing.Size(90, 20);
            this.chbsotrplan.TabIndex = 35;
            this.chbsotrplan.Text = "По плану";
            this.chbsotrplan.UseVisualStyleBackColor = true;
            // 
            // chbsotrvipolnil
            // 
            this.chbsotrvipolnil.AutoSize = true;
            this.chbsotrvipolnil.Location = new System.Drawing.Point(4, 21);
            this.chbsotrvipolnil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbsotrvipolnil.Name = "chbsotrvipolnil";
            this.chbsotrvipolnil.Size = new System.Drawing.Size(97, 20);
            this.chbsotrvipolnil.TabIndex = 34;
            this.chbsotrvipolnil.Text = "Выполнил";
            this.chbsotrvipolnil.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(738, 16);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 39);
            this.button8.TabIndex = 33;
            this.button8.Text = "Применить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(738, 74);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 37);
            this.button7.TabIndex = 32;
            this.button7.Text = "Сброс";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button4);
            this.panel12.Controls.Add(this.tbnameperiod2);
            this.panel12.Location = new System.Drawing.Point(41, 110);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(259, 22);
            this.panel12.TabIndex = 81;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(221, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 22);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbnameperiod2
            // 
            this.tbnameperiod2.BackColor = System.Drawing.Color.White;
            this.tbnameperiod2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbnameperiod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnameperiod2.Location = new System.Drawing.Point(0, 0);
            this.tbnameperiod2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnameperiod2.Name = "tbnameperiod2";
            this.tbnameperiod2.ReadOnly = true;
            this.tbnameperiod2.Size = new System.Drawing.Size(259, 27);
            this.tbnameperiod2.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(39, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 20);
            this.label15.TabIndex = 80;
            this.label15.Text = "Выберите период";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(43, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 20);
            this.label16.TabIndex = 79;
            this.label16.Text = "Выберите зал";
            // 
            // cbzaljournal
            // 
            this.cbzaljournal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbzaljournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbzaljournal.FormattingEnabled = true;
            this.cbzaljournal.Location = new System.Drawing.Point(45, 57);
            this.cbzaljournal.Margin = new System.Windows.Forms.Padding(4);
            this.cbzaljournal.Name = "cbzaljournal";
            this.cbzaljournal.Size = new System.Drawing.Size(257, 28);
            this.cbzaljournal.TabIndex = 78;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(179, 132);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 38);
            this.button10.TabIndex = 26;
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(38, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "Журнал занятий";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(227, 133);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 38);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(41, 133);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(132, 37);
            this.button12.TabIndex = 5;
            this.button12.Text = "Показать журнал";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer1);
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1127, 600);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Справочники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridspr);
            this.splitContainer1.Size = new System.Drawing.Size(1119, 556);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 1;
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imageList1;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Margin = new System.Windows.Forms.Padding(4);
            this.tree.Name = "tree";
            treeNode10.Name = "Узел0";
            treeNode10.Tag = "Направления";
            treeNode10.Text = "Направления групп";
            treeNode11.Name = "Узел0";
            treeNode11.Tag = "Группы";
            treeNode11.Text = "Группы";
            treeNode12.Name = "Узел1";
            treeNode12.Tag = "ПериодДействия";
            treeNode12.Text = "Периоды действия расписания";
            treeNode13.ImageIndex = 10;
            treeNode13.Name = "Узел2";
            treeNode13.SelectedImageIndex = 10;
            treeNode13.Tag = "Залы";
            treeNode13.Text = "Залы";
            treeNode14.ImageIndex = 10;
            treeNode14.Name = "Узел1";
            treeNode14.SelectedImageIndex = 10;
            treeNode14.Tag = "Должности";
            treeNode14.Text = "Должности";
            treeNode15.ImageIndex = 4;
            treeNode15.Name = "Узел0";
            treeNode15.SelectedImageIndex = 4;
            treeNode15.Tag = "parrent";
            treeNode15.Text = "Расписание";
            treeNode16.Name = "Узел3";
            treeNode16.Tag = "НазванияВидовАбонемента";
            treeNode16.Text = "Названия абонементов";
            treeNode17.ImageIndex = 11;
            treeNode17.Name = "Узел0";
            treeNode17.SelectedImageIndex = 11;
            treeNode17.Tag = "ВидыАбонементов";
            treeNode17.Text = "Виды абонементов";
            treeNode18.ImageIndex = 5;
            treeNode18.Name = "Узел0";
            treeNode18.SelectedImageIndex = 5;
            treeNode18.Tag = "parrent";
            treeNode18.Text = "Абонементы";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(315, 556);
            this.tree.TabIndex = 0;
            this.tree.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tree_DrawNode);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mail.png");
            this.imageList1.Images.SetKeyName(1, "mailvx.png");
            this.imageList1.Images.SetKeyName(2, "mailisx.png");
            this.imageList1.Images.SetKeyName(3, "arxiv.png");
            this.imageList1.Images.SetKeyName(4, "справочники.png");
            this.imageList1.Images.SetKeyName(5, "проекты.png");
            this.imageList1.Images.SetKeyName(6, "моипроекты.png");
            this.imageList1.Images.SetKeyName(7, "всепроекты.png");
            this.imageList1.Images.SetKeyName(8, "сотрудники.png");
            this.imageList1.Images.SetKeyName(9, "должности.png");
            this.imageList1.Images.SetKeyName(10, "отделы.png");
            this.imageList1.Images.SetKeyName(11, "видыдокументов.png");
            // 
            // gridspr
            // 
            this.gridspr.AllowUserToAddRows = false;
            this.gridspr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridspr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridspr.Location = new System.Drawing.Point(0, 0);
            this.gridspr.Margin = new System.Windows.Forms.Padding(4);
            this.gridspr.Name = "gridspr";
            this.gridspr.ReadOnly = true;
            this.gridspr.Size = new System.Drawing.Size(800, 556);
            this.gridspr.TabIndex = 0;
            this.gridspr.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridspr_CellFormatting);
            this.gridspr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridspr_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbpoiskspravochnik);
            this.panel2.Controls.Add(this.button49);
            this.panel2.Controls.Add(this.button62);
            this.panel2.Controls.Add(this.LabelSpavochnik);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.btneditspr);
            this.panel2.Controls.Add(this.btninsertspr);
            this.panel2.Controls.Add(this.btndeletespr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1119, 36);
            this.panel2.TabIndex = 0;
            // 
            // tbpoiskspravochnik
            // 
            this.tbpoiskspravochnik.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpoiskspravochnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.88991F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpoiskspravochnik.Location = new System.Drawing.Point(503, 0);
            this.tbpoiskspravochnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpoiskspravochnik.Name = "tbpoiskspravochnik";
            this.tbpoiskspravochnik.Size = new System.Drawing.Size(210, 30);
            this.tbpoiskspravochnik.TabIndex = 76;
            // 
            // button49
            // 
            this.button49.Dock = System.Windows.Forms.DockStyle.Right;
            this.button49.Image = ((System.Drawing.Image)(resources.GetObject("button49.Image")));
            this.button49.Location = new System.Drawing.Point(713, 0);
            this.button49.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(39, 32);
            this.button49.TabIndex = 77;
            this.button49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            // 
            // button62
            // 
            this.button62.Dock = System.Windows.Forms.DockStyle.Right;
            this.button62.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button62.Image = ((System.Drawing.Image)(resources.GetObject("button62.Image")));
            this.button62.Location = new System.Drawing.Point(752, 0);
            this.button62.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(42, 32);
            this.button62.TabIndex = 25;
            this.button62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button62.UseVisualStyleBackColor = true;
            this.button62.Click += new System.EventHandler(this.button62_Click);
            // 
            // LabelSpavochnik
            // 
            this.LabelSpavochnik.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelSpavochnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpavochnik.ForeColor = System.Drawing.Color.Black;
            this.LabelSpavochnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSpavochnik.Location = new System.Drawing.Point(38, 0);
            this.LabelSpavochnik.Name = "LabelSpavochnik";
            this.LabelSpavochnik.Size = new System.Drawing.Size(193, 32);
            this.LabelSpavochnik.TabIndex = 8;
            this.LabelSpavochnik.Text = "LabelSpavochnik";
            this.LabelSpavochnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 78;
            this.pictureBox5.TabStop = false;
            // 
            // btneditspr
            // 
            this.btneditspr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btneditspr.Image = ((System.Drawing.Image)(resources.GetObject("btneditspr.Image")));
            this.btneditspr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditspr.Location = new System.Drawing.Point(794, 0);
            this.btneditspr.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btneditspr.Name = "btneditspr";
            this.btneditspr.Size = new System.Drawing.Size(130, 32);
            this.btneditspr.TabIndex = 5;
            this.btneditspr.Text = "Редактировать";
            this.btneditspr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditspr.UseVisualStyleBackColor = true;
            this.btneditspr.Click += new System.EventHandler(this.btneditspr_Click);
            // 
            // btninsertspr
            // 
            this.btninsertspr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btninsertspr.Image = ((System.Drawing.Image)(resources.GetObject("btninsertspr.Image")));
            this.btninsertspr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsertspr.Location = new System.Drawing.Point(924, 0);
            this.btninsertspr.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btninsertspr.Name = "btninsertspr";
            this.btninsertspr.Size = new System.Drawing.Size(97, 32);
            this.btninsertspr.TabIndex = 6;
            this.btninsertspr.Text = "Добавить";
            this.btninsertspr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsertspr.UseVisualStyleBackColor = true;
            this.btninsertspr.Click += new System.EventHandler(this.btninsertspr_Click);
            // 
            // btndeletespr
            // 
            this.btndeletespr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btndeletespr.Image = ((System.Drawing.Image)(resources.GetObject("btndeletespr.Image")));
            this.btndeletespr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletespr.Location = new System.Drawing.Point(1021, 0);
            this.btndeletespr.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btndeletespr.Name = "btndeletespr";
            this.btndeletespr.Size = new System.Drawing.Size(94, 32);
            this.btndeletespr.TabIndex = 7;
            this.btndeletespr.Text = "Удалить";
            this.btndeletespr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeletespr.UseVisualStyleBackColor = true;
            this.btndeletespr.Click += new System.EventHandler(this.btndeletespr_Click);
            // 
            // Tabsheet7
            // 
            this.Tabsheet7.Controls.Add(this.gridklient);
            this.Tabsheet7.Controls.Add(this.panel9);
            this.Tabsheet7.Location = new System.Drawing.Point(4, 25);
            this.Tabsheet7.Margin = new System.Windows.Forms.Padding(4);
            this.Tabsheet7.Name = "Tabsheet7";
            this.Tabsheet7.Padding = new System.Windows.Forms.Padding(4);
            this.Tabsheet7.Size = new System.Drawing.Size(1127, 600);
            this.Tabsheet7.TabIndex = 5;
            this.Tabsheet7.Text = "Клиенты";
            this.Tabsheet7.UseVisualStyleBackColor = true;
            // 
            // gridklient
            // 
            this.gridklient.AllowUserToAddRows = false;
            this.gridklient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridklient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridklient.Location = new System.Drawing.Point(4, 40);
            this.gridklient.Margin = new System.Windows.Forms.Padding(4);
            this.gridklient.Name = "gridklient";
            this.gridklient.ReadOnly = true;
            this.gridklient.Size = new System.Drawing.Size(1119, 556);
            this.gridklient.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.tbpoiskzakazchik);
            this.panel9.Controls.Add(this.button48);
            this.panel9.Controls.Add(this.button34);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.pictureBox6);
            this.panel9.Controls.Add(this.button35);
            this.panel9.Controls.Add(this.button36);
            this.panel9.Controls.Add(this.button37);
            this.panel9.Controls.Add(this.button38);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(4, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1119, 36);
            this.panel9.TabIndex = 1;
            // 
            // tbpoiskzakazchik
            // 
            this.tbpoiskzakazchik.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpoiskzakazchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.88991F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpoiskzakazchik.Location = new System.Drawing.Point(461, 0);
            this.tbpoiskzakazchik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpoiskzakazchik.Name = "tbpoiskzakazchik";
            this.tbpoiskzakazchik.Size = new System.Drawing.Size(210, 30);
            this.tbpoiskzakazchik.TabIndex = 74;
            // 
            // button48
            // 
            this.button48.Dock = System.Windows.Forms.DockStyle.Right;
            this.button48.Image = ((System.Drawing.Image)(resources.GetObject("button48.Image")));
            this.button48.Location = new System.Drawing.Point(671, 0);
            this.button48.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(39, 32);
            this.button48.TabIndex = 75;
            this.button48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button34
            // 
            this.button34.Dock = System.Windows.Forms.DockStyle.Right;
            this.button34.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.Location = new System.Drawing.Point(710, 0);
            this.button34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(42, 32);
            this.button34.TabIndex = 26;
            this.button34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Клиенты";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 76;
            this.pictureBox6.TabStop = false;
            // 
            // button35
            // 
            this.button35.Dock = System.Windows.Forms.DockStyle.Right;
            this.button35.Image = ((System.Drawing.Image)(resources.GetObject("button35.Image")));
            this.button35.Location = new System.Drawing.Point(752, 0);
            this.button35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(46, 32);
            this.button35.TabIndex = 0;
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Dock = System.Windows.Forms.DockStyle.Right;
            this.button36.Image = ((System.Drawing.Image)(resources.GetObject("button36.Image")));
            this.button36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button36.Location = new System.Drawing.Point(798, 0);
            this.button36.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(132, 32);
            this.button36.TabIndex = 5;
            this.button36.Text = "Редактировать";
            this.button36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Dock = System.Windows.Forms.DockStyle.Right;
            this.button37.Image = ((System.Drawing.Image)(resources.GetObject("button37.Image")));
            this.button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.Location = new System.Drawing.Point(930, 0);
            this.button37.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(91, 32);
            this.button37.TabIndex = 6;
            this.button37.Text = "Добавить";
            this.button37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Dock = System.Windows.Forms.DockStyle.Right;
            this.button38.Image = ((System.Drawing.Image)(resources.GetObject("button38.Image")));
            this.button38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button38.Location = new System.Drawing.Point(1021, 0);
            this.button38.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(94, 32);
            this.button38.TabIndex = 7;
            this.button38.Text = "Удалить ";
            this.button38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.gridsotrudnik);
            this.tabPage7.Controls.Add(this.panel10);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1127, 600);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Сотрудники";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // gridsotrudnik
            // 
            this.gridsotrudnik.AllowUserToAddRows = false;
            this.gridsotrudnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsotrudnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridsotrudnik.Location = new System.Drawing.Point(4, 40);
            this.gridsotrudnik.Margin = new System.Windows.Forms.Padding(4);
            this.gridsotrudnik.Name = "gridsotrudnik";
            this.gridsotrudnik.ReadOnly = true;
            this.gridsotrudnik.Size = new System.Drawing.Size(1119, 556);
            this.gridsotrudnik.TabIndex = 4;
            this.gridsotrudnik.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridsotrudnik_MouseDoubleClick);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.tbpoisksotr);
            this.panel10.Controls.Add(this.button45);
            this.panel10.Controls.Add(this.button39);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.pictureBox7);
            this.panel10.Controls.Add(this.button40);
            this.panel10.Controls.Add(this.button41);
            this.panel10.Controls.Add(this.button42);
            this.panel10.Controls.Add(this.button43);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(4, 4);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1119, 36);
            this.panel10.TabIndex = 3;
            // 
            // tbpoisksotr
            // 
            this.tbpoisksotr.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpoisksotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.88991F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpoisksotr.Location = new System.Drawing.Point(461, 0);
            this.tbpoisksotr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpoisksotr.Name = "tbpoisksotr";
            this.tbpoisksotr.Size = new System.Drawing.Size(210, 30);
            this.tbpoisksotr.TabIndex = 74;
            // 
            // button45
            // 
            this.button45.Dock = System.Windows.Forms.DockStyle.Right;
            this.button45.Image = ((System.Drawing.Image)(resources.GetObject("button45.Image")));
            this.button45.Location = new System.Drawing.Point(671, 0);
            this.button45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(39, 32);
            this.button45.TabIndex = 75;
            this.button45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button39
            // 
            this.button39.Dock = System.Windows.Forms.DockStyle.Right;
            this.button39.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button39.Image = ((System.Drawing.Image)(resources.GetObject("button39.Image")));
            this.button39.Location = new System.Drawing.Point(710, 0);
            this.button39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(42, 32);
            this.button39.TabIndex = 26;
            this.button39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сотрудники";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 76;
            this.pictureBox7.TabStop = false;
            // 
            // button40
            // 
            this.button40.Dock = System.Windows.Forms.DockStyle.Right;
            this.button40.Image = ((System.Drawing.Image)(resources.GetObject("button40.Image")));
            this.button40.Location = new System.Drawing.Point(752, 0);
            this.button40.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(46, 32);
            this.button40.TabIndex = 0;
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Dock = System.Windows.Forms.DockStyle.Right;
            this.button41.Image = ((System.Drawing.Image)(resources.GetObject("button41.Image")));
            this.button41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button41.Location = new System.Drawing.Point(798, 0);
            this.button41.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(132, 32);
            this.button41.TabIndex = 5;
            this.button41.Text = "Редактировать";
            this.button41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Dock = System.Windows.Forms.DockStyle.Right;
            this.button42.Image = ((System.Drawing.Image)(resources.GetObject("button42.Image")));
            this.button42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button42.Location = new System.Drawing.Point(930, 0);
            this.button42.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(91, 32);
            this.button42.TabIndex = 6;
            this.button42.Text = "Добавить";
            this.button42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Dock = System.Windows.Forms.DockStyle.Right;
            this.button43.Image = ((System.Drawing.Image)(resources.GetObject("button43.Image")));
            this.button43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button43.Location = new System.Drawing.Point(1021, 0);
            this.button43.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(94, 32);
            this.button43.TabIndex = 7;
            this.button43.Text = "Удалить ";
            this.button43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.panelrasp);
            this.tabPage8.Controls.Add(this.panel1);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Size = new System.Drawing.Size(1127, 600);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Расписание";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // panelrasp
            // 
            this.panelrasp.AutoScroll = true;
            this.panelrasp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelrasp.Location = new System.Drawing.Point(3, 58);
            this.panelrasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelrasp.Name = "panelrasp";
            this.panelrasp.Size = new System.Drawing.Size(1121, 540);
            this.panelrasp.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbzall);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 56);
            this.panel1.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button14);
            this.panel11.Controls.Add(this.tbnameperiod);
            this.panel11.Location = new System.Drawing.Point(472, 25);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(357, 22);
            this.panel11.TabIndex = 76;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Right;
            this.button14.Location = new System.Drawing.Point(319, 0);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(38, 22);
            this.button14.TabIndex = 7;
            this.button14.Text = "...";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // tbnameperiod
            // 
            this.tbnameperiod.BackColor = System.Drawing.Color.White;
            this.tbnameperiod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbnameperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnameperiod.Location = new System.Drawing.Point(0, 0);
            this.tbnameperiod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnameperiod.Name = "tbnameperiod";
            this.tbnameperiod.ReadOnly = true;
            this.tbnameperiod.Size = new System.Drawing.Size(357, 27);
            this.tbnameperiod.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(468, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 20);
            this.label14.TabIndex = 75;
            this.label14.Text = "Выберите период";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(198, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 75;
            this.label12.Text = "Выберите зал";
            // 
            // cbzall
            // 
            this.cbzall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbzall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbzall.FormattingEnabled = true;
            this.cbzall.Location = new System.Drawing.Point(199, 22);
            this.cbzall.Margin = new System.Windows.Forms.Padding(4);
            this.cbzall.Name = "cbzall";
            this.cbzall.Size = new System.Drawing.Size(266, 28);
            this.cbzall.TabIndex = 74;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Right;
            this.button17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(850, 0);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 52);
            this.button17.TabIndex = 26;
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Расписание";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(74, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 78;
            this.pictureBox8.TabStop = false;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Right;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(892, 0);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 52);
            this.button18.TabIndex = 0;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Right;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(938, 0);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(179, 52);
            this.button19.TabIndex = 5;
            this.button19.Text = "Показать расписание";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.переходToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1285, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьТекстВБоковойПанелиToolStripMenuItem,
            this.показатьТекстВБоковойПанелиToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // скрытьТекстВБоковойПанелиToolStripMenuItem
            // 
            this.скрытьТекстВБоковойПанелиToolStripMenuItem.Name = "скрытьТекстВБоковойПанелиToolStripMenuItem";
            this.скрытьТекстВБоковойПанелиToolStripMenuItem.Size = new System.Drawing.Size(320, 24);
            this.скрытьТекстВБоковойПанелиToolStripMenuItem.Text = "Скрыть текст в боковой панели";
            this.скрытьТекстВБоковойПанелиToolStripMenuItem.Click += new System.EventHandler(this.скрытьТекстВБоковойПанелиToolStripMenuItem_Click);
            // 
            // показатьТекстВБоковойПанелиToolStripMenuItem
            // 
            this.показатьТекстВБоковойПанелиToolStripMenuItem.Name = "показатьТекстВБоковойПанелиToolStripMenuItem";
            this.показатьТекстВБоковойПанелиToolStripMenuItem.Size = new System.Drawing.Size(320, 24);
            this.показатьТекстВБоковойПанелиToolStripMenuItem.Text = "Показать текст в боковой панели";
            this.показатьТекстВБоковойПанелиToolStripMenuItem.Click += new System.EventHandler(this.показатьТекстВБоковойПанелиToolStripMenuItem_Click);
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.РасписаниеToolStripMenuItem,
            this.АбонементыToolStripMenuItem,
            this.ЖурналЗанятийToolStripMenuItem,
            this.КлиентыToolStripMenuItem,
            this.СотрудникиToolStripMenuItem,
            this.СправочникиToolStripMenuItem,
            this.ЗаставкаToolStripMenuItem1});
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.переходToolStripMenuItem.Text = "Переход";
            // 
            // РасписаниеToolStripMenuItem
            // 
            this.РасписаниеToolStripMenuItem.Name = "РасписаниеToolStripMenuItem";
            this.РасписаниеToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.РасписаниеToolStripMenuItem.Text = "Расписание";
            this.РасписаниеToolStripMenuItem.Click += new System.EventHandler(this.РасписаниеToolStripMenuItem_Click);
            // 
            // АбонементыToolStripMenuItem
            // 
            this.АбонементыToolStripMenuItem.Name = "АбонементыToolStripMenuItem";
            this.АбонементыToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.АбонементыToolStripMenuItem.Text = "Абонементы";
            this.АбонементыToolStripMenuItem.Click += new System.EventHandler(this.АбонементыToolStripMenuItem_Click);
            // 
            // ЖурналЗанятийToolStripMenuItem
            // 
            this.ЖурналЗанятийToolStripMenuItem.Name = "ЖурналЗанятийToolStripMenuItem";
            this.ЖурналЗанятийToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.ЖурналЗанятийToolStripMenuItem.Text = "Журнал занятий";
            this.ЖурналЗанятийToolStripMenuItem.Click += new System.EventHandler(this.ЖурналЗанятийToolStripMenuItem_Click);
            // 
            // КлиентыToolStripMenuItem
            // 
            this.КлиентыToolStripMenuItem.Name = "КлиентыToolStripMenuItem";
            this.КлиентыToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.КлиентыToolStripMenuItem.Text = "Клиенты";
            this.КлиентыToolStripMenuItem.Click += new System.EventHandler(this.КлиентыToolStripMenuItem_Click);
            // 
            // СотрудникиToolStripMenuItem
            // 
            this.СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem";
            this.СотрудникиToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.СотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.СотрудникиToolStripMenuItem.Click += new System.EventHandler(this.СотрудникиToolStripMenuItem_Click_1);
            // 
            // СправочникиToolStripMenuItem
            // 
            this.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem";
            this.СправочникиToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.СправочникиToolStripMenuItem.Text = "Справочники";
            this.СправочникиToolStripMenuItem.Click += new System.EventHandler(this.СправочникиToolStripMenuItem_Click);
            // 
            // ЗаставкаToolStripMenuItem1
            // 
            this.ЗаставкаToolStripMenuItem1.Name = "ЗаставкаToolStripMenuItem1";
            this.ЗаставкаToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.ЗаставкаToolStripMenuItem1.Text = "Заставка";
            this.ЗаставкаToolStripMenuItem1.Click += new System.EventHandler(this.ЗаставкаToolStripMenuItem1_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.сменаПароляToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // сменаПароляToolStripMenuItem
            // 
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.сменаПароляToolStripMenuItem.Text = "Смена пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton1,
            this.toolStripButton7,
            this.toolStripButton2,
            this.toolStripButton8,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton10});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(150, 629);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton9.Text = "Расписание";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton1.Text = "Абонементы";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton7.Text = "Журнал занятий";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton2.Text = "Клиенты";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton8.Text = "Сотрудники";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton3.Text = "Справочники";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton4.Text = "Заставка";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(147, 24);
            this.toolStripButton6.Text = "Выход";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(147, 4);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // imlistknopki
            // 
            this.imlistknopki.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlistknopki.ImageStream")));
            this.imlistknopki.TransparentColor = System.Drawing.Color.Transparent;
            this.imlistknopki.Images.SetKeyName(0, "Выход.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система  фитнес-клуба Antares x-fit premium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridabonement)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridjournal)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridspr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Tabsheet7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridklient)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridsotrudnik)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel DataLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LoginLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel FioLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel doljnlabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lroluser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btneditspr;
        private System.Windows.Forms.Button btninsertspr;
        private System.Windows.Forms.Button btndeletespr;
        private System.Windows.Forms.DataGridView gridspr;
        private System.Windows.Forms.ImageList imlistspravocnik;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LabelSpavochnik;
        private System.Windows.Forms.DataGridView gridabonement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbabonement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gridjournal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem РасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem АбонементыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЖурналЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СотрудникиToolStripMenuItem;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button62;
        private System.Windows.Forms.ToolStripMenuItem сменаПароляToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ImageList imlistknopki;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TabPage Tabsheet7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.DataGridView gridklient;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView gridsotrudnik;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.TextBox tbpoiskzakaz;
        private System.Windows.Forms.TextBox tbpoisksotr;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tbpoiskzakazchik;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.TextBox tbpoiskspravochnik;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьТекстВБоковойПанелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТекстВБоковойПанелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СправочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗаставкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.Panel panelrasp;
        private System.Windows.Forms.ComboBox cbzall;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox tbnameperiod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbnameperiod2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbzaljournal;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton rbzadatu;
        private System.Windows.Forms.CheckBox chbdennedeli;
        private System.Windows.Forms.ComboBox cbdennedeli;
        private System.Windows.Forms.ComboBox cbsotrplan;
        private System.Windows.Forms.ComboBox cbsotrvipolnil;
        private System.Windows.Forms.CheckBox chbsotrplan;
        private System.Windows.Forms.CheckBox chbsotrvipolnil;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpend2;
        private System.Windows.Forms.DateTimePicker dtpstart2;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.RadioButton rbperiod2;
        private System.Windows.Forms.CheckBox chbnapr;
        private System.Windows.Forms.CheckBox chbgruppa;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox tbnamegruppa;
        private System.Windows.Forms.RadioButton rbolperiod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbnevipolneno;
        private System.Windows.Forms.RadioButton rbvipolneno;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.ComboBox cbnapr;
    }
}

