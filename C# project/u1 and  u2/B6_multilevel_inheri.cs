using System;

class A{
    public A(){
        Console.WriteLine("constructing A");
    }
}
class B : A{
    public B(){
        Console.WriteLine("constructing B");
    }
}
class C : B{
    public C(){
        Console.WriteLine("constructing C");
    }
}
class demo{
    public static void Main(){
        C c1 = new C();
    }
}