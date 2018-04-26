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

        public void setData(int row, int col, double data)
        {
            this.data[row, col] = data;
        }

        public static Matrix operator+(Matrix m, Matrix n)
            {
            if(m.column != n.column || m.row != n.row)
                {
               throw new Exception("matrices size don't match");
                }
            Matrix sum = new Matrix(m.row,m.column);
            for(int i = 0; i < n.row; i++)
                {
                for(int j = 0; j < n.column; j++)
                    {
                    sum.data[i,j] = m.data[i,j] + n.data[i,j];
                    }
                }  
                return sum;
            }

        public static Matrix operator-(Matrix m, Matrix n)
            {
            if(m.column != n.column || m.row != n.row)
                {
               throw new Exception("matrices size don't match");
                }
            Matrix difference = new Matrix(m.row, m.column);
            for(int i = 0; i < n.row; i++)
                {
                for(int j = 0; j < n.column; j++)
                    {
                    difference.data[i,j] = m.data[i,j] - n.data[i,j];
                    }
                }  
                return difference;
            }

        public static Matrix operator*(Matrix m, Matrix n)
            {
            if(m.column != n.row)
                {
                 throw new Exception("matrices size don't match");
                }
            Matrix multiplication = new Matrix(m.row, n.column);
            for(int i = 0; i < multiplication.row; i++)
                {
                for(int j = 0; j < multiplication.column; j++)
                    {
                    for(int k = 0; k < n.column; k++)
                        {
                        multiplication.data[i,j] += m.data[i,k]*n.data[k,j]; 
                        }
                   
                    }
                }

            return multiplication;
            }

        public static Matrix operator*(double c, Matrix m)
            {
            Matrix multiplication = new Matrix(m.row, m.column);
            for(int i = 0; i < multiplication.row; i++)
                {
                for(int j = 0; j < multiplication.column; j++)
                    {
                    multiplication.data[i,j] = c*m.data[i,j]; 
                    }
                }
            return multiplication;
            }
       
        public Matrix transpose()
        {
            Matrix xTranspose = new Matrix(column, row);
            for(int i = 0; i < column; i ++)
            {
                for(int j = 0; j < row; j++)
                {
                    xTranspose.data[i, j] = data[j, i];
                }
            }
            return xTranspose;
        }

        private Matrix augment()
            {
            Matrix augmentedMatrix = new Matrix(row, 2*column);
            for(int i = 0; i < row; i++)
                {
                for(int k = 0; k < column; k++)
                    {
                    augmentedMatrix.data[i,k] = data[i,k];
                    }
                for(int j = column; j < 2*column; j++ )
                    {
                    if(j-column == i)
                        {
                        augmentedMatrix.data[i, j] = 1;
                        }
                    else augmentedMatrix.data[i, j] = 0;
                    }
                }
            return augmentedMatrix;
            }

       public Matrix invert()
       {
             if(row != column)
             {
               throw new Exception("matrice is not square");
             }
            Matrix inverse = new Matrix (row , column);
            Matrix augmented = augment();
            
            for(int i = 0; i < augmented.row; i++)
                {
                for(int k = 0; k < column; k++)
                    {
                    for(int j = 0; j < augmented.column; j++)
                        {
                        if(i != i+k)
                            {
                            augmented.data[i+k,j] = augmented.data[i,i] * augmented.data[i+k,j]
                                                   -augmented.data[i+k,i]* augmented.data[i,j];
                            }
                        }
                    }
                }
            for(int i = augmented.row - 1; i >= 0 ; i--)
                {
                for(int k = 0; k < column; k++)
                    {
                    for(int j = augmented.column - 1; j >= 0; j--)
                        {
                        if(i != i+k)
                            {
                            augmented.data[i-k,j] = augmented.data[i,i] * augmented.data[i-k,j]
                                                    -augmented.data[i-k,i]* augmented.data[i,j];
                            augmented.data[i-k,j] /= augmented.data[i,i];
                            }
                        }
                    }
                }

            for(int i = 0; i < inverse.row; i++)
                {
                for(int j = 0; j < inverse.column; j++)
                    {
                    inverse.data[i,j] = augmented.data[i, inverse.column+j];
                    }
                }
            return inverse;    
       }
    }
}
