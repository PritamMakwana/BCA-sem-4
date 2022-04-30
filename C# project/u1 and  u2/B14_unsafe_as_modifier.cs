using System;

 class myclass {
     public unsafe void method(){
     
         int x = 10;
         int y = 10;
         int *ptr1 = &x;
         int *ptr2 = &y;

         Console.WriteLine((int) ptr1);
         Console.WriteLine((int) ptr2);
         Console.WriteLine(*ptr1);
         Console.WriteLine(*ptr2);
       
     }
 }
  class Myclient{
      public static void Main(){
          myclass m = new myclass();
          m.method();
      }
  }