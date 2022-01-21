

using SMatrix;

var matrix = new SparseMatrix(100, 100);

matrix.AddItem(0, 0, 1);
matrix.AddItem(0, 100, 2);
matrix.AddItem(100, 0, 3);
matrix.AddItem(100, 100, 4);

foreach (var item in matrix.Elements)
{
    Console.WriteLine(item.value);
}

Console.WriteLine($"Indexer: { matrix[2, 2]}");

Console.WriteLine(matrix);