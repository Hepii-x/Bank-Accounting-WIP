﻿using System;
using System.Data.SQLite;

namespace Bank_Accounting
{    
    class Program
    {

        static void Main(string[] args)
        {
            DBFunctions db = new DBFunctions();
            Console.WriteLine("1. Zaloguj");
            Console.WriteLine("2. Zarejestruj");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1")
            {
                Console.WriteLine("Podaj numer karty: ");
                string cardNumber = Console.ReadLine();
                Console.WriteLine("Podaj kod cvc karty: ");
                string cvcNumber = Console.ReadLine();
                Console.WriteLine("Podaj kod pin karty: ");
                string pinNumber = Console.ReadLine();

                db.Login(cardNumber, cvcNumber, pinNumber);

            }
            else if (choice == "2")
            {
                Console.WriteLine("Podaj imię: ");
                string name = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Ilość pieniędzy do wpłaty: ");
                float money =  float.Parse(Console.ReadLine());
                db.Register(name, surname, money);
                Console.WriteLine("Zarejestrowano! Zaloguj ponownie.");
            }
            else
            {
                var rand = new Random();
                string cardNumber1 = rand.Next(00000000, 99999999).ToString();
                string cardNumber2 =  rand.Next(00000000, 99999999).ToString();

                string cardNumber = cardNumber1 + cardNumber2;
                Console.WriteLine(cardNumber);

            }
        }


    }
}
