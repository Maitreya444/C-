using System;
using System.Globalization;

class Numbers
{
    public int Divide(int iNo1, int iNo2)
    {
        return iNo1 / iNo2;
    }

}

class HA1_1
{
    static void Main()
    {
        Console.WriteLine("Enter Number 1 : ");
        int iValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number 2 : ");
        int iValue2 = Convert.ToInt32(Console.ReadLine());

        int iRet = 0;

        Numbers nObj = new Numbers();
        iRet = nObj.Divide(iValue1, iValue2);
        Console.WriteLine("Division is : " + iRet);
    }
}