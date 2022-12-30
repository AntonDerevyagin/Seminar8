// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int ReadInt(string message)
{
  Console.Write(message);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray(int[,] matr)
{
for ( int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]}");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for ( int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
}
}
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = ReadInt("Введите число строк 1-й матрицы: ");
int n = ReadInt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = ReadInt("Введите число столбцов 2-й матрицы: ");
int range = ReadInt("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
FillArray(secomdMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);


