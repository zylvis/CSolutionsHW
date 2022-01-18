using DiagonalMatrixT;

try
{
    Matrix<int> matrix1 = new Matrix<int>(3);
    Matrix<int> matrix2 = new Matrix<int>(3);
    MatrixTracker<int> tracker1 = new MatrixTracker<int>(matrix1);
    MatrixTracker<int> tracker2 = new MatrixTracker<int>(matrix1);

    matrix1.ElementChanged += tracker1.OnElementChanged;
    matrix2.ElementChanged += tracker2.OnElementChanged;

    Console.WriteLine("matrix1: " + matrix1);
    Console.WriteLine("matrix2: " + matrix2);

    matrix1.UpdateMatrix(0, 99, (i, j) => matrix1.DiagonalElements[i] != j);
    Console.WriteLine("Updated matrix1: " + matrix1);

    matrix2.UpdateMatrix(2, 55, (i, j) => matrix2.DiagonalElements[i] != j);
    Console.WriteLine("Updated matrix2: " + matrix2);

    var sumOfMatrixes = matrix1.Add(matrix2, (a, b) =>
    {
        Matrix<int> matrix = new Matrix<int>(matrix1.Size);
        for (int i = 0; i < matrix.Size; i++)
        {
            matrix.DiagonalElements[i] = a.DiagonalElements[i] + b.DiagonalElements[i];
        }
        return matrix;
    });

    Console.WriteLine("Sum of matrixes: " + sumOfMatrixes.ToString());

    Console.WriteLine("Undo tracker1: " + tracker1.Undo());
    Console.WriteLine("Undo tracker2: " + tracker2.Undo());


}
catch (Exception ex)
{
    Console.WriteLine("exeption");
}