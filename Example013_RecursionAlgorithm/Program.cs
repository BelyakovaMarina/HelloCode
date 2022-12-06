//Пример1.
/*
string[,] table = new string[2, 5];
table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    { 
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

//Пример2.0 

/*
int[,] matrix = new int[3, 4];

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    { 
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/

//Пример2.1

/*
int[,] matrix = new int[3, 4];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    { 
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/

//Пример3 с методом. С дополнительным методом, который будет заполнять нашу матрицу случайными числами.


void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        { 
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        { 
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
