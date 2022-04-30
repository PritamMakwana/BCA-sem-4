using System;

 public delegate void multicastDelegate(int x,int y);

 public class myclass2 {
     public static void Add2(int x, int y){
        Console.WriteLine("you are in Add ");
        Console.WriteLine("{0} + {1} = {2} ",x,y,x+y);

     }
      public static  void multiply2(int x, int y){
           Console.WriteLine("you are in multiply ");
           Console.WriteLine("{0} * {1} = {2} ",x,y,x*y);
     }
 }

 class Prg{

     static void Main(){
        multicastDelegate del1 = new multicastDelegate(myclass2.Add2);
        del1 += new multicastDelegate(myclass2.multiply2);
        Console.WriteLine("calling Add and multiply method");
        del1(5,5);
        del1 -= new multicastDelegate(myclass2.Add2);
        Console.WriteLine("Removed Add");
        del1(5,5);
    }
  }
 

 