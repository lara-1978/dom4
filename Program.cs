//Zadacha1
//Написать программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

 void Main()
 {
    {  
        Console.WriteLine(" Введите целые числа. Для завершения введите 'q' или введите число, сумма цифр которого чётная.");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")   // Проверка на завершение программы
            {
                Console.WriteLine("Программа завершена.");
                break;
            }
            if (int.TryParse(input, out int number))   // Попытка преобразовать введенное значение в целое число
            {  
                if (IsEvenDigitSum(number))  // Проверка на сумму цифр числа, если чётная, завершаем программу
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
            }
        }
    }
    bool IsEvenDigitSum(int num)

    {
        int digitSum = 0;
      while (num != 0)   // Суммируем цифры числа
        {
           digitSum += num % 10;
            num /= 10;
        }
        return digitSum % 2 == 0; // Проверяем чётность суммы цифр
    }
}

// Zadacha 2
//Задать массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
    
    int arraySize = 10;  // Задаем размер массива
       Random random = new Random();  // Создаем объект Random для генерации случайных чисел
        int[] numbers = new int[arraySize];  // Инициализируем массив случайными трехзначными числами
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }
        Console.WriteLine("Исходный массив:");   // Выводим массив на экран
      PrintArray(numbers);

       int evenCount = CountEvenNumbers(numbers);  // Подсчитываем количество четных чисел

       Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");  // Выводим результат
      Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    
     void PrintArray(int[] array)  // Метод для вывода массива на экран
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
       Console.WriteLine();
    }

     int CountEvenNumbers(int[] array) // Метод для подсчета четных чисел в массиве
    {
       int count = 0;
       foreach (var number in array)
       {
          if (number % 2 == 0)
           {
              count++;
          }
       }
       return count;
   }


//ZAdacha3 
//Написать программу, которая перевернёт одномерный массив (1й элемент станет последним, 2й – предпоследним и т.д.)
  
       int[] originalArray = { 1, 2, 3, 4, 5 };  // Исходный массив
{
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);
        ReverseArray(originalArray);  // Переворачиваем массив

        Console.WriteLine("Перевёрнутый массив:");
        PrintArray(originalArray);

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Обмен значениями между элементами с начала и конца массива
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}      