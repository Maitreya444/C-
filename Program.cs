using System;
using System.Globalization;

class Numbers
{
    public void Addition(int iNo1, int iNo2)
    {
        int iAns = iNo1 + iNo2;
        Console.WriteLine(iAns);
    }

    public void Addition(int iNo1, int iNo2, int iNo3)
    {
        int iAns = iNo1 - iNo2;
        Console.WriteLine(iAns);
    }

    public void Addition(float iNo1, float iNo2)
    {
        float iAns = iNo1 * iNo2;
        Console.WriteLine(iAns);
    }
}

class CompileTimePoly
{
    static void Main()
    {
        Numbers nobj = new Numbers();
        nobj.Addition(10, 11);
        nobj.Addition(51, 111, 69);
        nobj.Addition(69.66f, 88.69f);
    }
}