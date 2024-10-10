using System;
using System.Collections.Generic;


using System.Linq;
using System.IO;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.CSharp;

using System.Diagnostics;
using System.ComponentModel;
//using IronPython.Hosting;






namespace lebedi
{
    public partial class result : Form
    {

        public result(List<string> files)
        {

            
            InitializeComponent();


            //var engine = Python.CreateEngine();
            //dynamic py = engine.ExecuteFile(@"D:\project\main.py");

            //dynamic calc = py.Calculator();

            //string a;
            //string res;
            //string[] row = { "", "" };
            //ListViewItem lvi;
            //for (int i = 0; i < files.Count; i++)
            //{
            //    a = files[i];
            //    res = calc.predict(a);
            //    row[0] = a;
            //    row[1] = res;
            //    lvi = new ListViewItem(row);
            //    listView1.Items.Add(lvi);
            //}

            listView1.View = View.Details;

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void result_Load(object sender, EventArgs e)
        {

        }


    }
}
