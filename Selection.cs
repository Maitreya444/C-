using System;

namespace MyApp
{
    public class Selection()
    {
        public void PrintSelection()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            
            else if(time < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}