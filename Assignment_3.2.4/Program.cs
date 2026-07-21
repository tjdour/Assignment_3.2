//Assignment 3.2.4


//int[] nums = [2, 5, 6, 8];

Console.Write("Enter the first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
int third = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the fourth number: ");
int fourth = Convert.ToInt32(Console.ReadLine());

Calcs(out int total, out double average, first, second, third, fourth);

Console.WriteLine(
    $"The average of {first}, {second}, {third}, {fourth} is: {average}"
);

Console.WriteLine($"The total is {total}");

//Calcs(out int total, out double average, nums);
//Console.WriteLine($"Total: {total}");
//Console.WriteLine($"Average: {average}");
static void Calcs(out int total, out double average, params int[] nums)
{

    total = 0;

    foreach (int i in nums)
    {
        total += i;
    }

    average = (double)total / nums.Length;



}