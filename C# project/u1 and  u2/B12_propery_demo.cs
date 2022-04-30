using System;

class Country_state_demo{

public String State
  {
    set{
         _State = value;
     }
     get{
         return _State;
     }
  }
  public String Country
  {
    set{
         _Country = value;
     }
     get{
         return _Country;
     }
  }
 private String _State;
 private String _Country;

}


class Property_demo_Con_Sta
{
    public static void Main()
    {
     Country_state_demo obj = new Country_state_demo();

     obj.Country = "india";
     obj.State = "Gujarat";
     Console.WriteLine("This Country name is "+obj.Country); 
     Console.WriteLine("This State name is "+obj.State); 

    }
}