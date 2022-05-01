using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя");
        string userName = Console.ReadLine();
        Console.WriteLine("Введите символ");
        string userSimbol = Console.ReadLine();
        int OutputStringLength = 2 + Convert.ToInt32(userName.Length);
        Console.WriteLine("\n");

        for (int i = OutputStringLength; i > 0; i--)
        {
            Console.Write(userSimbol);
        }
        Console.WriteLine($"\n{userSimbol}{userName}{userSimbol}");

        for (int i = OutputStringLength; i > 0; i--)
        {
            Console.Write(userSimbol);
        }
        Console.WriteLine("\n");
    }
}