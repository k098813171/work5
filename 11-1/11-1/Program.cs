using System;

class Math1
{
    public static int 平方(int 整數)
    {
        return 整數 * 整數;
    }
    public static double 平方(double 小數)
    {
        return 小數 * 小數;
    }
    public static int 最小值(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }
    public static int 最小值(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}

class 程式
{
    static void Main(string[] args)
    {
        Console.WriteLine("整數 4 的平方: " + Math1.平方(4));
        Console.WriteLine("小數 2.5 的平方: " + Math1.平方(2.5));
        Console.WriteLine("三個數中的最小值 (7, 2, 5): " + Math1.最小值(7, 2, 5));
        Console.WriteLine("四個數中的最小值 (9, 4, 6, 1): " + Math1.最小值(9, 4, 6, 1));
    }
}
