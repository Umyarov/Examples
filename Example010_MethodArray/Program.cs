int[] array = {12, 23, 18, 41, 15, 64, 17, 18};
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


