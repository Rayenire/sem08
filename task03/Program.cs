int[, ] CreateMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x = new Random().Next(1, 1000);
            matrix[i , j] = x;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return matrix;
}

int[, ] matrix = new int[3, 3];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);


void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        int count = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if(array[i] == array[j] && i != j)
                count++;
        }
        Console.WriteLine(array[i] + " встречается " + count + " раз");
    }

}
