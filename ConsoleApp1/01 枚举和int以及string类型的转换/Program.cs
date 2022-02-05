using System;

namespace _01_枚举和int以及string类型的转换
{
    public enum QQState
    {
        Onlin=1, //在线
        Offlin,  //离线
        Leave,   //离开
        Busy,    //忙碌
        Qme      //Q我

    }
    public enum Gerden
    {
        男=1,
        女
          
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转换成 int 类型
            //QQState state = QQState.Onlin;
            //枚举类型默认可以跟int类型互相转换、枚举类型跟int类型是兼容的
            //定义了一个int类型的变量把枚举强制转换为int型
            //int n = (int)state;  //将枚举强制转换为int类型
            //Console.WriteLine(n); //查看枚举转换为int的值
            //Console.WriteLine((int)QQState .Offlin);//查看枚举转换为int的值
            //Console.WriteLine((int)QQState .Leave);//查看枚举转换为int的值
            //Console.WriteLine((int)QQState .Busy);//查看枚举转换为int的值
            //Console.WriteLine((int)QQState .Qme);//查看枚举转换为int的值

            //int a = (int)QQState.Onlin;
            //int b = (int)QQState.Offlin;
            //int c = (int)QQState.Leave;
            //int d = (int)QQState.Busy;
            //int e = (int)QQState.Qme;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //int aa = (int)QQState.Onlin;
            //int bb = (int)QQState.Offlin;
            //int cc = (int)QQState.Busy;
            //int dd = (int)QQState.Leave;
            //int ee = (int)QQState.Qme;
            //Console.WriteLine("qq的状态有5中模式:\n{0}离线\n{1}在线\n{2}忙碌\n{3}离开\n{4}q我",aa,bb,cc,dd,ee);
            #endregion
            #region  将int类型强转换为枚举类型
            //int n1 = 1;
            //int n2 = 2;
            //QQState state1 = (QQState)n1;
            //QQState state = (QQState)n2;
            //Console.WriteLine(state1);
            //Console.WriteLine(state);
            //while (true)
            //{


            //    Console.WriteLine("请输入1-5查看QQ状态模式");  //提示用户输入信息
            //    try
            //    {
            //        int a = Convert.ToInt32(Console.ReadLine()); //输入的字符串转换为int类型
            //        QQState aa = (QQState)a;  
            //        if (a == 1)
            //        {
            //            Console.WriteLine("在线");
            //        }
            //        else if (a == 2)
            //        {
            //            Console.WriteLine("离线");
            //        }
            //        else if (a == 3)
            //        {
            //            Console.WriteLine("离开");
            //        }
            //        else if (a == 4)
            //        {
            //            Console.WriteLine("忙碌");
            //        }
            //        else if (a >= 6)
            //        {
            //            Console.WriteLine("只能输入1到5，其余数字非法程序请继续输入1到5的数字");
            //        }
            //        else
            //        {
            //            Console.WriteLine("q我");

            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入有误程序退出");
            //        break;
            //    }
            //}


            #endregion
            #region 用switch case语句来完成int转换为枚举实现QQ状态模式
            //while (true)
            //{
            //    Console.WriteLine("请输入1到5查看QQ状态模式");
            //    try
            //    {
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        switch (number)
            //        {
            //            case 1:
            //                Console.WriteLine("在线");
            //                break;
            //            case 2:
            //                Console.WriteLine("离线");
            //                break;
            //            case 3:
            //                Console.WriteLine("离开");
            //                break;
            //            case 4:
            //                Console.WriteLine("忙碌");
            //                break;
            //            case 5:
            //                Console.WriteLine("q我");
            //                break;
            //            case 6:
            //                Console.WriteLine("只能输入1到5的整数，其余数字无效");
            //                break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入非法程序退出");
            //        break;
            //    }
            //}
            //枚举转换int类型
            //int a = (int)QQState.Onlin; //如果想把枚举转换成int类型先定义一个int型变量来接受强制转换
            //int转换枚举类型
            //int number1 = 1;
            //QQState a1 = (QQState)number1;
            //Console.WriteLine(a);
            //Console.WriteLine(a1);

            #endregion
            #region 将枚举类型转换成字符串
            //所有类型都能够转换成string类型
            // int n1 = 10;         //int转换string
            //double n1 = 3.14;     //double 转换字符串
            //decimal n1 = 5000m;   //金钱转换字符串
            //string s = n1.ToString();//就是要转换的变量名后面点一个ToString();就成功转换
            //Console.WriteLine(s);
            //枚举类型转换字符串
            //QQState a = QQState.Onlin; //枚举QQState里去一个元素Onlin
            //string state = a.ToString();//把Onlin元素转换成字符串转换公式变量点一个ToString();
            //QQState nnn = QQState.Offlin;
            //string aa= nnn.ToString();
            //Console.WriteLine(state);
            //Console.WriteLine(aa);


            #endregion
            #region  将字符串转换为枚举
            //string s = "2";
            //将s转换成枚举类型
            //QQState state = (QQState)s;这个式子是转换不了
            //将字符串转换为整数类型有三种 Convert.Toint32() int.parse()  int.tryparse()
            //QQState a = (QQState)Enum.Parse(typeof(QQState), s);
            //Gerden d = (Gerden)Enum.Parse(typeof(Gerden), s);
            //Console.WriteLine(a);
            //Console.WriteLine(d);
            
            while (true)
            {
                Console.WriteLine("请输入数字1到5来查看QQ状态模式1-onlin、2-offlin、3-leave、4-busy、5-Qme");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        QQState a1 = (QQState)Enum.Parse(typeof(QQState), input);
                        Console.WriteLine("{0}", a1);
                        break;
                    case "2":
                        QQState a2 = (QQState)Enum.Parse(typeof(QQState), input);
                        Console.WriteLine("{0}", a2);
                        break;
                    case "3":
                        QQState a3 = (QQState)Enum.Parse(typeof(QQState), input);
                        Console.WriteLine("{0}", a3);
                        break;
                    case "4":
                        QQState a4 = (QQState)Enum.Parse(typeof(QQState), input);
                        Console.WriteLine("{0}", a4);
                        break;
                    case "5":
                        QQState a5 = (QQState)Enum.Parse(typeof(QQState), input);
                        Console.WriteLine("{0}", a5);
                        break;
                    default:
                        Console.WriteLine("只能输入1到5的整数");
                        break;

                }
                Console.ReadKey();
            }
            
            #endregion

        }

    }
}
