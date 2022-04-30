using System;

sealed class Point
{
    public Point(int x ,int y){
        x1 = x;
        y1 = y;
    }
    public int x1;
    public int y1;
}
/*comiler error 
class myclass : Point {

}
*/
class sealedDemo{
    public static void Main(){

    Point pt = new Point(10,15);

    Console.WriteLine("value x = {0} y={1}",pt.x1,pt.y1);

    }
    
    }