using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwaitLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建线程 开启线程
            new Thread(Test1).Start();// .NET 1.0开始就有的

            Task.Factory.StartNew(Test1); // .NET 4.0 引入了 TPL

            Task.Run(new Action(Test1)); // .NET 4.5 新增了一个Run的方法

        }

        public static void Test1()
        {
            Console.WriteLine("哈哈,我其实是另一个线程");
        }
    }
}
