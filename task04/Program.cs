int[, ] CreateMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //int x = Convert.ToInt32(Console.ReadLine());
            int x = new Random().Next(1, 100);
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


void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int minrow = 1000;
    int kmin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
        }
        if (sumrow < minrow)
        {
            minrow = sumrow;
            kmin = i + 1;
        }
    }
    Console.WriteLine(minrow + " " + kmin);

}

int[, ] matrix = new int[3, 3];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);