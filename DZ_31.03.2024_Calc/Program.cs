/*Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую. Пользователь с
помощью меню выбирает направление перевода. Например, из десятичной в двоичную. После выбора направления,
пользователь вводит число в исходной системе исчисления. Приложение должно перевести число в требуемую систему.
Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.*/

using static System.Console;
class Program
{
    static void Main()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            WriteLine("Выберите действие:");
            WriteLine("1. Из десятичной в двоичную");
            WriteLine("2. Из двоичной в десятичную");
            WriteLine("3. Выйти из программы");

            int choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Write("Введите число в десятичной системе исчисления: ");
                    int decimalNumber = int.Parse(ReadLine());

                    string binaryNumber = Convert.ToString(decimalNumber, 2);
                    WriteLine($"Результат перевода: {binaryNumber}");
                    break;

                case 2:
                    Write("Введите число в двоичной системе исчисления: ");
                    string binaryInput = ReadLine();

                    try
                    {
                        int decimalResult = Convert.ToInt32(binaryInput, 2);
                        WriteLine($"Результат перевода: {decimalResult}");
                    }
                    catch (FormatException)
                    {
                        WriteLine("Некорректный ввод.");
                    }
                    catch (OverflowException)
                    {
                        WriteLine("Число выходит за пределы допустимого диапазона.");
                    }
                    break;

                case 3:
                    exitProgram = true;
                    break;

                default:
                    WriteLine("Выбрано некорректное действие. Попробуйте еще раз.");
                    break;
            }
        }
    }
}
