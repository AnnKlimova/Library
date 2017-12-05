namespace Library
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LendBookBut = new System.Windows.Forms.Button();
            this.ObnovBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BooksListView1 = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReaderUpdateBut = new System.Windows.Forms.Button();
            this.RegistBut = new System.Windows.Forms.Button();
            this.ReaderDeleteBut = new System.Windows.Forms.Button();
            this.ReaderLV1But = new System.Windows.Forms.Button();
            this.ReaderLV1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.readlistView2 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            // 
            // LendBookBut
            // 
            this.LendBookBut.BackColor = System.Drawing.Color.SteelBlue;
            this.LendBookBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendBookBut.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LendBookBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LendBookBut.Location = new System.Drawing.Point(9, 14);
            this.LendBookBut.Name = "LendBookBut";
            this.LendBookBut.Size = new System.Drawing.Size(127, 24);
            this.LendBookBut.TabIndex = 12;
            this.LendBookBut.Text = "ВЫДАТЬ КНИГУ";
            this.LendBookBut.UseVisualStyleBackColor = false;
            this.LendBookBut.Click += new System.EventHandler(this.Vidatbut_Click);
            // 
            // ObnovBut
            // 
            this.ObnovBut.BackColor = System.Drawing.Color.Tan;
            this.ObnovBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObnovBut.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObnovBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ObnovBut.Location = new System.Drawing.Point(5, 98);
            this.ObnovBut.Name = "ObnovBut";
            this.ObnovBut.Size = new System.Drawing.Size(144, 27);
            this.ObnovBut.TabIndex = 9;
            this.ObnovBut.Text = "Показать все книги";
            this.ObnovBut.UseVisualStyleBackColor = false;
            this.ObnovBut.Click += new System.EventHandler(this.Obnovbut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 8;
            // 
            // BooksListView1
            // 
            this.BooksListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28});
            this.BooksListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksListView1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BooksListView1.FullRowSelect = true;
            this.BooksListView1.GridLines = true;
            this.BooksListView1.Location = new System.Drawing.Point(0, 0);
            this.BooksListView1.MultiSelect = false;
            this.BooksListView1.Name = "BooksListView1";
            this.BooksListView1.Size = new System.Drawing.Size(609, 424);
            this.BooksListView1.TabIndex = 7;
            this.BooksListView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Инвентар.номер";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Автор";
            this.columnHeader22.Width = 150;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Название";
            this.columnHeader23.Width = 190;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Жанр";
            this.columnHeader24.Width = 120;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Статус";
            this.columnHeader25.Width = 80;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Зал";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Стеллаж";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Полка";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReaderUpdateBut);
            this.tabPage2.Controls.Add(this.RegistBut);
            this.tabPage2.Controls.Add(this.ReaderDeleteBut);
            this.tabPage2.Controls.Add(this.ReaderLV1But);
            this.tabPage2.Controls.Add(this.ReaderLV1);
            this.tabPage2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Читатели";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReaderUpdateBut
            // 
            this.ReaderUpdateBut.BackColor = System.Drawing.Color.MediumPurple;
            this.ReaderUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderUpdateBut.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderUpdateBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReaderUpdateBut.Location = new System.Drawing.Point(156, 19);
            this.ReaderUpdateBut.Name = "ReaderUpdateBut";
            this.ReaderUpdateBut.Size = new System.Drawing.Size(138, 54);
            this.ReaderUpdateBut.TabIndex = 5;
            this.ReaderUpdateBut.Text = "РЕДАКТИРОРАНИЕ ДАННЫХ ЧИТАТЕЛЯ";
            this.ReaderUpdateBut.UseVisualStyleBackColor = false;
            this.ReaderUpdateBut.Click += new System.EventHandler(this.Updatebut_Click);
            // 
            // RegistBut
            // 
            this.RegistBut.BackColor = System.Drawing.Color.Teal;
            this.RegistBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistBut.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegistBut.Location = new System.Drawing.Point(12, 19);
            this.RegistBut.Name = "RegistBut";
            this.RegistBut.Size = new System.Drawing.Size(138, 54);
            this.RegistBut.TabIndex = 1;
            this.RegistBut.Text = "РЕГИСТРАЦИЯ НОВОГО ЧИТАТЕЛЯ";
            this.RegistBut.UseVisualStyleBackColor = false;
            this.RegistBut.Click += new System.EventHandler(this.RegistBut_Click);
            // 
            // ReaderDeleteBut
            // 
            this.ReaderDeleteBut.BackColor = System.Drawing.Color.IndianRed;
            this.ReaderDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderDeleteBut.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderDeleteBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReaderDeleteBut.Location = new System.Drawing.Point(300, 19);
            this.ReaderDeleteBut.Name = "ReaderDeleteBut";
            this.ReaderDeleteBut.Size = new System.Drawing.Size(138, 54);
            this.ReaderDeleteBut.TabIndex = 3;
            this.ReaderDeleteBut.Text = "УДАЛЕНИЕ ЧИТАТЕЛЯ ";
            this.ReaderDeleteBut.UseVisualStyleBackColor = false;
            this.ReaderDeleteBut.Click += new System.EventHandler(this.ReaderDeleteBut_Click);
            // 
            // ReaderLV1But
            // 
            this.ReaderLV1But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderLV1But.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderLV1But.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ReaderLV1But.Location = new System.Drawing.Point(458, 32);
            this.ReaderLV1But.Name = "ReaderLV1But";
            this.ReaderLV1But.Size = new System.Drawing.Size(138, 41);
            this.ReaderLV1But.TabIndex = 2;
            this.ReaderLV1But.Text = "Обновить данные";
            this.ReaderLV1But.UseVisualStyleBackColor = true;
            this.ReaderLV1But.Click += new System.EventHandler(this.ReaderLV1But_Click);
            // 
            // ReaderLV1
            // 
            this.ReaderLV1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader29});
            this.ReaderLV1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderLV1.FullRowSelect = true;
            this.ReaderLV1.GridLines = true;
            this.ReaderLV1.Location = new System.Drawing.Point(-4, 99);
            this.ReaderLV1.Margin = new System.Windows.Forms.Padding(1);
            this.ReaderLV1.MultiSelect = false;
            this.ReaderLV1.Name = "ReaderLV1";
            this.ReaderLV1.Size = new System.Drawing.Size(803, 329);
            this.ReaderLV1.TabIndex = 0;
            this.ReaderLV1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "№ билетa";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата рождения";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Номер телефона";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-mail";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дата регистрации";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Адрес";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Паспорт";
            this.columnHeader29.Width = 80;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.readlistView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "История выдачи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // readlistView2
            // 
            this.readlistView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader32});
            this.readlistView2.FullRowSelect = true;
            this.readlistView2.GridLines = true;
            this.readlistView2.Location = new System.Drawing.Point(6, 97);
            this.readlistView2.MultiSelect = false;
            this.readlistView2.Name = "readlistView2";
            this.readlistView2.Size = new System.Drawing.Size(794, 209);
            this.readlistView2.TabIndex = 9;
            this.readlistView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "№ читательского билетa";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Фамилия";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Имя";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Отчество";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Номер телефона";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LendBookBut);
            this.splitContainer1.Panel1.Controls.Add(this.ObnovBut);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BooksListView1);
            this.splitContainer1.Size = new System.Drawing.Size(789, 424);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RegistBut;
        private System.Windows.Forms.ListView ReaderLV1;
        private System.Windows.Forms.Button ReaderLV1But;
        private System.Windows.Forms.Button ReaderDeleteBut;
        private System.Windows.Forms.Button ReaderUpdateBut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView BooksListView1;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView readlistView2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ObnovBut;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.Button LendBookBut;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

