using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboration_1
{
    internal class Lotto_handler
    {
        

        static bool CheckIfNumberExists(int[] array, int number)
        {
            // Loop through the array and check if the number exists
            foreach (int item in array)
            {
                if (item == number)
                {
                    return true; // Number found
                }
            }
            return false; // Number not found
        }
        public Boolean CheckValues(int[] values)

        {
            Boolean result = true;
            if(values.Distinct().Count() != values.Length)
            {
                result = false;
            }
            foreach (int item in values)
            {
                if (item<=0|| item >= 36)
                {
                    return false; // Number found
                }
            }
            return result;
        }
            public int[] Handle_lottery(int [] values, int NumberOfDraws)
        
        {

            int[] Amount_correct_draws_in_rows = { 0, 0, 0 };
            for (int x = 0; x < NumberOfDraws; x++)
            {
                int[] Random_numbers = new int[7];
                Random rnd = new Random();
               
                for (int i = 0; i < 7; i++)
                {
                    int randomNumber = rnd.Next(1, 35);
                    while (CheckIfNumberExists(Random_numbers, randomNumber) == true)
                    {
                        randomNumber = rnd.Next(1, 35);
                    }
                    Random_numbers[i] = randomNumber; // Random number between 1 and 35
                }
            //    MessageBox.Show(Random_numbers[0] +"-"+ Random_numbers[1] + "-"+ Random_numbers[2] + "-"+ Random_numbers[3] + "-" + Random_numbers[4] + "-" + Random_numbers[5] + Random_numbers[6] +"-----"+ values.Intersect(Random_numbers).Count());
                int AmountMatched = values.Intersect(Random_numbers).Count();
                if (AmountMatched >= 5 )
                {
                    if (AmountMatched == 5)
                    {
                        Amount_correct_draws_in_rows[0]++;
                    }
                    if (AmountMatched == 6)
                    {
                        Amount_correct_draws_in_rows[1]++;
                    }
                    if (AmountMatched == 7)
                    {
                        Amount_correct_draws_in_rows[2]++;
                    }
                }


            }
            return Amount_correct_draws_in_rows;
        }
    }
  
}
