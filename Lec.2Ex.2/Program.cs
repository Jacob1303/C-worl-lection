int[] array = { 1, 3, 5, 56, 56, 6565, 432, 54543, 2323 };

int n = array.Length;
int find = 6565;
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