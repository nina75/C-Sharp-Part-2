//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

class AllocateArr
{
    static void Main()
    {
        var arr = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arr[i] = i * 5;
        }
        System.Console.WriteLine(string.Join(", ", arr));
    }
}
