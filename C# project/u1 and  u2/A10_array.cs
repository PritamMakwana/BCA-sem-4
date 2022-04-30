using System;

class array_demo{

public static void Main(){

int [] age = new int[3] {1,2,3};

Console.WriteLine("age [0] = {0}",age[0]);
Console.WriteLine("age [1] = {0}",age[1]);
Console.WriteLine("age [2] = {0}",age[2]);
Console.WriteLine();

Console.WriteLine("Using For loop");
Console.WriteLine();

int[] area = new int[6];

area [0] = 10;
area [1] = 20;
area [2] = 30;
area [3] = 40;
area [4] = 50;
area [5] = 60;

for( int i= 0; i<area.Length ; i++){

Console.WriteLine("value = {0}",area[i]);
 
} 


}

}