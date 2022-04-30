using System;

class loops{
	
	public static void Main(){
		  
		  	Console.WriteLine("1.For loop");
			Console.Write("");
		  
		for(int i = 1; i <=5 ; i++){
			Console.WriteLine("value of i = {0}",i);
		}

		Console.Write("");
		Console.Write("");

       Console.WriteLine("2.while loop");
			Console.Write("");
         
		 int a = 1;

		 while(a<=5){
			 Console.WriteLine("a={0} ",a);
			 a++;
		 }

		 Console.Write("");
		Console.Write("");

       Console.WriteLine("3.do..while loop");
			Console.Write("");
         
		 int d = 1;

		 do{
			 Console.WriteLine("d={0} ",d);
			 d++;
		 }while(d<=5);

        Console.Write("");
		Console.Write("");

		Console.WriteLine("4.break statement");
        Console.Write("");

		for(int k = 1; k <=10 ; k++){

           if(k > 5){
			   break;
		   }

			Console.WriteLine("value of k = {0}",k);
		}

		Console.WriteLine("out of loop");

        Console.Write("");
		Console.Write("");

		Console.WriteLine("5.contiune statement");
        Console.Write("");

		for(int j = 1; j <=10 ; j++){

           if(j == 5){
			   continue;
		   }

			Console.WriteLine("value of j = {0}",j);
		}

		Console.WriteLine("out of loop");


		
	}
	
	
}