//assignment 3.2.2

Console.WriteLine("Input the size of the square matrix (less than 5):");
int size = Convert.ToInt32(Console.ReadLine());

int[,] mat1 = new int[size, size];
int[,] mat2 = new int[size, size];
int[,] mat3 = new int[size, size];


//First matrix
Console.WriteLine("Input elements in the first matrix :");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"Enter matrix values [{i}],[{j}] :");
        mat1[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}

//second matrix
Console.WriteLine("Input elements in the second matrix :");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"Enter matrix values [{i}],[{j}] :");
        mat2[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}

//matrix addition and result
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {

        mat3[i, j] = mat1[i, j] + mat2[i, j];

    }
}


//Print first matrix
Console.WriteLine("\nThe First matrix is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat1[i, j],4}");
    }

    Console.WriteLine();
}

// Print second matrix
Console.WriteLine("\nThe Second matrix is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat2[i, j],4}");
    }

    Console.WriteLine();
}

// Print resulting matrix
Console.WriteLine("\nThe Addition of two matrices is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat3[i, j],4}");
    }

    Console.WriteLine();
}
Console.WriteLine("\nThe First matrix is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat1[i, j],4}");
    }

    Console.WriteLine();
}

// Print second matrix
Console.WriteLine("\nThe Second matrix is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat2[i, j],4}");
    }

    Console.WriteLine();
}

// Print resulting matrix
Console.WriteLine("\nThe Addition of two matrices is:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{mat3[i, j],4}");
    }

    Console.WriteLine();
}
