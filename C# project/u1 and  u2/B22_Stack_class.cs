using System;
using System.Collections;

class stack_demo{
    public static void Main(){
        Stack st = new Stack();
        st.Push(1);
        st.Push(2);
        foreach (var i in st)
        {
            Console.WriteLine(i);
        }
        st.Push(3);
        Console.WriteLine("===Stack===");
        foreach(int a in st){
            Console.WriteLine(a);
        }
        Console.WriteLine("Applying Pop");
        int b = (int) st.Pop();
        Console.WriteLine(b);

    }
}