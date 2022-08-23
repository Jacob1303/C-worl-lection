// Двумерные массивы

//string[,] table = new string[2,3]; , в [] после string указывает что используется 2 размерности: строки и столбцы

// в [] после new string указано количество строчек и столбцов нам необходимо

// в примере выше - таблица строк. В примере ниже - таблица чисел, она же матрица;

//int[,] matrix = new int[5,8]; 

// индексация элементов массива от 0. Пример: первый элемент первой строки: table[0,0]
// первый элемент второй строки table[1,0]

// string[,] table = new string[2,5];
// table[1,2] = " слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // знаки - около {} позволил обозначить все пустые элементы массива
//     }

// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matr.GetLength(0) - индикатор количества строк в массиве matr
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matr.GetLength(1) - индикатор количества столбцов в массиве matr
        {
            Console.Write($"{matr[i, j]} "); // знаки - около {} позволил обозначить все пустые элементы массива
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i,j] =new Random().Next(1,11);  
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
