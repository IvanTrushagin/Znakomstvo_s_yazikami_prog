int Fact(int n)
{
    if(n == 1 || n == 0)
    {
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n-1);
}

System.Console.WriteLine(Fact(5));

// F11 Шаг с заходом
// F10 Шг с обходом
// F5 Продолжить (до следующей точки остановки)