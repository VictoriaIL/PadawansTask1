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

            if (persent < 0)
            {
                throw new ArgumentException();
            }
            try
            {
                int years = 0;
                double p = persent / 100;
                for (int pop = initialPopulation; pop < currentPopulation; pop = checked(a + (int)(p * a) + visitors))
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
