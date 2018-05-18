using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPerformance
{
    public partial class Form1 : Form
    {
        private ProdcutList _products;
        private PerformanceList _performances;
        public Form1()
        {
            InitializeComponent();
            InitialData();
            var summary = GetSummary();
            GetSalesAmount(summary);
            GetProductAmount(summary);

        }

        private  void GetProductAmount(List<Summary> summary)
        {
            var result = summary.GroupBy((x) => x.Item).Select((x) =>
            {
                return new { Item = x.Key, Amount = x.Sum((y) => y.Amount) };
            });

            dataGridView2.DataSource = result.ToList();
            var best = result.FirstOrDefault((x) => x.Amount == result.Max((y) => y.Amount));
            label6.Text = best.Item;
        }

        private  void GetSalesAmount(List<Summary> summary)
        {
            var result = summary.GroupBy((x) => x.Salesman).Select((x) =>
            {
                return new { Salesman = x.Key, Amount = x.Sum((y) => y.Amount) };
            }
            );
            dataGridView1.DataSource = result.ToList();
            var best = result.FirstOrDefault((x) => x.Amount == result.Max((y) => y.Amount));
            label4.Text = best.Salesman;
        }

        private void InitialData()
        {
            _products = ProdcutList.GetFakeProductList();
            _performances = PerformanceList.GetFakePerformanceList();
        }

        private List<Summary> GetSummary()
        {
            var data = from s in _performances.Items
                       join p in _products.Items
                       on s.ProductItem equals p.Item
                       select new Summary
                       {
                           Item = p.Item,
                           Salesman = s.Salesman,
                           Amount = p.Price * s.Quantity
                       };
            return data.ToList();
        }


    }
}
