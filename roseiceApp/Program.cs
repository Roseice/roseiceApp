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
            //算數運算:+ - *  / %
            Random rann = new Random();
            int k = rann.Next(1000);//亂數int型別變數
            float floata =30.2F;//宣告float型別變數為30.2(後置置元F代表fliat變數)
            double doublea = 0.0;//宣告double型別變數為0.0(用來儲存運算解)
            Console.WriteLine(k);
            doublea = k + floata;//將inta(int型別)轉為float後與原floata(float型別變數)相加後存入doublea           
            Console.WriteLine("k + floata=" + doublea.ToString());//加
            doublea = k - floata;
            Console.WriteLine("k - floata=" + doublea.ToString());//減
            doublea = k * floata;
            Console.WriteLine("k * floata=" + doublea.ToString());//乘
            doublea = k / floata;
            Console.WriteLine("k / floata=" + doublea.ToString());//除
            doublea = k % floata;
            Console.WriteLine("k % floata=" + doublea.ToString());//取餘數
            //比較運算== != > < >= <=
            int n1=5, n2=8;//宣告整數變數(int),設定初始值為n1=5,n2=8
            float f1=3.2f, f2=3.200001f;//宣告浮點數變數(float),設定初始值為f1=3.2,f2=3.200001
            bool cp;//宣告布林(bool)存放結果
            cp = n1 == n2;//比較n1是否等於n2
            Console.WriteLine("n1 相等於 n2 ? " + cp.ToString());
            cp = f1 != f2;//比較f1是否不等於f2
            Console.WriteLine("f1 不等於 f2 ? " + cp.ToString());
            cp = n2 > 0;//n2是否大於0
            Console.WriteLine("n2是否大於0 " + cp.ToString());
            cp = f2 < 0;//f2是否小於0
            Console.WriteLine("f2是否小於0 " + cp.ToString());
            cp = n1 >= f1;//n1是否大於等於f1
            Console.WriteLine("n1是否大於等於f1 " + cp.ToString());
            cp = f2 <= n1;//f2是否小於等於n1
            Console.WriteLine("f2是否小於等於n1 " + cp.ToString());
            //邏輯運算
            int x = 3;//設定整數變數x=3
            double y = 4.892;//設定實數變數y=4.892
            Console.WriteLine((x > 0) && (x <= 5));//x>為True,so(x>0)且(x<=5)為True
            Console.WriteLine((y < 0) || (y >= 5));//y<0為False,so(y<0)||(y>=5)為False
            Console.WriteLine(!(x > y));//>x>y為False,so!(x>y)為True
            //遞增與遞減運算:++ --
            int x1= 3, y1 = 3;
            Console.WriteLine("x1++ ?" + (++x1));
            Console.WriteLine("x1 ?" + x1);
            x1 = 3;
            Console.WriteLine("x1++ ?" + (x1++));
            Console.WriteLine("x1 ?" + x1);
            x1 = 3;
            int r1 = ++x1;
            x1 = 3;
            int r2 = x1++;
            Console.WriteLine("r1=" + r1 + "r2=" + r2);
            Console.ReadKey();
        }
    }
}
