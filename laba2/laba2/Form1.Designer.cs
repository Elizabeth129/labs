namespace laba2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.addColumn = new System.Windows.Forms.Button();
            this.deleteColumn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(2090, 900);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseClick);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(581, 37);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(93, 30);
            this.addRow.TabIndex = 1;
            this.addRow.Text = "Add Row";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(680, 37);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(108, 30);
            this.deleteRow.TabIndex = 2;
            this.deleteRow.Text = "Delete Row";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // addColumn
            // 
            this.addColumn.Location = new System.Drawing.Point(475, 37);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(100, 30);
            this.addColumn.TabIndex = 3;
            this.addColumn.Text = "Add Column";
            this.addColumn.UseVisualStyleBackColor = true;
            this.addColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // deleteColumn
            // 
            this.deleteColumn.Location = new System.Drawing.Point(352, 37);
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Size = new System.Drawing.Size(117, 30);
            this.deleteColumn.TabIndex = 4;
            this.deleteColumn.Text = "Delete Column";
            this.deleteColumn.UseVisualStyleBackColor = true;
            this.deleteColumn.Click += new System.EventHandler(this.DeleteColumn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 5;
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(12, 9);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 30);
            this.saveFile.TabIndex = 6;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(93, 9);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 30);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(177, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(74, 30);
            this.Info.TabIndex = 8;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteColumn);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "MiniExcel(@IvanytskaLisa)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button deleteColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Info;
    }
}

