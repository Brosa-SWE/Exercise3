using Exercise3._4;
using System;
using System.Collections.Generic;

namespace Exercise3._4
{
    class Program
    {
        /*
        3.4.11
            F: Varför är polymorfism viktigt att behärska?
            S: Det förenklar programmering då man kan behandla grupper av olika typer på ett och samma sätt i koden men
               under exekveringen sker olika saker beroende på vilken typ som för tillfället behandlas.

        3.4.12
            F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            S: Det reducerar hårdkodade undantag i koden, ökar återanvändbarheten för skriven kod som kan fungera på flera
               typer samt gör koden lättare att läsa då man slipper ha mängder av rader kod med undantag beroende på
               vilken typ som manipuleras.

        3.4.13
            F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            S: I en Abstrakt klass kan man definera 
        */

        static List<UserError> userErrors = new List<UserError>();

        static void Main(string[] args)
        {

            var myNumError = new NumericInputError();
            userErrors.Add(myNumError);

            var myTxtError = new TextInputError();
            userErrors.Add(myTxtError);

            myNumError = new NumericInputError();
            userErrors.Add(myNumError);

            myTxtError = new TextInputError();
            userErrors.Add(myTxtError);

            var myErr1 = new MyError1();
            userErrors.Add(myErr1);
            var myErr2 = new MyError2();
            userErrors.Add(myErr2);
            var myErr3 = new MyError3();
            userErrors.Add(myErr3);


            foreach (UserError errorInLIst in userErrors)
            {
                Console.WriteLine(errorInLIst.UEMessage());
            }

            Console.ReadKey();

        }
    }
}
