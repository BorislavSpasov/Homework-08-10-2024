int countHundred = 1;
int rowNum = 2;
while (countHundred < 100)
{
    Console.WriteLine(rowNum);
    rowNum = rowNum * -1;
    if (countHundred % 2 == 0)
    {
        rowNum = rowNum + 1;
    }
    else
    {
        rowNum = rowNum - 1;
    }
    countHundred = countHundred + 1;
}