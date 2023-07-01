using System;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                bool Input = true;

                while (Input)
                {

                    Console.WriteLine("Оберіть завдання (1-9):");
                    int task = int.Parse(Console.ReadLine());
                    Console.WriteLine(); 
                    switch (task)
                    {
                       
                        case 1:
                            Console.WriteLine();

                            string text1 = "Створіть додаток, який відображає кількість парних, непарних, унікальних елементів масиву.";

                            int width1 = text1.Length + 4; 

                            string horizontalLine1 = new string('*', width1);
                            string verticalLine1 = "*" + new string(' ', width1 - 2) + "*"; 

                            Console.WriteLine(horizontalLine1);
                            Console.WriteLine(verticalLine1);
                            Console.WriteLine($"* {text1} *"); 
                            Console.WriteLine(verticalLine1);
                            Console.WriteLine(horizontalLine1);
                            Console.WriteLine();


                            Console.WriteLine("Введіть елементи масиву через пробіл:");
                            string input = Console.ReadLine();

                          
                            string[] inputArray = input.Split(' ');

                           
                            int[] uniqueArray = inputArray.Distinct().Select(int.Parse).ToArray();

                            int evenCount = 0;
                            int oddCount = 0;

                            foreach (var element in uniqueArray)
                            {
                                if (element % 2 == 0)
                                {
                                    evenCount++;
                                }
                                else
                                {
                                    oddCount++;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Кількість парних елементів: {evenCount}");
                            Console.WriteLine();
                            Console.WriteLine($"Кількість непарних елементів: {oddCount}");
                            Console.WriteLine();
                            Console.WriteLine($"Кількість унікальних елементів: {uniqueArray.Length}");

                            


                            break;
                       
                        case 2:
                            Console.WriteLine();
                            string text21 = " Створіть додаток, який відображає кількість значень у масиві менше заданого параметра користувачем. ";
                            string text22 = "Наприклад, кількість значень менших, ніж 7 (7 введено користувачем з клавіатури).";

                            int width21 = text21.Length + 4;
                            int width22 = text22.Length + 4;
                            string horizontalLine21 = new string('*', width21);
                            string horizontalLine22 = new string('*', width21);
                            string verticalLine21 = "*" + new string(' ', width21 - 2) + "*";
                            string verticalLine22 = "*" + new string(' ', width21 - 2) + "*";


                            Console.WriteLine(horizontalLine21);
                            Console.WriteLine(verticalLine21);
                            Console.WriteLine($"* {text21} *");
                            Console.WriteLine($"* {text22}                     *");
                            Console.WriteLine(verticalLine22);
                            Console.WriteLine(horizontalLine22);
                            Console.WriteLine();

                            Console.WriteLine("Введіть елементи масиву через пробіл:");
                            string arr = Console.ReadLine();


                            string[] arrArray = arr.Split(' ');

                            int[] intArray = new int[arrArray.Length];

                            
                            for (int i = 0; i < arrArray.Length; i++)
                            
                            {
                                intArray[i] = int.Parse(arrArray[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Введіть число для порівняння:");
                
                            int userInput = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            int count = 0;

                            
                            for (int i = 0; i < intArray.Length; i++)
                            {
                                if (intArray[i] < userInput)
                                {
                                    count++;
                                }
                            }

                            Console.WriteLine($"Кількість значень у масиві, менших за {userInput}: {count}");
                   
                          
                    break;
                            
                        case 3:
                            Console.WriteLine();

                            string text31 = "Користувач вводить з клавіатури три числа.";
                            string text32 = "Необхідно підрахувати кількість разів послідовності цих трьох чисел в масиві. ";

                            int width31 = text31.Length + 4;
                            int width32 = text32.Length + 4;
                            string horizontalLine31 = new string('*', width32);
                            string horizontalLine32 = new string('*', width32);
                            string verticalLine31 = "*" + new string(' ', width32 - 2) + "*";
                            string verticalLine32 = "*" + new string(' ', width32 - 2) + "*";


                            Console.WriteLine(horizontalLine31);
                            Console.WriteLine(verticalLine31);
                            Console.WriteLine($"* {text31} \t \t \t \t \t *");
                            Console.WriteLine($"* {text32} *");
                            Console.WriteLine(verticalLine32);
                            Console.WriteLine(horizontalLine32);
                            Console.WriteLine();


                            Console.WriteLine("Введіть три числа через пробіл:");
                            string numbers = Console.ReadLine();
                            Console.WriteLine();


                            string[] numbersArray = numbers.Split(' ');

                            if (numbersArray.Length != 3)
                            {
                                Console.WriteLine("Потрібно ввести три числа!");
                                return;
                            }
                            else
                            {
                                int[] sequenceArray = new int[numbersArray.Length];


                                for (int i = 0; i < numbersArray.Length; i++)
                                {
                                    sequenceArray[i] = int.Parse(numbersArray[i]);
                                }
                                Console.WriteLine();

                                Console.WriteLine("Введіть елементи масиву через пробіл:");

                                string arrayInput = Console.ReadLine();


                                string[] arrayInputArray = arrayInput.Split(' ');

                                int[] intArray1 = new int[arrayInputArray.Length];


                                for (int i = 0; i < arrayInputArray.Length; i++)
                                {
                                    intArray1[i] = int.Parse(arrayInputArray[i]);
                                }

                                int sequenceCount = 0;
                                int sequenceLength = sequenceArray.Length;


                                for (int i = 0; i <= intArray1.Length - sequenceLength; i++)
                                {
                                    bool isSequenceFound = true;
                                    for (int j = 0; j < sequenceLength; j++)
                                    {
                                        if (intArray1[i + j] != sequenceArray[j])
                                        {
                                            isSequenceFound = false;
                                            break;
                                        }
                                    }

                                    if (isSequenceFound)
                                    {
                                        sequenceCount++;
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine($"Кількість повторень послідовності: {sequenceCount}");
                               
                            } Console.WriteLine();
                break;
                        
                        case 4:
                            Console.WriteLine();
                            string text41 = "Дано два масиви розмірності M і N відповідно.";
                            string text42 = "Необхідно переписати до третього масиву загальні елементи перших двох масивів без повторів.";

                            int width41 = text41.Length + 4;
                            int width42 = text42.Length + 4;
                            string horizontalLine41 = new string('*', width42);
                            string horizontalLine42 = new string('*', width42);
                            string verticalLine41 = "*" + new string(' ', width42 - 2) + "*";
                            string verticalLine42 = "*" + new string(' ', width42 - 2) + "*";


                            Console.WriteLine(horizontalLine41);
                            Console.WriteLine(verticalLine41);
                            Console.WriteLine($"* {text41} \t \t \t \t \t      *");
                            Console.WriteLine($"* {text42} *");
                            Console.WriteLine(verticalLine42);
                            Console.WriteLine(horizontalLine42);
                            Console.WriteLine();



                            Console.WriteLine("Введіть елементи першого масиву через пробіл:");
                            string input1 = Console.ReadLine();
                            int[] array1 = ParseInputArray(input1);
                            Console.WriteLine();
                            Console.WriteLine("Введіть елементи другого масиву через пробіл:");
                            string input2 = Console.ReadLine();
                            int[] array2 = ParseInputArray(input2);
                            Console.WriteLine();

                            if (int.TryParse(input1, out int number1) || int.TryParse(input2, out int number2)) 
                            {
                                Console.WriteLine("Ви ввели ціле число.");
                            


                            HashSet<int> uniqueElementsSet = new HashSet<int>();

                          
                            foreach (var element in array1)
                            {
                                uniqueElementsSet.Add(element);
                            }

                            
                            foreach (var element in array2)
                            {
                                uniqueElementsSet.Add(element);
                            }

                            
                            int[] uniqueArray1 = new int[uniqueElementsSet.Count];
                            uniqueElementsSet.CopyTo(uniqueArray1);

                            Console.WriteLine("Масив унікальних загальних елементів:");
                            PrintArray(uniqueArray1);
                            Console.WriteLine();
                            }

                            else
                            {
                                Console.WriteLine("Ви ввели неправильний формат числа.");
                            }

                            static int[] ParseInputArray(string input)
                    {
                        string[] inputArray = input.Split(' ');
                        int[] intArray = new int[inputArray.Length];

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            intArray[i] = int.Parse(inputArray[i]);
                        }

                        return intArray;
                    }

                  
                    static void PrintArray(int[] array)
                    {
                        foreach (var element in array)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                    }

                    break;
                        
                        case 5:
                            Console.WriteLine();

                            string text5 = "Розробіть додаток, який знаходитиме мінімальне і максимальне значення у двовимірному масиві.";
                            

                            int width5 = text5.Length + 4;
                            
                            string horizontalLine5 = new string('*', width5);
                          
                            string verticalLine5 = "*" + new string(' ', width5 - 2) + "*";
                          

                            Console.WriteLine(horizontalLine5);
                            Console.WriteLine(verticalLine5);
                            Console.WriteLine($"* {text5} *");
                            Console.WriteLine(verticalLine5);
                            Console.WriteLine(horizontalLine5);
                            Console.WriteLine();


                            Console.WriteLine("Введіть кількість рядків:");
                            int rows = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Введіть кількість стовпців:");
                            int cols = int.Parse(Console.ReadLine());
                            Console.WriteLine(); 
                            int[,] twoDArray = new int[rows, cols];
                            Random random = new Random();

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < cols; j++)
                                {
                                    twoDArray[i, j] = random.Next(1, 101); 
                                }
                            }

                            
                            int min = twoDArray[0, 0];
                            int max = twoDArray[0, 0];

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < cols; j++)
                                {
                                    if (twoDArray[i, j] < min)
                                    {
                                        min = twoDArray[i, j];
                                    }

                                    if (twoDArray[i, j] > max)
                                    {
                                        max = twoDArray[i, j];
                                    }
                                }
                            }

                            
                            Console.WriteLine("Двовимірний масив:");
                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < cols; j++)
                                {
                                    Console.Write(twoDArray[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine(); 
                            Console.WriteLine($"Мінімальне значення: {min}");
                            Console.WriteLine();
                            Console.WriteLine($"Максимальне значення: {max}");
                            Console.WriteLine();

                            break;
                       
                        case 6:
                            Console.WriteLine();

                            string text6 = "Користувач вводить речення з клавіатури. Вам необхідно підрахувати кількість слів у ньому.";


                            int width6 = text6.Length + 4;

                            string horizontalLine6 = new string('*', width6);

                            string verticalLine6 = "*" + new string(' ', width6 - 2) + "*";


                            Console.WriteLine(horizontalLine6);
                            Console.WriteLine(verticalLine6);
                            Console.WriteLine($"* {text6} *");
                            Console.WriteLine(verticalLine6);
                            Console.WriteLine(horizontalLine6);
                            Console.WriteLine();

                            Console.WriteLine("Введіть речення:");
                            string sentence = Console.ReadLine();

                            
                            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            int wordCount = words.Length;

                            Console.WriteLine($"Кількість слів у реченні: {wordCount}");
                            Console.WriteLine();

                            break;
                       
                        case 7:
                            Console.WriteLine();
                            string text71 = "Користувач вводить речення з клавіатури. Вам необхідно";
                            string text72 = "перевернути кожне слово речення і вивести результат на екрані. ";

                            int width71 = text71.Length + 4;
                            int width72 = text72.Length + 4;
                            string horizontalLine71 = new string('*', width72);
                            string horizontalLine72 = new string('*', width72);
                            string verticalLine71 = "*" + new string(' ', width72 - 2) + "*";
                            string verticalLine72 = "*" + new string(' ', width72 - 2) + "*";


                            Console.WriteLine(horizontalLine71);
                            Console.WriteLine(verticalLine71);
                            Console.WriteLine($"* {text71}          *");
                            Console.WriteLine($"* {text72} *");
                            Console.WriteLine(verticalLine72);
                            Console.WriteLine(horizontalLine72);
                            Console.WriteLine();

                            Console.WriteLine("Введіть речення:");
                            string sentence2 = Console.ReadLine();
                            Console.WriteLine();

                            string[] words2 = sentence2.Split(' ');

                           
                            string reversedSentence = "";

                            for (int i = 0; i < words2.Length; i++)
                            {
                                string reversedWord = ReverseWord(words2[i]);
                                reversedSentence += reversedWord + " ";
                            }

                            Console.WriteLine("Результат: " + reversedSentence.TrimEnd());
                            Console.WriteLine();


                            static string ReverseWord(string word)
                    {
                        char[] charArray = word.ToCharArray();
                        Array.Reverse(charArray);
                        return new string(charArray);
                    }

                    break;
                        
                        case 8:
                            Console.WriteLine();

                            string text81 = "Користувач вводить з клавіатури речення.";
                            string text82 = "Додаток має підрахувати кількість голосних літер у реченні.";

                            int width81 = text81.Length + 4;
                            int width82 = text82.Length + 4;
                            string horizontalLine81 = new string('*', width82);
                            string horizontalLine82 = new string('*', width82);
                            string verticalLine81 = "*" + new string(' ', width82 - 2) + "*";
                            string verticalLine82 = "*" + new string(' ', width82 - 2) + "*";


                            Console.WriteLine(horizontalLine81);
                            Console.WriteLine(verticalLine81);
                            Console.WriteLine($"* {text81} \t \t      *");
                            Console.WriteLine($"* {text82} *");
                            Console.WriteLine(verticalLine82);
                            Console.WriteLine(horizontalLine82);
                            Console.WriteLine();

                            Console.WriteLine("Введіть речення:");
                            string sentence8 = Console.ReadLine();

                            int vowelCount = CountVowels(sentence8);
                            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
                    

                    static int CountVowels(string text)
                    {
                        string vowels = "AEIOUaeiouАоуаеіяюї";
                        int count = 0;

                        foreach (char c in text)
                        {
                            if (vowels.Contains(c))
                            {
                                count++;
                            }
                        }

                        return count;
                    }
                

                break;
                        
                        case 9:
                            Console.WriteLine();


                            string text91 = "Створіть додаток для підрахунку кількості входжень підрядка в рядок. Користувач вводить";
                            string text92 = "вихідний рядок і слово для пошуку. Додаток відображає результат пошуку.";

                            int width91 = text91.Length + 4;
                            int width92 = text92.Length + 4;
                            string horizontalLine91 = new string('*', width91);
                            string horizontalLine92 = new string('*', width91);
                            string verticalLine91 = "*" + new string(' ', width91 - 2) + "*";
                            string verticalLine92 = "*" + new string(' ', width91 - 2) + "*";


                            Console.WriteLine(horizontalLine91);
                            Console.WriteLine(verticalLine91);
                            Console.WriteLine($"* {text91} *");
                            Console.WriteLine($"* {text92} \t \t  *");
                            Console.WriteLine(verticalLine92);
                            Console.WriteLine(horizontalLine92);
                            Console.WriteLine();

                            Console.WriteLine("Введіть вихідний рядок:");
                            string inputString = Console.ReadLine();

                            Console.WriteLine("Введіть підрядок для пошуку:");
                            string searchString = Console.ReadLine();

                            int count9 = CountOccurrences(inputString, searchString);
                            Console.WriteLine($"Результат пошуку: {count9}");
                    

                    static int CountOccurrences(string input, string search)
                    {
                        int count = 0;
                        int index = 0;

                        
                        while ((index = input.IndexOf(search, index)) != -1)
                        {
                            count++;
                            index += search.Length;
                        }

                        return count;
                    }

                    break;
                       
                        default:
                            Console.WriteLine("Помилка");
                            Console.WriteLine();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}