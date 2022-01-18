using DiagonalMatrixT;

Matrix<int> matrix1 = new Matrix<int>(3);
Matrix<int> matrix2 = new Matrix<int>(3);
MatrixTracker<int> tracker = new MatrixTracker<int>(matrix1);

matrix1.ElementChanged += tracker.OnElementChanged;


Console.WriteLine(matrix1);

matrix1.UpdateMatrix(0, 99, (i, j) => matrix1.DiagonalElements[i] != j);
matrix2.UpdateMatrix(2, 55, (i, j) => matrix1.DiagonalElements[i] != j);
Console.WriteLine(matrix1);
Console.WriteLine(matrix2);


var sumOfMatrixes = matrix1.Add(matrix2, (a, b) =>
{
    Matrix<int> matrix = new Matrix<int>(matrix1.Size);
    for (int i = 0; i < matrix.Size; i++)
    {
        matrix.DiagonalElements[i] = a.DiagonalElements[i] + b.DiagonalElements[i];
    }
    return matrix;
});

Console.WriteLine(sumOfMatrixes.ToString());



Console.WriteLine(tracker.Undo());



