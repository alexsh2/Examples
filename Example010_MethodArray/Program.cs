Console.Clear();

int[] array = { 1, 28, 3, 471, 5, 6, 3, 773, 80 };
int index = 0;

int n = array.Length;
int find = 3;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}