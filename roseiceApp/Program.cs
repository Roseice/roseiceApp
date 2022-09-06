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
            string line;//宣告變數為line
            Console.WriteLine("Hello World!");//顯示Hello World!
            Console.WriteLine("請輸入姓名");
            line = Console.ReadLine();//獲取使用者輸入存於line
            Console.WriteLine("你好"+line);//顯示line儲存資料
            Console.ReadLine();//按Enter結束
        }
    }
}
