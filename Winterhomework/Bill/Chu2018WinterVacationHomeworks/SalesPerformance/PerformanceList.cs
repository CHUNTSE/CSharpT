using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerformance
{
    public class PerformanceList
    {
        public List<Performance> Items { get; set; }

        public PerformanceList()
        {
            Items = new List<Performance>();
        }

        public static PerformanceList GetFakePerformanceList()
        {
            var result = new PerformanceList();
            result.Items.Add(new Performance { Salesman = "Bill", ProductItem = ProductItem.BallPointPen, Quantity = 33 });
            result.Items.Add(new Performance { Salesman = "Bill", ProductItem = ProductItem.Pencil, Quantity = 32 });
            result.Items.Add(new Performance { Salesman = "Bill", ProductItem = ProductItem.Eraser, Quantity = 56 });
            result.Items.Add(new Performance { Salesman = "Bill", ProductItem = ProductItem.Ruler , Quantity = 45 });
            result.Items.Add(new Performance { Salesman = "Bill", ProductItem = ProductItem.Whiteout , Quantity = 33 });

            result.Items.Add(new Performance { Salesman = "John", ProductItem = ProductItem.BallPointPen, Quantity = 77 });
            result.Items.Add(new Performance { Salesman = "John", ProductItem = ProductItem.Pencil, Quantity = 33 });
            result.Items.Add(new Performance { Salesman = "John", ProductItem = ProductItem.Eraser, Quantity = 68 });
            result.Items.Add(new Performance { Salesman = "John", ProductItem = ProductItem.Ruler, Quantity = 45 });
            result.Items.Add(new Performance { Salesman = "John", ProductItem = ProductItem.Whiteout, Quantity = 23 });

            result.Items.Add(new Performance { Salesman = "David", ProductItem = ProductItem.BallPointPen, Quantity = 43 });
            result.Items.Add(new Performance { Salesman = "David", ProductItem = ProductItem.Pencil, Quantity = 55 });
            result.Items.Add(new Performance { Salesman = "David", ProductItem = ProductItem.Eraser, Quantity = 43 });
            result.Items.Add(new Performance { Salesman = "David", ProductItem = ProductItem.Ruler, Quantity = 67 });
            result.Items.Add(new Performance { Salesman = "David", ProductItem = ProductItem.Whiteout, Quantity = 65 });


            return result;

        }


    }
}
