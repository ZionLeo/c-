using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExample2
{
    /// <summary>
    /// 定义Fram类
    /// </summary>
    class Fram
    {
        public int x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.WriteLine("请选择1-5 对应着 加 / 减 / 乘 / 除 / 比较两个数是否相等 ");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        // Add();
                        string c, d;
                        Console.WriteLine("请输入两个字符");
                        c = Convert.ToString(Console.ReadLine());
                        d = Convert.ToString(Console.ReadLine());
                        Add(c, d);
                        break;

                    case 2:
                        //JianFa();
                        string a, b;
                        Console.WriteLine("请输入两个字符");
                        a = Convert.ToString(Console.ReadLine());
                        b = Convert.ToString(Console.ReadLine());
                        break;


                    case 3:
                        Mul();
                        break;


                    case 4:
                        Div();
                        break;

                    case 5:
                        Equals();
                        break;
                }
            }
        }
        public static void Equals()
        {
            Fram sc = new Fram();
            int a, b;
            Console.WriteLine("请输入要比较的两个数");
            sc.x = Convert.ToInt32(Console.ReadLine());
            sc.y = Convert.ToInt32(Console.ReadLine());
            a = sc.x; b = sc.y;
            if (a.Equals(b))
            {
                Console.WriteLine("这两个数相等");
            }
            else
            {
                Console.WriteLine("这两个数不相等");
            }
        }
        public static void Add()
        {
            int a, b;
            Fram sc = new Fram();
            Console.WriteLine("请输入第一个加数和第二个加数");
            sc.x = Convert.ToInt32(Console.ReadLine());
            sc.y = Convert.ToInt32(Console.ReadLine());
            a = sc.x; b = sc.y;
            int num = a + b;
            try
            {
                Console.WriteLine(a + b);
            }
            catch
            {
                if (a == null || b == null)
                {
                    Console.WriteLine("请重新输入数字");
                }
            }
            finally
            {
                Console.WriteLine("结束");
            }
            Console.WriteLine("两数相加得：" + num);
        }
        public static void Add(string c, string d)
        {
            Console.Write("c+d=");
            Console.WriteLine(c + d);

        }
        public static void JianFa()
        {
            int a, b;
            Fram sc = new Fram();
            Console.WriteLine("请输入第一个减数和第二个减数");
            sc.x = Convert.ToInt32(Console.ReadLine());
            sc.y = Convert.ToInt32(Console.ReadLine());
            a = sc.x; b = sc.y;
            int num = a - b;
            try
            {
                Console.WriteLine(a - b);
            }
            catch
            {
                if (a == null || b == null)
                {
                    Console.WriteLine("请重新输入数字");
                }
            }
            finally
            {
                Console.WriteLine("结束");
            }
            Console.WriteLine("两数相减得：" + num);
        }
        public static void JianFa(string a, string b)
        {
            Console.Write("a-b=");
            Console.WriteLine("{0}-{1}", a, b);
        }
        public static void Mul()
        {
            int a, b;
            Fram sc = new Fram();
            Console.WriteLine("请输入第一个乘数和第二个乘数");
            sc.x = Convert.ToInt32(Console.ReadLine());
            sc.y = Convert.ToInt32(Console.ReadLine());
            a = sc.x; b = sc.y;
            int num = a * b;
            try
            {
                Console.WriteLine(a * b);
            }
            catch
            {
                if (a == null || b == null)
                {
                    Console.WriteLine("请重新输入数字");
                }
            }
            finally
            {
                Console.WriteLine("结束");
            }
            Console.WriteLine("两数相乘得：" + num);
        }
        public static void Div()
        {
            int a, b;
            Fram sc = new Fram();
            Console.WriteLine("请输入被除数和除数");
            sc.x = Convert.ToInt32(Console.ReadLine());
            sc.y = Convert.ToInt32(Console.ReadLine());
            a = sc.x; b = sc.y;

            try
            {
                Console.WriteLine("两数整除相得：{0}/{1}", a, b);
            }
            catch
            {
                Console.WriteLine("分母不能为0");
            }
            finally
            {
                Console.WriteLine("结束");
            }

        }
    }
}
