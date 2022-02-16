using DiagonalMatrixT;

try
{
    Matrix<int> matrix1 = new Matrix<int>(3);
    Matrix<int> matrix2 = new Matrix<int>(3);

    Console.WriteLine("matrix1: " + matrix1);
    Console.WriteLine("matrix2: " + matrix2);

    matrix1[0, 0] = 1;
    matrix1[1, 1] = 2;
    matrix1[2, 2] = 3;

    matrix2[0, 0] = 11;
    matrix2[1, 1] = 22;
    matrix2[2, 2] = 33;

    Console.WriteLine("matrix1: " + matrix1);
    Console.WriteLine("matrix2: " + matrix2);

    MatrixTracker<int> tracker1 = new MatrixTracker<int>(matrix1);
    MatrixTracker<int> tracker2 = new MatrixTracker<int>(matrix2);

    Console.WriteLine("Undo tracker1: " + tracker1.Undo());
    Console.WriteLine("Undo tracker2: " + tracker2.Undo());


    var sumOfMatrixes = matrix1.Add(matrix2, (a, b) => a + b);
    Console.WriteLine("Sum of matrixes: " + sumOfMatrixes.ToString());

    matrix1[0, 0] = 100;
    matrix2[0, 0] = 200;

    Console.WriteLine("matrix1: " + matrix1);
    Console.WriteLine("matrix2: " + matrix2);

    Console.WriteLine("Undo tracker1: " + tracker1.Undo());
    Console.WriteLine("Undo tracker2: " + tracker2.Undo());
}

catch (Exception ex)
{
    Console.WriteLine("Sorry");
}