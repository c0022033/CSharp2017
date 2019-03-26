static void Main(string[] args)
{
    
    int[] array = new int[10] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };

    // 氣泡排序法，由小到大排序
    for (int i = 0; i < 10; i++)
    {
        for (int j = i + 1; j < 10; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(array[i]);
    }

    Console.Read();
}