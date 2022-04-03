using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание №1
        Console.WriteLine("ЯЮниор");

        // Задание №2
        
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
    }
}