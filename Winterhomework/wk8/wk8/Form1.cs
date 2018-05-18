using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk8
{
    public partial class Form1 : Form
    {
        private List<Perfect> perfectList = Databox.DataPerfect();
        private List<ThingTotal> thingList = Databox.DataThing();
        private List<string> nameList = Databox.ThingName();
        private List<decimal> Totalmoney = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            Totalmoney = Databox.ThingTotalMoney(perfectList,thingList);
            Databox.CountAll(perfectList,thingList);
            GetData();
        }
        private void GetData()
        {
            List<ThingTotal> x = new List<ThingTotal>();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = perfectList;
            dataGridView2.DataSource = Databox.DecimalThing(Totalmoney);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in perfectList.Where(x=>x.PerfectOne == perfectList.Max(y =>y.PerfectOne)))
            {
               label2.Text = item.PerfectName;
            }
            var n = Totalmoney.IndexOf(Totalmoney.Max());
            label4.Text = nameList[n];
        }
    }
}
