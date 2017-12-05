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
            this.InverNumtxt = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReaderSearchtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InverNumtxt
            // 
            this.InverNumtxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InverNumtxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InverNumtxt.Location = new System.Drawing.Point(31, 90);
            this.InverNumtxt.Name = "InverNumtxt";
            this.InverNumtxt.ReadOnly = true;
            this.InverNumtxt.Size = new System.Drawing.Size(125, 23);
            this.InverNumtxt.TabIndex = 0;
            // 
            // Authortxt
            // 
            this.Authortxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Authortxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authortxt.Location = new System.Drawing.Point(31, 137);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.ReadOnly = true;
            this.Authortxt.Size = new System.Drawing.Size(161, 23);
            this.Authortxt.TabIndex = 1;
            // 
            // NameBooktxt
            // 
            this.NameBooktxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameBooktxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBooktxt.Location = new System.Drawing.Point(31, 187);
            this.NameBooktxt.Name = "NameBooktxt";
            this.NameBooktxt.ReadOnly = true;
            this.NameBooktxt.Size = new System.Drawing.Size(161, 23);
            this.NameBooktxt.TabIndex = 2;
            // 
            // Readertxt
            // 
            this.Readertxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Readertxt.Location = new System.Drawing.Point(31, 257);
            this.Readertxt.Name = "Readertxt";
            this.Readertxt.Size = new System.Drawing.Size(84, 23);
            this.Readertxt.TabIndex = 3;
            // 
            // IssuDateTime
            // 
            this.IssuDateTime.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuDateTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.IssuDateTime.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush;
            this.IssuDateTime.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.IssuDateTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuDateTime.Location = new System.Drawing.Point(31, 324);
            this.IssuDateTime.Name = "IssuDateTime";
            this.IssuDateTime.Size = new System.Drawing.Size(146, 23);
            this.IssuDateTime.TabIndex = 4;
            // 
            // ReturnDateTime
            // 
            this.ReturnDateTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnDateTime.Location = new System.Drawing.Point(31, 394);
            this.ReturnDateTime.Name = "ReturnDateTime";
            this.ReturnDateTime.Size = new System.Drawing.Size(146, 23);
            this.ReturnDateTime.TabIndex = 5;
            // 
            // LendingBut
            // 
            this.LendingBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LendingBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendingBut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LendingBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LendingBut.Location = new System.Drawing.Point(31, 457);
            this.LendingBut.Name = "LendingBut";
            this.LendingBut.Size = new System.Drawing.Size(144, 36);
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
            this.LendingLV.FullRowSelect = true;
            this.LendingLV.GridLines = true;
            this.LendingLV.Location = new System.Drawing.Point(255, 173);
            this.LendingLV.MultiSelect = false;
            this.LendingLV.Name = "LendingLV";
            this.LendingLV.Size = new System.Drawing.Size(368, 282);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(184, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выдача книг читателю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 166);
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
            this.label4.Location = new System.Drawing.Point(28, 119);
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
            this.label5.Location = new System.Drawing.Point(28, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "№ читательского билета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(47, 303);
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
            this.label7.Location = new System.Drawing.Point(47, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Дата возврата";
            // 
            // ReaderSearchtxt
            // 
            this.ReaderSearchtxt.Location = new System.Drawing.Point(255, 114);
            this.ReaderSearchtxt.Name = "ReaderSearchtxt";
            this.ReaderSearchtxt.Size = new System.Drawing.Size(168, 23);
            this.ReaderSearchtxt.TabIndex = 19;
            this.ReaderSearchtxt.TextChanged += new System.EventHandler(this.ReaderSearchtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(274, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Введите фамилию";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(501, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Список читателей";
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(635, 510);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReaderSearchtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Closebut);
            this.Controls.Add(this.LendingLV);
            this.Controls.Add(this.LendingBut);
            this.Controls.Add(this.ReturnDateTime);
            this.Controls.Add(this.IssuDateTime);
            this.Controls.Add(this.Readertxt);
            this.Controls.Add(this.NameBooktxt);
            this.Controls.Add(this.Authortxt);
            this.Controls.Add(this.InverNumtxt);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Lending";
            this.Text = "Выдача книг";
            this.Load += new System.EventHandler(this.Lending_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InverNumtxt;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ReaderSearchtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}