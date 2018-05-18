using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerformance
{
    public class ProdcutList
    {
        public List<Product> Items { get; set; }

        public ProdcutList ()
        {
            Items = new List<Product>();
        }

        public static ProdcutList GetFakeProductList()
        {
            var result = new ProdcutList();
            result.Items.Add(new Product { Item = ProductItem.BallPointPen, Price = 12 });
            result.Items.Add(new Product { Item = ProductItem.Pencil , Price = 16 });
            result.Items.Add(new Product { Item = ProductItem.Eraser , Price = 10 });
            result.Items.Add(new Product { Item = ProductItem.Ruler , Price = 14 });
            result.Items.Add(new Product { Item = ProductItem.Whiteout , Price = 15 });

            return result;
        }
    }
}
