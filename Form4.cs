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
    public partial class Form4 : Form
    {
        public static DataTable OC_table()
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

            return dt;
        }
        public static DataTable OE = OC_table();
        public Form4()
        {
            InitializeComponent();
            DataRow dtrow = OE.NewRow();
            dtrow[" "] = Form1.OClist[0];
            dtrow["Amount"] = Form1.OClistVal[0];
            OE.Rows.Add(dtrow);

            DataRow dtrow1 = OE.NewRow();
            dtrow1[" "] = "Net Income";
            dtrow1["Amount"] = Form3.NI;
            OE.Rows.Add(dtrow1);

            DataRow dtrow2 = OE.NewRow();
            decimal OW = Form1.OWlistVal[0];
            dtrow2[" "] = "Owner Withdrawal";
            dtrow2["Amount"] = -OW;
            OE.Rows.Add(dtrow2);

            DataRow dtrow3 = OE.NewRow();
            dtrow3[" "] = "Owner Capital";
            decimal sum = Convert.ToDecimal(OE.Compute("Sum(Amount)", ""));
            dtrow3["Amount"] =sum;
            OE.Rows.Add(dtrow3);

            dataGridView1.DataSource = OE;
            dataGridView1.Refresh();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
