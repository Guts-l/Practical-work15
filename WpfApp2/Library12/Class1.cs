using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Library12
{
    public class Mas
    {
        public static object MessageBox { get; private set; }

        public static void CreateArray(out int[] mas, int Count)
        {
            mas = new int[Count];
        }
        public static void FillArray(out int[] mas, int BeginningRange, int EndRange, int Count)
        {
            mas = new int[Count];
            Random Rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Rand.Next(BeginningRange, EndRange);
                if (mas[i] == 0) i--;
            }
        }
        public static void ClearArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++) mas[i] = 0;
        }
        public static void SaveArray(int[] mas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            if (mas != null)
            {
                if ((bool)save.ShowDialog())
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.WriteLine(mas.Length);
                    for (int i = 0; i < mas.Length; i++)
                        file.WriteLine(mas[i]);
                    file.Close();
                }
            }
        }
        public static void OpenArray(out int[] mas)
        {
            mas = new int[1];
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";
            if ((bool)open.ShowDialog())
            {
                StreamReader file = new StreamReader(open.FileName);
                int len = Convert.ToInt32(file.ReadLine());
                mas = new Int32[len];
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = Convert.ToInt32(file.ReadLine());
                file.Close();
            }
        }
    }
}
