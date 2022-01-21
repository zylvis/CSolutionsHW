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
        public int RowIndex { get; }
        public int ColumnIndex { get; }

        public List<(int row, int column, int value)> Elements { get; set; }


        public SparseMatrix(int rowIndex, int columnIndex)
        {
            this.RowIndex = rowIndex;
            this.ColumnIndex = columnIndex;
            Elements = new List<(int, int, int)>();
        }

        public void AddItem(int row, int column, int item)
        {
            Elements.Add((row, column, item));
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in Elements)
            {
                builder.Append($"{ item.row}, {item.column}, { item.value}");
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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
    }
}
