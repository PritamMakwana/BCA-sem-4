using System;

 class cmdDemo{
     public static void Main(String[] args){
        int temp = 0 ;
        for (int i = 0 ; i < args.Length ; i++){
            Console.WriteLine(args[i]);
            temp = 1;
        }
        if(temp == 1){
          Console.WriteLine("Argument value is passing");
        }
        else{
            Console.WriteLine("Argument value is not passing ");
        }
     }
 }
//  D:\C#>"B3_cmdargs_ues_ para_show" 1 2 3 4
// 1
// 2
// 3
// 4
// Argument value is passing

// D:\C#>"B3_cmdargs_ues_ para_show"
// Argument value is not passing
