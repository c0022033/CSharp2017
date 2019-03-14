using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleList
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }      // 姓名屬性          
            public bool Status { get; set; }        // 本系生屬性
            public int Score { get; set; }           // 計概成績屬性

            //public override string ToString()    // 覆寫覆類別 ToString()方法
            // {
            //   return string.Format("姓名 : {0} \t 本系生 : {1} \t 成績  : {2} \n ", Name, Status ? "是" : "非", Score.ToString());
            //}
        }
        static void Main(string[] args)
        {
            List<Course> bcc = new List<Course>();   // 泛型           

            bcc.Add(new Course() { Name = "David", Status = true, Score = 85 });
            bcc.Add(new Course() { Name = "Mary", Status = false, Score = 95 });
            bcc.Add(new Course() { Name = "Tom", Status = true, Score = 75 });
            bcc.Add(new Course() { Name = "Jack", Status = true, Score = 80 });

            Console.WriteLine("\n  === 泛型  List  操作不需強制轉換 .... \n");
            foreach (var item in bcc)
            {
                Console.WriteLine("  姓名 : {0} \t 本系生 : {1} \t 成績 : {2} \n ", item.Name, item.Status ? "是" : "非", item.Score.ToString());
                // Console.WriteLine(item.ToString());  // 執行此行 會呼叫覆寫覆類別 ToString()方法
            }
            Console.Read();
        }
    }
}
