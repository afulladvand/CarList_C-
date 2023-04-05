using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace moment2
{
    internal class FordonManager
    {
        List<Fordon> fordons = new List<Fordon>();// Klassen har en lista av Fordon objekt som lagrar information om olika fordon

        string makeValue, modelValue, colorValue;// Klassen har också fyra variabler som håller värdet av make, model, färg och år för varje fordon
        int yearValue;
        public void Questions()// Klassen har en metod som heter Questions som låter användaren interagera med listan av fordon
        {

            bool start = true;
            do
            {// Valen är att visa listan, lägga till ett fordon, ta bort ett fordon eller avsluta dialogen
                Console.WriteLine("Du har följande val");
                Console.WriteLine("1 . Mata in 1 för att visa dina fordon i listan på skärmen");
                Console.WriteLine("+ . Mata in plustecken (+) för att lägga till ett fordon");
                Console.WriteLine("- . Mata in minustecken (-) för att ta bort ett fordon");
                Console.WriteLine("0 . Mata in null (0) för att avsluta dialogen.");
                string firstVal = Console.ReadLine();
                Console.WriteLine();
                switch (firstVal)// Metoden använder en switch-sats för att hantera olika val som användaren kan göra
                {// Metoden anropar andra metoder beroende på valet: print, increase eller decrease
                    case "1":
                        print();
                        break;
                    case "+":
                        increase();
                        break;
                    case "-":
                        decrease();
                        break;
                    case "0":
                        Console.WriteLine("Hej då :)");
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Inmatningen var fel");
                        break;
                }
            } while (start);
         

        }
        private void print()//Metoden print skriver ut listan av fordon i console med index, id, make, model, färg och år för varje fordon
        {
            int index = 1;
            Console.WriteLine("Index \t ID \t Make \t Model \t Färg \t År");
            foreach (Fordon f in fordons)
            {
                Console.WriteLine($"{index} \t {f.id} \t {f.Make} \t {f.Model} \t {f.Color} \t {f.Year} " );
                index++;
            }
        }
        
        private void increase()// Metoden increase lägger till ett nytt fordon i listan genom att fråga användaren om de olika attributen
        {
            Console.WriteLine("Mata in fordonens make: ");
            makeValue = Console.ReadLine();
            Console.WriteLine($"Mata in {makeValue}s model: ");
            modelValue = Console.ReadLine();
            Console.WriteLine($"Mata in {makeValue}s färg: ");
            colorValue = Console.ReadLine();
            int incorectTry = 0;
            bool corect = false;
            while(!corect)
            {
                Console.WriteLine("Mata in tilvärknings år: ");
                corect = int.TryParse(Console.ReadLine(),out yearValue);
                incorectTry++;
                if (incorectTry > 1)
                {
                    Console.WriteLine("Inmatning av tilvärknings år var fel.");
                    break;
                }
            }
            string addMessage = "Fordonet är tillagt.";
            if (corect && colorValue != " ")
            {
                Fordon fordon = new Fordon(makeValue , modelValue,colorValue, yearValue);
                fordons.Add(fordon);
                Console.WriteLine(addMessage);
            }
            else if (corect)
            {
                Fordon fordon = new Fordon(makeValue, modelValue, yearValue);
                fordons.Add(fordon);
                Console.WriteLine(addMessage);
            }
            else
            {
                Fordon fordon = new Fordon(makeValue, modelValue, colorValue);
                fordons.Add(fordon);
                Console.WriteLine(addMessage);
            }
            
            
        }

        private void decrease()// Metoden decrease tar bort ett fordon från listan genom att fråga användaren om indexet för det fordonet
        {
            int clearID = 0;
            bool clearSucces = false;
            while(!clearSucces)
            {
                Console.WriteLine("Mata in Index nummeret till den fordon som du vill ta bort: ");
                clearSucces = int.TryParse(Console.ReadLine(),out clearID);
            }
                try
                {
                    int clearIDIndex = clearID - 1;
                    fordons.RemoveAt(clearIDIndex);
                    Console.WriteLine("Fordonet radierades.");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
        }
        
        public void Run()
        {
            Questions();

        }
    }
}
