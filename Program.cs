using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание №1
        // Console.WriteLine("ЯЮниор");

        // Задание №2

        short angle = -10;
        ushort colorNumber = 10;
        int cardBalanceRub = -70000;
        uint paymentRub = 3000000000;
        long cardBalanceUsd = -100;
        ulong lenght = 200;
        string introText = "heelo world";
        double detailedBalanceRub = 10.2;
        float detailedBalanceUsd = 10.6f;
        Boolean balanceIsPositive = true;
        char currency = '$';

        Console.WriteLine(angle);
        Console.WriteLine(colorNumber);
        Console.WriteLine(cardBalanceRub);
        Console.WriteLine(cardBalanceUsd);
        Console.WriteLine(paymentRub);
        Console.WriteLine(lenght);
        Console.WriteLine(introText);
        Console.WriteLine(detailedBalanceRub);
        Console.WriteLine(detailedBalanceUsd);
        Console.WriteLine(balanceIsPositive);
        Console.WriteLine(currency);

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