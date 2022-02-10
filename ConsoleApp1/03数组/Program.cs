using System;

namespace _03数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组的定义赋值和取值
            //数组类型[] 数组名 = new 数组类型[数组长度]
            //数组的声明方式
            //int[] nums = new int[10];//定义一个数组开辟了10个空间，但空间都没有赋值，如果赋值
            //int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] nums2 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] nums3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //string[] str = new string[10]; //字符串数组
            //bool[] bools = new bool[10];   //布尔数组
            //nums[0] = 1;//如果下标少可以这样赋值
            //nums[1] = 2;
            //nums[2] = 3;
            //nums[3] = 4;
            //nums[4] = 5;
            //nums[5] = 6;
            //nums[6] = 7;
            //nums[7] = 8;
            //nums[8] = 9;
            //nums[9] = 10;
            //Console.WriteLine(nums[8]);
            //如果数组数量多我们就要用循环来实现用for循环
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            #endregion
            #region  数组练习1
            //从一个整数数组中去除最大的整数，最小的整数，总和，平均值
            //int[] numbers = { -1, -2, -3, -4, -5, -6, -7, -8, -9 };  //定一个数组
            //int  max = numbers[0];  //定仪一个最大整数变量
            //int min = numbers[0];   //定仪一个最小整数变量
            //int nums = 0;           //定义一个总和变量
            //for (int i = 0; i < numbers.Length; i++)  //循环这个数组
            //{
            //    if ( numbers[i] >max )  //判断如果这个数组里的最大值大于定义的最大变量
            //    {
            //        max = numbers[i];   //把数组里的最大值赋值给定义的最大值
            //    }
            //    if (numbers[i] < min)   //判断数组里的最小值小于定义的最小值
            //    {
            //        min = numbers[i];   //把数组里的最小值赋值给定义的最小值
            //    }
            //    nums += numbers[i];     //每次循环数组里的值累加到定义好的总和变量里
            //}
            //Console.WriteLine("最大值{0}最小值{1}总和{2}平均值{3}",max,min,nums,nums/numbers.Length); //打印出最大值、最小值、总和、平均值
            //int[] nums = { -1, 2, 3, 4, -5, 6, 7, -8, 9, 0 };
            //int max = nums[0];
            //int min = nums[0];
            //int num = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    num += nums[i];
            //}
            //Console.WriteLine("最大值{0} 最小值{1} 总和{2} 平均值{3}",max,min,num,num/nums.Length);


            #endregion
            #region  字符串数组练习2
            ////数组里都是人名字，{老杨、老苏、老邹、老虎、老牛、老将、老王、老马}
            ////分割成列如 老杨|老苏|老邹|.....老马最后面没有竖线
            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老将", "老王", "老马" };
            //string a = null;  //定义一个字符串便变量
            ////解题思路：
            ////通过循环获得每一个字符串数组的元素
            ////然后将每一个元素都累加到一个字符串中以 | 分割
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    a += names[i]+"|";  //每循环一次把字符串数组里的元素累加到a里

            //}
            //Console.WriteLine(a + names[names.Length-1]);//打印出每次循环的元素
            #endregion
            #region  数组练习3
            //将一个整数数组的每一个元素进行以下处理
            //如果元素是整数将这个元素的位置加以，如果是负数则减一如果是0则不变
            //int[] nums = { -8, 8, -45, 22, 8, 6, 25, -36, -77, 12, -100, 100 ,0};
            //Console.WriteLine("原数组里的元素");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("  {0}",nums[i]);
            //}
            //Console.WriteLine();
            ////解题思路：
            ////循环遍历数组的每一个元素
            ////判断数组里的每一个元素如果元素大于0每个元素自身加以
            ////如果每个元素里有小于0则自身减一 遇到0则不变
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }
            //    else
            //    {
            //        nums[i] = 0;
            //    }
            //}
            //Console.WriteLine("改变数组后的元素");
            //for (int i = 0; i < nums.Length ; i++)
            //{
            //    Console.Write("  {0}",nums[i]);
            //}
            //int[] nums = { 11, 2, 5, 28, 29, -7, -8, -55, -66, 0 };
            //for (int i = 0; i < 10; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }
            //    if (nums[i] == 0)
            //    {

            //    }
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("  {0}",  nums[i]);
            //}
            #endregion
            #region 练习4
            //将数组里的字符串进行反转
            //{"我","是","好人"}
            //string[] names = { "我", "是", "好人" };
            //Console.WriteLine("交换前");
            //for (int i = 0; i < names.Length; i++)  //循环遍历定义数组的元素
            //{
            //    Console.Write("{0}  ",names[i]);  //打印出所有元素
            //}
            //for (int i = 0; i < names.Length/2; i++)  //循环要对换数组里的元素
            //{
            //    string temp = names[i];  //声明一个第三方变量来接受数组里的i的字符串当i是 0 names[i]的值是"我"
            //    names[i] = names[names.Length - 1 - i];  //意思是数组里索引的长度减一
            //                                             //再减去遍历 i 的索引值等于跟当前数组里所处的位置
            //    names[names.Length - 1 - i] = temp;      //把names[i]赋值给要对换的值
            //}
            //Console.WriteLine();
            //Console.WriteLine("交换后");
            //for (int i = 0; i < names.Length; i++)
            //{
            //Console.Write("{0}  ", names[i]);
            //}
            //int[] numbers = { 1, -2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 14, 15, 16, 17, 18, 19, 20,0 };
            //    for (int i = 0; i<numbers.Length / 2; i++)
            //    {
            //        int number = numbers[i];
            //numbers[i] = numbers[numbers.Length - 1 - i];
            //        numbers[numbers.Length - 1 - i] = number;
            //    }
            //    for (int i = 0; i<numbers.Length; i++)
            //    {
            //        Console.Write("{0}  ", numbers[i]);
            //    }
            #endregion
            #region  冒泡排序
            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //for (int i = 0; i < nums.Length-1; i++)  //要实现降序用for嵌套来实现外面要循环一次里面要循环n次
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)  //
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}

            //Array.Sort(nums); //最简单的方法就是用array数组调用sort方法实现降序
            //对数组进行反转
            //Array.Reverse(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            #endregion
            Console.ReadKey();
        }
    }
}
