class BoxP{
    double height , width , depth;

    BoxP(double h1, double w1,double d1){
        height = h1;
        width = w1;
        depth = d1;
    }
    double volume(){
        return height * width * depth;
    }
}

public class A14_Parameter_Constructor {
    public static void main(String [] args){
        double val;
        BoxP b1 = new BoxP(10,20,15);
        BoxP b2 = new BoxP(1,2,5);
        val = b1.volume();
        System.out.println("b1 volume = "+val);
        val = b2.volume();
        System.out.println("b2 volume = "+val);
    }


}
