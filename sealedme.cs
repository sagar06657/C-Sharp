using System;
class Base{
    public virtual void Test(){
        Console.WriteLine("jpt");
    }
}
class  Subclass :Base{
    public sealed override void Test(){
        Console.WriteLine("jptgfhvjbkn");
    }
}

class  Subclass1 :Subclass{
    public void Test(){
        Console.WriteLine("jptgfhvjbkn");
    }
}
///this shows error because sealded methos cannot be over write