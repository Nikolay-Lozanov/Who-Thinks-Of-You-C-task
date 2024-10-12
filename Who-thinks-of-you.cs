namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napishi tricifreno chislo i vij koi si misli za teb v momenta: ");


            //Тук използвам вместо Console.Read(), Console.ReadKey(), защото то чете символа ВЕДНАГА, след като го напишеш, без да трябва да натискаш ентър
            //Ако не използувам ReadKey, проверките са въведените данни, няма да са коректни.
      

            // Четене на първата цифра
            var firstKey = Console.ReadKey(); // Премахнахме intercept: true, за да се показва въведеният символ
            int firstAsciiNumber = firstKey.KeyChar; // това взема кода от аски таблицата на това, което сме въвели

            // Проверка за валидна цифра и дали първата цифра е 0
            while (!Char.IsDigit(firstKey.KeyChar) || firstAsciiNumber == '0') //това прави проверка дали въведените данни са числа + дали първото въведено число е 0
            {
                if (!Char.IsDigit(firstKey.KeyChar))
                {
                    Console.Write("\nMolq, vuvedi chislo, a ne bukva: "); // ако не си въвел число
                }
                else
                {
                    Console.Write("\nMolq vuvedi za purvo chislo razlichno ot nula: ");// ако си въвел число, но то е нула
                }

                firstKey = Console.ReadKey(); // Прочитаме отново въведения символ и го показваме
                firstAsciiNumber = firstKey.KeyChar;
            }

            // Четене на втората цифра
            var secondKey = Console.ReadKey(); // показва въведения символ
            int secondAsciiNumber = secondKey.KeyChar;
            while (!Char.IsDigit(secondKey.KeyChar)) //това прави проверка дали въведените данни са числа
            {
                Console.Write("\nMolq, vuvedi chislo, a ne bukva: ");
                secondKey = Console.ReadKey(); // Прочитаме отново въведения символ и го показваме
                secondAsciiNumber = secondKey.KeyChar;
            }

            // Четене на третата цифра
            var thirdKey = Console.ReadKey(); // показва въведения символ
            int thirdAsciiNumber = thirdKey.KeyChar;
            while (!Char.IsDigit(thirdKey.KeyChar)) //това прави проверка дали въведените данни са числа
            {
                Console.Write("\nMolq, vuvedi chislo, a ne bukva: ");
                thirdKey = Console.ReadKey(); // Прочитаме отново въведения символ и го показваме
                thirdAsciiNumber = thirdKey.KeyChar;
            }

            // Преобразуване на ASCII кодовете към числа
            firstAsciiNumber -= '0'; //zashtoto firstAsciiNumber = 49(ako vuvedem 1), a minus simvol nula, e vse edno 48 ---> demek 49 - 48, koeto ni dava 1 (chisloto, koeto e dejstvitelno)
            secondAsciiNumber -= '0';
            thirdAsciiNumber -= '0';

            // Изчисляване на сумата
            int sum = firstAsciiNumber + secondAsciiNumber + thirdAsciiNumber;//сбор от трите числа на трицифреното число

            char letterFounder = (char)(sum + 'A' - 1); //логика представена чрез първата буква и цифра

            Console.WriteLine();//празен ред

            if (sum >= 27) // ако сбора от числата е по-голям или равен на 27, няма буква
            {
                Console.Write("V momenta nikoq ne si misli za teb"); //финално съобщение
            }
            else
            {
                Console.Write("Niakoi, chieto ime zapochva s bukvata {0}, si misli za teb! ", letterFounder);//финално съобщение
            }

            Console.WriteLine();
            //----------------------------------------------------------------------------
        }
    }
}