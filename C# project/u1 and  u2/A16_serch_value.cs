using System;

class Serch_value{

public static void Main(){

int[] a = new int [5];

  for (int i =0 ; i<a.Length ; i++){
   
   Console.Write("Enter value {0} number :-",i+1);
   a[i] = Int32.Parse(Console.ReadLine());

  }

  Console.WriteLine("Search value inter ");
  int s=Int32.Parse(Console.ReadLine());

  int tamp = 0 , index = 0;

  for(int i =0 ; i<a.Length; i++){
      if(a[i]==s){
          tamp = 1;
          s =a[i];
          index = i + 1;
      }
  }

  if(tamp==1){
      Console.WriteLine("value found");
      Console.WriteLine("index is :- {0}",index);
      Console.WriteLine("value is :- {0}",s);
  }
  else{
      Console.WriteLine("not input this value");
  }
 }
}