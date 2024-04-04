using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Fifth_lesson
{
    internal class Program
    {
        class JobWithLine
        {
            public static void MethodOne(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(words[0] + words[2]);
            }
            public static void MethodTwo(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(words[0] + "- " + "***" + " -" + words[2] + "- " + "***" + " -" + words[4]);
                
            }
            public static void MethodThree(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(words[1].Trim() + "/" + words[3].Trim() + "/" + words[4][2] + "/" + words[4][4]);
               
            }
            public static void MethodFour(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(words[1].Trim() + "/" + words[3].Trim() + "/" + words[4][2] + "/" + words[4][4]);
                Console.WriteLine($"Letters:{stringBuilder}");
            }
            public static void MethodFive(string line)
            {
                if (line.IndexOf("abc") != -1 || line.IndexOf("ABC") != -1)
                {
                    Console.WriteLine("Строка содержит содержит последовательность abc или ABC");
                }
                else
                {
                    Console.WriteLine("Строка не содержит содержит последовательность abc или ABC");
                }
            }
            public static void MethodSix(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[0].Remove(words[0].Length - 2) == "555")
                {
                    Console.WriteLine("Номер начинается с 555");
                }
                else
                {
                    Console.WriteLine("Номер не начинаеться с 555");
                }
            }
            public static void MethodSeven(string line)
            {
                string[] words = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[4].Trim() == "1a2b")
                {
                    Console.WriteLine("Номер заканчивается на 1a2b");
                }
                else
                {
                    Console.WriteLine("Номер не заканчивается на 1a2b");
                }
            }
        }
        static void Main(string[] args)
        {
            // HomeWork

            //1. Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

            //string teskst = "sdfsd_test_fsdfsdf";

            //Console.WriteLine(teskst.Replace("test", "testing"));


            //   2.Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:Welcome to the TMS lesons.

            //string wordOne = "Welcome ";
            //string wordTwo = "to the TMS ";
            //string wordThree = "lesons";

            //Console.WriteLine(wordOne + wordTwo + wordThree);



            //3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
            // Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.

            //string line = "teamwithsomeofexcersicesabcwanttomakeitbetter";

            //string oneLine = line.Remove(line.IndexOf("abc"));
            //string twoLine = line.Substring(line.LastIndexOf("abc") + 3);

            //Console.WriteLine(oneLine);
            //Console.WriteLine(twoLine);

            //4. Дана строка: Плохой день.
            //Необходимо с помощью метода substring удалить слово "плохой".После чего необходимо используя команду insert создать строку со значением:
            //Хороший день!!!!!!!!!.
            //Заменить последний "!" на "?"

            //string line = "Плохой день.";
            //line = line.Substring("Плохой".Length);
            //line = line.Insert(0,"Хороший");
            //line = line.Insert(line.Length - 1, "!!!!!!!!!");
            //Console.WriteLine(line.Replace("!!!!!!!!!", "!!!!!!!!?"));

            //5. Написать программу со следующим функционалом:
            // На вход передать строку(будем считать, что это номер документа).
            //Номер документа имеет формат xxxx - yyy - xxxx - yyy - xyxy, где x — это число, а y — это буква.

            //5.1.Вывести на экран в одну строку два первых блока по 4 цифры.

            //string line = "1234 - qwe - 5678 - asd - 9a9b";
            //JobWithLine.MethodOne(line);


            //5.2.Вывести на экран номер документа, но блоки из трех букв заменить на * **(каждая буква заменятся на *).

            //string line = "1234 - qwe - 5678 - asd - 9a9b";
            //JobWithLine.MethodTwo(line);

            //5.3.Вывести на экран только одни буквы из номера документа в формате yyy/ yyy / y / y в нижнем регистре.

            //string line = "1234 - qwe - 5678 - asd - 9a9b";
            //JobWithLine.MethodThree(line);

            //5.4.Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
            //класса StringBuilder).

            //string line = "1234 - qwe - 5678 - asd - 9a9b";
            //JobWithLine.MethodFour(line);


            //5.5.Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается
            //одинаковой последовательностью).

            //string line = "1234 - abc - 5678 - asd - 9a9b";
            //JobWithLine.MethodFive(line);

            //5.6.Проверить начинается ли номер документа с последовательности
            //555.

            //string line = "5553 - qwe - 5678 - asd - 9a9b";
            //JobWithLine.MethodSix(line);

            //5.7.Проверить заканчивается ли номер документа на
            //последовательность 1a2b.

            //string line = "5553 - qwe - 5678 - asd - 1a2b";
            //JobWithLine.MethodSeven(line);

            //Все эти методы реализовать в отдельном классе в статических методах,
            //которые на вход(входным параметром) будут принимать вводимую на
            //вход программы строку.























































































            // 1.
            //string firstName = "AAA";
            //string secondName = "BBB";

            //string fullName = firstName + " " + secondName;

            //string fullNameSecond = string.Concat(firstName," ", secondName);

            //string fullNameThree = "{0} {1}";

            //Console.WriteLine(fullName);
            //Console.WriteLine(fullNameSecond);

            //Console.WriteLine($"{firstName} {secondName}");
            //Console.WriteLine(string.Format(fullNameThree,firstName,secondName));


            //2.

            //string firstName = "qqq";
            //string lastName = "Ktoto";

            //string fullName = "";

            //if (firstName.Length > 3)
            //{
            //    fullName = firstName.Remove(3);

            //}
            //else
            //{
            //    fullName = firstName;
            //}
            //fullName = string.Concat(fullName, "***");
            //Console.WriteLine(fullName);

            //3.

            //string firstName = "Maksim";
            //string lastName = "    ";

            //if(string.IsNullOrEmpty(lastName))
            //{
            //    Console.WriteLine($"{firstName[0]}.");
            //}
            //else
            //{
            //    Console.WriteLine($"{firstName[0]}.{lastName[0]}.");
            //}

            //4.

            //StringBuilder line = new StringBuilder();

            //while (true)
            //{
            //    Console.WriteLine("Введите слово");

            //    line.Append(Console.ReadLine());

            //    Console.Clear();
            //    Console.WriteLine(line);

            //    Console.WriteLine("Продолжить введите +, закончить -");

            //    if(Console.ReadLine() == "-")
            //    {
            //        break;
            //    }
            //}


        }
}
}
