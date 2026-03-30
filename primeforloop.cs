using System;
class Prim
{
    static void Main()
    {
        int num,i;
        for(num=2; num<=50; num++){
             bool isprime=true;
        for(i=2; i<num; i++){
           
            if(num%i==0){
                isprime=false;
                break;
            }
        }
        if(isprime){
            Console.WriteLine(num);
        }
    }
    }
}