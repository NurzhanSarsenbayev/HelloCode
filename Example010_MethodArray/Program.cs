int[] array = { 11, 32, 23, 14, 15, 16, 14, 18 };

int n = array.Length;
int find = 14;

int index = 0;

while(index<n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}