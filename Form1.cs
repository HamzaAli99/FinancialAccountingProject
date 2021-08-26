using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AccountingWindows
{
    public partial class Form1 : Form
    {
        public struct entry
        {

            public string acc_head;
            public string acc_title;
            public decimal amount;
        }

        public string GetStructData(entry e)
        {
            string StructData = "";
            StructData = e.acc_head + "  " + e.acc_title + "  " + e.amount.ToString();
            return StructData;
        }

        public decimal GetListSum(List<entry> list)
        {
            decimal sum = 0;
            foreach(entry e in list)
            {
                sum += e.amount;
            }

            return sum;
        }
        int count = 1;
        public Form1()
        {
            InitializeComponent();
            // string mainconn = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection();

        }

        
        public List<entry> GJ_debit = new List<entry>();
        public List<entry> GJ_credit = new List<entry>();
        List<Control> myList = new List<Control>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void DebitAccount_Click(object sender, EventArgs e)
        {

        }

        private void CreditAccount_Click(object sender, EventArgs e)
        {

        }

        private void Typebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DebitAmount_Click(object sender, EventArgs e)
        {

        }

        private void Debitvalue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void creditvalue_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date;
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void Entry_Click(object sender, EventArgs e)
        {

            decimal dSum = GetListSum(GJ_debit);
            decimal cSum = GetListSum(GJ_credit);

            if (dSum != cSum)
            {
                MessageBox.Show("Debit and Credit couldn't be balanced. Please check if you are missing some entries.");
                return;
            }

            //SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=accounting;Integrated Security=True");

            string commandText = "INSERT INTO GJ (T_id, Date, Debit_account, Debit_type, Debit_amount, Credit_account,Credit_type,Credit_amount) VALUES (@T_id, @Date, @Debit_account, @Debit_type, @Debit_amount, @Credit_account,@Credit_type,@Credit_amount); ";
            //SqlCommand cmd = new SqlCommand(commandText, sqlconn);
            //sqlconn.Open();
           // cmd.Parameters.AddWithValue("@T_id", 1);
            // cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
           // int i = cmd.ExecuteNonQuery();

            //string DebitEntryQuery = "INSERT INTO GJ (Debit_account, Debit_type, Debit_amount) VALUES ( @Debit_account, @Debit_type, @Debit_amount); ";
            //SqlCommand a = new SqlCommand(DebitEntryQuery, sqlconn);

            //string CreditEntryQuery = "INSERT INTO GJ (Credit_account,Credit_type,Credit_amount) VALUES (@Credit_account,@Credit_type,@Credit_amount); ";
            //SqlCommand b = new SqlCommand(CreditEntryQuery, sqlconn);
           
           
           // sqlconn.Close();


            foreach (entry d_entry in GJ_debit)
            {
                using(SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=accounting;Integrated Security=True"))
                {
                    SqlCommand cmd1 = new SqlCommand(commandText, sqlconn);
                    cmd1.Parameters.AddWithValue("@T_id", 1);
                    cmd1.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                    cmd1.Parameters.AddWithValue("@Debit_account", d_entry.acc_title);
                    cmd1.Parameters.AddWithValue("@Debit_type", d_entry.acc_head);
                    cmd1.Parameters.AddWithValue("@Debit_amount", d_entry.amount);

                    cmd1.Parameters.AddWithValue("@Credit_account", "");
                    cmd1.Parameters.AddWithValue("@Credit_type", "");
                    cmd1.Parameters.AddWithValue("@Credit_amount", 0);
                    sqlconn.Open();
                    int execute = cmd1.ExecuteNonQuery();
                }
            }
            //string commandText1 = "INSERT INTO GJ (T_id, Date, Debit_account, Debit_type, Debit_amount, Credit_account,Credit_type,Credit_amount) VALUES (@T_id, @Date, @Debit_account, @Debit_type, @Debit_amount, @Credit_account,@Credit_type,@Credit_amount); ";
            //SqlCommand cmd1 = new SqlCommand(commandText1, sqlconn);

            foreach (entry c_entry in GJ_credit)
            {
                using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=accounting;Integrated Security=True"))
                {
                    SqlCommand cmd1 = new SqlCommand(commandText, sqlconn);

                    cmd1.Parameters.AddWithValue("@T_id", 1);
                    cmd1.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd1.Parameters.AddWithValue("@Debit_account", "");
                    cmd1.Parameters.AddWithValue("@Debit_type", "");
                    cmd1.Parameters.AddWithValue("@Debit_amount", 0);

                    cmd1.Parameters.AddWithValue("@Credit_account", c_entry.acc_title);
                    cmd1.Parameters.AddWithValue("@Credit_type", c_entry.acc_head);
                    cmd1.Parameters.AddWithValue("@Credit_amount", c_entry.amount);
                    sqlconn.Open();
                    int execute = cmd1.ExecuteNonQuery();
                }
            }

            GJ_credit.Clear();
            GJ_debit.Clear();
            txt_OngoingEntry.ResetText();
            // foreach(Control control in this.myList)
            // {
            //     if(control is TextBox)
            //     {
            //         Console.WriteLine(control);
            //         Console.WriteLine();
            //     }
            // }
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandType = CommandType.StoredProcedure;

            // int id = 1;
            // SqlCommand cmd = new SqlCommand(sqlconn);



            //cmd.Parameters.AddWithValue("@T_id", 1);
            //cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@Credit_account", textBox2.Text);
            //cmd.Parameters.AddWithValue("@Credit_type", comboBox1.SelectedItem);  //name changed to creditAcc...
            //cmd.Parameters.AddWithValue("@Credit_amount", creditvalue.Value);

            //sqlconn.Open();

            //int i = cmd.ExecuteNonQuery();

            //sqlconn.Close();

            // if (i != 0)
            // {
            //     MessageBox.Show(i + "Data Saved");
            // }
        }

        /*        private void DAccountName_TextChanged(object sender, EventArgs e)
                {

                }

                private void CAccountname_TextChanged(object sender, EventArgs e)
                {

                }
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    TextBox txt = new TextBox();
            //    txt.Name = "Credit_Entry_"+this.count.ToString();
            //    txt.Top = 50 + (this.count+2) * 10;
            //    txt.Left = 60;
            //    this.count++;
            //    this.Controls.Add(txt);
            //    this.myList.Add(txt);
            if (DebitAccHead.Text != "" && textBox1.Text != "" && Debitvalue.Value != 0)
            {
                entry d;
                d.acc_head = DebitAccHead.Text;
                d.acc_title = textBox1.Text;
                d.amount = Debitvalue.Value;
                this.GJ_debit.Add(d);
            }

            if (CreditAccHead.Text != "" && textBox2.Text != "" && creditvalue.Value != 0)
            {
                entry c;
                c.acc_head = CreditAccHead.Text;
                c.acc_title = textBox2.Text;
                c.amount = creditvalue.Value;
                this.GJ_credit.Add(c);
            }



            DebitAccHead.ResetText();
            CreditAccHead.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            Debitvalue.Value = 0;
            creditvalue.Value = 0;


            txt_OngoingEntry.ResetText();


            foreach (entry item in GJ_debit)
            {
                txt_OngoingEntry.AppendText(GetStructData(item) + "\n");
            }

            txt_OngoingEntry.AppendText("\n\n");

            foreach (entry item in GJ_credit)
            {
                txt_OngoingEntry.AppendText(GetStructData(item) + "\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DebitAccHead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreditAccHead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_OngoingEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DebitAccHead.ResetText();
            CreditAccHead.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            Debitvalue.Value = 0;
            creditvalue.Value = 0;


            txt_OngoingEntry.ResetText();

            GJ_credit.Clear();
            GJ_debit.Clear();
        }
    }
}
