using System;

 class age
{
   public static void Main()
   {
      int i;
     
     Console.WriteLine(" Enter your age :-");
     i = Int32.Parse(Console.ReadLine());	 
	 if( i >=1 && i < 18){
		 Console.WriteLine("you are child please not driving !");
		 
	 }
	 else if( i >= 18 && i <=60 ){
		 Console.WriteLine(" you are prafact age for driving ");
		 
	 }
	 else if(i > 60){
		 Console.WriteLine("you are  not prafact age for driving, you old ");
	 }
	 
	 else{
		 Console.WriteLine("Enter positive age value !!!! ");
	 }
   Console.WriteLine("END program");
  }
}
