using static System.Console;
Clear();

WriteLine("Введите количество эл-тов в массиве: ");
int N = Int32.Parse(ReadLine());

FillArray(N);


void FillArray(int collection)
{
    int [] length = new int [collection];

    for (int i = 0; i < collection; i ++)
    {
        
        length[i] = new Random().Next(-100,100); // Заполняем массив рандомными числами
    }
    Write("[");
    for (int k = 0; k < collection; k ++ )
    {
        Write(length[k]);
        if (k < length.Length - 1) Write(", ");   
    }
    WriteLine("]");
}

