using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_12
{
    public class Practice
    {
        public static int Sum(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 15)
                    sum += mas[i];
            }
            return sum;
        }
    }
}
