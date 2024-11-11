Console.Write("How long would you like the number squence to be: ");
int repetitions = int.Parse(Console.ReadLine());

if (repetitions <= 0)
{
    Console.WriteLine("Please restart the program and input a positive number!");
}
else
{
    int outputNum = 1;
    int counter = 0;
    int addingNum = 2;

    while (counter < repetitions)
    {
        Console.Write(outputNum + ", ");

        outputNum *= 2;
        outputNum += addingNum;
        addingNum -= 1;

        counter++;
    }
}