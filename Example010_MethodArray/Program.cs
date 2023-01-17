int[] array = { 12, 15, 44, 96, 75, 13, 62, 33 };

int n = array.Length;
int find = 62;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}