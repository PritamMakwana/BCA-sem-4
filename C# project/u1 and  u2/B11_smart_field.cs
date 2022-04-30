using System;

class employe
{
 
 public String FirstName
  {
    set{
         _FirstName = value;
     }
     get{
         return _FirstName;
     }
  }
 private String _FirstName;

}


class Property_demo
{
    public static void Main()
    {
     employe emp =new employe();
     emp.FirstName = "india";
     Console.WriteLine(emp.FirstName); 
    }
}