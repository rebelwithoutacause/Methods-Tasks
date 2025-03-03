//Write a program that:
//•	Reads an integer number N from the console
//•	Create a method for printing triangle depending on value of the number N

int num = int.Parse(Console.ReadLine());

PrintingTriangle(num);

static void PrintingTriangle(int num) 
{
    for (int row  = 1; row < num; row++) 
    {
    PrintLine(1, row);
    }
    for (int row = num; row >= 1; row--) 
    {
        PrintLine (1, row);
    }
}
static void PrintLine(int start, int end) 
{
for (int i = start; i <=end; i++) 
    {
        Console.Write($"{i} ");
    }
Console.WriteLine();
}