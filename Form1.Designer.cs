
namespace AccountingWindows
{
    partial class Form1
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
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DebitAccount = new System.Windows.Forms.Label();
            this.CreditAccount = new System.Windows.Forms.Label();
            this.Debit_acc_head = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DebitAmount = new System.Windows.Forms.Label();
            this.Creditamount = new System.Windows.Forms.Label();
            this.Debitvalue = new System.Windows.Forms.NumericUpDown();
            this.creditvalue = new System.Windows.Forms.NumericUpDown();
            this.Entry = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DebitAccHead = new System.Windows.Forms.ComboBox();
            this.CreditAccHead = new System.Windows.Forms.ComboBox();
            this.txt_OngoingEntry = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Debitvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(193, 49);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 17);
            this.date.TabIndex = 0;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DebitAccount
            // 
            this.DebitAccount.AutoSize = true;
            this.DebitAccount.Location = new System.Drawing.Point(45, 131);
            this.DebitAccount.Name = "DebitAccount";
            this.DebitAccount.Size = new System.Drawing.Size(96, 17);
            this.DebitAccount.TabIndex = 2;
            this.DebitAccount.Text = "Debit Account";
            this.DebitAccount.Click += new System.EventHandler(this.DebitAccount_Click);
            // 
            // CreditAccount
            // 
            this.CreditAccount.AutoSize = true;
            this.CreditAccount.Location = new System.Drawing.Point(264, 131);
            this.CreditAccount.Name = "CreditAccount";
            this.CreditAccount.Size = new System.Drawing.Size(100, 17);
            this.CreditAccount.TabIndex = 3;
            this.CreditAccount.Text = "Credit Account";
            this.CreditAccount.Click += new System.EventHandler(this.CreditAccount_Click);
            // 
            // Debit_acc_head
            // 
            this.Debit_acc_head.FormattingEnabled = true;
            this.Debit_acc_head.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Owner Capital",
            "Owner Withdrawl",
            "Revenue",
            "Expense"});
            this.Debit_acc_head.Location = new System.Drawing.Point(690, 10);
            this.Debit_acc_head.Name = "Debit_acc_head";
            this.Debit_acc_head.Size = new System.Drawing.Size(117, 24);
            this.Debit_acc_head.TabIndex = 4;
            this.Debit_acc_head.SelectedIndexChanged += new System.EventHandler(this.Typebox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Owner Capital",
            "Owner Withdrawl",
            "Revenue",
            "Expense"});
            this.comboBox1.Location = new System.Drawing.Point(690, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DebitAmount
            // 
            this.DebitAmount.AutoSize = true;
            this.DebitAmount.Location = new System.Drawing.Point(48, 255);
            this.DebitAmount.Name = "DebitAmount";
            this.DebitAmount.Size = new System.Drawing.Size(93, 17);
            this.DebitAmount.TabIndex = 8;
            this.DebitAmount.Text = "Debit Amount";
            this.DebitAmount.Click += new System.EventHandler(this.DebitAmount_Click);
            // 
            // Creditamount
            // 
            this.Creditamount.AutoSize = true;
            this.Creditamount.Location = new System.Drawing.Point(271, 255);
            this.Creditamount.Name = "Creditamount";
            this.Creditamount.Size = new System.Drawing.Size(97, 17);
            this.Creditamount.TabIndex = 9;
            this.Creditamount.Text = "Credit Amount";
            // 
            // Debitvalue
            // 
            this.Debitvalue.Location = new System.Drawing.Point(41, 275);
            this.Debitvalue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Debitvalue.Name = "Debitvalue";
            this.Debitvalue.Size = new System.Drawing.Size(120, 22);
            this.Debitvalue.TabIndex = 10;
            this.Debitvalue.ThousandsSeparator = true;
            this.Debitvalue.ValueChanged += new System.EventHandler(this.Debitvalue_ValueChanged);
            // 
            // creditvalue
            // 
            this.creditvalue.Location = new System.Drawing.Point(261, 275);
            this.creditvalue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.creditvalue.Name = "creditvalue";
            this.creditvalue.Size = new System.Drawing.Size(120, 22);
            this.creditvalue.TabIndex = 11;
            this.creditvalue.ThousandsSeparator = true;
            this.creditvalue.ValueChanged += new System.EventHandler(this.creditvalue_ValueChanged);
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(658, 428);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(118, 56);
            this.Entry.TabIndex = 12;
            this.Entry.Text = "Entry";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebitAccHead
            // 
            this.DebitAccHead.FormattingEnabled = true;
            this.DebitAccHead.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Owner Capital",
            "Owner Withdrawal",
            "Resourses",
            "Expenses"});
            this.DebitAccHead.Location = new System.Drawing.Point(48, 158);
            this.DebitAccHead.Name = "DebitAccHead";
            this.DebitAccHead.Size = new System.Drawing.Size(121, 24);
            this.DebitAccHead.TabIndex = 16;
            this.DebitAccHead.SelectedIndexChanged += new System.EventHandler(this.DebitAccHead_SelectedIndexChanged);
            // 
            // CreditAccHead
            // 
            this.CreditAccHead.FormattingEnabled = true;
            this.CreditAccHead.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Owner Capital",
            "Owner Withdrawal",
            "Resourses",
            "Expenses"});
            this.CreditAccHead.Location = new System.Drawing.Point(260, 151);
            this.CreditAccHead.Name = "CreditAccHead";
            this.CreditAccHead.Size = new System.Drawing.Size(121, 24);
            this.CreditAccHead.TabIndex = 17;
            this.CreditAccHead.SelectedIndexChanged += new System.EventHandler(this.CreditAccHead_SelectedIndexChanged);
            // 
            // txt_OngoingEntry
            // 
            this.txt_OngoingEntry.Location = new System.Drawing.Point(457, 120);
            this.txt_OngoingEntry.Name = "txt_OngoingEntry";
            this.txt_OngoingEntry.Size = new System.Drawing.Size(358, 279);
            this.txt_OngoingEntry.TabIndex = 18;
            this.txt_OngoingEntry.Text = "";
            this.txt_OngoingEntry.TextChanged += new System.EventHandler(this.txt_OngoingEntry_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 496);
            this.Controls.Add(this.txt_OngoingEntry);
            this.Controls.Add(this.CreditAccHead);
            this.Controls.Add(this.DebitAccHead);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.creditvalue);
            this.Controls.Add(this.Debitvalue);
            this.Controls.Add(this.Creditamount);
            this.Controls.Add(this.DebitAmount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Debit_acc_head);
            this.Controls.Add(this.CreditAccount);
            this.Controls.Add(this.DebitAccount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Debitvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DebitAccount;
        private System.Windows.Forms.Label CreditAccount;
        private System.Windows.Forms.ComboBox Debit_acc_head;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DebitAmount;
        private System.Windows.Forms.Label Creditamount;
        private System.Windows.Forms.NumericUpDown Debitvalue;
        private System.Windows.Forms.NumericUpDown creditvalue;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DebitAccHead;
        private System.Windows.Forms.ComboBox CreditAccHead;
        private System.Windows.Forms.RichTextBox txt_OngoingEntry;
    }
}

