﻿using System;

class Телефон
{
    public string Модель { get; set; }
    public string Номер { get; set; }

    public Телефон(string модель, string номер)
    {
        Модель = модель;
        Номер = номер;
    }

    public void Звонить(string номер)
    {
        Console.WriteLine($"Звоним по номеру {номер} с {Модель}");
    }
}

class Смартфон : Телефон
{
    public double РазрешениеКамеры { get; set; }

    public Смартфон(string модель, string номер, double разрешениеКамеры)
        : base(модель, номер)
    {
        РазрешениеКамеры = разрешениеКамеры;
    }

    public void СделатьФото()
    {
        Console.WriteLine($"Делаем фото с камеры {Модель}");
    }
}

class ТранспортноеСредство
{
    public string Название { get; set; }
    public int МаксимальнаяСкорость { get; set; }

    public ТранспортноеСредство(string название, int максимальнаяСкорость)
    {
        Название = название;
        МаксимальнаяСкорость = максимальнаяСкорость;
    }
}

class ПолитехМашина : ТранспортноеСредство
{
    public ПолитехМашина(string название, int максимальнаяСкорость) : base(название, максимальнаяСкорость)
    {
    }

    public void ВключитьГромкуюПлохуюМузыку()
    {
        Console.WriteLine("Громко включить плохую музыку");
    }
}

class Самолет : ТранспортноеСредство
{
    public Самолет(string название, int максимальнаяСкорость) : base(название, максимальнаяСкорость)
    {
    }

    public void ОпылитьПоле()
    {
        Console.WriteLine("Опылить поле");
    }
}

class Бетономешалка : ТранспортноеСредство
{
    public Бетономешалка(string название, int максимальнаяСкорость) : base(название, максимальнаяСкорость)
    {
    }

    public void МешатьБетон()
    {
        Console.WriteLine("Мешать бетон");
    }
}

class Человек
{
    public string Имя { get; set; }
    public int Возраст { get; set; }
    public string Пол { get; set; }

    public Человек(string имя, int возраст, string пол)
    {
        Имя = имя;
        Возраст = возраст;
        Пол = пол;
    }
}

class Сотрудник : Человек
{
    public string Должность { get; set; }

    public Сотрудник(string имя, int возраст, string пол, string должность)
        : base(имя, возраст, пол)
    {
        Должность = должность;
    }
}

class Программа
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Телефон домашнийТелефон = new Телефон("Samsung Galaxy", "88005553535");
        домашнийТелефон.Звонить("89123456789");

        Смартфон рабочийТелефон = new Смартфон("Google Pixel 6", "88001112233", 108.0);
        рабочийТелефон.Звонить("911");
        рабочийТелефон.СделатьФото();

        ПолитехМашина машина = new ПолитехМашина("ТихийАвтомобиль", 150);
        машина.ВключитьГромкуюПлохуюМузыку();

        Самолет самолет = new Самолет("PassengerJet", 900);
        самолет.ОпылитьПоле();

        Бетономешалка бетономешалка = new Бетономешалка("CementMaster", 75);
        бетономешалка.МешатьБетон();

        Человек человек = new Человек("Иван", 25, "Мужской");
        Console.WriteLine($"{человек.Имя} - {человек.Пол} возрастом {человек.Возраст} лет.");

        Сотрудник сотрудник = new Сотрудник("Елена", 35, "Женский", "Директор");
        Console.WriteLine($"{сотрудник.Имя} - {сотрудник.Пол} возрастом {сотрудник.Возраст} лет, работает на должности {сотрудник.Должность}.");

        int[] числа = { 15, 25, 35, 45, 55 };
        double сумма = 0;

        foreach (int число in числа)
        {
            сумма += число;
        }

        double среднее = сумма / числа.Length;

        Console.WriteLine("Среднее арифметическое чисел в массиве: " + среднее);
    }
}
