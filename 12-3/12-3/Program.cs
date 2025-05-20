using System;

class Program
{
    delegate double 單位轉換(double 數值);

    static double 英呎轉英寸(double 英呎)
    {
        return 英呎 * 12;
    }

    static double 英碼轉英寸(double 英碼)
    {
        return 英碼 * 3 * 12;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("請輸入要轉換的單位：英呎 或 英碼");
        string 單位 = Console.ReadLine()?.ToLower();

        Console.WriteLine("請輸入數值：");
        double 數值 = Convert.ToDouble(Console.ReadLine());

        單位轉換 轉換方法;

        if (單位 == "英呎")
        {
            轉換方法 = new 單位轉換(英呎轉英寸);
        }
        else if (單位 == "英碼")
        {
            轉換方法 = new 單位轉換(英碼轉英寸);
        }
        else
        {
            Console.WriteLine("不支援的單位。");
            return;
        }

        double 結果 = 轉換方法(數值);
        Console.WriteLine($"{數值} {單位} 等於 {結果} 英寸");
    }
}