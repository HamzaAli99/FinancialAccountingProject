using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingWindows
{
    public partial class Form3 : Form
    {
        public static DataTable DT_Income()
        {
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            DataRow myDataRow;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = " ";
            dtColumn.Caption = "Rev&Exp";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.  
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(decimal);
            dtColumn.ColumnName = "Amount";
            dtColumn.Caption = "Amount";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.  
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(decimal);
            dtColumn.ColumnName = "Total";
            dtColumn.Caption = "Total";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.  
            dt.Columns.Add(dtColumn);

            return dt;
        }

       


        public static DataTable IncomeRevenue = DT_Income();
        public static DataTable IncomeExpense = DT_Income();
        public static decimal NI;
        public Form3()
        {
            InitializeComponent();

            DataRow dtrow;
            for (int i = 0; i < Form1.Rlist.Count; i++)
            {
                dtrow = IncomeRevenue.NewRow();
                dtrow[" "] = Form1.Rlist[i];
                dtrow["Amount"] = Form1.RlistVal[i];
                IncomeRevenue.Rows.Add(dtrow);
            }

            DataRow dtrow1 = IncomeRevenue.NewRow();
            decimal sum = Convert.ToDecimal(IncomeRevenue.Compute("Sum(Amount)", ""));
            dtrow1[" "] = "Total";
            dtrow1["Amount"] = 0;
            dtrow1["Total"] = sum;
            IncomeRevenue.Rows.Add(dtrow1);

            dataGridView1.DataSource = IncomeRevenue;
            for (int i = 0; i < Form1.Elist.Count; i++)
            {
                dtrow = IncomeExpense.NewRow();
                dtrow[" "] = Form1.Elist[i];
                dtrow["Amount"] = Form1.ElistVal[i];
                IncomeExpense.Rows.Add(dtrow);
            }
            DataRow dtrow4 = IncomeExpense.NewRow();
            decimal sum1 = Convert.ToDecimal(IncomeExpense.Compute("Sum(Amount)", ""));
            dtrow4[" "] = "Total";
            dtrow4["Amount"] = 0;
            dtrow4["Total"] = sum1;
            IncomeExpense.Rows.Add(dtrow4);

             NI = sum - sum1;
            textBox1.Text = NI.ToString();
            dataGridView1.DataSource = IncomeRevenue;
            dataGridView1.Refresh();
            dataGridView2.DataSource = IncomeExpense;
            dataGridView2.Refresh();
            textBox1.Refresh();
        }

        private void income_st_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
