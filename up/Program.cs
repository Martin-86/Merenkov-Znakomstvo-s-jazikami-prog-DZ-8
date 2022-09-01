int[,] arr = {{1,4,7,2},
              {5,9,2,3},
              {8,4,2,4},};


void PrintArray(int[,] array)

{
    int[,] matrix = new int[3, 4];

    for (int i = 0; i < array.GetLength(0); i++)   // matrix.GetLength(0) - берет количество строк(0 означает строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // matrix.GetLength(1)- означает столбцы(1)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void SelectionSort(int[,] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)
    {
        for(int j =0; j < array.Length - 1 ; j++)
        {
            int maxPosition = j;

            for (int g = j + 1; g < array.Length; g++)
            {
                if(array[i, g] > array[i, maxPosition]) maxPosition = g;  
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);






// int[] arr = {1,4,7,2};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1 ; i++)
//     {
//         int maxPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//           if(array[j] > array[maxPosition]) maxPosition = j;  
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);