using System;
using System.Collections.Generic;

namespace powtorka
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Pierwszy program
            // Zadanie 2

            Console.WriteLine(" ");
            Console.WriteLine("***Pierwszy program - rozgrzewka***");
            Console.WriteLine(" ");

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Zadanie 3

            int result = 5 + 9;
            // Problem spowodowany był brakiem średnika na końcu linii.

            // Operatory
            // Zadanie 1

            Console.WriteLine(" ");
            Console.WriteLine("***Operatory***");
            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 1");
            Console.WriteLine(" ");

            int number = 4;
            float money = 3.14f;
            string text = "Tekscik";
            bool isLogged = true;
            char myChar = 'M';
            decimal price = 1.1234M;

            Console.WriteLine("number: " + number);
            Console.WriteLine("money: " + money);
            Console.WriteLine("text: " + text);
            Console.WriteLine("isLogged: " + isLogged);
            Console.WriteLine("myChar: " + myChar);
            Console.WriteLine("price: " + price);

            // Zadanie 2

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 2");
            Console.WriteLine(" ");

            string myAge = "Age: ";
            int wifeAge = 18;
            var result1 = myAge + wifeAge;
            Console.WriteLine(result1);

            // Wnioski: Do zmiennej typu string możemy "dodać" zmienną typu number - co skutkuje ich połączeniem w konsoli.

            // Zadanie 3

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 3");
            Console.WriteLine(" ");

            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue && isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("and: " + and + ", OR: " + or + ", negative: " + negative);


            // Zadanie 4

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 4");
            Console.WriteLine(" ");

            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            float div = (float)a / (float)b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("add: " + add);
            Console.WriteLine("sub: " + sub);
            Console.WriteLine("div: " + div);
            Console.WriteLine("mul: " + mul);
            Console.WriteLine("mod: " + mod);


            //Zadanie 5

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 5");
            Console.WriteLine(" ");

            string a1 = "Ala ";
            string b1 = "ma ";
            string c1 = "kota.";
            string result2 = a1 + b1 + c1;

            Console.WriteLine(result2);

            // Dodając stringi powinniśmy przewidywać spacje, inaczej słowa będą "sklejone".

            //Instrukcje sterujące i pętle
            // Zadanie 1

            Console.WriteLine(" ");
            Console.WriteLine("***Instrukcje sterujące i pętle***");
            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 1");
            Console.WriteLine(" ");

            int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("n1 jest równe n2");
            }
            else
            {
                Console.WriteLine("n2 jest większe od n1"); // Dodane w celu wypisania przy niespełnionych warunkach
            }


            // Zadanie 2

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 2");
            Console.WriteLine(" ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int j = 0;

            while (j < 10)
            {
                Console.WriteLine("C#");
                j++;
            }

            //Zadanie 3

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 3");
            Console.WriteLine(" ");

            int n = 10;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }

            // Zadanie 4

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 4");
            Console.WriteLine(" ");

            int n3 = 5;
            for (int i = 1; i <= n3; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // Zadanie 5

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 5");
            Console.WriteLine(" ");

            int exam = 57;

            if (exam < 0 || exam > 100)
            {
                Console.WriteLine("Wartość poza zakresem");
            }
            else if (exam < 40)
            {
                Console.WriteLine("Ocena Niedostateczna");
            }
            else if (exam > 39 && exam < 55)
            {
                Console.WriteLine("Ocena Dopuszczająca");
            }
            else if (exam > 54 && exam < 70)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam > 69 && exam < 85)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (exam > 84 && exam < 99)
            {
                Console.WriteLine("Ocena Bardzo Dobra");
            }
            else
            {
                Console.WriteLine("Ocena Celująca");
            }


            // Kolekcje
            // Zadanie 1

            Console.WriteLine(" ");
            Console.WriteLine("***Kolekcje***");
            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 1");
            Console.WriteLine(" ");

            string[] colors = new string[] { "Biały", "Czerwony", "Pomarańczowy", "Żółty" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);


            // Zadanie 2

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 2");
            Console.WriteLine(" ");

            int[] numbers = new int[] { 2, 1, 7, 8, 3, 6, 4, 8, 7, 1 };

            Console.WriteLine("FOR:");
            for (int i3 = 0; i3 < numbers.Length; i3++)
            {
                Console.WriteLine("Liczba: " + numbers[i3]);
            }
            Console.WriteLine("FOR EACH:");
            foreach (int number1 in numbers)
            {
                Console.WriteLine("Liczba: " + number1);
            }
            Console.WriteLine("WHILE:");
            int i4 = 0;
            while (i4 < numbers.Length)
            {
                Console.WriteLine("Liczba: " + numbers[i4]);
                i4++;
            }

            // Zadanie 3

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 3");
            Console.WriteLine(" ");

            List<string> fruits = new List<string>();
            fruits.Add("Banan");
            fruits.Add("Truskawka");
            fruits.Add("Malina");
            fruits.Add("Brzoskwinia");
            fruits.Add("Pomarańcza");

            Console.WriteLine(string.Join(", ", fruits));

            fruits.Remove(fruits[0]);
            fruits.RemoveAt(fruits.Count - 1);
            Console.WriteLine(string.Join(", ", fruits));

        }
    }
}
