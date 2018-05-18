using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerformance
{


    public class Product
    {
        public string Item { get; set; }
        public int Price { get; set; }
    }

  
    public class Performance
    {
        public string Salesman { get; set; }
        
        public string ProductItem { get; set; }

        public int Quantity { get; set; }

    }

    public static class ProductItem
    {
        public const string BallPointPen = "原子筆";
        public const string Pencil = "鉛筆";
        public const string Eraser = "橡皮擦";
        public const string Ruler = "直尺";
        public const string Whiteout = "立可白";

    }
   
}
