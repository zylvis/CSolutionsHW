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


        public List<(int row, int column, int value)> Elements { get; set; }


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

            Elements = new List<(int, int, int)>();
        }

        public void AddItem(int row, int column, int item)
        {
            Elements.Add((row, column, item));
        }
        public int this[int row, int column]
        {
            get
            {

                var tempList = Elements.Where(x => x.row == row && x.column == column).Select(x => x.value).ToList();
                if (tempList.Count < 1)
                {
                    return 0;
                }
                else
                {
                    return tempList[0];
                }


            }
            set { }
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
                        if (item.row == r && item.column == c)
                        {
                            builder.Append(item.value);
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
                        if (item.row == r && item.column == c)
                        {
                            yield return item.value;
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

            return Elements.OrderBy(x => x.column).ToList();
        }

        public int GetCount(int value)
        {
            if (value == 0)
            {
                return RowIndex * ColumnIndex - Elements.Count;
            }
            return Elements.Count(x => x.value == value);
        }
    }
}
