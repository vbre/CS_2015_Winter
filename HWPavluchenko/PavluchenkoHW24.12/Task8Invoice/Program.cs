﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Invoice
{
    //    Задание 8
    //Требуется:
    //Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider 
    //    которые должны быть проинициализированы один раз (при создании экземпляра данного класса)
    //    без возможности их дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    class Program
    {
        static void Main(string[] args)
        {
            Invoice order1 = new Invoice(344, "Petrov", "Fregat");
            order1.Price();

        }
    }
}
