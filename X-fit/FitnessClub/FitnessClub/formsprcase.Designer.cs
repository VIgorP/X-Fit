namespace FitnessClub
{
    partial class formsprcase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsprcase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpoisk = new System.Windows.Forms.TextBox();
            this.button44 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridspr = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridspr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbpoisk);
            this.panel1.Controls.Add(this.button44);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lbres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 36);
            this.panel1.TabIndex = 2;
            // 
            // tbpoisk
            // 
            this.tbpoisk.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.88991F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpoisk.Location = new System.Drawing.Point(220, 0);
            this.tbpoisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpoisk.Name = "tbpoisk";
            this.tbpoisk.Size = new System.Drawing.Size(210, 30);
            this.tbpoisk.TabIndex = 74;
            this.tbpoisk.TextChanged += new System.EventHandler(this.tbpoiskzakaz_TextChanged);
            // 
            // button44
            // 
            this.button44.Dock = System.Windows.Forms.DockStyle.Right;
            this.button44.Image = ((System.Drawing.Image)(resources.GetObject("button44.Image")));
            this.button44.Location = new System.Drawing.Point(430, 0);
            this.button44.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(39, 36);
            this.button44.TabIndex = 75;
            this.button44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(469, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(655, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbres
            // 
            this.lbres.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbres.Location = new System.Drawing.Point(66, 0);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(150, 36);
            this.lbres.TabIndex = 1;
            this.lbres.Text = "label2";
            this.lbres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbres.Click += new System.EventHandler(this.lbres_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 50);
            this.panel2.TabIndex = 1;
            // 
            // gridspr
            // 
            this.gridspr.AllowUserToAddRows = false;
            this.gridspr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridspr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridspr.Location = new System.Drawing.Point(0, 36);
            this.gridspr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridspr.Name = "gridspr";
            this.gridspr.ReadOnly = true;
            this.gridspr.RowTemplate.Height = 24;
            this.gridspr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridspr.Size = new System.Drawing.Size(840, 449);
            this.gridspr.TabIndex = 1;
            this.gridspr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridspr_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formsprcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.gridspr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "formsprcase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridspr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridspr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbpoisk;
        private System.Windows.Forms.Button button44;
    }
}