using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] ints = new int[i];
            string btnMenu = "";
            while (btnMenu != "выйти")
            {
                btnMenu = "";
                while (true)
                {
                    Console.WriteLine("Введите число, чтобы добавить его в массив или букву Q чтобы закончить ввод");
                    string number = Console.ReadLine();
                    int num = 0;
                    if (int.TryParse(number, out num))
                    {
                        var bufInts = ints;
                        ints = new int[++i];
                        bufInts.CopyTo(ints, 0);
                        ints[i - 1] = num;
                    }
                    else if (number.ToLower() == "q")
                    {
                        string s = "array: ";
                        foreach (var item in ints)
                            s += item.ToString() + " ";
                        Console.WriteLine(s);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Для выхода из цикла введите Q");
                    }
                };
                while (!new string[] { "выйти", "продолжить" }.Contains(btnMenu))
                {
                    Console.WriteLine("Выберите действие:\n- Очистить\n- Продолжить\n- Выйти");
                    btnMenu = Console.ReadLine().ToLower();
                    if (btnMenu == "очистить")
                    {
                        i = 0;
                        ints = new int[i];
                        Console.WriteLine("Массив успешно очищен!");
                    }
                }
            }
        }
    }
}
