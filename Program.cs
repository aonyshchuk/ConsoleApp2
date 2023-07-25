
﻿using System.Text;
using System.Text.RegularExpressions;


﻿namespace ConsoleApp2
{

    internal class Program
    {



        static void Main(string[] args)
        {
            try {


                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                bool Input = true;

                while (Input)
                {

                    Console.WriteLine("Оберіть завдання (1-7):");
                    int task = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (task)
                    {
                        case 1:


                            string text1 = "Оголосити одновимірний (5 елементів) масив з назвою A i двовимірний масив (3 рядки, 4 стовпці) дробових чисел з назвою B. Заповнити одновимірний масив А числами, введеними з клавіатури користувачем, а двовимірний масив В — випадковими числами за допомогою циклів. Вивести на екран значення масивів: масиву А — в один рядок, масиву В — у вигляді матриці. Знайти у даних масивах загальний максимальний елемент, мінімальний елемент, загальну суму усіх елементів, загальний добуток усіх елементів, суму парних елементів масиву А, суму непарних стовпців масиву В.";
                            int Width1 = 2;
                            int padding1 = (Width1 - text1.Length) / 2;
                            string centeredText1 = text1.PadLeft(text1.Length + padding1).PadRight(Width1);

                            Console.WriteLine(centeredText1);
                            Console.WriteLine();

                            int[] A = new int[5];
                            double[,] B = new double[3, 4];


                            Console.WriteLine("Введіть 5 чисел для масиву A через Enter:");
                            for (int i = 0; i < 5; i++)
                            {
                                A[i] = int.Parse(Console.ReadLine());
                            }


                            Random random = new Random();
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    B[i, j] = random.NextDouble() * 100;
                                }
                            }


                            Console.WriteLine("Масив A:");
                            foreach (int num in A)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine();


                            Console.WriteLine("Масив B:");
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write(B[i, j] + " ");
                                }
                                Console.WriteLine();
                            }


                            int maxA = A[0];
                            int minA = A[0];
                            int sumA = 0;
                            int productA = 1;
                            int sumEvenB = 0;
                            for (int i = 0; i < 5; i++)
                            {

                                if (A[i] > maxA)
                                    maxA = A[i];


                                if (A[i] < minA)
                                    minA = A[i];


                                sumA += A[i];


                                productA *= A[i];
                            }


                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    if (j % 2 == 0)
                                        sumEvenB += (int)B[i, j];
                                }
                            }


                            Console.WriteLine($"Загальний максимальний елемент у масиві A: {maxA}");
                            Console.WriteLine($"Загальний мінімальний елемент у масиві A: {minA}");
                            Console.WriteLine($"Загальна сума усіх елементів у масиві A: {sumA}");
                            Console.WriteLine($"Загальний добуток усіх елементів у масиві A: {productA}");
                            Console.WriteLine($"Сума парних елементів у масиві B: {sumEvenB}");


                            break;
                        case 2:


                            string text2 = "Дано двовимірний масив розміром 5×5, заповнений випадковими числами з діапазону від –100 до 100.  Визначити суму елементів масиву, розташованих між мінімальним і максимальним елементами.";
                            int Width2 = 2;
                            int padding2 = (Width2 - text2.Length) / 2;
                            string centeredText2 = text2.PadLeft(text2.Length + padding2).PadRight(Width2);

                            Console.WriteLine(centeredText2);
                            Console.WriteLine();

                            int[,] array = new int[5, 5];
                            Random random1 = new Random();


                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    array[i, j] = random1.Next(-100, 101);
                                }
                            }

                            Console.WriteLine("Двовимірний масив:");
                            PrintArray(array);


                            int minElement = array[0, 0];
                            int maxElement = array[0, 0];
                            foreach (int element in array)
                            {
                                if (element < minElement)
                                    minElement = element;

                                if (element > maxElement)
                                    maxElement = element;
                            }


                            int sumBetweenMinMax = 0;
                            bool foundMin = false;
                            foreach (int element in array)
                            {
                                if (element == minElement)
                                {
                                    foundMin = true;
                                }
                                else if (element == maxElement)
                                {
                                    break;
                                }
                                else if (foundMin)
                                {
                                    sumBetweenMinMax += element;
                                }
                            }

                            Console.WriteLine($"\nМінімальний елемент: {minElement}");
                            Console.WriteLine($"Максимальний елемент: {maxElement}");
                            Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sumBetweenMinMax}");



                            static void PrintArray(int[,] arr)
                            {
                                for (int i = 0; i < arr.GetLength(0); i++)
                                {
                                    for (int j = 0; j < arr.GetLength(1); j++)
                                    {
                                        Console.Write(arr[i, j] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }

                            break;
                        case 3:

                            string text3 = "Користувач вводить рядок із клавіатури. Необхідно зашифрувати цей рядок, використовуючи шифр Цезаря.";
                            int Width3 = 2;
                            int padding3 = (Width3 - text3.Length) / 2;
                            string centeredText3 = text3.PadLeft(text3.Length + padding3).PadRight(Width3);

                            Console.WriteLine(centeredText3);
                            Console.WriteLine();

                            Console.WriteLine("Введіть рядок для шифрування за допомогою шифру Цезаря:");
                            string input = Console.ReadLine();

                            Console.WriteLine("Введіть зсув:");
                            int shift = int.Parse(Console.ReadLine());

                            string encryptedText = CaesarCipherEncrypt(input, shift);

                            Console.WriteLine($"Зашифрований текст: {encryptedText}");


                            static string CaesarCipherEncrypt(string text, int shift)
                            {
                                string result = "";

                                foreach (char character in text)
                                {
                                    if (char.IsLetter(character))
                                    {
                                        char encryptedChar = (char)(character + shift);


                                        if ((char.IsLower(character) && encryptedChar > 'z') || (char.IsUpper(character) && encryptedChar > 'Z'))
                                        {
                                            encryptedChar = (char)(encryptedChar - 26);
                                        }

                                        result += encryptedChar;
                                    }
                                    else
                                    {

                                        result += character;
                                    }
                                }

                                return result;
                            }

                            break;

                        case 4:
                            string text4 = "Створіть додаток, який здійснює операції над матрицями.";
                            int Width4 = 2;
                            int padding4 = (Width4 - text4.Length) / 2;
                            string centeredText4 = text4.PadLeft(text4.Length + padding4).PadRight(Width4);

                            Console.WriteLine(centeredText4);
                            Console.WriteLine();



                            int[,] matrixA = { { 1, 2 }, { 3, 4 } };
                            int[,] matrixB = { { 5, 6 }, { 7, 8 } };

                            Console.WriteLine("Матриця A:");
                            PrintMatrix(matrixA);

                            Console.WriteLine("\nМатриця B:");
                            PrintMatrix(matrixB);


                            Matrix.MultiplyByScalar(matrixA, 3);
                            Console.WriteLine("\nМатриця A після множення на 3:");
                            PrintMatrix(matrixA);

                            int[,] sumMatrix = Matrix.AddMatrices(matrixA, matrixB);
                            Console.WriteLine("\nСума матриць A і B:");
                            PrintMatrix(sumMatrix);

                            int[,] productMatrix = Matrix.MatrixMultiplication(matrixA, matrixB);
                            Console.WriteLine("\nДобуток матриць A і B:");
                            PrintMatrix(productMatrix);


                            static void PrintMatrix(int[,] matrix)
                            {
                                int rows = matrix.GetLength(0);
                                int cols = matrix.GetLength(1);

                                for (int i = 0; i < rows; i++)
                                {
                                    for (int j = 0; j < cols; j++)
                                    {
                                        Console.Write(matrix[i, j] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }

                            break;
                        case 5:

                            string text5 = "Користувач з клавіатури вводить до рядка арифметичний вираз. Додаток має підрахувати його результат. Необхідно дотримуватися лише двох операцій: + і –.";
                            int Width5 = 2;
                            int padding5 = (Width5 - text5.Length) / 2;
                            string centeredText5 = text5.PadLeft(text5.Length + padding5).PadRight(Width5);

                            Console.WriteLine(centeredText5);
                            Console.WriteLine();

                            Console.WriteLine("Введіть арифметичний вираз, що складається з + та -:");
                            string input1 = Console.ReadLine();

                            try
                            {
                                double result = CalculateExpression(input1);
                                Console.WriteLine($"Результат: {result}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Помилка: {ex.Message}");
                            }


                            static double CalculateExpression(string input1)
                            {

                                input1 = input1.Replace(" ", "");


                                string[] numbers = input1.Split('+', '-');
                                char[] operators = input1.Where(c => c == '+' || c == '-').ToArray();


                                double[] values = new double[numbers.Length];
                                for (int i = 0; i < numbers.Length; i++)
                                {
                                    if (!double.TryParse(numbers[i], out values[i]))
                                    {
                                        throw new ArgumentException($"Невірне число: {numbers[i]}");
                                    }
                                }


                                double result = values[0];
                                for (int i = 1; i < values.Length; i++)
                                {
                                    if (operators[i - 1] == '+')
                                        result += values[i];
                                    else if (operators[i - 1] == '-')
                                        result -= values[i];
                                }

                                return result;
                            }


                            break;
                        case 6:


                            string text6 = "Користувач з клавіатури вводить певний текст. Додаток має змінювати регістр першої літери кожного речення на літеру у верхньому регістрі.";
                            int Width6 = 2;
                            int padding6 = (Width6 - text6.Length) / 2;
                            string centeredText6 = text6.PadLeft(text6.Length + padding6).PadRight(Width6);

                            Console.WriteLine(centeredText6);
                            Console.WriteLine();

                            Console.WriteLine("Введіть текст:");
                            string inputText = Console.ReadLine();

                            string modifiedText = ChangeFirstLetterToUpper(inputText);
                            Console.WriteLine("Результат:");
                            Console.WriteLine(modifiedText);


                            static string ChangeFirstLetterToUpper(string inputText)
                            {

                                string pattern = @"(^[а-я]|[.!?]\s*[а-я])";


                                string modifiedText = Regex.Replace(inputText, pattern, m => m.Value.ToUpper());

                                return modifiedText;
                            }


                            break;
                        case 7:


                            string text7 = "Створіть додаток, який перевіряє текст на неприпустимі слова. Якщо неприпустиме слово знайдено, воно має бути замінено набором символів *. За підсумками роботи програми, необхідно показати статистику дій.";
                            int Width7 = 2;
                            int padding7 = (Width7 - text7.Length) / 2;
                            string centeredText7 = text7.PadLeft(text7.Length + padding7).PadRight(Width7);

                            Console.WriteLine(centeredText7);
                            Console.WriteLine();



                            List<string> prohibitedWords = new List<string> { "в", "і", "й" };

                            Console.WriteLine("Введіть текст:");
                            string inputText1 = Console.ReadLine();


                            (string modifiedText1, int replacedWordsCount) = ReplaceProhibitedWords(inputText1, prohibitedWords);

                            Console.WriteLine("\nРезультат:");
                            Console.WriteLine(modifiedText1);
                            Console.WriteLine($"\nКількість замінених неприпустимих слів: {replacedWordsCount}");


                            static (string modifiedText1, int replacedWordsCount) ReplaceProhibitedWords(string inputText1, List<string> prohibitedWords)
                            {
                                int replacedWordsCount = 0;

                                foreach (string word in prohibitedWords)
                                {

                                    string pattern = $@"\b{Regex.Escape(word)}\b";


                                    inputText1 = Regex.Replace(inputText1, pattern, m =>
                                    {
                                        replacedWordsCount++;
                                        return new string('*', m.Length);
                                    });
                                }

                                return (inputText1, replacedWordsCount);
                            }


                            break;

                        default:
                            Console.WriteLine("Помилка");
                            Console.WriteLine();
                            break;
                    }
                }
            }


        

            catch(Exception e)          
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }
}