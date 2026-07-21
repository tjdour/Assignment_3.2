//Assignment 2.3.5

//prompt user for array size
Console.WriteLine("Enter array size: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrSize];

//prompt for values of array indices 
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter values of index[{i}]: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}


//prompt for number to find
Console.WriteLine("Enter a number 0-9 to find its index: ");
int toFind = Convert.ToInt32(Console.ReadLine());

//call function and show result
int result = FindIndex(numbers, toFind);
Console.WriteLine(result);



//find index method
int FindIndex (int[] numbers, int toFind)
{
    for (int i = 0; i < numbers.Length; i++)
    {


        if (numbers[i] == toFind)
        {
        return i;
            
        }

        //return -1;
    }
    return -1;
}
