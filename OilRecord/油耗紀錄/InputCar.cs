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
    public partial class InputCar : Form
    {
        public InputCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarTable cardata = new CarTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = Convert.ToInt32(numericUpDown1.Value),
                Kilometer = Convert.ToInt32(numericUpDown2.Value)
            };
            try
            {
                CartotalModel cartotal = new CartotalModel();
                cartotal.CarTable.Add(cardata);
                cartotal.SaveChanges();
                MessageBox.Show("存檔完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
