namespace DataStructures
{
    public static class Arrays
    {
        public static int[,] RotateMatrixClockwise(int[,] oldMatrix)
        {
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)]; //Set new dimension

            for (int oldColumnIndex = 0, newRowIndex = 0;
                oldColumnIndex >= 0 && newRowIndex < oldMatrix.GetLength(1);
                oldColumnIndex++, newRowIndex++)
            {
                for (int oldRowIndex = oldMatrix.GetLength(0) - 1, newColumnIndex = 0;
                    oldRowIndex >= 0 && newColumnIndex < oldMatrix.GetLength(0);
                    oldRowIndex--, newColumnIndex++)
                {
                    newMatrix[newRowIndex, newColumnIndex] = oldMatrix[oldRowIndex, oldColumnIndex];
                }
            }
            return newMatrix;
        }

        public static int[,] RotateMatrixCounterClockwise(int[,] oldMatrix)
        {
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];//Set new dimension

            for (int oldColumnIndex = oldMatrix.GetLength(1) - 1, newRowIndex = 0;
                oldColumnIndex >= 0;
                oldColumnIndex--, newRowIndex++)
            {
                for (int oldRowIndex = 0, newColumnIndex = 0;
                    oldRowIndex < oldMatrix.GetLength(0);
                    oldRowIndex++, newColumnIndex++) //Zero to last
                {
                    newMatrix[newRowIndex, newColumnIndex] = oldMatrix[oldRowIndex, oldColumnIndex];
                }

            }
            return newMatrix;
        }




    }
}
