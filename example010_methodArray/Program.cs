int[] array = {1,21,3,42,53, 82,46,76,82};

int n = array.Length;
int find = 82;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}