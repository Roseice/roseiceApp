using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roseiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line;//宣告變數為line
            //Console.WriteLine("Hello World!");//顯示Hello World!
            //Console.WriteLine("請輸入姓名");
            //line = Console.ReadLine();//獲取使用者輸入存於line
            //Console.WriteLine("你好"+line);//顯示line儲存資料
            //Console.ReadKey();//按Enter結束
            //宣告整數變數
            int intNumber;//宣告int型別變數
            ushort ushrNumber;//宣告ushort型別變數
            long lngNumber;//宣告long型別變數
            //浮點數變數宣告(儲存含有小數的數值)
            float fltNumber;//宣告float型別變數
            double deNumber;//宣告double型別變數
            decimal decNumber;//宣告decimal型別變數
            //布林型別變數宣告(儲存true/false)
            bool boolFlag;//宣告bool型別變數
            //字元形別變數宣告
            char chCode;//宣告char型別變數
            //字串形別變數宣告(儲存一串字元)
            string strName;//宣告string型別變數
            //變數宣告與數值的設定
            intNumber = 32;//設定intNumber為32
            deNumber = 3.14159;//設定deNumber為3.14159
            boolFlag = true;//設定boolFlag為true
            chCode = '\u0045';//設定chCode編碼值為\u0045
            sbyte intNumber2 = 100;//宣告sbyte整數變數,並自動轉換為int型別做儲存 
            Random ran = new Random();
            int n = ran.Next(100);
            Console.WriteLine("隨機產生數字="+ n);
            if (n < 50)
            {
                boolFlag = true;
                Console.WriteLine("判定小於50 bool=" + boolFlag);
            }
            else
            {
                boolFlag = false;
                Console.WriteLine("判定大於50 bool=" + boolFlag); 
            }
            Console.WriteLine("intNumber="+intNumber.ToString()+"\n"+"deNumber="+deNumber.ToString());//顯示存入的數值
            Console.ReadKey();
            //將double轉換為float後存入並顯示
            fltNumber = Convert.ToSingle(92.6);
            fltNumber = (float)33.828;
            Console.WriteLine("fltNumber=" + fltNumber.ToString());
            //隱含型別轉換
            deNumber = intNumber;
            Console.WriteLine("decNumber=" + deNumber.ToString());
            Console.ReadKey();
            //各類運算練習

        }
    }
}
