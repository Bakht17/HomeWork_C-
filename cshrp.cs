using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== КАЛЬКУЛЯТОР ===");
            Console.WriteLine("Для выхода введите 'q' в любой момент\n");

            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    string input1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input1))
                    {
                        Console.WriteLine("\nОшибка: ввод не может быть пустым. Попробуйте снова.\n");
                        continue;
                    }

                    if (input1.Equals("q", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    if (!double.TryParse(input1, out double num1))
                    {
                        Console.WriteLine("\nОшибка: введено некорректное число. Попробуйте снова.\n");
                        continue;
                    }

                    Console.Write("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input2))
                    {
                        Console.WriteLine("\nОшибка: ввод не может быть пустым. Попробуйте снова.\n");
                        continue;
                    }

                    if (input2.Equals("q", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    if (!double.TryParse(input2, out double num2))
                    {
                        Console.WriteLine("\nОшибка: введено некорректное число. Попробуйте снова.\n");
                        continue;
                    }

                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1. Сложение (+)");
                    Console.WriteLine("2. Вычитание (-)");
                    Console.WriteLine("3. Умножение (*)");
                    Console.WriteLine("4. Деление (/)");
                    Console.Write("Введите номер операции или знак: ");

                    string operation = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(operation))
                    {
                        Console.WriteLine("\nОшибка: операция не может быть пустой.\n");
                        continue;
                    }

                    if (operation.Equals("q", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    double result = 0;
                    bool hasResult = true;

                    switch (operation)
                    {
                        case "1":
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"\nРезультат: {num1} + {num2} = {result}");
                            break;

                        case "2":
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"\nРезультат: {num1} - {num2} = {result}");
                            break;

                        case "3":
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"\nРезультат: {num1} * {num2} = {result}");
                            break;

                        case "4":
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("\nОшибка: деление на ноль невозможно!");
                                hasResult = false;
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"\nРезультат: {num1} / {num2} = {result}");
                            }
                            break;

                        default:
                            Console.WriteLine("\nОшибка: неверная операция!");
                            hasResult = false;
                            break;
                    }

                    if (hasResult)
                    {
                        Console.WriteLine($"Результат с округлением до 2 знаков: {Math.Round(result, 2)}");
                    }

                    Console.WriteLine("\n" + new string('-', 30) + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nПроизошла ошибка: {ex.Message}\n");
                }
            }
        }
    }
}
