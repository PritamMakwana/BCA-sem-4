using System;
using System.Collections;

class hashdemo{
    public static void Main(){
        Hashtable ht = new Hashtable();
        ht["a"] = 50; //ht.Add("a",50);
        ht["b"] = 60;
        ht["c"] = 70;
        ht["d"] = 80;

        foreach(String s in ht.Keys){
            Console.WriteLine("Key = {0} ",s);
        }
        Console.WriteLine();

        Console.WriteLine("===values");

        foreach(int i in ht.Values){
            Console.WriteLine("val = {0} ",i);
        }

    }
}