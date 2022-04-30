using System;
using System.Collections;

class BCA{
    public static void Main(){
        Queue Q = new Queue();
        Q.Enqueue("a");
        Q.Enqueue("b");
        Q.Enqueue("c");
        Q.Enqueue("d");
        Q.Enqueue("e");
      foreach(String s in Q){
        Console.WriteLine(s);
      }
   
     Console.WriteLine("===peek");
     Console.WriteLine(Q.Peek());
     Console.WriteLine("Removing one");
     Q.Dequeue();
     Console.WriteLine("contains a = {0}",Q.Contains("a"));


    }
}