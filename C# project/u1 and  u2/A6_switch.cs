using System;

class switch_demo{
	
	public static void Main(){
		
		int d;
		
		Console.WriteLine("Enter day namber :-");
		d=Int32.Parse(Console.ReadLine());
		
		switch(d){
			case 1:
			Console.WriteLine("sunday"); 
			break;
			case 2:
			Console.WriteLine("monday"); 
			break;
			case 3:
			Console.WriteLine("tuesday"); 
			break;
			case 4:
			Console.WriteLine("Wedneday"); 
			break;
			case 5:
			Console.WriteLine("thussday"); 
			break;
			case 6:
			Console.WriteLine("friday"); 
			break;
			case 7:
			Console.WriteLine("saturday"); 
			break;
			default:
			Console.WriteLine("plases inter 1 to 7 values");
			break;
			
				
		}
		
	    Console.ReadLine();
	}
	
	
}