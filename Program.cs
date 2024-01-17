namespace Arvidsson_Mattias_Labration2
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variabler för menyval, antal personer, namn och åldrar.
            int menuSelect = 0;
            int numberofPeople = 0;
            string[]? nameofRelativs = null;    // Array för att lagra namnen på personerna.
            int[]? ageofRelativs = null;        // Array för att lagra åldrarna på personerna.

            // Huvudloop för programmet, fortsätter tills användaren väljer att avsluta(menuSelect == 5).
            while (menuSelect != 5)
            {
                // Skriver ut menyalternativ.
                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "\nVälj ett av alternativen: " +
                    "\n1.) Skriv in antal personer samt namn och ålder. " +
                    "\n2.) Skriv ut namn samt ålder. " +
                    "\n3.) Skriv ut den totala summan av de tillagda personers ålder. " +
                    "\n4.) Skriv ut genomsnitt åldern för de tillagda personerna. " +
                    "\n5.) Avsluta programmet. " +
                    "\n------------------------------------------------"
                    );

                // Läser in användarens menyval.
                menuSelect = Convert.ToInt32(Console.ReadLine());

                // Hanterar användarens val med en switch-sats.
                switch (menuSelect)
                {

                    case 1:

                        // Användaren väljer att lägga till personer.
                        Console.WriteLine("Hur många personer vill du lägga till?");
                        numberofPeople = Convert.ToInt32(Console.ReadLine());

                        // Skapar arrayer för namn och ålder baserat på användarens inmatning.
                        nameofRelativs = new string[numberofPeople];
                        ageofRelativs = new int[numberofPeople];

                        // Loop för att mata in namn och åldrar från användaren för varje person.
                        for (int i = 0; i < numberofPeople; i++)
                        {
                            Console.WriteLine($"Vad heter person nummer {i + 1}? ");
                            nameofRelativs[i] = Console.ReadLine() +"";

                            Console.WriteLine($"Hur gammal är person nummer {i + 1}? ");
                            ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        break;

                    case 2:

                        // Användaren väljer att skriva ut namn och ålder.
                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            // Loop för att skriva ut namnen och åldrarna för varje person samt räkna ålderssumman.
                            for (int i = 0; i < numberofPeople; i++)
                            {
                                Console.WriteLine("{0} är {1} år gammal.", nameofRelativs[i], ageofRelativs[i]);
                            }
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 3:

                        // Användaren väljer att skriva ut den totala ålderssumman.
                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            Console.WriteLine("Gemensamt är alla " + ageofRelativs.Sum() + " år gamla.");
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 4:

                        // Användaren väljer att skriva ut genomsnittsåldern.
                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            double averageAge = Convert.ToDouble(ageofRelativs.Sum()) / ageofRelativs.Length;
                            Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 5:

                        // Användaren väljer att avsluta programmet.
                        Console.WriteLine("Då avslutar vi programmet. ");

                        break;

                    default:

                        // Felaktigt menyval om användaren skriver in fel siffra.
                        Console.WriteLine("Det är ett svar jag inte förstår... Du behöver ange en siffra mellan 1-5.\n");

                        break;
                }
 
            }

        }
    
    }

}