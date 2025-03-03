int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(numberOne, numberTwo));

static int MathPower(int numberOne, int numberTwo) 
{
    int result = 1;
    
    for (int i = 1; i <= numberTwo; i++) 
    {
        result *= numberOne; 
    }
    return result;
}