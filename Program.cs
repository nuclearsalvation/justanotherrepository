int number = 0;
number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 0;
int boundary = 3;
string[] array = new string[number];
while (i < number)
{
    array[i] = Console.ReadLine();
    if (array[i].Length <= boundary)
    {
        count++;
    }
    i++;
}
i = 0;
int j = 0;
string[] arrayOutput = new string[count];
while (i < number)
{
    if (array[i].Length <= boundary)
    {
        arrayOutput[j] = array[i];
        j++;
    }
    i++;
}
Console.WriteLine();
i = 0;
while (i < count)
{
    Console.WriteLine(arrayOutput[i]);
    i++;
}