﻿using System;
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

        public int getRow()
        {
            return row;
        }

        public int getCol()
        {
            return column;
        }

        public void setData(int row, int col, double data)
        {
            this.data[row, col] = data;
        }

        public double getData(int row, int col)
        {
            return this.data[row, col];
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
                    for(int k = 0; k < m.column; k++)
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

        
       public Matrix invert()
       {
             if(row != column)
             {
               throw new Exception("matrice is not square");
             }
            Matrix inverse = new Matrix (row , column);
            Matrix augmented = augment();
            
            
            augmented.rowOperation();
            augmented = augmented.rearrange();
            augmented.rowOperation();
            augmented.normalize();
            augmented = augmented.rearrange();

            for (int i = 0; i < inverse.row; i++)
            {
                for (int j = 0; j < inverse.column; j++)
                {
                    //inverse.data[i, j] = augmented.data[augmented.row - 1 - i, inverse.column + j];
                    inverse.data[i, j] = augmented.data[i, inverse.column + j];
                }
            }

            return inverse;    
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

        public void rowOperation()
        {
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < row - i; k++)
                {
                    if (i != i + k)
                    {
                        double divisor = firstNonZero(this, i + k);
                        double multiplier = data[i + k, i];
                        for (int j = 0; j < column; j++)
                        {
                            data[i + k, j] = data[i, i] * data[i + k, j]
                                                   - multiplier * data[i, j];
                            data[i + k, j] /= divisor;
                        }
                    }
                }
            }
        }
        

        public Matrix rearrange()
        {
            Matrix newMatrix = new Matrix(row, column);
            for (int i = 0; i < newMatrix.row; i++)
            {
                for (int j = 0; j < newMatrix.column / 2; j++)
                {
                    newMatrix.data[i, j] = data[row - 1 - i, (column - 1)/2 - j];
                }
            }

            for(int i = 0; i < newMatrix.row; i++)
            {
                for (int j = newMatrix.column / 2; j < newMatrix.column; j++)
                {
                    newMatrix.data[i, j] = data[row - 1 - i, j];
                }
            }
            return newMatrix;
        }

        public void normalize()
        {
            for(int i = 0; i<row; i++)
            {
                if(data[i,i] == 0)
                    {
                    throw new Exception("inverse matrix doesn't exist");
                    }
                double divisor = data[i,i];
                for(int j = 0; j < column; j++)
                {
                    data[i, j] /= divisor;
                }
            }
        }

        public double firstNonZero(Matrix m, int row)
            {
            double divisor = 0;
            for(int i = 0; i< m.column; i++)
                {
                if(m.data[row,i]!=0) 
                    {
                    divisor = m.data[row,i];
                    return divisor;
                    }
                }
            return divisor;
            }


    }
}

