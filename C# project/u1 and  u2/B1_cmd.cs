using System;

 class cmdDemo{
     public static void Main(String[] args){
         if(args[0] == "a"){
             Console.WriteLine("you have entered = {0}", args[0]);
         }else{
             Console.WriteLine("Length of argrument = {0}", args.Length);
         }
     }
 }