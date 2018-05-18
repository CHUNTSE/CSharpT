using System;
using System.Collections.Generic;
using System.Text;

namespace 回文測試
{
    public class ReverseArray
    {
        public bool Rever(string conso)
        {
            char[] text;
            string revertext;
            revertext = conso.Replace(" ","");
            text = revertext.ToCharArray();
            Array.Reverse(text);
            return revertext == new string(text);
        }
    }
}
