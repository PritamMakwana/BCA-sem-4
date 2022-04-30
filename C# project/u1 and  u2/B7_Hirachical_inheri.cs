using System;

class Database{
    public Database(){
        CommanField = 42;
    }

    public int CommanField;

    public void Commanmethod(){
        Console.WriteLine("Database method called");
    }
}
class Sqlserver : Database
{
    public void Sqlservermethod(){
        Console.WriteLine("Sqlserver method called");
    }
}

class Oracle : Database
{
    public void Oraclemethod(){
        Console.WriteLine("oracle method called");
    }
}

class inheritdemo
{

public static void Main(){
    Console.WriteLine("calling sqlserver");


 Sqlserver s = new Sqlserver();

 Console.WriteLine("calling sqlserver method");
 s.Sqlservermethod();

 Console.WriteLine("calling comman method");
 s.Commanmethod();

 Console.WriteLine("Accessing comman Field " + s.CommanField);

 Console.WriteLine("calling oracle");

 Oracle ob = new Oracle();

 Console.WriteLine("calling oracle method");
 ob.Oraclemethod();

 Console.WriteLine("calling comman mehtod");
 ob.Commanmethod();

 Console.WriteLine("Accessing commanField " + ob.CommanField);

}

}