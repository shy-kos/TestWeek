using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание №1
        // Console.WriteLine("ЯЮниор");

        // Задание №2

        short shortVariable = -10;
        ushort unsignShortVariale = 10;
        int integerVariable = -70000;
        uint unsignIntegerVairable = 3000000000;
        long longVariable = -100;
        ulong unsignLongVariable = 200;
        string text = "heelo world";
        double doubleVariable = 10;
        float floatVariable = 10f;
        Boolean trueFalseSign = true;
        char znak = '1';

        Console.WriteLine(shortVariable);
        Console.WriteLine(unsignShortVariale);
        Console.WriteLine(integerVariable);
        Console.WriteLine(unsignIntegerVairable);
        Console.WriteLine(longVariable);
        Console.WriteLine(unsignLongVariable);
        Console.WriteLine(text);
        Console.WriteLine(doubleVariable);
        Console.WriteLine(trueFalseSign);
        Console.WriteLine(znak);


        /*
        // Объявление без инициализации
        string name;
        string surname;
        string patronymic;

        // Инициализация
        name = "Иван";
        surname = "Иванов";
        patronymic = "Иванович";

        // Объявление с инициализацией
        int birthDay = 1;
        int birthMonth = 1;
        int birthYear = 2000;
        char sex = 'M';

        // Динамическая инициализация        
        string birthDate;
        birthDate = birthDay + "." + birthMonth + "." + birthYear;

        int ageYears = 22;
        int ageMonths;
        ageMonths = ageYears * 12;

        Console.WriteLine($"Фамилия: {surname} \nИмя: {name}\nОтчество: {patronymic}");
        Console.WriteLine("Дата рождения: " + birthDate);
        Console.WriteLine("Возраст, лет: {0}", ageYears ) ;
        Console.WriteLine("Пол: " + sex);

        */
    }
}