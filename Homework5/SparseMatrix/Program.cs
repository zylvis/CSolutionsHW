

using SMatrix;

var matrix = new SparseMatrix(4, 5);

matrix.AddItem(0, 0, 1);
matrix.AddItem(0, 4, 2);
matrix.AddItem(3, 0, 1);
matrix.AddItem(3, 4, 4);

Console.WriteLine("OverrideToString: " + "\n" + matrix);

Console.WriteLine($"Indexer [0, 4]: { matrix[0, 4]}");
Console.WriteLine($"Indexer [0, 1]: { matrix[0, 1]}");

Console.WriteLine("All Elements: ");
foreach (var item in matrix)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine("Get No zero Elements by columns:");
foreach (var item in matrix.GetNoZeroElements())
{
    Console.Write(item.Item3);
}

Console.WriteLine();

Console.WriteLine("GetCount(1): " + matrix.GetCount(1));
Console.WriteLine("GetCount(0): " + matrix.GetCount(0));
Console.WriteLine();
Console.WriteLine("Print all matrix:");

bool isNotZero = false; 

for (int r = 0; r < matrix.RowIndex; r++)
{
    Console.WriteLine();
    for (int c = 0; c < matrix.ColumnIndex; c++)
    {
        foreach (var item in matrix.Elements)
        {
            if (item.row == r && item.column == c)
            {
                Console.Write(item.value);
                isNotZero = true;
            }
        }
        if (!isNotZero)
        {
            Console.Write(0);
        }
       isNotZero= false;
    }
}