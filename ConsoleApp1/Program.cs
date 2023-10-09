using System;

class FloatIndexerDemo
{
    private double[] data;

    public FloatIndexerDemo(int size)
    {
        data = new double[size];
    }

    public double this[double index]
    {
        get
        {
            int roundedIndex = (int)Math.Round(index);
            if (roundedIndex >= 0 && roundedIndex < data.Length)
            {
                return data[roundedIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
            }
        }
        set
        {
            int roundedIndex = (int)Math.Round(index);
            if (roundedIndex >= 0 && roundedIndex < data.Length)
            {
                data[roundedIndex] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        FloatIndexerDemo collection = new FloatIndexerDemo(100);

        try
        {
            collection[4.51] = 42.0;
            collection[9.49] = 66.0;
            collection[99.9] = 123.0;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }

        try
        {
            Console.WriteLine($"Элемент с индексом 4.51: {collection[4.51]}");
            Console.WriteLine($"Элемент с индексом 9.49: {collection[9.49]}");
            Console.WriteLine($"Элемент с индексом 99.9: {collection[99.9]}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }
}
