using System;

class A12_multidemansiton{

    public static void Main(){
  
  int [ , ] twodim  =new int [4,3];


  // input loop

  for (int i = 0 ; i<4 ; i++){
     
     for (int j = 0 ; j<3 ;j++){
               Console.WriteLine("Enter value:");

         twodim[i,j] = Int32.Parse(Console.ReadLine());
     }

  }
 
 // output loop
 Console.WriteLine();
  Console.WriteLine();
  Console.WriteLine();


  for (int i = 0 ; i<4 ; i++){
     
     for (int j = 0 ; j<3 ;j++){
        Console.Write(" ");
         Console.Write(twodim[i,j]);
     }

     Console.WriteLine();

  }


    }


}