using DiagonalMatrixT;

Matrix<int> matrix1 = new Matrix<int>(3);
Matrix<int> matrix2 = new Matrix<int>(3);
MatrixTracker<int> tracker = new MatrixTracker<int>(matrix1);

matrix1.ElementChanged += tracker.OnElementChanged;

for (int i = 0; i < matrix1.DiagonalElements.Length; i++)
{
    matrix1.DiagonalElements[i] = i;
   
}
 Console.WriteLine(matrix1);

matrix1.UpdateMatrix(0, 99, (i, j) => matrix1.DiagonalElements[i] != j);

Console.WriteLine(matrix1);

//for (int i = 0; i < matrix2.DiagonalElements.Length; i++)
//{
//    matrix2.DiagonalElements[i] = i;
//}


//Console.WriteLine(Convert.ToString(matrix1));



//matrix1.UpdateMatrix(0, 1, (x, y) => matrix1.DiagonalElements[x] != y);


//var sumOfMatrixes = matrix1.Add(matrix2, (a, b) =>
//{
//    Matrix<int> matrix = new Matrix<int>(matrix1.Size);
//    for (int i = 0; i < matrix.Size; i++)
//    {
//        matrix.DiagonalElements[i] = a.DiagonalElements[i] + b.DiagonalElements[i];
//    }
//    return matrix;
//});



//Console.WriteLine(matrix1.ToString());

//Console.WriteLine(sumOfMatrixes.ToString());

Console.WriteLine(tracker.Undo());



