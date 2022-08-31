

int[,] Method = (number)
int temp = 0;
{   
    if(i < number.GetLength(1))
    {
        if (j < number.GetLength(0))
        {   
            if(number[i, j - 1] < number[i, j])
            temp = (number[i, j - 1]);
            number[i, j - 1] = number[i, j];
            number[i, j] = temp;

            j--;


        }
        i++;
    }
    return num;
}

int[,] number = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},};

int[,] num = Method(int[,] number, 0);

