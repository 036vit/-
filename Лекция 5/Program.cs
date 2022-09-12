// string[,] table = new string[2,5];
// table[1,2] = "слово";

//  for (int rows = 0; rows < 2; rows++)
//  {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
//  }



 // Прямоуголная матрица чисел, где 3 строки и 4 столбца
 // Перебор указываем цифрами
//  int[,] matrix = new int[3, 4];
 
//  for (int i = 0; i < 3; i++)
//  {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
//  }

// Прямоуголная матрица чисел, где 3 строки и 4 столбца
 // Перебор указываем переменной длинны массива
//  int[,] matrix = new int[3, 4];
 
//  for (int i = 0; i < matrix.GetLength(0); i++)
//  {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
//  }


// Создаём метод вывода матрицы
 void PrintArray(int[,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
   {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
   }
 }
// Создаём метод наполнения матрицы
 void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
 {
for (int j = 0; j < matr.GetLength(1); j++)
   {
    matr[i,j] = new Random().Next(1,10);
   }
 }
}
 int[,] matr = new int[3, 4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);