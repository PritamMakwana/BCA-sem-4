using  System;

namespace KSCstudent{

class student{

String name;
int age , mathmark , engmark , scimark , totmark = 300 , obatainmark;

double per;

 void CaltoMark(){
     obatainmark = mathmark + engmark + scimark ;
 }
   
  void Calper(){
      per = (double) obatainmark / totmark * 100;
  }
  
  double getPer(){
      return per;

  }

  static void Main(){

  student s = new student();

  Console.WriteLine("Enter name");
  s.name = Console.ReadLine();

  Console.WriteLine("Enter age ");
  s.age = Int32.Parse(Console.ReadLine());
  

  Console.WriteLine("Enter match mark");
  s.mathmark = Int32.Parse(Console.ReadLine());

   Console.WriteLine("Enter English mark");
  s.engmark = Int32.Parse(Console.ReadLine());

   Console.WriteLine("Enter science mark");
  s.scimark = Int32.Parse(Console.ReadLine());

  s.CaltoMark();
  s.Calper();
  double sper = s.getPer();

  Console.WriteLine("Name : {0} age : {1} math : {2} English : {3} science : {4} total mark obtain : {5} parcentage {6}",
  s.name , s.age ,s.mathmark, s.engmark, s.scimark ,s.obatainmark,sper);


  


  }

}


}