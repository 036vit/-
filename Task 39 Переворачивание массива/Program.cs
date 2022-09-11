//Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте а первый - на последнем и т.д.)

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse (Console.ReadLine());
int [] array = FillArray(size, 1, 10);
Console.WriteLine("Входящий массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Join(" ", array.Reverse()));

int [] FillArray(int size, int min, int max){
    int[] result = new int[size];
    for(int i = 0; i < size;i++){
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}