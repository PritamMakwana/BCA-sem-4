using System;
using System.Collections;

class hashdemo{
    public static void Main(){
        Hashtable ht = new Hashtable();
        ht["a"] = 50; //ht.Add("a",50);
        ht["b"] = "Absent";
        ht["c"] = 70;
        ht["d"] = 80;

        foreach(DictionaryEntry d in ht){
            Console.WriteLine("key = {0} values = {1} ",d.Key,d.Value);
        }

    }
}