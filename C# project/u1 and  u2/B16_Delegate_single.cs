using System;

 public delegate int myDelegate(int x,int y);

 public class myclass {
     public static int Add(int x, int y){
         return x+y;
     }
      public static int multiply(int x, int y){
         return x*y;
     }
 }

 class BCA{

 public static void Main(){
     myDelegate del1 = new myDelegate(myclass.Add);
     myDelegate del2 = new myDelegate(myclass.multiply);

     int result = del1 (5,5);
     int mResult = del2 (5,5);

     Console.WriteLine("Result = {0} ",result);
     Console.WriteLine("Multiplecation Result = {0}",mResult);

 }


 }