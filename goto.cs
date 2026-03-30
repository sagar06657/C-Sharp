using System;
class Pro
{
    static void Main()
    {
        int i=1;
        Ab:
        if(i<=10){
        Console.Write(i +"");
        i++;
        goto Ab;
    }
        Console.WriteLine("Out of Goto");

    }
}