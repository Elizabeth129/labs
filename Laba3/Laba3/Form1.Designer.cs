namespace Laba3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxPIP = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxDep = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonToHTML = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(320, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1200, 596);
            this.listBox1.TabIndex = 0;
            // 
            // checkBoxPIP
            // 
            this.checkBoxPIP.AutoSize = true;
            this.checkBoxPIP.Location = new System.Drawing.Point(19, 50);
            this.checkBoxPIP.Name = "checkBoxPIP";
            this.checkBoxPIP.Size = new System.Drawing.Size(65, 21);
            this.checkBoxPIP.TabIndex = 1;
            this.checkBoxPIP.Text = "П.І.П.";
            this.checkBoxPIP.UseVisualStyleBackColor = true;
            this.checkBoxPIP.CheckedChanged += new System.EventHandler(this.CheckBoxPIP_CheckedChanged);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(20, 88);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(102, 21);
            this.checkBoxFaculty.TabIndex = 2;
            this.checkBoxFaculty.Text = "Факультет";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            this.checkBoxFaculty.CheckedChanged += new System.EventHandler(this.CheckBoxFaculty_CheckedChanged);
            // 
            // checkBoxDep
            // 
            this.checkBoxDep.AutoSize = true;
            this.checkBoxDep.Location = new System.Drawing.Point(22, 126);
            this.checkBoxDep.Name = "checkBoxDep";
            this.checkBoxDep.Size = new System.Drawing.Size(120, 21);
            this.checkBoxDep.TabIndex = 3;
            this.checkBoxDep.Text = "Департамент";
            this.checkBoxDep.UseVisualStyleBackColor = true;
            this.checkBoxDep.CheckedChanged += new System.EventHandler(this.CheckBoxDep_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(148, 391);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 45);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonToHTML
            // 
            this.buttonToHTML.Location = new System.Drawing.Point(147, 326);
            this.buttonToHTML.Name = "buttonToHTML";
            this.buttonToHTML.Size = new System.Drawing.Size(139, 46);
            this.buttonToHTML.TabIndex = 8;
            this.buttonToHTML.Text = "HTML";
            this.buttonToHTML.UseVisualStyleBackColor = true;
            this.buttonToHTML.Click += new System.EventHandler(this.ButtonToHTML_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 280);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(119, 24);
            this.comboBox4.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 22);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.buttonToHTML);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxDep);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxPIP);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = " Database(@Lisa_Ivanytska)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxPIP;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxDep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonToHTML;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

