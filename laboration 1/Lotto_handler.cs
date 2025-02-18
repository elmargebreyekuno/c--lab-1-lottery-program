using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboration_1
{
    internal class Lotto_handler
    {


        /* Denna är en funktion som validerar värde på och antal dragningar */
        public int[] ValidateValues(string[] valuesString, string amountDrawsString)

        {
            //här skapas variabler i heltal som kommer att användas för att spara den omvandlade värden från string(som användaren mattar in)
            int[] valuesInt = new int[7];
            int amountDrawsInt = 0;

            try
            {
                valuesInt = valuesString.Select(int.Parse).ToArray();
                amountDrawsInt = int.Parse(amountDrawsString);
            }
            catch (Exception ex)
            {
                //Detta fel skapas när omvandlingen mellan sträng till heltal har myslyckats, vilket tyder på att användaren har mattatin värde som inte är en siffra!
                throw new ArgumentException($"Ogiltig inmatning: Alla inmatningar måste vara heltal siffror");
            }
            if (amountDrawsInt < 0)
            {
                // Detta fel skapas när antal dragningar är inte positiva heltal.
                throw new ArgumentException($"Ogiltig inmatning: Antal draggningar måste vara positvit heltal");
            }

            if (valuesInt.Distinct().Count() != valuesInt.Length)
            {
                // Detta fel skapas när användaren checkar in dubblettvärden vid dragningar
                throw new ArgumentException($"Ogiltig inmatning: Inga duplikator på draggningarna");
            }
            foreach (int value in valuesInt)
            {
                if (value <= 0 || value >= 36)
                {
                    // Detta fel skapas när användaren checkar in värde på dragningar som är utanför från 1 till 35
                    throw new ArgumentException($"Ogiltig inmatning: {value}. Förväntas att värde på draggningarna ska vara mellan 1-35");
                }
            }
            return valuesInt;




        }

        public int[] Handle_lottery(int[] values, int NumberOfDraws)
        {
            // Array för att lagra antal matchade nummer (respektiv 5, 6 eller 7 matchningar)
            int[] ResultMatchedNumbers = { 0, 0, 0 };
            Random rnd = new Random();
            for (int x = 0; x < NumberOfDraws; x++)
            {
                // Array för att lagra de 7 slumpmässiga numren
                int[] Random_numbers = new int[7];

              
             

               
                for (int i = 0; i < 7; i++)
                {
                    int randomNumber = rnd.Next(1, 35);

                    // Kontrollera att numret är unikt innan det läggs till i arrayen
                    while (Random_numbers.Contains(randomNumber))
                    {
                        randomNumber = rnd.Next(1, 35); 
                    }
                    Random_numbers[i] = randomNumber; 
                }

               
                // Jämför hur många nummer som matchar mellan den genererade uppsättningen och användarens värden
                int AmountMatched = values.Intersect(Random_numbers).Count();

                // Om 5 eller fler nummer matchar, öka motsvarande resultaträkning
                if (AmountMatched >= 5)
                {
                    if (AmountMatched == 5)
                    {
                        ResultMatchedNumbers[0]++; // Öka räknaren för 5 matchningar
                    }
                    if (AmountMatched == 6)
                    {
                        ResultMatchedNumbers[1]++; // Öka räknaren för 6 matchningar
                    }
                    if (AmountMatched == 7)
                    {
                        ResultMatchedNumbers[2]++; // Öka räknaren för 7 matchningar
                    }
                }
            }

           
            return ResultMatchedNumbers;
        }
    }


    }
