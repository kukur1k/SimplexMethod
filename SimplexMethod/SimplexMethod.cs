using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexMethod
{
    public class SimplexMethod
    {
        public static void SimplexCalculateMax(int[,] matrix, int[] targetF)
        {
            //Ограниченияb и значения (x1, x2, x3 ...)
            List<int> limitsList = new List<int>();
            for (int i = 0; i < targetF.Length; i++)
            {
                if (targetF[i] == 0)
                {
                    limitsList.Add(i++);
                }
            }

            int[] limits = limitsList.ToArray();
            int [] values = new int[matrix.GetLength(1)];

            //минимальный отрицательный для Ведущего столбца
            int minVal = int.MaxValue;
            int minIdx = 0;
            for (int i = 0; i < targetF.Length; i++)
            {
                if (targetF[i] < 0 && targetF[i] < minVal)
                {
                    minVal = targetF[i];
                    minIdx = i;
                }
            }


            // пересчет для выбора Ведущей строки
            double minStringVal = int.MaxValue;
            int minStringIdx = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double tempVal = matrix[-1, minIdx] / matrix[i, minIdx];
                if (tempVal < minVal && tempVal > 0 && matrix[i, minIdx] != 0)
                {
                    minStringVal = tempVal;
                    minStringIdx = i;
                }
            }


            //Меняем в ведущей строке и столбце местами переменые

        }
    }
}
