using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;   // 匯入ystem.Collections 命名空間

namespace ConsoleArrayList
{
    class Program
    {
        // 自訂Member 類別
        class Course
        {
            public string Name { get; set; }     // 姓名屬性          
            public bool Status { get; set; }        // 本系屬性
            public int Score { get; set; }          // 成績屬性
            public override string ToString()   // 覆寫覆類別 ToString()方法
            {
                  return string.Format("  姓名 : {0} \t 本系生 : {1} \t 計概成績 : {2} \n " , Name , Status ? "是" : "非" , Score.ToString ());
             }

         }
    static void Main(string[] args)
        {
            ArrayList bcc = new ArrayList();   // 非泛型

            //SortedList<string, Course> bcc = new SortedList<string, Course>();

            bcc.Add(new Course() { Name = "David", Status = true, Score = 85 });
            bcc.Add(new Course() { Name = "Mary", Status = false, Score = 95 });
            bcc.Add(new Course() { Name = "Tom", Status = true, Score = 75 });
            bcc.Add(new Course() { Name = "Jack", Status = true, Score = 80 });

            Console.WriteLine("\n === 非泛型陣列 ArrayList 操作需強制轉換 .... \n");
            foreach (var item in bcc)
            {
                if (item is Course)
                    Console.WriteLine("{0} ", item.ToString());
                else
                    Console.WriteLine("{0} ", (string)item);
            }
            Console.Read();
        }
    }
}
