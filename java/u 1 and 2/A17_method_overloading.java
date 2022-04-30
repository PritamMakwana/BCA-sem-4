class Adder{
    static int add(int a, int b){
        return a + b;
    }
    static int add(int a, int b ,int c){
        return a + b + c;
    }
}
class AdderDemo{
    static int add(int a, int b){
        return a + b;
    }
    static double add(double a, double b ){
        return a + b ;
    }
}


public class A17_method_overloading {
    public  static  void main(String[] args){

        System.out.println("1.change number of argument");
        System.out.println(Adder.add(10,10));
        System.out.println(Adder.add(10,10,10));

        System.out.println("2.change data type of argument");
        System.out.println(AdderDemo.add(11,11));
        System.out.println(AdderDemo.add(12.3,12.6));

    }
}
