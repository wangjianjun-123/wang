using System;

namespace ConsoleApp1
{
    //语法:[public]   enum 枚举名
    //{
    //    值1,
    //    值2，
    //    值3，
    //}
    public enum Gender   //定义一个男、女、的枚举
    {
        男,
        女
    }
    public enum Season  //定义一个四季的枚举
    {
        春,
        夏,
        秋,
        冬
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Gender Tom = Gender.男; //调用枚举Season -->汤姆是男性
            Gender Xiaomei = Gender.女;
            Season chun = Season.春;
            Season xia = Season.夏;
            Season qiu = Season.秋;
            Season don = Season.冬;
            Console.WriteLine("汤姆是{0}声，小梅是{1}生",Tom ,Xiaomei );
            Console.WriteLine("一年有四季分别是:\n{0}季\n{1}季\n{2}季\n{3}季",chun,xia ,qiu,don);
            Console.ReadKey();
        }
    }
}
