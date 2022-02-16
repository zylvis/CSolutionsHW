using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMatrix
{
    internal class SparseMatrix : IEnumerable<int>
    {

        public int RowIndex { get; private set; }
        public int ColumnIndex { get; private set; }

        public Dictionary<(int row, int column), int> Elements { get; set; }

        public SparseMatrix(int rowIndex, int colIndex)
        {
            if (rowIndex < 1)
            {
                throw new ArgumentOutOfRangeException("Row Size can't be Zero");
            }
            else
            {
                RowIndex = rowIndex;
            }

            if (colIndex < 1)
            {
                throw new ArgumentOutOfRangeException("Column Size can't be Zero");
            }
            else
            {
                ColumnIndex = colIndex;
            }

            Elements = new Dictionary<(int row, int column), int>();
        }


        public int this[int row, int column]
        {
            get
            {
                if (Elements.TryGetValue((row, column), out int result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                if (value != 0)
                {
                    Elements.Add((row, column), value);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            bool isNotZero = false; ;

            for (int r = 0; r < RowIndex; r++)
            {
                builder.Append(Environment.NewLine);
                for (int c = 0; c < ColumnIndex; c++)
                {
                    foreach (var item in Elements)
                    {
                        if (item.Key.row == r && item.Key.column == c)
                        {
                            builder.Append(item.Value);
                            isNotZero = true;
                        }
                    }
                    if (!isNotZero)
                    {
                        builder.Append(0);
                    }
                    isNotZero = false;
                }
            }
            return builder.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {

            bool isNotZero = false; ;

            for (int r = 0; r < RowIndex; r++)
            {

                for (int c = 0; c < ColumnIndex; c++)
                {
                    foreach (var item in Elements)
                    {
                        if (item.Key.row == r && item.Key.column == c)
                        {
                            yield return item.Value;
                            isNotZero = true;
                        }
                    }
                    if (!isNotZero)
                    {
                        yield return 0;
                    }
                    isNotZero = false;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<(int, int, int)> GetNoZeroElements()
        {
            List<(int row, int column, int value)> list = new List<(int, int, int)>();

            foreach (var item in Elements)
            {
                list.Add((item.Key.row, item.Key.column, item.Value));
            }

            return list.OrderBy(x => x.column).ToList();
        }

        public int GetCount(int value)
        {
            if (value == 0)
            {
                return RowIndex * ColumnIndex - Elements.Count;
            }
            return Elements.Count(x => x.Value == value);
        }
    }
}
