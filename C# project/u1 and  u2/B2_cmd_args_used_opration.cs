using System;

 class cmdOparationDemo{
      
         
     
     public static void Main(String[] args){
         int a,b,res;
         
         a = int .Parse(args[0]);
         b = int.Parse(args[2]);

         if(args[1] == "+"){
             res = a+b;
             Console.WriteLine("{0} {1} {2} = {3}",a,args[1],b,res);
             
         }
         else if(args[1] == "-"){
             res = a-b;
            Console.WriteLine("{0} {1} {2} = {3}",a,args[1],b,res);
         }
         else if(args[1] == "*"){
             res = a*b;
            Console.WriteLine("{0} {1} {2} = {3}",a,args[1],b,res);
         }
         else if(args[1] == "/"){
             res = a/b;
            Console.WriteLine("{0} {1} {2} = {3}",a,args[1],b,res);
         }
  
     }
    
    
 }

