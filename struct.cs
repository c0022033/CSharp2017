using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStruct
{
    class Program
    {
        // 定義Product產品結構資料型別
        struct Product
        {
            // Product產品結構內含No編號欄位、Name品名欄位、Price單價欄位
            public string No, Name;
            public int Price;
        }

        static void Main(string[] args)
        {
            Product xbox;            // 宣告xbox結構變數為Product結構型別
            xbox.No = "TVGame001";   // 設定xbox.No編號欄位的值為 "TVGame001"
            xbox.Name = "XBox One(含Kinect)"; // 設定xbox.Name品名欄位值
                                             // 為"XBox One(含Kinect)"
            xbox.Price = 17200;     // 設定xbox.Price單價欄位的值為17200
            Product ps4;         // 宣告ps4結構變數為Product結構型別
            Console.Write(" 請輸入產品編號：");
            ps4.No = Console.ReadLine();       // 輸入編號再指定給ps4.No欄位
            Console.Write(" 請輸入產品名稱：");   // 輸入品名再指定給ps4.Name
            ps4.Name = Console.ReadLine();
            Console.Write(" 請輸入產品單價：");  //輸入單價轉整數再指定給ps4.Price
            ps4.Price = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" ====== 產品單價清單 ====== ");
            Console.WriteLine();
            // 印出game及cookie結構的編號、品名及單價
            Console.WriteLine(" 產品編號：{0} ", xbox.No);
            Console.WriteLine(" 產品名稱：{0} ", xbox.Name);
            Console.WriteLine(" 產品單價：{0} ", xbox.Price);
            Console.WriteLine(" 產品編號：{0} ", ps4.No);
            Console.WriteLine(" 產品名稱：{0} ", ps4.Name);
            Console.WriteLine(" 產品單價：{0} ", ps4.Price);
            Console.Read();

        }
    }
}
