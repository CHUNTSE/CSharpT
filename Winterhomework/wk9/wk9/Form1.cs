using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk9
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, decimal>> di1 = new Dictionary<string, Dictionary<string, decimal>>();
        public Form1()
        {
            InitializeComponent();
            di1 = Databox.Text1();
            comboBox1.SelectedIndexChanged += Combobox1_Index;
            comboBox2.SelectedIndexChanged += Combobox2_Index;
            checkBox1.Click += checkBox1_CheckedChanged;
            checkBox2.Click += checkBox2_CheckedChanged;
            AllData();
        }
        private void AllData()
        {
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
            comboBox1.DataSource = Databox.list1;
            comboBox2.DataSource = Databox.list2;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Data.Total);
            AllData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var money = di1[Data.ComboBox1][Data.ComboBox2];
            if(checkBox1.Checked && checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.81));
            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(1));
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var money = di1[Data.ComboBox1][Data.ComboBox2];
            if (checkBox1.Checked && checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.81));
            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                Data.Total = Math.Ceiling(money * Convert.ToDecimal(1));
            }
        }
        private void Combobox1_Index(object sender,EventArgs e)
        {
            Data.ComboBox1 = Convert.ToString(comboBox1.SelectedItem);
        }
        private void Combobox2_Index(object sender, EventArgs e)
        {
            Data.ComboBox2 = Convert.ToString(comboBox2.SelectedItem);
        }
        private void checkBox1_check(object sender,EventArgs e)
        {
            if (checkBox1.Checked)
                Data.CheckBox1 = true;
            else
                Data.CheckBox1 = false;
        }
        private void checkBox2_check(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                Data.CheckBox2 = true;
            else
                Data.CheckBox2 = false;
        }
        private void RadioButton1_check(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Data.RadioButton1 = true;
            else
                Data.RadioButton1 = false;
        }
        private void RadioButton2_check(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                Data.RadioButton2 = true;
            else
                Data.RadioButton2 = false;
        }
    }
}
