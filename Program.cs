using System;

class OneDimensionalVector
{
    private int[] elements; // Масив для зберігання елементів вектора

    // Конструктор: ініціалізує масив із розмірністю 4
    public OneDimensionalVector()
    {
        elements = new int[4];
    }

    // Метод для задання елементів вектора з клавіатури
    public void SetElementsFromKeyboard()
    {
        Console.WriteLine("Введіть 4 елементи вектора:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out elements[i]))
            {
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть ціле число:");
            }
        }
    }

    // Метод для виведення вектора на екран
    public void DisplayVector()
    {
        Console.WriteLine("Вектор: [" + string.Join(", ", elements) + "]");
    }

    // Метод для знаходження максимального елемента вектора
    public int FindMaxElement()
    {
        int max = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        // Створюємо об'єкт класу
        OneDimensionalVector vector = new OneDimensionalVector();

        // Задання елементів вектора з клавіатури
        vector.SetElementsFromKeyboard();

        // Виведення вектора на екран
        vector.DisplayVector();

        // Знаходження максимального елемента
        int maxElement = vector.FindMaxElement();
        Console.WriteLine("Максимальний елемент вектора: " + maxElement);
    }
}
