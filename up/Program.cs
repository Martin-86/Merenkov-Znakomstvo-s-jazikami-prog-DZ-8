﻿int[,] number = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},};
int row = 0;
int column = 0;
int step = 1;
int temp = 0;
while(row < number.GetLength(0))
{
    while(column < number.GetLength(0))
    {

        if ((number[row, column]) < (number[row,(column + step)]))
        {
            temp = number[row, column];
            number[row, column] = number[row, column + step];
            number[row, column + step] = temp;
            step++;

        }
        step++;
    }
    row++;

    for(int i = 0; i < number.GetLength(0); i++)
        {
            for(int j = 0; j < number.GetLength(0); j++)
            {
                Console.Write(number[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
