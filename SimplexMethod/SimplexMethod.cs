using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexMethod
{
    public class SimplexMethod
    {
        public static void SimplexCalculateMax(double[,] matrix, double[] targetF)
        {
            int rows = matrix.GetLength(0);
            int colums = matrix.GetLength(1); 
            
            
            //базисные переменные
            List<int> basis = new List<int>();
            for (int i = 0; i < rows - 1; i++)
            {
                basis.Add(targetF.Length + i);
            }
            
            
            bool needCheck = true;
            while (needCheck)
            {
                
                //ищем ведущий столбец
                double minVal = double.MaxValue;  // --------------Целевой столбец
                int minIdxCol = -1;
                for (int i = 0; i < colums - 1; i++)
                {
                    // проходим по последней строке и ищем минимальный отрицательный
                    if (matrix[rows - 1, i] < 0 && matrix[rows - 1, i] < minVal)
                    {
                        minVal = matrix[rows - 1, i];
                        minIdxCol = i;
                    }
                }

                if (minIdxCol == -1)
                {
                    Console.WriteLine("Оптимальное решение -- все значения >= 0");
                    needCheck = false;
                    break;
                }
                
                //ищем ведущую строку
                double minValRow = double.MaxValue; // --------------Целевая строка
                int minIdxRow = -1;
                for (int i = 0; i < rows - 1; i++)
                {
                    // ищем только положительные, в качестве столбца берем найденный ранее ведущий
                    if (matrix[i, minIdxCol] > 1e-9)
                    {
                        double tempVal = matrix[i, colums - 1] / matrix[i, minIdxCol];
                        if (tempVal < minValRow)
                        {
                            minValRow = tempVal;
                            minIdxRow = i;
                        }
                    }
                }
                
                
                //Меняем в ведущей строке и столбце местами переменые

                basis[minIdxRow] = minIdxCol;
                
                //находим переменную
                double targetVal = matrix[minIdxRow, minIdxCol];
                
                //Применяем жордана гауса, делим строку на найденное целевое значение
                for (int i = 0; i < colums; i++)
                {
                    matrix[minIdxRow, i] /= targetVal;
                }
                
                // зануляем столбец
                for (int i = 0; i < rows; i++)
                {
                    // если еще не занулен и если это не ведущая строка
                    if (i != minIdxRow && Math.Abs(matrix[i, minIdxCol]) > 1e-9)
                    {
                        double temp = matrix[i, minIdxCol];
                        for (int j = 0; j < colums; j++)
                        {
                            matrix[i, j] -= temp * matrix[minIdxRow, j];
                        }
                    }
                }
            }
            
            Console.WriteLine($"целевая функция ---  {matrix[rows - 1, colums - 1]}");
            for( int i = 0; i < rows; ++i)
            {
                Console.WriteLine(matrix[i, colums - 1]);
            }
        }
    }
}
