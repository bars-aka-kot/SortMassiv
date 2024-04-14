class SortMassiv
{
    static void Main(string[] args)
    {
        int[,] massiv = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int[] array = new int[massiv.GetLength(0) * massiv.GetLength(1)];
        int z = 0;

        PrintMatrix(massiv, "Первоначальная матрица");
        for (int i = 0; i < massiv.GetLength(1); i++)
        {
            for (int j = 0; j < massiv.GetLength(0); j++)
            {
                array[z] = massiv[i, j];
                z++;
            }
        }
        PrintArray(array,"Несортированный одномерный массив");
        Array.Sort(array);
        PrintArray(array, "Сортированный одномерный массив");

        z = 0;

        for (int i = 0; i < massiv.GetLength(1); i++)
        {
            for (int j = 0; j < massiv.GetLength(0); j++)
            {
                massiv[i, j] = array[z];
                z++;
            }
        }
        PrintMatrix(massiv, "Сортированная матрица");
    }
    public static void PrintArray(int[] arr,string text)
    {
        Console.WriteLine($"{text}");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void PrintMatrix(int[,] matrix, string text)
    {
        Console.WriteLine($"{text}");
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}