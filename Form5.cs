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
    public partial class Form5 : Form
    {
        public static DataTable DT_Income()
        {
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            DataRow myDataRow;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Assets";
            dtColumn.Caption = "Assets";
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


            return dt;
        }
        public static DataTable DT_Income1()
        {
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            DataRow myDataRow;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Liabilities";
            dtColumn.Caption = "Liabilities";
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


            return dt;
        }
        public static DataTable BalanceAssets = DT_Income();
        public static DataTable BalanceLiabilities = DT_Income1();

        public Form5()
        {
            InitializeComponent();
            DataRow dtrow;
            for (int i = 0; i < Form1.Alist.Count; i++)
            {
                dtrow = BalanceAssets.NewRow();
                dtrow["Assets"] = Form1.Alist[i];
                dtrow["Amount"] = Form1.AlistVal[i];
                BalanceAssets.Rows.Add(dtrow);
            }
            for (int i = 0; i < Form1.Deplist.Count; i++)
            {
                dtrow = BalanceAssets.NewRow();
                dtrow["Assets"] = Form1.Deplist[i];
                dtrow["Amount"] = Form1.DeplistVal[i];
                BalanceAssets.Rows.Add(dtrow);
            }
            decimal sum = Convert.ToDecimal(BalanceAssets.Compute("Sum(Amount)", ""));
            DataRow dtrow1 = BalanceAssets.NewRow();
            dtrow1["Assets"] = "Total";
            dtrow1["amount"] = sum;
            BalanceAssets.Rows.Add(dtrow1);

            dataGridView1.DataSource = BalanceAssets;
            dataGridView1.Refresh();

            DataRow dtrow3;
            for (int i = 0; i < Form1.Llist.Count; i++)
            {
                dtrow3 = BalanceLiabilities.NewRow();
                dtrow3["Liabilities"] = Form1.Llist[i];
                dtrow3["Amount"] = Form1.LlistVal[i];
                BalanceLiabilities.Rows.Add(dtrow3);
            }

            DataRow dtrow4 = BalanceLiabilities.NewRow();
            dtrow4["Liabilities"] = "Owner Equity";
            dtrow4["Amount"] = Form4.sum;
            BalanceLiabilities.Rows.Add(dtrow4);

            decimal sum1 = Convert.ToDecimal(BalanceLiabilities.Compute("Sum(Amount)", ""));
            DataRow dtrow5 = BalanceLiabilities.NewRow();
            dtrow5["Liabilities"] = "Total";
            dtrow5["amount"] = sum1;
            BalanceLiabilities.Rows.Add(dtrow5);

            dataGridView2.DataSource = BalanceLiabilities;
            dataGridView2.Refresh();

            if (sum == sum1)
            {
                textBox1.Text="BALANCED!";
            }
            else
            {
                textBox1.Text = "UNBALANCED!";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
