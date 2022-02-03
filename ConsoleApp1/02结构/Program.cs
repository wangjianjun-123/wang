using System;

namespace _02结构
{
    public struct Person
    {
        public string _name;   //姓名
        public int _age;       //年龄
        public Gender _gender;   //性别
        public int _grade;     //年级（拽的）
    }
    public enum Gender
    {
        男,
        女
    }
    public struct MyColor
    {
        public int _reg;
        public int _green;
        public int _blue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构的定义和应用
            //某某大学管理系统
            //姓名、性别、年龄、年级 
            //string zsName = "张三";  //如果大学有5000人就得定义20000个变量，工作量很大也很麻烦，
            //char zsGender = '男';    //这是就出现了结构来解决这个庞大的工作量
            //int zsAge = 18;
            //int zsGrade = 3;
            Person zsperson; //实列化一个张三结构
            zsperson._name = "张三";
            zsperson._age = 18;
            zsperson._gender = Gender.男;
            zsperson._grade = 3;

            Person lsperson;  //实列化一个李四结构
            lsperson._name = "李四";
            lsperson._age = 20;
            lsperson._gender = Gender.男;
            lsperson._grade = 3;

            Person xmperson;  //实列化一个小梅的结构
            xmperson._name = "小梅";
            xmperson._age = 19;
            xmperson._gender =Gender.女;
            xmperson._grade = 3;

            Person wwperson;  //实列化一个王五的结结构
            wwperson._name = "王五";
            wwperson._age = 18;
            wwperson._gender = Gender.男;
            wwperson._grade = 3;

            Person zgperson;   //实列化一个赵刚的结结构
            zgperson._name = "赵刚";
            zgperson._age = 18;
            zgperson._gender =Gender.男;
            zgperson._grade = 3;

            Person zjperson;   //实列化一个张静的结结构
            zjperson._name = "张静";
            zjperson._age = 18;
            zjperson._gender = Gender.女;
            zjperson._grade = 1;

            Console.WriteLine(zsperson._name);
            Console.WriteLine("{0}岁",zsperson._age);
            Console.WriteLine(zsperson._gender);
            Console.WriteLine("{0}年级",zsperson._grade);

            #endregion
            #region 结构练习1
            MyColor mc; //实列化mycolor结构来实现红颜色
            mc._reg = 255;
            mc._green = 0;
            mc._blue = 0;

            MyColor hei;  //实列化mycolor来实现黑色
            hei._reg = 0;
            hei._green = 0;
            hei._blue = 0;
            
            Console.WriteLine(mc);
            Console.WriteLine(hei);


            Console.ReadKey();
            #endregion
        }
    }
}



