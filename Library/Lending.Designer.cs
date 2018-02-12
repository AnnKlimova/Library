namespace Library
{
    partial class Lending
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
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.NameBooktxt = new System.Windows.Forms.TextBox();
            this.Readertxt = new System.Windows.Forms.TextBox();
            this.IssuDateTime = new System.Windows.Forms.DateTimePicker();
            this.ReturnDateTime = new System.Windows.Forms.DateTimePicker();
            this.LendingBut = new System.Windows.Forms.Button();
            this.LendingLV = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Closebut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReaderSearchtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authortxt
            // 
            this.Authortxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Authortxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authortxt.Location = new System.Drawing.Point(120, 24);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.ReadOnly = true;
            this.Authortxt.Size = new System.Drawing.Size(146, 23);
            this.Authortxt.TabIndex = 1;
            // 
            // NameBooktxt
            // 
            this.NameBooktxt.AcceptsReturn = true;
            this.NameBooktxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameBooktxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBooktxt.Location = new System.Drawing.Point(120, 74);
            this.NameBooktxt.Multiline = true;
            this.NameBooktxt.Name = "NameBooktxt";
            this.NameBooktxt.ReadOnly = true;
            this.NameBooktxt.Size = new System.Drawing.Size(146, 48);
            this.NameBooktxt.TabIndex = 2;
            // 
            // Readertxt
            // 
            this.Readertxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Readertxt.Location = new System.Drawing.Point(120, 142);
            this.Readertxt.Name = "Readertxt";
            this.Readertxt.Size = new System.Drawing.Size(146, 23);
            this.Readertxt.TabIndex = 3;
            // 
            // IssuDateTime
            // 
            this.IssuDateTime.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuDateTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.IssuDateTime.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush;
            this.IssuDateTime.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.IssuDateTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuDateTime.Location = new System.Drawing.Point(120, 186);
            this.IssuDateTime.Name = "IssuDateTime";
            this.IssuDateTime.Size = new System.Drawing.Size(146, 23);
            this.IssuDateTime.TabIndex = 4;
            // 
            // ReturnDateTime
            // 
            this.ReturnDateTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnDateTime.Location = new System.Drawing.Point(120, 231);
            this.ReturnDateTime.Name = "ReturnDateTime";
            this.ReturnDateTime.Size = new System.Drawing.Size(146, 23);
            this.ReturnDateTime.TabIndex = 5;
            // 
            // LendingBut
            // 
            this.LendingBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LendingBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LendingBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendingBut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LendingBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LendingBut.Location = new System.Drawing.Point(0, 306);
            this.LendingBut.Name = "LendingBut";
            this.LendingBut.Size = new System.Drawing.Size(295, 36);
            this.LendingBut.TabIndex = 6;
            this.LendingBut.Text = "Выдать книгу";
            this.LendingBut.UseVisualStyleBackColor = false;
            this.LendingBut.Click += new System.EventHandler(this.LendingBut_Click);
            // 
            // LendingLV
            // 
            this.LendingLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.LendingLV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LendingLV.FullRowSelect = true;
            this.LendingLV.GridLines = true;
            this.LendingLV.Location = new System.Drawing.Point(0, 71);
            this.LendingLV.MultiSelect = false;
            this.LendingLV.Name = "LendingLV";
            this.LendingLV.Size = new System.Drawing.Size(373, 271);
            this.LendingLV.TabIndex = 10;
            this.LendingLV.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Фамилия";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Имя";
            this.columnHeader11.Width = 85;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Отчество";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "№ читат.билета";
            this.columnHeader13.Width = 55;
            // 
            // Closebut
            // 
            this.Closebut.Location = new System.Drawing.Point(54, 796);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(126, 38);
            this.Closebut.TabIndex = 11;
            this.Closebut.Text = "button1";
            this.Closebut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Название книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Автор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(7, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "№  билета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата выдачи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Дата возврата";
            // 
            // ReaderSearchtxt
            // 
            this.ReaderSearchtxt.Location = new System.Drawing.Point(121, 29);
            this.ReaderSearchtxt.Name = "ReaderSearchtxt";
            this.ReaderSearchtxt.Size = new System.Drawing.Size(249, 23);
            this.ReaderSearchtxt.TabIndex = 19;
            this.ReaderSearchtxt.TextChanged += new System.EventHandler(this.ReaderSearchtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "Введите фамилию";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NameBooktxt);
            this.splitContainer1.Panel1.Controls.Add(this.LendingBut);
            this.splitContainer1.Panel1.Controls.Add(this.Authortxt);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Readertxt);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.ReturnDateTime);
            this.splitContainer1.Panel1.Controls.Add(this.IssuDateTime);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.ReaderSearchtxt);
            this.splitContainer1.Panel2.Controls.Add(this.LendingLV);
            this.splitContainer1.Size = new System.Drawing.Size(672, 342);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 24;
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(672, 342);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Closebut);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Lending";
            this.Text = "Выдача книг";
            this.Load += new System.EventHandler(this.Lending_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.TextBox NameBooktxt;
        private System.Windows.Forms.TextBox Readertxt;
        private System.Windows.Forms.DateTimePicker IssuDateTime;
        private System.Windows.Forms.DateTimePicker ReturnDateTime;
        private System.Windows.Forms.Button LendingBut;
        private System.Windows.Forms.ListView LendingLV;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button Closebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ReaderSearchtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}