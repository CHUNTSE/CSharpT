using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 祖聖
{
    class Program
    {
            //Encrypt 函式
            //輸入參數：
            //  1. PasswordTableFrom : String 密碼表 #1
            //  2. PasswordTableTo : String 密碼表 #2
            //  3. Message : String 要加密的字串
            //加密方式：
            //  將訊息字串中包含在密碼表 #1 中的字元替換成密碼表 #2 中對應的字元
            //範例：
            //  密碼表 #1   ABCDFGKM
            //  密碼表 #2   39SDK8LT

            //  Bob is not A Girl  ==> 90b is not 3 8irl


            public static string Emcrypt(string PasswordTableFrom, string PasswordTableTo,string Message)
            {
            //檢查密碼表 #1 的長度，如果不是 8 個字就產生錯誤
            if (PasswordTableFrom.Length != 8) throw new Exception("ERROR");

            //檢查密碼表 #2 的長度，如果不是 8 個字就產生錯誤
            if (PasswordTableTo.Length != 8) throw new Exception("ERROR");

            //將密碼表 #1 中的每一個字元 chA，以及密碼表 #2 中對應的字元 chB，一個一個拿出來
            for(int i =0;i<PasswordTableFrom.Length;i++)
            {
                char chA = PasswordTableFrom[i];
                char chB = PasswordTableTo[i];

                //	將訊息字串中的所有的字元 chA 替換成 chB
                Message = Message.Replace(chA,chB);
            }

            //將結果傳回
            return Message;
        }
        static void Main(string[] args)
        {
        }
    }
}
