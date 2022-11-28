// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

int A = int.Parse(ReadLine()); 
int B = int.Parse(ReadLine()); 
Degree (A, B);

void Degree(int A, int B)
{
    int result = 0;
    for (int i = 1; i <= B; i++)
     {
        result = Convert.ToInt32(Math.Pow(A, B));
     }
    WriteLine(result);
}
  


