Console.Clear();


var sheep = new bool[] { true, true, false, true, false, false, };


int count = 0;

for (int i = 0; i < sheep.Length; i++)
{
    if (sheep[i] == true)
    {
        count++;
        Console.WriteLine(count + " sheep are here");
    }
}
