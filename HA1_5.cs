using System;

class PRINT
{
    public void Display(int iNo)
    {
        int iCnt = 0;
        for(iCnt = 0; iCnt < iNo; iCnt++)
        {
            Console.WriteLine("*");
        }
    }
}
class HA5_5
{
    static void Main()
    {
        Console.WriteLine("Enter a Number : ");
        int iValue = Convert.ToInt32(Console.ReadLine());

        PRINT nobj = new PRINT();
        nobj.Display(iValue);
    }
}