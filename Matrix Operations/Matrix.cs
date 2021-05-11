using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOP
{
    public class Matrix
    {
        private double[,] mat;
        public Matrix(int rows, int cols)
        {
            mat = new double[rows, cols];
        }
        //Matrix x = Matrix.Parse(MatrixA.Text)
        public static Matrix Parse(string data)
        {
            Matrix m = null;
            string[] Rows = data.Split("\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int row = Rows.Length;
            int col = 0;

            for (int r = 0; r < row; ++r)
            {
                string[] Cols = Rows[r].Split("\t ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    col = Cols.Length;
                    m = new Matrix(row, col);
                }
                else if (col != Cols.Length) throw new ArgumentException("Unregular matrix data");
                for (int c = 0; c < col; ++c)
                {
                    m[r, c] = double.Parse(Cols[c]);
                }
            }
            return m;
        }
        public int RowCount { get { return mat.GetLength(0); } }
        public int ColCount { get { return mat.GetLength(1); } }
        public double this[int r,int c]
        {
            get
            {
                return mat[r, c];
            }
            set
            {
                mat[r, c] = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int row = RowCount;
            int col = ColCount;
            for(int r =0; r< row; ++r)
            {
                for(int c=0; c<col; ++c)
                {
                    if (c > 0) sb.Append(' ');
                    sb.Append(string.Format("{0,10:F3}", mat[r, c]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int row = a.RowCount;
            int col = a.ColCount;
            if (row != b.RowCount) throw new ArgumentException("Unequal row sizes");
            if (col != b.ColCount) throw new ArgumentException("Unequal col sizes");
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    m[r, c] = a[r, c] + b[r, c]; 
                }
                
            }
            return m;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            int row = a.RowCount;
            int col = a.ColCount;
            if (row != b.RowCount) throw new ArgumentException("Unequal row sizes");
            if (col != b.ColCount) throw new ArgumentException("Unequal col sizes");
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    m[r, c] = a[r, c] - b[r, c];
                }

            }
            return m;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int row = a.RowCount;
            int col = b.ColCount;
            int height = a.ColCount;
            if (height != b.RowCount) throw new ArgumentException("Unequal row sizes");
            
            Matrix m = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < col; ++c)
                {
                    for(int h=0;h<height;++h) m[r, c] += a[r, h] * b[h, c];

                }

            }
            return m;
        }

        public static Matrix solve(Matrix a, Matrix b)
        {
            int row = a.RowCount, acol = a.ColCount, bcol = b.ColCount, col = acol + bcol;
            if (row != acol) throw new ArgumentException("Must be square");
            if (row != b.RowCount) throw new ArgumentException("Matrix row count must be equal");
            Matrix tmp = new Matrix(row, col);
            for (int r = 0; r < row; ++r)
            {
                for (int c = 0; c < acol; ++c)
                {
                    tmp[r, c] = a[r, c];
                }
                for (int c = 0; c < bcol; ++c)
                {
                    tmp[r, acol + c] = b[r, c];
                }
            }
            for (int d = 0; d < row; ++d)
            {
                double div = tmp[d, d];
                for (int r = 0; r < row; ++r)
                {
                    if (d == r) continue;
                    double mul = tmp[r, d] / div;
                    for (int c = 0; c < col; ++c)
                    {
                        tmp[r, c] -= tmp[d, c] * mul;
                    }
                }
            }
            Matrix ret = new Matrix(row, bcol);

            for (int d = 0; d < row; ++d)
            {
                double div = tmp[d, d];
                for (int c=acol; c < col; ++c)
                {
                    ret[d,c - acol] = tmp[d,c] / div;
                }       
            }
            return ret;
        }
    }
}
