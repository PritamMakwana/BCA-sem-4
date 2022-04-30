using System;

class twodshaps{
    public double width , height ;
    public void showdin(){
        Console.WriteLine("width = {0} height = {1}",width,height);
    }
}

class trai : twodshaps
{
    public String Style;

    public double Area(){
        return width * height;
    }

    public void showstyle(){
        Console.WriteLine("trai style is {0}",Style);
    }

    class shapes{
        public static void Main(){
            trai t1 = new trai();
            trai t2 = new trai();
            t1.width = 4.0;
            t1.height = 4.0;
            t1.Style = "left";
            t2.width = 8.0;
            t2.height = 8.0;
            t2.Style = "Right";
            Console.WriteLine("info for t1");
            t1.showstyle();
            t1.showdin();
            Console.WriteLine("Area is "+ t1.Area());
            Console.WriteLine("info for t2");
            t2.showstyle();
            t2.showdin();
            Console.WriteLine("Area is "+ t2.Area());
        }
    }

}