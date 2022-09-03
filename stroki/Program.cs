// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

int[,] arr = {{1,4,7,2},
              {5,9,2,3},
              {8,4,2,4},
              {5,2,6,7},};

int Method3(int i, int j)
{   
    int mintemp = 0;
    if (i == 0)
    {
        for(j = 0; j < arr.GetUpperBound(0)+1; j++)
        {
            int cmin = 0;
            cmin = arr[i, j];
            mintemp = mintemp + cmin;
        }
    }
    return mintemp;
}

int Method4(int i, int j, int mintemp)
{   
    int c = 0;
    int result = 0;
    int min = mintemp;
    int index = 0;
    for(i = 0; i < arr.GetUpperBound(0)+1; i++)
    {
        int temp = 0;
        for(j = 0; j < arr.GetUpperBound(0)+1; j++)
        {
            c = arr[i, j];
            temp = temp + c;
        }
        if(temp <= mintemp)
        {
            min = temp;
            index = i + 1;
        }
    }
    result = index;
    return result;
}

int mintemp = Method3(0, 0);

int res = Method4(0, 0, mintemp);
Console.WriteLine("Наименьшая сумма в строке " + res);













// void SelectionSort(int[,] array)
// {
//     int i = 0;
//     for(i=0; i < array.GetUpperBound(0)+1;i++)
//     {
//         int j = 0;
//         for(j=0; j < array.GetUpperBound(0)+1; j++)
//         {
//             int g = j + 1;
//             while(g < array.GetUpperBound(0)+1)
//             {
//              if(arr[i, j] < arr[i, g])
//                 {
//                     int temporary = arr[i, j];
//                     arr[i, j] = arr[i, g];
//                     arr[i, g] = temporary;
//                 }
//                 g++;
//             }      
//         }
//     }   
// }

// PrintArray(arr);
// Console.WriteLine();
// SelectionSort(arr);
// PrintArray(arr);