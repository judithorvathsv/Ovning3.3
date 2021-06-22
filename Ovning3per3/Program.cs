using System;
using System.Collections.Generic;

namespace Ovning3per3
{
   public class Program
    {
        public static void Main(string[] args)
        {

            List<UserError> userErrors = new ();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());


            // 8. Skriv ut samtliga UserErrors UEMessage() genom en foreach loop:
            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
            Console.WriteLine();



            // 9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage()
            // 10.Testa och se så det fungerar:
            Console.WriteLine("Errors and messages with new errors ");
            List<UserError> userErrors2 = new();
            userErrors2.Add(new NumericInputError());
            userErrors2.Add(new TextInputError());
            userErrors2.Add(new NumericInputError());
            userErrors2.Add(new TextInputError());
            userErrors2.Add(new MoreInputError1());
            userErrors2.Add(new MoreInputError3());
            userErrors2.Add(new MoreInputError2());
            userErrors2.Add(new MoreInputError1());
            foreach (var error in userErrors2)
            {
                Console.WriteLine(error.UEMessage());
            }



            // 11.F: Varför är polymorfism viktigt att behärska? -- Utan polimorfism kan man inte få egen version för olika klasser för en method till exempel.
            // 12.F: Hur kan polymorfism förändra och förbättra kod via en bra struktur ? -- Kortare kod, enklare modifiera om det behövs senare. 
            // 13.F: Vad är det för en skillnad på en Abstrakt klass och ett Interface ?
            // -- abstract: när klasser är liknande: car, airplan, bycicle -> vehicle. Abstract klass är blueprint för klasserna. Det är "IS", car IS a vehicle.
            // --interface: när klasser (de behöver inte likna varandra) behövs samma method: MP3 spelare i car, MP3 spelare i hemma -> MP3 spelare interface. Det är en "HAS". car HAS an MP3 spelare.
            // skillnad till exempel:  abstract: kan ha konstruktor, kan ha icke abstract method och field, men interface kan inte ha någon konstruktor, kan bara ha abstract metod.

        }
    }
}
