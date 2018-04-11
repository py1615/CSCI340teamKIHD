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

        /*public Matrix(double[,] entry)
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
        */


        public void setData(int row, int col, double data)
        {
            this.data[row, col] = data;
        }

        public Matrix add(Matrix m)
        {
            if(this.column != m.column || this.row != m.column)
                {
               throw new Exception("matrices size don't match");
                }
            Matrix sum = new Matrix(row,column);
            for(int i = 0; i < m.column; i++)
                {
                for(int j = 0; j < m.row; j++)
                    {
                    sum.data[i,j] = this.data[i,j] + m.data[i,j];
                    }
                }  
                return sum;
        }

        public Matrix subtract(Matrix m)
        {
            if(this.column != m.column || this.row != m.column)
                {
               throw new Exception("matrices size don't match");
                }
            Matrix sum = new Matrix(row, column);
            for(int i = 0; i < m.column; i++)
                {
                for(int j = 0; j < m.row; j++)
                    {
                    sum.data[i,j] = this.data[i,j] - m.data[i,j];
                    }
                }  
                return sum;
        }

        public Matrix transpose()
        {
            Matrix xTranspose = new Matrix(column, row);
            for(int i = 0; i < row; i ++)
            {
                for(int j = 0; j < column; j++)
                {
                    xTranspose.data[i, j] = data[j, i];
                }
            }
            return xTranspose;
        }

        public Matrix multiply(Matrix m)
        {
            if(column != m.row)
                {
                 throw new Exception("matrices size don't match");
                }
            Matrix multiplication = new Matrix(row, m.column);
            for(int i = 0; i < multiplication.row; i++)
                {
                for(int j = 0; j < multiplication.column; j++)
                    {
                    for(int k = 0; k < m.column; k++)
                        {
                        multiplication.data[i,j] += data[i,k]*m.data[k,j]; 
                        }
                   
                    }
                }

            return multiplication;
        }
        
        public Matrix multiply(double c)
        {
            Matrix multiplication = new Matrix(row, column);
            for(int i = 0; i < multiplication.row; i++)
                {
                for(int j = 0; j < multiplication.column; j++)
                    {
                    
                    multiplication.data[i,j] = c*data[i,j]; 
                    }
                }

            return multiplication;
        }

        public Matrix invert()
        {
             if(row != column)
                {
               throw new Exception("matrice is not square");
                }
            Matrix inverse = new Matrix(row, column);
            Matrix inverseTemp = new Matrix(row, 2*column);
            for(int i = 0; i < row; i++)
                {
                for(int j = column; j < 2*column; j++ )
                    {
                    inverseTemp.data[i, j] =  0;
                    }
                }

            Matrix tempRow1 = new Matrix(1, inverseTemp.column);
            Matrix tempRow2 = new Matrix(1, inverseTemp.column);
           
            for(int i = 1; i < inverseTemp.row; i++)
                {
                for(int j = 0; j < inverseTemp.column; j++)
                    {
                    tempRow1.data[1,j] = inverseTemp.data[i-1,j];
                    tempRow2.data[1,j] = inverse.data[i,j];
                    double firstEntryTemp1 = tempRow1.data[1,1];
                    double firstEntryTemp2 = tempRow2.data[1,1];
                    if(firstEntryTemp1 != firstEntryTemp2)
                        {
                        tempRow1 = tempRow1.multiply(firstEntryTemp2);
                        tempRow2 = tempRow2.multiply(firstEntryTemp1);
                        }
                    tempRow2 = tempRow2.subtract(tempRow1);
                    inverseTemp.data[i,j] = tempRow2.data[i,j];
                    }                
                }
            for(int i = 0; i < inverse.row; i++)
                {
                for(int j = 0; j < inverse.column; j++)
                    {
                    inverse.data[i,j] = inverseTemp.data[i,inverseTemp.column + j]; 
                    }
                }
            return inverse;
        }
       
    }
}
