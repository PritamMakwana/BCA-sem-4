using System;

class multiplecation_table{

public static void Main(String[] args){
int num ;

Console.WriteLine("Enter value number :");
num = Int32.Parse(Console.ReadLine());

for(int i=1; i<=10; i++){
Console.WriteLine("{0} * {1} = {2}",num,i,num * i );


}

}

}