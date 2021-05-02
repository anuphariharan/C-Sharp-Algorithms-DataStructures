namespace DataStructures
{
    public static class Arrays
    {
        public static int[,] RotateMatrixClockwise(int[,] oldMatrix)
        {
            //Solution : Assign and get oldRowIndex, oldColumnIndex and then assign it to the new Matrix newRowIndex, newColumnIndex.
            #region OldMatrixDimension Length
            int oldMatrixRowLength = oldMatrix.GetLength(0);
            int oldMatrixColumnLength = oldMatrix.GetLength(1);
            #endregion

            int[,] newMatrix = new int[oldMatrixColumnLength, oldMatrixRowLength]; //Set new dimension

            for (int oldColumnIndex = 0, newRowIndex = 0;
                oldColumnIndex < oldMatrixColumnLength && newRowIndex < oldMatrixColumnLength;
                oldColumnIndex++, newRowIndex++)
            {
                for (int oldRowIndex = oldMatrixRowLength - 1, newColumnIndex = 0;
                    oldRowIndex >= 0 && newColumnIndex < oldMatrixRowLength;
                    oldRowIndex--, newColumnIndex++)
                {
                    
                    newMatrix[newRowIndex, newColumnIndex] = oldMatrix[oldRowIndex, oldColumnIndex];
                }
            }
            return newMatrix;
        }

        public static int[,] RotateMatrixCounterClockwise(int[,] oldMatrix)
        {
            //Solution : Assign and get oldRowIndex, oldColumnIndex and then assign it to the new Matrix newRowIndex, newColumnIndex.
            #region OldMatrixDimension Length
            int oldMatrixRowLength = oldMatrix.GetLength(0);
            int oldMatrixColumnLength = oldMatrix.GetLength(1);
            #endregion

            int[,] newMatrix = new int[oldMatrixColumnLength, oldMatrixRowLength];//Set new dimension

            for (int oldColumnIndex = oldMatrixColumnLength - 1, newRowIndex = 0;
                oldColumnIndex >= 0;
                oldColumnIndex--, newRowIndex++)
            {
                for (int oldRowIndex = 0, newColumnIndex = 0;
                    oldRowIndex < oldMatrixRowLength;
                    oldRowIndex++, newColumnIndex++) //Zero to last
                {
                    newMatrix[newRowIndex, newColumnIndex] = oldMatrix[oldRowIndex, oldColumnIndex];
                }

            }
            return newMatrix;
        }


        public static int[,] MakeRowAndColumZero(int[,] matrix)
        {
            int[,] MakeZero(int[,] matrix, int rowNumber, int columnNumber)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[rowNumber, i] = 0;
                }
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, columnNumber] = 0;
                }
                return matrix;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        MakeZero(matrix, i, j);
                        i++;
                    }
                }
            }
            return matrix;
        }
    }
}
