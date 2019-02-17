using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            double growth = initialPopulation * (percent / 100) + visitors;
            for (int a = initialPopulation; a <= currentPopulation; a += growth)
            {
                int years = 0;
                years++;
            }
           throw new NotImplementedException();
            return years;
        } 
      
    } 
}