using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wk8
{
    class Databox
    {
        static private List<string> ThingNameList = new List<string>();
        static public List<Perfect> DataPerfect()
        {
            List<Perfect> result = new List<Perfect>();
            var fname = "Name.txt";
            if(File.Exists(fname))
            {
                foreach(var text in File.ReadLines(fname))
                {
                    var x = text.Split(',');
                    var total = new Perfect
                    {
                        PerfectName = x[0],
                        AtomPen = Convert.ToDecimal(x[1]),
                        Pen = Convert.ToDecimal(x[2]),
                        Eraser = Convert.ToDecimal(x[3]),
                        Ruler = Convert.ToDecimal(x[4]),
                        LiWhite = Convert.ToDecimal(x[5])
                    };
                    result.Add(total);
                }
            }
            return result;
        }
        static public List<ThingTotal> DataThing()
        {
            List<ThingTotal> result = new List<ThingTotal>();
            var fname = "Thing.txt";
            if(File.Exists(fname))
            {
                foreach(var text in File.ReadLines(fname))
                {
                    var y = text.Split(',');
                    ThingNameList.Add(y[0]);
                    ThingNameList.Add(y[2]);
                    ThingNameList.Add(y[4]);
                    ThingNameList.Add(y[6]);
                    ThingNameList.Add(y[8]);
                    var x = new ThingTotal
                    {
                        AtomPen = Convert.ToDecimal(y[1]),
                        Pen = Convert.ToDecimal(y[3]),
                        Eraser = Convert.ToDecimal(y[5]),
                        Ruler = Convert.ToDecimal(y[7]),
                        LiWhite = Convert.ToDecimal(y[9])
                    };
                    result.Add(x);
                }
            }
            return result;
        }
        static public List<decimal> ThingTotalMoney(List<Perfect> Tall,List<ThingTotal>Tmoney)
        {
            List<decimal> result = new List<decimal>();
            result.Add(CountMoney(Tall.Sum(x =>x.AtomPen),Tmoney.Sum(x =>x.AtomPen)));
            result.Add(CountMoney(Tall.Sum(x => x.Pen), Tmoney.Sum(x => x.Pen)));
            result.Add(CountMoney(Tall.Sum(x => x.Eraser), Tmoney.Sum(x => x.Eraser)));
            result.Add(CountMoney(Tall.Sum(x => x.Ruler), Tmoney.Sum(x => x.Ruler)));
            result.Add(CountMoney(Tall.Sum(x => x.LiWhite), Tmoney.Sum(x => x.LiWhite)));
            return result;
        }
        static public List<ThingTotal> DecimalThing(List<decimal> list)
        {
            List<ThingTotal> ThingDecimal = new List<ThingTotal>();
            var t = new ThingTotal
            {
                AtomPen = list[0],
                Pen = list[1],
                Eraser = list[2],
                Ruler = list[3],
                LiWhite = list[4]
            };
            ThingDecimal.Add(t);
            return ThingDecimal;
        }
        static public void CountAll(List<Perfect> pfList,List<ThingTotal>ttList)
        {
            foreach(var item in pfList)
            {
                item.PerfectOne =
                    CountMoney(item.AtomPen, ttList.Sum(x => x.AtomPen)) +
                    CountMoney(item.Pen, ttList.Sum(x => x.Pen)) +
                    CountMoney(item.Eraser, ttList.Sum(x => x.Eraser)) +
                    CountMoney(item.Ruler, ttList.Sum(x => x.Ruler)) +
                    CountMoney(item.LiWhite, ttList.Sum(x => x.LiWhite));
            }
        }
        static public List<string> ThingName()
        {
            return ThingNameList;
        }
        static public decimal CountMoney(decimal x,decimal y)
        {
            var money = x * y;
            return money;
        }
    }
}
