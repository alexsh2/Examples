Console.Clear();

void FillArray(int[] collection, int range)
{
    int len = collection.Length;
    int ind = 0;
    while (ind < len)
    {
        collection[ind] = new Random().Next(1, range);
        ind++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int range = 30;
int[] array = new int[range];

FillArray(array, range);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 10);
Console.WriteLine(pos);