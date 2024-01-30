using ClassLibrary1;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes
{
    public partial class Form2 : Form

    {
        public List<SalesLine> ds = SalesLineDS.GetSalesLines();
        public DataTable dt = new DataTable();

        public DataTable toDataTable<T>(List<T> items)
        {

            DataTable datatable = new DataTable(typeof(T).Name);
            //obtenemos todas las propiedades del tipo T

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                datatable.Columns.Add(prop.Name);

            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                datatable.Rows.Add(values);

            }
            return datatable;
        }


        public Form2()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Informes.Report1.rdlc";

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = toDataTable(ds);
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

        }
    }
}
