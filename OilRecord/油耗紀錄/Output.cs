using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 油耗紀錄.CarModels;

namespace 油耗紀錄
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cartext = new CartotalModel();
            var list = cartext.CarTable.ToList();
            double test = 0;
            foreach (var item in list)
            {
                if (item.RefuelingDate > dateTimePicker1.Value && item.RefuelingDate < dateTimePicker2.Value)
                {
                    dataGridView1.DataSource = list;
                    if (item.Liter != 0)
                        test += item.Kilometer / item.Liter;
                    else
                        test += 0;
                    double listliter = list.Max((x) => x.Liter) - list.Min((x) => x.Liter);
                    double listkilometer = list.Max((x) => x.Kilometer) - list.Min((x) => x.Kilometer);
                    label3.Text = Convert.ToString(listkilometer / listliter);
                    //for (int x = 0; x < item.Id; x++)
                    //var All += list[x].Liter / list[x].Kilometer;// item.Liter[x] / item.Kilometer[x];
                    //label3.Text = Alltotal.ToString();
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
        }
    }
}
