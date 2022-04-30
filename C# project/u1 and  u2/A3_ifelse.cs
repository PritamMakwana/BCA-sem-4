using System;

 class demoifelse
{
   public static void Main()
   {
      int i;
     
     Console.WriteLine(" Enter day number  :-");
     i = Int32.Parse(Console.ReadLine());	 
	 if(i == 1){
		 Console.WriteLine("sunday"); 
	 }
	 else if(i == 2){
		 Console.WriteLine("monday");
		 
	 }
	 else if(i == 3){
		 Console.WriteLine("tuesday");
	 }
	 else if(i == 4){
		 Console.WriteLine("wednesday");
	 }
	 else if(i == 5){
		 Console.WriteLine("thursday");
	 }
	 else if(i == 6){
		 Console.WriteLine("friday");
	 }
	 else if(i == 7){
		 Console.WriteLine("sutreday");
	 }
	 else{
		 Console.WriteLine("please Enter 1 to 7 OK !!!! ");
	 }
   Console.WriteLine("END program");
  }
}
