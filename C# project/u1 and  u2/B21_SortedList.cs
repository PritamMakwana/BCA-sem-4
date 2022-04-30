using System;
using System.Collections;

class SortedList_demo{
    public static void Main(){
        SortedList st = new SortedList();
        st.Add("BH","bhavnger");
        st.Add("RJ","Rajkot");
        st.Add("AM","Amreli");
        st.Add("ST","Surat");
        st.Add("MU","Mumbai");

        foreach(String ct in st.Keys){
            Console.WriteLine(ct);
        }
        foreach(String ct1 in st.Values){
            Console.WriteLine(ct1);
        }

        Console.WriteLine("total element are {0} ",st.Count);
        Console.WriteLine("BH Key is exist {0}",st.ContainsKey("BH"));

    }
}