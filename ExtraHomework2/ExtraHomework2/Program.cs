Console.Write("Please input Jimmy's max jump height: ");
int jumpHeight = int.Parse(Console.ReadLine());

Console.Write("Please input the number of tower floors: ");
int tower = int.Parse(Console.ReadLine());

if (jumpHeight <= 0)
{
    Console.WriteLine("Jimmy couldn't jump at all so he never went to the tower.");
    return;
}
else if (tower == 0)
{
    Console.WriteLine("There was never a tower and Jimmy just sat at home and enjoyed a cold beer.");
    return;
}
else if (tower < 0)
{
    Console.WriteLine("Turns out the tower was a hole all along and Jimmy just went home dissapointed.");
    return;
}

int distanceResult = 0;

int[] array = new int[tower];

string jimmyResult = null;

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Please input the lenght of tower floor number " + (i + 1) + ": ");
    array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] <= jumpHeight)
    {
        distanceResult += array[i];
    }
    else
    {
        jimmyResult = "Sadly Jimmy couldn't reach the top of the tower. :(";
        break;
    }
    jimmyResult = "Jimmy managed to reach the top of the tower! 🎉";
}


Console.WriteLine("Jimmy has ascended a total distance of: " + distanceResult + ". " + jimmyResult);
