int[,] arr = {{1,4,7,2},
              {5,9,2,3},
              {8,4,2,4},};

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] array)
{
    int i = 0;
    for(i=0; i < array.GetUpperBound(0)+1;i++)
    {
        int j = 0;
        for(j=0; j < array.GetUpperBound(0)+2; j++)
        {
            int g = j + 1;
            while(g < array.GetUpperBound(0)+2)
            {
             if(arr[i, j] < arr[i, g])
                {
                    int temporary = arr[i, j];
                    arr[i, j] = arr[i, g];
                    arr[i, g] = temporary;
                }
                g++;
            }      
        }
    }   
}

PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
