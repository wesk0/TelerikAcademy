﻿using System;

class Problem_11
{
    static void Main()
    {
        string[] phrases = {"Продуктът е отличен.", "Това е страхотен продукт.",
                            "Постоянно ползвам този продукт.",
                            "Това е най-добрият продукт от тази категория." };
        string[] happenings = {"Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна."};
        string[] firstNames = {"Диана", "Петя", "Стела", "Елена", "Катя"};
        string[] familyNames = {"Иванова", "Петрова", "Кирова", "Георгиева", "Стоянова"};
        string[] towns = {"София", "Пловдив", "Варна", "Русе", "Бургас"};
        Random r = new Random();
        Console.WriteLine("{0} {1}  -- {2} {3}, {4}", phrases[r.Next(0,4)], happenings[r.Next(0,5)], firstNames[r.Next(0,5)], familyNames[r.Next(0,5)], towns[r.Next(0,5)]);
    }
}
