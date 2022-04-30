using System;
class salary{
	public static void Main(){
		int sal;
		int ta;
		int da;
		int sum;
		string gender;
		Console.WriteLine("Enter your Gender ");
		gender=Console.ReadLine();
		Console.WriteLine("Enter your Salary ");
		sal=Int32.Parse(Console.ReadLine());

		if(gender=="m" || gender=="M"){
			if(sal<10000){
				ta=(sal*5)/100;
				da=(sal*10)/100;
				getSalary();
		       }
			else if(sal>=10000 && sal<60000){
				ta=(sal*6)/100;
				da=(sal*11)/100;
				getSalary();
			    }
			else if(sal>=60000){
				ta=(sal*7)/100;
				da=(sal*12)/100;
				getSalary();
		          }
		}
		else if(gender=="f" || gender=="F"){
			if(sal<10000){
				ta=(sal*4)/100;
				da=(sal*9)/100;
				getSalary();
					
			}
			else if(sal>=10000 && sal<60000){
				ta=(sal*3)/100;
				da=(sal*8)/100;
				getSalary();
			}
			else if(sal>=60000){
				ta=(sal*2)/100;
				da=(sal*7)/100;
				getSalary();
			}
			
		}
		else{
			Console.WriteLine("Enter Correct Gender");
		}

		void getSalary()
		{
		sum=ta+da+sal;
		Console.WriteLine("Your T.A is {0}",ta);
		Console.WriteLine("Your D.A is {0}",da);
        Console.WriteLine("Your Gross Salary is {0}",sum);
	   }	
		}
	}	
	