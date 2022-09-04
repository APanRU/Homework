// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
int[] array = new int[cube+1];
void Cube(int[] array)
{
  int index = 0;
  int length = array.Length;
  while (index <  length)
  {
    array[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}
void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 1;
  while(position < count)
  {
    Console.Write(col[position]+ " ");
    position++;
  }
} 
Cube(array);
PrintArray(array);
