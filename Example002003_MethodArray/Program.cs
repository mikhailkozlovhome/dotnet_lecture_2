// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result;
// }

int[] array = { 1, 2, 31, 4, 18, 15, 61, 17, 18, 19 };

int n =array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
