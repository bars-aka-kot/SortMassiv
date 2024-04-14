class SortMassiv
{
    static void Main(string[] args)
    {
        int[,] massiv = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        int k = massiv.GetLength(0);
        int l = massiv.GetLength(1);

        int[] array = new int[k*l];

        int z = 0;
        for (int i = 0; i < l; i++)
        {   
            for (int j = 0; j < k; j++)
            {
                array[z] = massiv[i,j];
                z++;
            }
        }

        Array.Sort(array);
        z = 0;

        for (int i = 0; i < l; i++)
        {
            for(int j=0;j< k; j++)
            {
                massiv[i,j] = array[z];
                z++;
                Console.Write(massiv[i,j] + " ");
            }
           Console.WriteLine();
        }        
    }
}