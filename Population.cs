using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation == 0)
            {
                throw new ArgumentException();
            }

            if (currentPopulation == 0)
            {
                throw new ArgumentException();
            }

            if (percent < 0)
            {
                throw new ArgumentException();
            }
            int years = 0;
            try
            {
                
                double p = percent / 100;
                for (int pop = initialPopulation; pop < currentPopulation; pop = checked(pop + (int)(p * pop) + visitors))
                {
                    years++;
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            return years;
        } 
      
    } 
}
