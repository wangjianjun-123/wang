using System;

namespace _04方法
{
    public enum Gender  //枚举
    {
        男,
        女
           
    }
    public struct Person  //类
    {
        public string _name;
        public int _age;
        public Gender _gender;
        public string _telephone;
    }
    
    class Program
    {
        public static int _b = 30; //定义一个静态字段也叫全局变量；
        static void Main(string[] args)
        {
            #region 函数（方法）的调用
            //计算两个整数之间的最大值
            //int number = Program.GatMax(9,2);//有返回值括号里写内容并且用一个变量来接受
            //Console.WriteLine("最大值是{0}",number);//打印出这个结果
            //Program.KaiShi();//没有返回值的调用
            //Program.KaiShi();//没有返回值的调用
            //Program.ChaoJi();//没有返回值的调用
            //Program.ChaoJi();
            //Program.KaiShi();
            //Program.KaiShi();
            //Program.KaiShi();
            //Console.ReadKey();
            #endregion
            #region  复习
            //复习 常量、枚举、结构、数组
            //const double p = 3.14;
            //const int a1 = 10;
            //const string laohu = "老虎";
            //Console.WriteLine(p+a1+laohu );
            //Gender tom = Gender.男;
            //Gender xl = Gender.女;
            //Console.WriteLine(tom);
            //Console.WriteLine(xl);
            //Person zsperson;
            //zsperson._name = "张三";
            //zsperson._gender = Gender.男;
            //zsperson._age = 20;
            //zsperson._telephone = "139209258793";
            //Console.WriteLine("我叫{0}我是{1}生我今年{2}岁我的电话号码是{3}",
            //                   zsperson._name,zsperson._gender,zsperson._age,zsperson._telephone);
            //int[] nums = { 3, 6, 8, 9, 45, 76, 36, 42, 55, 64, 69 };
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            #endregion
            //int a = 3;  //Main函数里定义一个变量来调用Test函数
            //int s= Test(_b);  //用新的变量来接受方法的值
            Test(_b);  //调用函数
            Console.WriteLine(Test(_b));
            Console.ReadKey();
        }
        #region 定义函数
        /// <summary>
        /// 计算两个整数的最大值并且返回最大值
        /// </summary>
        /// <param name="a1">第一个整数</param>
        /// <param name="a2">第二个整数</param>
        /// <returns></returns>
        public static int GatMax(int a1,int a2)
        {
            return a1 > a2 ? a1 : a2;
        }
        /// <summary>
        /// 正常游戏
        /// </summary>
        /// <param name=""></param>
       public static void KaiShi()
        {
            
            //闪烁 播放一段特殊的背景音乐 屏幕停止
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶"); 
        }
       /// <summary>
       /// 无敌
       /// </summary>
        public static void ChaoJi()
        {
            Console.WriteLine("突然，顶了一个无敌");
            Console.WriteLine("屏幕开始闪烁");
            Console.WriteLine("播放背景音乐");
            Console.WriteLine("屏幕停止");
        }
        #endregion
        /// <summary>
        /// 定义一个函数来调用静态字段
        /// </summary>
        /// <param name="a">形参</param>
        /// <returns></returns>
        public static int Test(int a)
        {
            a = a + 5;
            return a;
        }

    }
}
