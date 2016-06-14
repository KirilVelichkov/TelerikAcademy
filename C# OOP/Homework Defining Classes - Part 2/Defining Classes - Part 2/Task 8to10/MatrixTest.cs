using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2.Task_8to10
{
    class MatrixTest
    {
        [Version(1, 0)]
        public static void TestMatrix()
        {
            Console.WriteLine("---- Testing Task 8 ----");
            int row = 4;
            int col = 3;
            var matrix1 = new Matrix<string>(row, col);
            var matrix2 = new Matrix<string>(row, col);
            var intMatrix1 = new Matrix<int>(row, col);
            var intMatrix2 = new Matrix<int>(row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = "String" + i + "," + j;
                    matrix2[i, j] = "String" + (i * -1) + "," + (j * -1);
                    intMatrix1[i, j] = i + j;
                    intMatrix2[i, j] = (i + j) * -1;
                }
            }

            Console.WriteLine("----String Matrix 1----");
            Console.WriteLine(matrix1);
            Console.WriteLine("----String Matrix 2----");
            Console.WriteLine(matrix2);
            Console.WriteLine("----String Matrix 1 + String Matrix 2----");
            var matrix3 = matrix1 + matrix2;
            Console.WriteLine(matrix3);

            Console.WriteLine("----Int Matrix 1----");
            Console.WriteLine(intMatrix1);
            Console.WriteLine("----Int Matrix 2----");
            Console.WriteLine(intMatrix2);
            Console.WriteLine("----Int Matrix 1 + Int Matrix 2----");
            var intMatrix3 = intMatrix1 + intMatrix2;
            Console.WriteLine(intMatrix3);
            Console.WriteLine("----Int Matrix 1 * Int Matrix 2----");
            intMatrix3 = intMatrix1 * intMatrix2;
            Console.WriteLine(intMatrix3);
            Console.Write("Int Matrix 1 - Non-Zero elements: ");
            if (!intMatrix1)
            {
                Console.WriteLine(false);
            }else
            {
                Console.WriteLine(true);
            }

        }
    }
}
