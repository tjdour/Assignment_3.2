Console.WriteLine("Enter number of Rows of 2D array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of 2D array: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows, columns];


for (int i = 0; i < rows; i++)
{
    
    for (int j = 0; j < columns; j++)
    {

        Console.Write($"Enter values of matrix [{i}][{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("\nMatrix:");


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"| {matrix[i, j],3} ");
    }

    Console.WriteLine("|");
}

//matrix[i, j] = Convert.ToInt32(Console.ReadLine());