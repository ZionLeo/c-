using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请选择运算符号(+、-、*、/)");
                Operation oper;
                oper = OperationFactory.createOperate(Convert.ToString(Console.ReadLine()));
                Console.Write("请输入数字A:");
                oper.NumberA = Convert.ToDouble(Console.ReadLine());
                Console.Write("请输入数字B:");
                oper.NumberB = Convert.ToDouble(Console.ReadLine());
                double result = oper.GetResult();
                Console.WriteLine("结果是：" + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有误：" + ex.Message);
                //Console.ReadKey();
            }
        }
    }
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        //虚方法，在子类中重写
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    //新建符号类，继承运算类
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                Console.Write("除数不能为0.");
            result = NumberA / NumberB;
            return result;
        }
    }

    class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }

}
