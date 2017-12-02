using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strassen
{
    class Strassen
    {
        public Strassen()
        {

        }


        //بررسی توانی از دو بودن
        public static bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public virtual int[,] addMatrices(int[,] A, int[,] B)
        {
            int n = ((int)Math.Sqrt(A.Length));

            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = A[i, j] + B[i, j];

            return result;
        }

        public virtual int[,] subtractMatrices(int[,] A, int[,] B)
        {
            int n = (int)Math.Sqrt(A.Length);
            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = A[i, j] - B[i, j];

            return result;
        }

        public virtual void divideArray(int[,] parent, int[,] child, int iB, int jB)
        {
            for (int i1 = 0, i2 = iB; i1 < (int)Math.Sqrt(child.Length); i1++, i2++)
                for (int j1 = 0, j2 = jB; j1 < (int)Math.Sqrt(child.Length); j1++, j2++)
                {
                    child[i1, j1] = parent[i2, j2];
                }
        }

        public virtual void copySubArray(int[,] child, int[,] parent, int iB, int jB)
        {
            for (int i1 = 0, i2 = iB; i1 < (int)Math.Sqrt(child.Length); i1++, i2++)
                for (int j1 = 0, j2 = jB; j1 < (int)Math.Sqrt(child.Length); j1++, j2++)
                {
                    parent[i2, j2] = child[i1, j1];
                }
        }

        //public virtual void classicalMatrixMultiplication(int[,] a, int[,] b, int[,] c)
        //{
        //    int n = (int)Math.Sqrt(a.Length);
        //    for (int i = 0; i < n; i++)
        //        for (int j = 0; j < n; j++)
        //            for (int k = 0; k < n; k++)
        //                c[i,j] += a[i,k] * b[k,j];
        //}

        public int[,] strassenMatrixMultiplication(int[,] A, int[,] B)
        {
            //اندازه ماتریس
            int n = (int)Math.Sqrt(A.Length);

            //ماتریس نتیجه
            int[,] result = new int[n, n];


            if ((n % 2 != 0) && (n != 1))
            {
                int[,] a1, b1, c1;
                int n1 = n + 1;
                a1 = new int[n1, n1];
                b1 = new int[n1, n1];
                c1 = new int[n1, n1];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        a1[i, j] = A[i, j];
                        b1[i, j] = B[i, j];
                    }
                c1 = strassenMatrixMultiplication(a1, b1);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        result[i, j] = c1[i, j];
                return result;
            }

            if (n == 1)
            {
                result[0, 0] = A[0, 0] * B[0, 0];
            }
            else
            {
                int[,] A11 = new int[(n / 2), (n / 2)];
                int[,] A12 = new int[n / 2, n / 2];
                int[,] A21 = new int[n / 2, n / 2];
                int[,] A22 = new int[n / 2, n / 2];

                int[,] B11 = new int[n / 2, n / 2];
                int[,] B12 = new int[n / 2, n / 2];
                int[,] B21 = new int[n / 2, n / 2];
                int[,] B22 = new int[n / 2, n / 2];

                divideArray(A, A11, 0, 0);
                divideArray(A, A12, 0, n / 2);
                divideArray(A, A21, n / 2, 0);
                divideArray(A, A22, n / 2, n / 2);

                divideArray(B, B11, 0, 0);
                divideArray(B, B12, 0, n / 2);
                divideArray(B, B21, n / 2, 0);
                divideArray(B, B22, n / 2, n / 2);

                int[,] P = strassenMatrixMultiplication(addMatrices(A11, A22), addMatrices(B11, B22));
                int[,] Q = strassenMatrixMultiplication(addMatrices(A21, A22), B11);
                int[,] R = strassenMatrixMultiplication(A11, subtractMatrices(B12, B22));
                int[,] S = strassenMatrixMultiplication(A22, subtractMatrices(B21, B11));
                int[,] T = strassenMatrixMultiplication(addMatrices(A11, A12), B22);
                int[,] U = strassenMatrixMultiplication(subtractMatrices(A21, A11), addMatrices(B11, B12));
                int[,] V = strassenMatrixMultiplication(subtractMatrices(A12, A22), addMatrices(B21, B22));

                int[,] C11 = addMatrices(subtractMatrices(addMatrices(P, S), T), V);
                int[,] C12 = addMatrices(R, T);
                int[,] C21 = addMatrices(Q, S);
                int[,] C22 = addMatrices(subtractMatrices(addMatrices(P, R), Q), U);

                copySubArray(C11, result, 0, 0);
                copySubArray(C12, result, 0, n / 2);
                copySubArray(C21, result, n / 2, 0);
                copySubArray(C22, result, n / 2, n / 2);
            }
            return result;

        }
        public static int[,] Parse(string text)
        {
            if (text == "")
            {
                return null;
            }
            try
            {
                text = text.Trim();
                string[] line = text.Split('\n');
                int n = line.Length;
                int lines = n;
              
                 if (n > 2)
                {
                    int temp = (int)Math.Sqrt(n);
                    temp++;
                    n = (int)Math.Pow(2, temp);
                }
                else if (n > 8)
                    return null;

                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = 0;


                for (int i = 0; i < lines; i++)
                {
                    string[] num = line[i].Split(' ');
                    if (num.Length > n)
                        return null;
                    for (int j = 0; j < num.Length; j++)
                    {
                        matrix[i, j] = int.Parse(num[j]);
                    }
                }
                return matrix;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
