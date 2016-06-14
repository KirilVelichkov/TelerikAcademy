namespace Defining_Classes___Part_2
{
    using System;
    using System.Text;
    [Version(1, 0)]
    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result.Append(this.matrix[i, j].ToString() + " ");
                }
                result.Append("\r\n").Append("\r\n");
            }
            return result.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0))
                || (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
            {
                throw new ArgumentException("Matrixes can't be with different dimentions");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0))
               || (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
            {
                throw new ArgumentException("Matrixes can't be with different dimentions");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0))
                || (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
            {
                throw new ArgumentException("Matrixes can't be with different dimentions");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));

            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    result[r, c] += (dynamic)m1[r, c] * (dynamic)m2[r, c];
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return !isTrue;
        }

        public static bool operator !(Matrix<T> matrix)
        {
            if (matrix)
            {
                return false;
            }
            return true;
        }


    }
}
