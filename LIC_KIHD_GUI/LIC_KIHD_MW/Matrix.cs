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
        public void addData(int row, int col, double data)
        {

        }
        public Matrix multiplication(Matrix m, Matrix n)
        {
            Matrix value = new Matrix();
            return value;
        }
        public Matrix transpose(Matrix x)
        {
            return x;
        }
    }
}
