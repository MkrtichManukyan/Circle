
int cricliY = 10;

for (int y = -cricliY; y <= cricliY; y++)
{
	for (int x = -cricliY; x <= cricliY; x++)
	{
        double distance = Math.Sqrt(x * x + y * y);
        if (distance <= cricliY)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}