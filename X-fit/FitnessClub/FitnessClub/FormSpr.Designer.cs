namespace FitnessClub
{
    partial class FormSpr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpr));
            this.label1 = new System.Windows.Forms.Label();
            this.lbtablica = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbpole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица: ";
            // 
            // lbtablica
            // 
            this.lbtablica.AutoSize = true;
            this.lbtablica.Location = new System.Drawing.Point(80, 20);
            this.lbtablica.Name = "lbtablica";
            this.lbtablica.Size = new System.Drawing.Size(60, 16);
            this.lbtablica.TabIndex = 1;
            this.lbtablica.Text = "lbtablica";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(13, 73);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(493, 22);
            this.tb1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbpole
            // 
            this.lbpole.AutoSize = true;
            this.lbpole.Location = new System.Drawing.Point(14, 45);
            this.lbpole.Name = "lbpole";
            this.lbpole.Size = new System.Drawing.Size(46, 16);
            this.lbpole.TabIndex = 5;
            this.lbpole.Text = "lbpole";
            // 
            // FormSpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 228);
            this.Controls.Add(this.lbpole);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbtablica);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSpr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSpr";
            this.Load += new System.EventHandler(this.FormSpr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtablica;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbpole;
    }
}