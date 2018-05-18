using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wk9
{
    class Databox
    {
        static public List<string> list1 = new List<string>();
        static public List<string> list2 = new List<string>();
        static public Dictionary<string,Dictionary<string,decimal>> Text1()
        {
            Dictionary<string, Dictionary<string, decimal>> di1 = new Dictionary<string, Dictionary<string, decimal>>();
            string fname = "Ticket.txt";
            if(File.Exists(fname))
            {
                var s = File.ReadAllLines(fname);
                var listbox = s[0].Split(',');
                for(int x = 1,y=0;x<s.Length;x++,y++)
                {
                    var n = s[x].Split(',');
                    Dictionary<string, decimal> di2 = new Dictionary<string, decimal>();
                    for(int z = 0;z<n.Length;z++)
                    {
                        di2.Add(listbox[z], Convert.ToDecimal(n[z]));
                    }
                    di1.Add(listbox[y], di2);
                    list1.Add(listbox[y]);
                    list2.Add(listbox[y]);
                }
            }
            return di1;
        }
    }
    public class Data
    {
        static public bool CheckBox1;
        static public bool CheckBox2;
        static public bool RadioButton1;
        static public bool RadioButton2;
        static public string ComboBox1;
        static public string ComboBox2;
        static public decimal Total;
    }
}
