using System;

class MarkSheet{

public static void Main(){

    int Rollno,java,Csharp,OS,NW;
    String name;

    Console.WriteLine(" input details ....");

    Console.Write(" Roll Number :- ");
    Rollno = Int32.Parse(Console.ReadLine());

    Console.WriteLine(" Name :- ");
    name = Console.ReadLine();

    Console.Write(" Mark for java :- ");
    java = Int32.Parse(Console.ReadLine());

    Console.Write(" Mark for C# :- ");
    Csharp = Int32.Parse(Console.ReadLine());

    Console.Write(" Mark for OS :- ");
    OS = Int32.Parse(Console.ReadLine());

    Console.Write(" Mark for Networking :- ");
    NW = Int32.Parse(Console.ReadLine());
    //---logical wroks
    int total;
    float pr;
    Boolean fail = false;
    String note = "";

    total = java + Csharp + OS + NW ;

    pr = total/4f;

    if(java<33){
        fail = true;
        note = " java \n";
    } 
    if(Csharp<33){
        fail = true;
        note = note + " C# \n";
    } 
    if(OS<33){
        fail = true;
        note = note + " OS \n";
    } 
    if(NW<33){
        fail = true;
        note = note + " Networking ";
    } 

    //-----

     Console.WriteLine(" ----- Marksheet -----");

     Console.WriteLine(" Roll No :- {0}",Rollno);
     Console.WriteLine(" Name :- {0}",name);
     Console.WriteLine(" ....Results.... ");
     Console.WriteLine(" java = {0}",java);
     Console.WriteLine(" C# = {0}",Csharp);
     Console.WriteLine(" OS = {0}",OS);
     Console.WriteLine(" Networking = {0}",NW);
     Console.WriteLine(" Total = {0}",total);
     Console.WriteLine(" percentage = {0}",pr);

     if(fail == false)
     {
         Console.WriteLine(" Result = PASS ");
             if(pr>=85){
                Console.WriteLine(" Grad = A");
             }
            else if(pr>=70){
                Console.WriteLine(" Grad = B");
            }
            else if(pr>=50){
                Console.WriteLine(" Grad = C");
            }
            else{
                Console.WriteLine(" Grad = D");
            }

     }else{
         Console.WriteLine(" Result = Fail ");
         Console.WriteLine(" Fail this subject :- ");
         Console.WriteLine(note);

     }
    
}

}