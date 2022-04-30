using System;

class method_overload{
    public void ovldemo(){
        Console.WriteLine("No parameter");
    }
    public void ovldemo(int a){
        Console.WriteLine("One parameter = {0} ",a);
    }
    public int ovldemo(int a,int b){
        Console.WriteLine("two para {0} {1} ",a,b);
        return a+b;
    }
    public double ovldemo(double a,double b){
        Console.WriteLine("two double para {0} {1} ",a,b);
        return a+b;
    }
}
class OverloadDemo{
    public static void Main(){
        method_overload ob = new method_overload();
        int res1;
        double resD;
        ob.ovldemo();
        Console.WriteLine();
        ob.ovldemo(3);
        Console.WriteLine();
        
        res1 = ob.ovldemo(4,6);
        Console.WriteLine("rel1 = {0}",res1);
        Console.WriteLine();

        resD = ob.ovldemo(1.1,2.32);
        Console.WriteLine("relD = {0}",resD);
        
    }
}