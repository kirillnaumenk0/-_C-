Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(i < N)
{
    if((N - i) % 2 == 0)
    {
        Console.WriteLine(N-i);
    }
    i += 1; 
}
