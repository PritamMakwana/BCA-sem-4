
class Box{
    double h,w,d;
    Box(){
        h = 10;
        w = 10;
        d = 10;
    }
    double volume(){
        return h * w * d;
    }
}


public class A13_Constructor {
    public static  void main(String[] args){
        double val;
        Box b1 = new Box();
        Box b2 = new Box();

        val = b1.volume();

        System.out.println("volume of b1 = "+ val);
        val = b2.volume();
        System.out.println("volume of b2 = "+val);
    }

}
