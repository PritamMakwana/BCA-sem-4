using System;

namespace somenamespace{
    public class myclass{
        static void Main(){

           Nested.myclassdemo.display();

        }
    }

   namespace Nested{
       public class myclassdemo{
           public static void display(){
               Console.WriteLine("hello world !");
           }
       }
   }

}