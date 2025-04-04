using System;

namespace MyApp
{
    public class Iteration()
    {
        public void PrintIterator()
        {
            int iCnt = 0;

            Console.WriteLine("For LOOP : \n");
            for(iCnt = 1; iCnt <= 5; iCnt++)
            {
                Console.WriteLine(iCnt);
            }

            iCnt = 0;
            
            Console.WriteLine("While LOOP : \n");
            while(iCnt < 5)
            {
                Console.WriteLine(iCnt);
                iCnt++;
            }
        }
    }
}