using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class Matrix
    {
        private int column;
        private int row;
        private double[,] data;
        public Matrix(int theRow, int theCol)
        {
            row = theRow;
            column = theCol;
            data = new double[row, column];
        }
        public Matrix(double[,] entry)
        {
            row = entry.Rank;
            column = entry.GetLength(0);
            data = new double[row , column];
            for(int i = 0; i<row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    data[i,j] = entry[i, j];
                }
            }

        }
        public Matrix addData(Matrix m)
        {
            Matrix sum = new Matrix(row, column);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum.data[i, j] = data[i, j] + m.data[i,j];
                }
            }
            return sum;
        }
        public Matrix multiplication(Matrix m, Matrix n)
        {
            Matrix value = new Matrix(m.row, m.column);
            return value;
        }
        public Matrix transpose()
        {
            Matrix t = new Matrix(column, row);
            for(int i = 0; i < row; i ++)
            {
                for(int j = 0; j < column; j++)
                {
                    t.data[i, j] = data[j, i];
                }
            }
            return t;
        }
    }
}
