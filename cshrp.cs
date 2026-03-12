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
                    // Ввод первого числа
                    Console.Write("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    
                    if (input1.ToLower() == "q")
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    double num1 = Convert.ToDouble(input1);

                    // Ввод второго числа
                    Console.Write("Введите второе число: ");
                    string input2 = Console.ReadLine();
                    
                    if (input2.ToLower() == "q")
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    double num2 = Convert.ToDouble(input2);

                    // Выбор операции
                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1. Сложение (+)");
                    Console.WriteLine("2. Вычитание (-)");
                    Console.WriteLine("3. Умножение (*)");
                    Console.WriteLine("4. Деление (/)");
                    Console.Write("Введите номер операции или знак: ");
                    
                    string operation = Console.ReadLine();
                    
                    if (operation.ToLower() == "q")
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }

                    // Выполнение операции и вывод результата
                    double result = 0;
                    bool validOperation = true;

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
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"\nРезультат: {num1} / {num2} = {result}");
                            }
                            break;
                        
                        default:
                            validOperation = false;
                            Console.WriteLine("\nОшибка: неверная операция!");
                            break;
                    }

                    if (validOperation && operation != "/" || (operation == "/" && num2 != 0))
                    {
                        Console.WriteLine($"Результат (с округлением до 2 знаков): {Math.Round(result, 2)}");
                    }
                    
                    Console.WriteLine("\n" + new string('-', 30) + "\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОшибка: введено некорректное число! Попробуйте снова.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nПроизошла ошибка: {ex.Message}\n");
                }
            }
        }
    }
}